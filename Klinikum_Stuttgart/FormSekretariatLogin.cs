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
    public partial class FrmSekLogin : Form
    {
        public FrmSekLogin()
        {
            InitializeComponent();
        }
        SQLverbindung conn = new SQLverbindung();
        private void Btneinloggin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Sekretärin where SekrBürgerID =@p1 and SekrPasswort=@p2", conn.verbindung());
            cmd.Parameters.AddWithValue("@p1",MaskedID.Text);
            cmd.Parameters.AddWithValue("@p2",Txtpasswort.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmSekDetail frs = new FrmSekDetail();
                frs.IdNr=MaskedID.Text;
                frs.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Passwort oder Login ungültig");
            
            }
            conn.verbindung().Close();






        }
    }
}
