using System;
using System.Threading;
using System.Windows.Forms;

namespace Klinikum_Stuttgart
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt fuer die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += OnThreadException;

            try
            {
                Frmeingang mainForm = new Frmeingang();
                if (SQLverbindung.IsDemoMode)
                {
                    mainForm.Text = mainForm.Text.TrimEnd() + " - Demo-Modus";
                }
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private static void OnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowError(e.Exception);
        }

        private static void ShowError(Exception exception)
        {
            string message = exception is InvalidOperationException
                ? exception.Message
                : "Es ist ein unerwarteter Fehler aufgetreten:" + Environment.NewLine + Environment.NewLine +
                  exception.Message;

            MessageBox.Show(message, "Klinikum Stuttgart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
