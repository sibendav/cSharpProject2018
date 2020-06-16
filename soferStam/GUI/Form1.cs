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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void הצגToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListKlafim f = new frmListKlafim();
            f.Show();
        }

        private void הוסףToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmKlaf f = new frmKlaf(statusKind.add);
            f.Show();
        }

        private void הזמנותToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillLabel();
        }

        public void fillLabel()
        {
            txtDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.destinationDate, abodotStam.nameOfAboda, [mazminim].[nameOfMazmin]+' '+[mazminim].[NameOfFamily] AS fullName FROM mazminim INNER JOIN (hazmanot INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin WHERE (((pirteHazmana.destinationDate)>Date()))");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string s = "*";
                s += dr["destinationDate"];
                s += "-";
                s += dr["nameOfAboda"];
                s += "-";
                s += dr["fullName"];
                s += " ";
                lblHodaot.Text += s;

            }
        }

        private void עבודותסתםToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הוסףToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAbodatStam f = new frmAbodatStam(statusKind.add);
            f.Show();
        }

        private void עדכןToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmKlaf f = new frmKlaf(statusKind.update);
            f.Show();
        }

        private void מחקToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmKlaf f = new frmKlaf(statusKind.delet);
            f.Show();
        }

        private void מאגרמידעToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void קלףמסוייםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKlaf f = new frmKlaf(statusKind.show);
            f.Show();
        }

        private void כלהקלפיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListKlafim f = new frmListKlafim();
            f.Show();
        }

        private void עדכןToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAbodatStam f = new frmAbodatStam(statusKind.update);
            f.Show();
        }

        private void מחקToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAbodatStam f = new frmAbodatStam(statusKind.delet);
            f.Show();
        }

        private void עבודתסתםספציפיתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbodatStam f = new frmAbodatStam(statusKind.show);
            f.Show();
        }

        private void כלעבודותהסתםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAbodotStam f= new frmListAbodotStam();
            f.Show();
        }

        private void כלהלקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMazminim f = new frmListMazminim();
            f.Show();
        }

        private void רשימתהזמנותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void חדשToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfo f = new frmInfo();
            f.Show();
        }

        private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMazmin f = new frmMazmin(statusKind.add);
            f.Show();
        }

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMazmin f = new frmMazmin(statusKind.update);
            f.Show();
        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMazmin f = new frmMazmin(statusKind.delet);
            f.Show();
        }

        private void לקוחספציפיToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMazmin f = new frmMazmin(statusKind.show);
            f.Show();
        }

        private void הזמנהספציפיתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHazmana f = new frmHazmana(statusKind.show);
            f.Show();
        }

        private void כלההזמנותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListHazmanot f = new frmListHazmanot();
            f.Show();
        }

        private void כלההספקיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHespekiHazmana f = new frmHespekiHazmana();
            f.Show();
        }

        private void הוסףToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmSogKlaf f = new frmSogKlaf(statusKind.add);
            f.Show();
        }

        private void מחקToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmSogKlaf f = new frmSogKlaf(statusKind.delet);
            f.Show();
        }

        private void עדכןToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmSogKlaf f = new frmSogKlaf(statusKind.update);
            f.Show();
        }

        private void סוגקלףמסויםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSogKlaf f = new frmSogKlaf(statusKind.show);
            f.Show();
        }

        private void כלסוגיהקלפיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSogKlaf f = new frmListSogKlaf();
            f.Show();
        }

        private void הוסףToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHespekim f = new frmHespekim(statusKind.add);
            f.Show();
        }

        private void מחקToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHespekim f = new frmHespekim(statusKind.delet);
            f.Show();
        }

        private void עדכןToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHespekim f = new frmHespekim(statusKind.update);
            f.Show();
        }

        private void הספקספציפיToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHespekim f = new frmHespekim(statusKind.show);
            f.Show();
        }

        private void כלההספקיםToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListHespekim f = new frmListHespekim();
            f.Show();
        }

        private void הוסףToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmHazmana f = new frmHazmana(statusKind.add);
            f.Show();
        }

        private void עדכוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHazmana f = new frmHazmana(statusKind.update);
            f.Show();
        }

        private void ביטולToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHazmana f = new frmHazmana(statusKind.delet);
            f.Show();
        }

        private void פרטיהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void כלפרטיההזמנותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPirtieHazmana t = new frmListPirtieHazmana();
            t.Show();
        }

        private void הוסףToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmPirteHazmana t = new frmPirteHazmana(statusKind.add);
            t.Show();
        }

        private void מחקToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmPirteHazmana t = new frmPirteHazmana(statusKind.delet);
            t.Show();
        }

        private void עדכןToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmPirteHazmana t = new frmPirteHazmana(statusKind.update);
            t.Show();
        }

        private void פרטיהזמנהמסוימתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPirteHazmana t = new frmPirteHazmana(statusKind.show);
            t.Show();
        }

        private void הצגמטלותשלאבוצעוToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatalot f = new frmMatalot();
            f.Show();
        }

        private void הוספהקולקטיביתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("לקוח קיים?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                frmHosafaKolectivit f = new frmHosafaKolectivit(statusKind.add);
                f.Show();
            }
            else
            {
                frmMazmin f = new frmMazmin(statusKind.addAndBack);
                f.Show();

            }
        }

        private void עדכוןToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmHosafaKolectivit f = new frmHosafaKolectivit(statusKind.update);
            f.Show();
        }

        private void מחיקהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHosafaKolectivit f = new frmHosafaKolectivit(statusKind.delet);
            f.Show();
        }

        private void מצבהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHosafaKolectivit f = new frmHosafaKolectivit(statusKind.show);
            f.Show();
        }

        private void מחיקהToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPirteHazmana t = new frmPirteHazmana(statusKind.update);
            t.Show();
        }

        private void הוספהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPirteHazmana t = new frmPirteHazmana(statusKind.add);
            t.Show();
        }

        private void עדכוןToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPirteHazmana t = new frmPirteHazmana(statusKind.delet);
            t.Show();
        }

        private void פרטיהזמנהמסוימתToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPirteHazmana t = new frmPirteHazmana(statusKind.show);
            t.Show();
        }

        private void כלפרטיההזמנותToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListPirtieHazmana t = new frmListPirtieHazmana();
            t.Show();
        }

        private void הצגהכלToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListHazmanot f = new frmListHazmanot();
            f.Show();
        }

        private void timerColorChange_Tick(object sender, EventArgs e)
        {
            lblHodaot.Location = new Point(lblHodaot.Location.X - 1, lblHodaot.Location.Y);
            //if (lblHodaot.Width == this.Width)
            if (lblHodaot.Location.X == this.Width + lblHodaot.Size.Width)
            {
               MessageBox.Show("");
               lblHodaot.Location = new Point(432, 338);
               fillLabel();

                
            }

            
        }

        private void רשימתמטלותToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_Click(object sender, EventArgs e)
        {

        }

        private void חודשיותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasHacnasa f = new frmMasHacnasa(statusKind.showMonth);
            f.Show();
        }

        private void שנתיותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMasHacnasa f = new frmMasHacnasa(statusKind.Showyear);
            f.Show();
        }

        
    }
}
