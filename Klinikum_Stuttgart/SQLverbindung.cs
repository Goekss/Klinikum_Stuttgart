using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Klinikum_Stuttgart
{
    internal class SQLverbindung                // sinifin adi
    {                                           
       // SQLConnection Metodu geliyor + verbindung metodumun ismi
       
       public SqlConnection verbindung() // Verbindung Sqlden türettigim ve linkimi tutan NESNEnin adi
        { 

            SqlConnection verbindung = new SqlConnection("               -----          --------              ------------              -------------  ");

                                                         

            verbindung.Open();
            return verbindung;
        }

        //Ich lasse das     >>>   new SqlConnection-LINK-FELD <<< , da oben leer.
        
        //Befolgen Sie diese Schritte, damit das System richtig funktioniert;

        //1) Importieren Sie die exportierte „SQL-DATA“-Datei in Ihren lokalen oder einen anderen Microsoft Sql Server auf Ihrem eigenen Computer.
        //2) Kopieren Sie den Verbindungslink Ihres Microsoft SQL Servers, den Sie auf Ihrem eigenen Computer an einem lokalen oder anderen Ort gespeichert haben, in dieses Feld und starten Sie das System.
    }
}
