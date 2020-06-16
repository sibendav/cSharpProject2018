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
    public partial class frmMasHacnasa : Form
    {
        private statusKind statusFrm;

        public frmMasHacnasa(statusKind sta)
        {
            InitializeComponent();
            this.statusFrm = sta;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public int numOfMonth()
        {
            if (cmbMounth.SelectedItem == "ינואר")
                return 1;
            else if (cmbMounth.SelectedItem == "פברואר")
                return 2;
            else if (cmbMounth.SelectedItem == "מרץ")
                return 3;
            else if (cmbMounth.SelectedItem == "אפריל")
                return 4;
            else if (cmbMounth.SelectedItem == "מאי")
                return 5;
            else if (cmbMounth.SelectedItem == "יוני")
                return 6;
            else if (cmbMounth.SelectedItem == "יולי")
                return 7;
            else if (cmbMounth.SelectedItem == "אוגוסט")
                return 8;
            else if (cmbMounth.SelectedItem == "ספטמבר")
                return 9;
            else if (cmbMounth.SelectedItem == "אוקטובר")
                return 10;
            else if (cmbMounth.SelectedItem == "נובמבר")
                return 11;
            else
                return 12;
        }

        private void frmMasHacnasa_Load(object sender, EventArgs e)
        {
            manegeFrmByStatus();
            //for(int i=0;i<cmbYear.ItemHeight)
        }
        public void manegeFrmByStatus()
        {
            if (this.statusFrm == statusKind.showMonth)
            {
                cmbYear.Visible = false;
                label3.Visible = false;
            }
            if (this.statusFrm == statusKind.Showyear)
            {
                cmbMounth.Visible = false;
                label2.Visible = false;
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvHacnasot.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.destinationDate, abodotStam.nameOfAboda, pirteHazmana.price FROM abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda WHERE (((Year([pirteHazmana]![destinationDate]))=" + cmbYear.SelectedItem.ToString() + "))");
            dgvHacnasot.Columns[0].HeaderText = "תאריך יעד";
            dgvHacnasot.Columns[1].HeaderText = "עבודת הסת'ם";
            dgvHacnasot.Columns[2].HeaderText = "מחיר ששולם";
            int zover = 0;
            for (int i = 0; i < dgvHacnasot.RowCount; i++)
            {
                zover += Convert.ToInt32(dgvHacnasot.Rows[i].Cells["price"].Value);
            }
            lblZover.Text = Convert.ToString(zover);
        }

        private void cmbMounth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvHacnasot.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.destinationDate, abodotStam.nameOfAboda, pirteHazmana.price FROM abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda WHERE (((Year([pirteHazmana]![destinationDate]))=" + DateTime.Today.Year + ") AND ((Month([pirteHazmana]![destinationDate]))=" + numOfMonth() + "))");
            dgvHacnasot.Columns[0].HeaderText = "תאריך יעד";
            dgvHacnasot.Columns[1].HeaderText = "עבודת הסת'ם";
            dgvHacnasot.Columns[2].HeaderText = "מחיר ששולם";
            int zover = 0;
            for (int i = 0; i < dgvHacnasot.RowCount; i++)
            {
                zover += Convert.ToInt32(dgvHacnasot.Rows[i].Cells["price"].Value);
            }
            lblZover.Text = Convert.ToString(zover);
        }
    }
}
