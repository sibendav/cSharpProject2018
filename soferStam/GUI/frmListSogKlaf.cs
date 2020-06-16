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
    public partial class frmListSogKlaf : Form
    {
        public frmListSogKlaf()
        {
            InitializeComponent();
        }

        private void frmListSogKlaf_Load(object sender, EventArgs e)
        {
            //sogKlafTable allSog = new sogKlafTable();
            DataTable dtSogKlap = DAL.dal.GetTableFromSQL("SELECT sogKlaf.nameSogKlaf FROM sogKlaf ORDER BY sogKlaf.nameSogKlaf");
            dgvSogeKlafim.DataSource = dtSogKlap;
            dgvSogeKlafim.Columns[0].HeaderText = "סוגי הקלפים שבמאגר";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSogKlaf f = new frmSogKlaf(statusKind.add);
            f.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            frmSogKlaf f = new frmSogKlaf(statusKind.delet);
            f.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            frmSogKlaf f = new frmSogKlaf(statusKind.update);
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
