using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Klinikum_Stuttgart
{
    /// <summary>
    /// Zentrale Stelle fuer die Datenbankverbindung.
    /// Reihenfolge: 1) Connection-String aus App.config, 2) Demo-Datenbank (LocalDB/SQL Express),
    /// 3) verstaendliche Fehlermeldung mit Einrichtungsanleitung.
    /// </summary>
    internal class SQLverbindung
    {
        private const string ConfigName = "KlinikumConnectionString";
        private const string DemoDatabaseName = "Klinikum_Stuttgart_Demo";
        private const string DemoScriptFileName = "Klinikum_Stuttgart_Demo.sql";

        // Lokale SQL-Server-Instanzen, auf denen die Demo-Datenbank automatisch angelegt wird.
        private const string LocalDbServer = @"(LocalDB)\MSSQLLocalDB";

        private static readonly object SyncRoot = new object();
        private static string _connectionString;
        private static bool _demoMode;
        private static Exception _lastError;

        internal static bool IsDemoMode
        {
            get
            {
                EnsureConnectionString();
                return _demoMode;
            }
        }

        /// <summary>
        /// Liefert eine geoeffnete Verbindung. Der Aufrufer schliesst sie wieder.
        /// </summary>
        public SqlConnection verbindung()
        {
            SqlConnection verbindung = new SqlConnection(EnsureConnectionString());
            verbindung.Open();
            return verbindung;
        }

        private static string EnsureConnectionString()
        {
            if (_connectionString != null)
            {
                return _connectionString;
            }

            lock (SyncRoot)
            {
                if (_connectionString == null)
                {
                    _connectionString = ResolveConnectionString();
                }
                return _connectionString;
            }
        }

        private static string ResolveConnectionString()
        {
            string configured = ReadConfiguredConnectionString();
            if (!string.IsNullOrWhiteSpace(configured) && CanConnect(configured))
            {
                return configured;
            }

            string demo = TryPrepareDemoDatabase();
            if (demo != null)
            {
                _demoMode = true;
                return demo;
            }

            throw new InvalidOperationException(BuildSetupHint());
        }

        private static string ReadConfiguredConnectionString()
        {
            try
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[ConfigName];
                if (settings == null)
                {
                    return null;
                }
                return (settings.ConnectionString ?? string.Empty).Trim();
            }
            catch (ConfigurationErrorsException)
            {
                return null;
            }
        }

        private static bool CanConnect(string connectionString)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                builder.ConnectTimeout = 5;
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                _lastError = ex;
                return false;
            }
        }

        private static string TryPrepareDemoDatabase()
        {
            string script = LoadDemoScript();
            if (script == null)
            {
                return null;
            }

            foreach (string server in GetDemoServerCandidates())
            {
                try
                {
                    using (SqlConnection master = new SqlConnection(BuildDemoConnectionString(server, "master")))
                    {
                        master.Open();
                        using (SqlCommand command = new SqlCommand(
                            "IF DB_ID(N'" + DemoDatabaseName + "') IS NULL CREATE DATABASE [" + DemoDatabaseName + "];",
                            master))
                        {
                            command.CommandTimeout = 60;
                            command.ExecuteNonQuery();
                        }
                    }

                    string demoConnectionString = BuildDemoConnectionString(server, DemoDatabaseName);
                    using (SqlConnection connection = new SqlConnection(demoConnectionString))
                    {
                        OpenWithRetry(connection);
                        ExecuteScript(connection, script);
                    }

                    return demoConnectionString;
                }
                catch (Exception ex)
                {
                    _lastError = ex;
                }
            }

            return null;
        }

        private static void OpenWithRetry(SqlConnection connection)
        {
            const int maxAttempts = 5;

            for (int attempt = 1; ; attempt++)
            {
                try
                {
                    connection.Open();
                    return;
                }
                catch (SqlException)
                {
                    if (attempt >= maxAttempts)
                    {
                        throw;
                    }
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private static System.Collections.Generic.IEnumerable<string> GetDemoServerCandidates()
        {
            // LocalDB nur probieren, wenn es installiert ist - sonst wartet der Verbindungsversuch
            // unnoetig lange auf einen Timeout.
            if (IsLocalDbInstalled())
            {
                yield return LocalDbServer;
            }
            yield return @".\SQLEXPRESS";
            yield return @"localhost";
        }

        private static bool IsLocalDbInstalled()
        {
            const string keyPath = @"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions";
            using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyPath))
            {
                if (key != null)
                {
                    return true;
                }
            }
            using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Microsoft SQL Server Local DB\Installed Versions"))
            {
                return key != null;
            }
        }

        private static string BuildDemoConnectionString(string server, string database)
        {
            int timeout = server.Equals(LocalDbServer, StringComparison.OrdinalIgnoreCase) ? 10 : 5;

            // Pooling=False: Die Formulare oeffnen/schliessen Verbindungen historisch bedingt
            // nicht paarweise. Ohne Pool kann der Verbindungs-Pool dadurch nicht erschoepfen.
            return "Data Source=" + server + ";Initial Catalog=" + database +
                   ";Integrated Security=True;Connect Timeout=" + timeout + ";Pooling=False";
        }

        private static void ExecuteScript(SqlConnection connection, string script)
        {
            string[] batches = Regex.Split(script, @"^\s*GO\s*$",
                RegexOptions.IgnoreCase | RegexOptions.Multiline);

            foreach (string batch in batches)
            {
                string commandText = (batch ?? string.Empty).Trim();
                if (commandText.Length == 0)
                {
                    continue;
                }

                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteNonQuery();
                }
            }
        }

        private static string LoadDemoScript()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (string resourceName in assembly.GetManifestResourceNames())
            {
                if (resourceName.EndsWith(DemoScriptFileName, StringComparison.OrdinalIgnoreCase))
                {
                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8, true))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Liefert die Zugangsdaten des ersten Datensatzes einer Demo-Tabelle, damit sich
        /// Tester im Demo-Modus nicht selbst anmelden muessen. Ausserhalb des Demo-Modus
        /// (also bei eigener Datenbank) wird nichts vorbelegt.
        /// </summary>
        internal static bool TryGetDemoLogin(string query, out string benutzerId, out string passwort)
        {
            benutzerId = null;
            passwort = null;

            try
            {
                if (!IsDemoMode)
                {
                    return false;
                }

                using (SqlConnection connection = new SqlConnection(EnsureConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return false;
                        }

                        benutzerId = (reader.GetValue(0) ?? string.Empty).ToString().Trim();
                        passwort = (reader.GetValue(1) ?? string.Empty).ToString().Trim();
                        return benutzerId.Length > 0 && passwort.Length > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Die Vorbelegung ist reiner Komfort - Fehler duerfen den Login nicht blockieren.
                benutzerId = null;
                passwort = null;
                return false;
            }
        }

        private static string BuildSetupHint()
        {
            StringBuilder hint = new StringBuilder();
            hint.AppendLine("Es konnte keine Verbindung zur Datenbank hergestellt werden.");
            hint.AppendLine();
            hint.AppendLine("Moegliche Loesungen:");
            hint.AppendLine("1) Demo-Modus: SQL Server Express LocalDB installieren (wird mit Visual Studio");
            hint.AppendLine("   mitgeliefert). Die Demo-Datenbank wird dann automatisch angelegt.");
            hint.AppendLine("2) Eigene Datenbank: 'Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac'");
            hint.AppendLine("   in SSMS importieren oder 'Database\\Klinikum_Stuttgart_Demo.sql' ausfuehren.");
            hint.AppendLine("3) Anschliessend den Connection-String in App.config");
            hint.AppendLine("   (KlinikumConnectionString) auf die eigene Instanz setzen.");
            hint.AppendLine();
            hint.AppendLine("Siehe README.md fuer eine Schritt-fuer-Schritt-Anleitung.");

            if (_lastError != null)
            {
                hint.AppendLine();
                hint.AppendLine("Letzter Datenbankfehler:");
                hint.AppendLine(_lastError.Message);
            }

            return hint.ToString();
        }
    }
}
