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
    public partial class FrmPattEinstellung : Form
    {
        public FrmPattEinstellung()
        {
            InitializeComponent();
        }


        public string IdentNo;
        SQLverbindung conn = new SQLverbindung();
        private void FrmPattEinstellung_Load(object sender, EventArgs e)
        {
            
            MaskedID.Text = IdentNo;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Patient where PtBürgerID =@p1", conn.verbindung());
            cmd.Parameters.AddWithValue("@p1", MaskedID.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                Txtvorname.Text = dr[1].ToString();
                Txtnachname.Text= dr[2].ToString();
                MaskedTelefon.Text = dr[4].ToString();
                TxtPasswort.Text = dr[5].ToString();
                CmbSex.Text = dr[6].ToString();
            
            
            
            
            }
            conn.verbindung().Close();
        }

        private void BtnAktuel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand(" update Tbl_Patient set PtName=@a1,PtNachname=@a2,PtTelnummer=@a3,PtPasswort=@a4,PtGeschlecht=@a5 where PtBürgerID=@a6", conn.verbindung());


            cmd2.Parameters.AddWithValue("@a1", Txtvorname.Text);
            cmd2.Parameters.AddWithValue("@a2", Txtnachname.Text);
            cmd2.Parameters.AddWithValue("@a3", MaskedTelefon.Text.ToString());
            cmd2.Parameters.AddWithValue("@a4", TxtPasswort.Text.ToString());
            cmd2.Parameters.AddWithValue("@a5", CmbSex.Text);
            cmd2.Parameters.AddWithValue("@a6",MaskedID.Text.ToString());
            cmd2.ExecuteNonQuery();
             
            
            conn.verbindung().Close() ;

            MessageBox.Show("Ihre Angaben wurden erfolgreich aktualisiert.","Infos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            this.Close();


        }
    }
    }


