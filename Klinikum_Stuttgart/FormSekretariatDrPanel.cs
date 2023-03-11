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
    public partial class FrmSekDrPanel : Form
    {
        public FrmSekDrPanel()
        {
            InitializeComponent();
        }
        SQLverbindung conn = new SQLverbindung();   
        private void FrmSekDrPanel_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();         //Select (DrName+ ' ' + DrNachname as'Ärzte',DrFachrichtung)--Kullanilabilir                                       
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Doktor ", conn.verbindung());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            // Übertragung der Fächer auf Combobox

            SqlCommand cmd = new SqlCommand(" Select FachName From Tbl_Fach ", conn.verbindung());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())

            {
                CmbFach.Items.Add(dr[0]);

            }
            conn.verbindung().Close();


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktor (DrName,DrNachname,DrFachrichtung,DrBürgerID,DrPasswort) values (@d1,@d2,@d3,@d4,@d5)",conn.verbindung());
            cmd.Parameters.AddWithValue("@d1",TxtName.Text);
            cmd.Parameters.AddWithValue("@d2",TxtNachname.Text);
            cmd.Parameters.AddWithValue("@d3",CmbFach.Text);
            cmd.Parameters.AddWithValue("@d4",MskBürgerId.Text);
            cmd.Parameters.AddWithValue("@d5",TxtPass.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Arzt/Ärztin wurde erfolgreich eingefügt.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int anklicken = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[anklicken].Cells[1].Value.ToString();
            TxtNachname.Text = dataGridView1.Rows[anklicken].Cells[2].Value.ToString();
            CmbFach.Text = dataGridView1.Rows[anklicken].Cells[3].Value.ToString();
            MskBürgerId.Text = dataGridView1.Rows[anklicken].Cells[4].Value.ToString();
            TxtPass.Text = dataGridView1.Rows[anklicken].Cells[5].Value.ToString();
        }


        private void BtnLösch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Tbl_Doktor where DrBürgerID =@p1",conn.verbindung());
            cmd.Parameters.AddWithValue("@p1",MskBürgerId.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Die Eintragung ist gelöscht.","Information",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void BtnAktuel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doktor set DrName=@p1, DrNachname =@p2, DrFachrichtung=@p3, DrPasswort =@p5 where DrBürgerID= @p4", conn.verbindung());
            cmd.Parameters.AddWithValue("@p1",TxtName.Text);
            cmd.Parameters.AddWithValue("@p2",TxtNachname.Text);
            cmd.Parameters.AddWithValue("@p3",CmbFach.Text);
            cmd.Parameters.AddWithValue("@p4",MskBürgerId.Text);
            cmd.Parameters.AddWithValue("@p5",TxtPass.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Die Angaben wurden erfolgreich aktualisiert.","Information",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        
    }
}
