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
    public partial class FrmDrAnkündigung : Form
    {
        SqlConnection verbindung = new SqlConnection("Data Source=DESKTOP-86KQ4NB\\SQLEXPRESS;Initial Catalog=Klinikum_Stuttgart;Integrated Security=True");
        public FrmDrAnkündigung()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();   
        private void FrmDrAnkündigung_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Tbl_Mitteilungen",verbindung);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
