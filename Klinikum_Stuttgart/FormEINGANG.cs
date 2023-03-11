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
    public partial class Frmeingang : Form
    {
        public Frmeingang()
        {
            InitializeComponent();
        }

        private void BtnPatientLogin_Click(object sender, EventArgs e)
        {
            FormPatientenLogin frPaLo= new FormPatientenLogin();
            frPaLo.Show();
            
            
        }

        private void BtnDrLogin_Click(object sender, EventArgs e)
        {
           FrmDrLogin frDrLogin = new FrmDrLogin();
            frDrLogin.Show();
              
        }

        private void BtnSekLogin_Click(object sender, EventArgs e)
        {
            FrmSekLogin frSkLo= new FrmSekLogin();  
            frSkLo.Show();
            
        }
    }
}
