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
    public partial class FormPatientenLogin : Form
    {
        public FormPatientenLogin()
        {
            InitializeComponent();
        }

        SQLverbindung vrb = new SQLverbindung(); 

        private void Lnkregis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatRegistrieren fr = new FrmPatRegistrieren();
            fr.Show();
        }

        private void Btneinloggin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Patient Where PtBürgerID =@1 and PtPasswort =@2", vrb.verbindung());
            cmd.Parameters.AddWithValue("@1", MaskedID.Text);
            cmd.Parameters.AddWithValue("@2", Txtpasswort.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FrmPatDetail frm = new FrmPatDetail();
                frm.Identno=MaskedID.Text;
                
                frm.Show();
                this.Hide();
            }
            else 
            {
               Fehler.Text =("Login Fehler! Mail oder Kennwort nicht korrekt !");
                Fehler.Visible = true;
            
            }
            vrb.verbindung().Close();




        }
    }
}
