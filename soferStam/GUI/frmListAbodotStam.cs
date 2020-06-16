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
    public partial class frmListAbodotStam : Form
    {
        public frmListAbodotStam()
        {
            InitializeComponent();
        }

        private void frmListAbodotStam_Load(object sender, EventArgs e)
        {
            abodotStamTable allAbodot = new abodotStamTable();
            DataTable dtAbodot = allAbodot.GetTableTrue();
            dgvAbodotStam.DataSource = dtAbodot;
            dgvAbodotStam.Columns[0].Visible = false;
            dgvAbodotStam.Columns[1].HeaderText = "שם עבודת סת'ם";
            dgvAbodotStam.Columns[2].HeaderText = "הקלף";
            dgvAbodotStam.Columns[3].HeaderText = "מספר קלפים";
            dgvAbodotStam.Columns[4].HeaderText = "סוג כתב";
            dgvAbodotStam.Columns[5].HeaderText = "זמן כתיבה בשעות";
            dgvAbodotStam.Columns[6].Visible = false;
        }

        private void dgvAbodotStam_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //abodotStam a = new abodotStam();
            int kod = Convert.ToInt32(dgvAbodotStam.Rows[e.RowIndex].Cells["kodAboda"].Value. ToString());
            //a.NameOfAboda=Convert.ToString(dgvAbodotStam.Rows[e.RowIndex].Cells["nameOfAboda"]);
            //a.KodKlaf=Convert.ToInt32(dgvAbodotStam.Rows[e.RowIndex].Cells["kodKlaf"]);
            //a.AmountOfKlafim=Convert.ToInt32(dgvAbodotStam.Rows[e.RowIndex].Cells["amountOfKlafim"]);
            //a.WritingType=Convert.ToString(dgvAbodotStam.Rows[e.RowIndex].Cells["writingType"]);
            //a.TheTimeToWrite=Convert.ToDouble(dgvAbodotStam.Rows[e.RowIndex].Cells["theTimeToWrite"]);

            frmAbodatStam f = new frmAbodatStam(statusKind.showRow, kod);
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
