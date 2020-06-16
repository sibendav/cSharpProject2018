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
    public partial class frmMatalot : Form
    {
        public frmMatalot()
        {
            InitializeComponent();
        }

        private void frmMatalot_Load(object sender, EventArgs e)
        {
            dvgMatalot.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.destinationDate, abodotStam.nameOfAboda, mazminim.nameOfMazmin+' '+ mazminim.NameOfFamily FROM mazminim INNER JOIN (hazmanot INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin WHERE (((pirteHazmana.destinationDate)>Date()))");
            dvgMatalot.Columns[0].HeaderText = "תאריך יעד";
            dvgMatalot.Columns[1].HeaderText = "המשימה";
            dvgMatalot.Columns[2].HeaderText = "הלקוח";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
