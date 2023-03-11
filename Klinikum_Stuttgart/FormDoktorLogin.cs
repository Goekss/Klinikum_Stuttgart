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
    public partial class FrmDrLogin : Form
    {
       
        public FrmDrLogin()
        {
            InitializeComponent();
        }
         SQLverbindung conn=new SQLverbindung();
        private void Btneinloggin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doktor where DrBürgerID=@p1 and DrPasswort=@p2",conn.verbindung());
            cmd.Parameters.AddWithValue("@p1",MaskedID.Text);
            cmd.Parameters.AddWithValue("@p2",Txtpasswort.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FrmDrDetail frm = new FrmDrDetail();
                frm.ID=MaskedID.Text;
                frm.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Leider ID und Passwort stimmen nicht überein, Bitte versuchen Sie es noch einmal !", "FEHLER !",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            
            }
            conn.verbindung().Close();
        }
    }
}
