using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using soferStam.BLL;
using System.Drawing.Printing;

namespace soferStam.GUI
{
    public partial class kabala : Form
    {
        private int myKodHazmana;

        public kabala(int h, DataTable dtP)
        {
            this.myKodHazmana = h;
            InitializeComponent();
            this.Controls.Add(printButtom);

            lblDatePrint.Text = DateTime.Today.ToShortDateString();
            lblTimePrint.Text = DateTime.Today.ToShortTimeString();
            lblNumHazmana.Text =Convert.ToString(this.myKodHazmana);
            dgv.DataSource = dtP;
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].HeaderText = "עבודת סת'ם";
            dgv.Columns[3].Width=120;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].HeaderText = "כמות";
            dgv.Columns[5].Width=50;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].HeaderText = "מחיר";
            dgv.Columns[8].Width = 50;
            dgv.Columns[9].Visible = false;


            int zover = 0;
            for (int i = 0; i < dtP.Rows.Count; i++)
            {
                DataRow dr=dtP.Rows[i];
                zover += Convert.ToInt32(dr["price"]);
            }
            lblSum.Text = Convert.ToString(zover);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kabala_Load(object sender, EventArgs e)
        {

        }

        private void printButtom_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height,myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage,0 ,0);
        }
    }
}
