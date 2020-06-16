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
    public partial class frmListHazmanot : Form
    {
        public frmListHazmanot()
        {
            InitializeComponent();
        }

        private void frmListHazmanot_Load(object sender, EventArgs e)
        {
            DataTable dtHazmanot = DAL.dal.GetTableFromSQL("SELECT hazmanot.dateHazmana, mazminim.nameOfMazmin+' '+mazminim.NameOfFamily AS fullname FROM (mazminim INNER JOIN hazmanot ON mazminim.kodMaznim = hazmanot.kodMazmin) INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana ORDER BY hazmanot.dateHazmana DESC");
            dgvHazmanot.DataSource = dtHazmanot;
            dgvHazmanot.Columns[0].HeaderText = "תאריך הזמנה";
            dgvHazmanot.Columns[1].HeaderText = "שם המזמין";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
