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
    public partial class FrmDrBearbeitung : Form
    {
        public FrmDrBearbeitung()
        {
            InitializeComponent();
        }
         SQLverbindung conn = new SQLverbindung();
        public string IDNo;
        private void FrmDrBearbeitung_Load(object sender, EventArgs e)
        {
            MaskedID.Text = IDNo;

            SqlCommand cmd = new SqlCommand("select * from Tbl_Doktor where DrBürgerID = @Bürgerid",conn.verbindung());
            cmd.Parameters.AddWithValue("@Bürgerid",MaskedID.Text);
            SqlDataReader dr = cmd.ExecuteReader(); 
            if (dr.Read())
            {
                Txtvorname.Text = dr[1].ToString();
                Txtnachname.Text = dr[2].ToString();
                CmbFach.Text= dr[3].ToString();
                TxtPasswort.Text = dr[5].ToString();
            }
            conn.verbindung().Close();



        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doktor set DrName=@p1,DrNachname=@p2,DrFachrichtung=@p3,DrPasswort=@p4 where DrBürgerID=@p5 ",conn.verbindung());
            cmd.Parameters.AddWithValue("@p1",Txtvorname.Text);
            cmd.Parameters.AddWithValue("@p2",Txtnachname.Text);
            cmd.Parameters.AddWithValue("@p3",CmbFach.Text);
            cmd.Parameters.AddWithValue("@p4",TxtPasswort.Text);
            cmd.Parameters.AddWithValue("@p5",MaskedID.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Ihre Angaben wurden aktualisiert.");


        }
    }
}
