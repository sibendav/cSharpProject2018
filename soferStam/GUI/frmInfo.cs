using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soferStam.GUI
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMazmin_Click(object sender, EventArgs e)
        {
            frmMazmin f = new frmMazmin(statusKind.add);
            f.Show();
        }

        private void btnHazmana_Click(object sender, EventArgs e)
        {
            frmHazmana f = new frmHazmana(statusKind.add);
            f.Show();
        }

        private void btnPratim_Click(object sender, EventArgs e)
        {
            frmPirteHazmana f = new frmPirteHazmana(statusKind.add);
            f.Show();
        }
    }
}
