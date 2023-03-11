using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Klinikum_Stuttgart
{
    public partial class FrmPatRegistrieren : Form
    {
        public FrmPatRegistrieren()
        {
            InitializeComponent();
        }
         SQLverbindung conn = new SQLverbindung();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand("insert into Tbl_Patient (PtName,PtNachname,PtBürgerID,PtTelnummer,PtPasswort,PtGeschlecht) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn.verbindung());

            cmd.Parameters.AddWithValue("@p1", Txtvorname.Text);
            cmd.Parameters.AddWithValue("@p2", Txtnachname.Text);
            cmd.Parameters.AddWithValue("@p3", MskID.Text);
            cmd.Parameters.AddWithValue("@p4", MaskedTelefon.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPasswort.Text);
            cmd.Parameters.AddWithValue("@p6", CmbSex.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Ihre Informationen wurde erfolgreich aufgezeichnet. Ihr Passwort :"+ TxtPasswort.Text,"Infos",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
