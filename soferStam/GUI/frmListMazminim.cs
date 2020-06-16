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
    public partial class frmListMazminim : Form
    {
        public frmListMazminim()
        {
            InitializeComponent();
        }

        private void frmListMazminim_Load(object sender, EventArgs e)
        {
            mazminimTable allMaz = new mazminimTable();
            DataTable dtMazminim = allMaz.GetTableTrue();
            dgvMazminim.DataSource = dtMazminim;
            dgvMazminim.Columns[0].Visible = false;
            dgvMazminim.Columns[1].HeaderText = "שם פרטי";
            dgvMazminim.Columns[2].HeaderText = "שפ משפחה";
            dgvMazminim.Columns[3].HeaderText = "מספר טלפון";
            dgvMazminim.Columns[4].HeaderText = "טלפון נוסף";
            dgvMazminim.Columns[5].HeaderText = "רחוב";
            dgvMazminim.Columns[6].HeaderText = "מספר בית";
            dgvMazminim.Columns[7].HeaderText = "עיר";
            dgvMazminim.Columns[8].Visible = false;
        }


        private void dgvMazminim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
