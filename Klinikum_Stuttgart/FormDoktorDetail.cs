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
    public partial class FrmDrDetail : Form
    {
        public FrmDrDetail()
        {
            InitializeComponent();
        }
        SQLverbindung conn = new SQLverbindung();

        public string ID;

        private void FrmDrDetail_Load(object sender, EventArgs e)
        {
            LblDrid.Text = ID;

            // Name und Nachname vom Artz_______________________________________________________________________________________

            SqlCommand cmd = new SqlCommand("select DrName, DrNachname from Tbl_Doktor where DrBürgerID=@p1",conn.verbindung());
            cmd.Parameters.AddWithValue("@p1",LblDrid.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
              LblDrnamen.Text = dr[0]+" "+ dr[1];

            }
            conn.verbindung().Close();

            // Termine ___________________________________________________________________________________________________________

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From Tbl_Termine where TerminArzt='"+ LblDrnamen.Text +"'  ",conn.verbindung());
            da.Fill(dt);
            dataGridView1.DataSource = dt;  
            conn.verbindung().Close();








        }

        private void BtnEinstellung_Click(object sender, EventArgs e)
        {
            FrmDrBearbeitung fr = new FrmDrBearbeitung();
            fr.IDNo = LblDrid.Text;
            fr.Show();
        }

        private void BtnAnkündigung_Click(object sender, EventArgs e)
        {
            FrmDrAnkündigung fr = new FrmDrAnkündigung();
            fr.Show();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int wahl= dataGridView1.SelectedCells[0].RowIndex;
            RchBeschwerdung.Text= dataGridView1.Rows[wahl].Cells[7].Value.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
