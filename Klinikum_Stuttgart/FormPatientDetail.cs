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
    public partial class FrmPatDetail : Form
    {
        public FrmPatDetail()
        {
            InitializeComponent();
        }
        public string Identno;
        SQLverbindung conn = new SQLverbindung();




        // VOR-NACHNAME zugreifen
        private void FrmPatDetail_Load(object sender, EventArgs e)
        {
            LblID.Text = Identno;

            SqlCommand cmd = new SqlCommand("Select PtName,PtNachname From Tbl_Patient where PtBürgerID=@p1", conn.verbindung());
            cmd.Parameters.AddWithValue("@p1", LblID.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                LblNamen.Text = dr[0] +" "+ dr[1];
            
            }
           conn.verbindung().Close();




            //Frühere-Terminen

            DataTable dt = new DataTable();   //Veri Tablosu   //DataAdapter DataGriw icin veri aktarim komutu
             SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Termine where Ptid=" +Identno,conn.verbindung());
            da.Fill(dt); //DataAdaptarin icini doldur neyle ? dt(tablo) den gelen degerle
            dataGridView1.DataSource = dt;


            // Fächer zuzugreifen
            SqlCommand     cmd2 = new SqlCommand("Select FachName From Tbl_Fach",conn.verbindung());
            SqlDataReader  dr2 = cmd2.ExecuteReader();
            while (dr2.Read()) 
            {
                CmbFach.Items.Add(dr2[0]);
            
            
            }



        }

        private void CmbFach_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDr.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select DrName, DrNachname From Tbl_Doktor where DrFachrichtung =@p1" ,conn.verbindung());
            cmd3.Parameters.AddWithValue("@p1",CmbFach.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read()) 
            {
                CmbDr.Items.Add(dr3[0]+" " + dr3[1]);
            
            }
            conn.verbindung() .Close(); 
        }

        private void CmbDr_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From Tbl_Termine where TerminFach='" + CmbFach.Text + "'" + " and TerminArzt='" + CmbDr.Text  + "' and TerminStatus=0 ", conn.verbindung()) ;
            da.Fill(dt);
            dataGridView2.DataSource = dt;  
        }

        private void lnkEinstellung_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPattEinstellung fr = new FrmPattEinstellung();
            fr.IdentNo =LblID.Text;
            fr.Show();
        }

        private void BtnTermin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Termine Set TerminStatus=1,Ptid=@p1,PatientBeschwerden=@p2 where Terminid =@p3",conn.verbindung());
            cmd.Parameters.AddWithValue("@p1", LblID.Text);
            cmd.Parameters.AddWithValue("@p2",RchBeschwerungen.Text);
            cmd.Parameters.AddWithValue("@p3",TxtTerminId.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Sie haben einen Termin ausgemact.","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int wahl = dataGridView2.SelectedCells[0].RowIndex;
            TxtTerminId.Text = dataGridView2.Rows[wahl].Cells[0].Value.ToString();  
        }
    }
}
