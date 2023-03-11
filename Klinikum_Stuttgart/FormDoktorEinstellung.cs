using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinikum_Stuttgart
{
    public partial class FrmDrEinstellung : Form
    {
        public FrmDrEinstellung()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BtnAktuel_Click(object sender, EventArgs e)
        {
            FrmDrBearbeitung fr = new FrmDrBearbeitung();
            fr.Show();
            
        }
    }
}
