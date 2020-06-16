using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using soferStam.BLL;

namespace soferStam.GUI
{
    public partial class frmListPirtieHazmana : Form
    {
        public frmListPirtieHazmana()
        {
            InitializeComponent();
        }

        private void frmListPirtieHazmana_Load(object sender, EventArgs e)
        {
            pirteHazmanaTable allpir = new pirteHazmanaTable();
            DataTable dtPirte = allpir.GetTableTrue();
            dgvPirtieHazmana.DataSource = dtPirte;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
