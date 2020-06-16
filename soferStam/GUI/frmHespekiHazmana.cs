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
    public partial class frmHespekiHazmana : Form
    {
        //pirteHazmanaTable myPirteHazmanot;
        int numPirteHazmana;
        public frmHespekiHazmana()
        {
            InitializeComponent();

            cmbKodHazmana.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.kodPirteyHazmana, mazminim.NameOfFamily+' '+mazminim.nameOfMazmin+'-'+abodotStam.nameOfAboda AS fullName FROM mazminim INNER JOIN (hazmanot INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin ORDER BY mazminim.nameOfMazmin+' '+mazminim.NameOfFamily+'-'+abodotStam.nameOfAboda");
            cmbKodHazmana.DisplayMember = "fullName";
            cmbKodHazmana.ValueMember = "kodPirteyHazmana";

        }

        public frmHespekiHazmana(int numPirteHazmana)
        {
            InitializeComponent();
            this.numPirteHazmana = numPirteHazmana;
            cmbKodHazmana.Visible = false;

            DataTable dt = DAL.dal.GetTableFromSQL("SELECT hespekim.kodHespek, hespekim.kodParitHazmana, hespekim.theDate, hespekim.fromTime, hespekim.tillTime FROM hespekim WHERE (((hespekim.kodParitHazmana)=" + numPirteHazmana + ")) ORDER BY hespekim.theDate");
            dgvHespekiHazmana.DataSource = dt;
            dgvHespekiHazmana.Columns[0].Visible = false;
            dgvHespekiHazmana.Columns[1].Visible = false;
            dgvHespekiHazmana.Columns[2].HeaderText="תאריך";
            dgvHespekiHazmana.Columns[3].HeaderText="משעה";
            dgvHespekiHazmana.Columns[4].HeaderText="עד שעה";
            lblZover.Text = Convert.ToString(HoursFigure(dt));
            pirteHazmanaTable p1 = new pirteHazmanaTable();
            lblHoursRequiered.Text = Convert.ToString(p1.getNumWorkHour(this.numPirteHazmana));
            lblHefres.Text= Convert. ToString(Convert.ToDouble(lblHoursRequiered.Text) - Convert.ToDouble(lblZover.Text));
            
            if (Convert.ToDouble(lblZover.Text) >= Convert.ToDouble(lblHoursRequiered.Text))
            {
                proBTahalichHazmana.Value = 100;
                lblHefres.Text = "0";
                lblHariga.Text = Convert.ToString(Convert.ToDouble(lblZover.Text) - Convert.ToDouble(lblHoursRequiered.Text));
                LB.Visible = true;
                lblHariga.Visible = true;
            }
            else
                proBTahalichHazmana.Value = Convert.ToInt32((Convert.ToDouble(lblZover.Text) / Convert.ToDouble(lblHoursRequiered.Text)) * 100);

            
        }

        private void frmHespekiHazmana_Load(object sender, EventArgs e)
        {
            cmbKodHazmana.Text = "-בחר הזמנה-";

        }

        private void cmbKodHazmana_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtHespekiHazmana = DAL.dal.GetTableFromSQL("SELECT hespekim.kodHespek, hespekim.theDate, hespekim.fromTime, hespekim.tillTime FROM pirteHazmana INNER JOIN hespekim ON pirteHazmana.kodPirteyHazmana = hespekim.kodParitHazmana WHERE (((pirteHazmana.kodPirteyHazmana)=" + cmbKodHazmana.SelectedValue + ") AND ((hespekim.kodParitHazmana)=" + cmbKodHazmana.SelectedValue + "))");
            dgvHespekiHazmana.DataSource = dtHespekiHazmana;
            dgvHespekiHazmana.Columns[0].HeaderText = "קוד הספק";
            dgvHespekiHazmana.Columns[1].HeaderText = "תאריך ביצוע";
            dgvHespekiHazmana.Columns[2].HeaderText = "שעת התחלה";
            dgvHespekiHazmana.Columns[3].HeaderText = "שעת סיום";
            lblZover.Text = Convert.ToString(HoursFigure(dtHespekiHazmana));
            pirteHazmanaTable p1 = new pirteHazmanaTable();
            lblHoursRequiered.Text = Convert.ToString(p1.getNumWorkHour(Convert.ToInt32(cmbKodHazmana.SelectedValue)));
            lblHefres.Text = Convert.ToString(Convert.ToDouble(lblHoursRequiered.Text) - Convert.ToDouble(lblZover.Text));

            if (Convert.ToDouble(lblZover.Text) >= Convert.ToDouble(lblHoursRequiered.Text))
            {
                proBTahalichHazmana.Value = 100;
                lblHefres.Text = "0";
                lblHariga.Text = Convert.ToString(Convert.ToDouble(lblZover.Text) - Convert.ToDouble(lblHoursRequiered.Text));
                LB.Visible = true;
                lblHariga.Visible = true;
            }
            else
                proBTahalichHazmana.Value = Convert.ToInt32((Convert.ToDouble(lblZover.Text) / Convert.ToDouble(lblHoursRequiered.Text)) * 100);



        }
        public double HoursFigure(DataTable dt)
        {
            double zover = 0;
            for (int i = 0; i < dt.Rows.Count; i++)// אין אני מנחשת מה מספר השורות????
            {
                DataRow dr = dt.Rows[i];
                DateTime a = Convert.ToDateTime(dr["tillTime"]);
                DateTime b = Convert.ToDateTime(dr["fromTime"]);

                double c = Convert.ToDouble(a.Hour - b.Hour) + ((Convert.ToDouble(a.Minute) - Convert.ToDouble(b.Minute)) / 60);
                zover += Math.Round(c, 2);
            }
            return zover;
        }

        private void dgvHespekiHazmana_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddHespek_Click(object sender, EventArgs e)
        {
            frmHespekim f = new frmHespekim(statusKind.add, this.numPirteHazmana);
            f.Show();

        }

        private void lblZover_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHoursRequiered_Click(object sender, EventArgs e)
        {

        }
    }
}
