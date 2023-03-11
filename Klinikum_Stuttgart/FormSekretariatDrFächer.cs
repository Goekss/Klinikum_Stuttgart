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
    public partial class FrmSekDrFach : Form
    {
        public FrmSekDrFach()
        {
            InitializeComponent();
        }
        
        SQLverbindung conn = new SQLverbindung();
        
        private void FrmSekDrFach_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From Tbl_Fach",conn.verbindung());   
            da.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Tbl_Fach (FachName) values (@fachname)",conn.verbindung());
            cmd.Parameters.AddWithValue("@fachname",TxtFachname.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Das Fach wurde eingefügt.","Information",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int wahl = dataGridView1.SelectedCells[0].RowIndex;
            TxtFachId.Text = dataGridView1.Rows[wahl].Cells[0].Value.ToString();
            TxtFachname.Text = dataGridView1.Rows[wahl].Cells[1].Value.ToString();
        }

        private void BtnLösch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" Delete from Tbl_Fach where Fachid=@b1 ",conn.verbindung());
            cmd.Parameters.AddWithValue("@b1",TxtFachId.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Das Fach wurde gelöscht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void BtnAktuel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Fach Set FachName=@p1 where Fachid=@p2",conn.verbindung());
            cmd.Parameters.AddWithValue("@p1",TxtFachname.Text);
            cmd.Parameters.AddWithValue("@p2",TxtFachId.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Die Angaben wurde erfolgreich aktualisiert","Information",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
    

        }
    }
}
