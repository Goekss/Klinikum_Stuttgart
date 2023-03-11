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
    public partial class FrmSekDetail : Form
    {
        public FrmSekDetail()
        {
            InitializeComponent();
        }
        public String IdNr;
        SQLverbindung conn=new SQLverbindung();
        private void FrmSekDetail_Load(object sender, EventArgs e)
        {
            LblSkid.Text = IdNr;

           // ---------------------------------------------------------------------------------------------------------------------------------------


            //Vorname-Nachname 
            SqlCommand cmd1 = new SqlCommand("Select SekrNameNachname From Tbl_Sekretärin where SekrBürgerID=@p1",conn.verbindung());
            cmd1.Parameters.AddWithValue("@p1",LblSkid.Text);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read()) 
            {
                LblSknamen.Text = dr1[0].ToString();
            
            }
            conn.verbindung().Close();

            //---------------------------------------------------------------------------------------------------------------------------------------


            // Übertragung von Fächer auf DataGridView  
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select FachName From Tbl_Fach", conn.verbindung());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //---------------------------------------------------------------------------------------------------------------------------------------

            //Übertragung von Ärzte auf List

            DataTable dt2= new DataTable();         //Select (DrName+ ' ' + DrNachname as'Ärzte',DrFachrichtung)--Kullanilabilir                                       
            SqlDataAdapter da2 = new SqlDataAdapter("Select DrName,DrNachname,DrFachrichtung From Tbl_Doktor ", conn.verbindung());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //---------------------------------------------------------------------------------------------------------------------------------------

            // Übertragung vom Fach auf Combobox

            SqlCommand cmd2 = new SqlCommand("Select FachName from Tbl_Fach ", conn.verbindung());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbFach.Items.Add(dr2[0]);
            }
            conn.verbindung().Close();

            //---------------------------------------------------------------------------------------------------------------------------------------

            

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Termine (TerminDatum,TerminUhr,TerminFach,TerminArzt) values (@r1,@r2,@r3,@r4)",conn.verbindung());

            cmd.Parameters.AddWithValue("@r1",Msktxtdatum.Text);
            cmd.Parameters.AddWithValue("@r2",MsktxtbxZeituhr.Text);
            cmd.Parameters.AddWithValue("@r3",CmbFach.Text);
            cmd.Parameters.AddWithValue("@r4",CmbDr.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();

            MessageBox.Show("Der Termin wurde erfolgreich angelegt.");
        }

        private void CmbFach_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDr.Items.Clear();
            CmbDr.Text = "";

            SqlCommand cmd3 = new SqlCommand("Select DrName, DrNachname  From Tbl_Doktor where DrFachrichtung=@t1",conn.verbindung());
            cmd3.Parameters.AddWithValue("@t1",CmbFach.Text);
            SqlDataReader dr3= cmd3.ExecuteReader();
            while (dr3.Read()) 
            {
                CmbDr.Items.Add(dr3[0]+" "+dr3[1]);     
            }
            conn.verbindung().Close();
        }

        private void btnankng_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" insert into Tbl_Mitteilungen(Mitteilung) values (@m1)",conn.verbindung());
            cmd.Parameters.AddWithValue("@m1",Rchankndg.Text);
            cmd.ExecuteNonQuery();
            conn.verbindung().Close();
            MessageBox.Show("Die Mitteilungen wurden an alle Ärzte und Krankenschwestern verschickt.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void BtnDrPanel_Click(object sender, EventArgs e)
        {
           FrmSekDrPanel drPanel = new FrmSekDrPanel();
            drPanel.Show();
        }

        private void BtnFachPanel_Click(object sender, EventArgs e)
        {
            FrmSekDrFach frf= new FrmSekDrFach();
            frf.Show();
        }

        private void BtnTerminList_Click(object sender, EventArgs e)
        {
          FormSekTerList formSekTerList = new FormSekTerList();
            formSekTerList.Show();
            
        }

        private void BtnMitteilung_Click(object sender, EventArgs e)
        {
            FrmDrAnkündigung drmitteil = new FrmDrAnkündigung();
            drmitteil.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
