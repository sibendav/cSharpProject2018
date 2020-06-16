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
    public partial class frmListKlafim : Form
    {
        public frmListKlafim()
        {
            InitializeComponent();
        }

        private void frmListKlafim_Load(object sender, EventArgs e)
        {
            klafimTable allPro = new klafimTable();
            DataTable dtKlafim = allPro.GetTableTrue();
            dgvKlafim.DataSource = dtKlafim;
            dgvKlafim.Columns[0].Visible = false;
            dgvKlafim.Columns[1].HeaderText = "שם קלף";
            dgvKlafim.Columns[2].HeaderText = "גודל";
            dgvKlafim.Columns[3].Visible = false;
        }

        private void dgvKlafim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
