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
    public partial class FormSekTerList : Form
    {
       
        public FormSekTerList()
        {
            InitializeComponent();
        }
        SQLverbindung conn = new SQLverbindung();

        public void FormSekTerList_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Tbl_Termine ", conn.verbindung());
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
