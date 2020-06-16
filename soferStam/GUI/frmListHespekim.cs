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
    public partial class frmListHespekim : Form
    {
        public frmListHespekim()
        {
            InitializeComponent();
        }

        private void frmListHespekim_Load(object sender, EventArgs e)
        {
            hespekimTable allHes = new hespekimTable();
            DataTable dtHespkim = allHes.GetTableTrue();
            dgvHespekim.DataSource = dtHespkim;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
