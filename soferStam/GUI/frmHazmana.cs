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
    public partial class frmHazmana : Form
    {
        private hazmanot myHazmana;
        private hazmanotTable myHazmanots;
        private statusKind statusfrm;

        private mazminim myMazmin;
        private mazminimTable myMazminims;

        public frmHazmana(statusKind sta)
        {
            InitializeComponent();
            this.myHazmana = new hazmanot();
            this.myHazmanots = new hazmanotTable();
            myMazmin = new mazminim();
            myMazminims=new mazminimTable();
            this.statusfrm = sta;

            cmbMazmin.DataSource = new mazminimTable().getFullName();
            cmbMazmin.DisplayMember = "fullName"; //"nameOfMazmin";"fullName";
            cmbMazmin.ValueMember = "kodMaznim";
           //לא מועיל //cmbMazmin.Text = "-בחר מזמין-"; 
        }
        public void FillFields()
        {
            lblKod.Text = Convert.ToString(this.myHazmana.KodHazmana);
            txtDate.Text = Convert.ToString(this.myHazmana.DateHazmana.ToShortDateString());
            //cmbMazmin.DataSource = myMazminims.getNameLakoah(this.myHazmana.KodMazmin);
            //cmbMazmin.DisplayMember = "fullName";
            //cmbMazmin.ValueMember = "";
            cmbMazmin.Text = Convert.ToString(this.myHazmana.KodMazmin);
        }
        public bool BuildObjectByFields()
        {
            errorProvider1.Clear();
            bool ok = true;
            this.myHazmana = new hazmanot();

            try//קוד הזמנה
            {
                this.myHazmana.KodHazmana = Convert.ToInt32(lblKod.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKod, ex.Message);
                ok = false;
            }

            try//תאריך הזמנה
            {
                this.myHazmana.DateHazmana = Convert.ToDateTime(txtDate.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDate, ex.Message);
                ok = false;
            }

            try//קוד מזמין
            {
                this.myHazmana.KodMazmin = Convert.ToInt32(cmbMazmin.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbMazmin, ex.Message);
                ok = false;
            }
            return ok;
        }

        public void ManegeFieldByStatusFrm()
        {
            if (this.statusfrm == statusKind.add)
            {
                lblKod.Text = Convert.ToString(this.myHazmanots.GetNextCode());
                cmbHazmana.Visible = false;
                cmbPirteiHazmanatLakoach.Visible = false;
                //label8.Visible = false;
                btnAdd.Visible = true;
                btnDelet.Visible = false;
                btnUpdate.Visible = false;
                txtDate.Text =Convert.ToString(DateTime.Today.ToShortDateString());
            }

            else if (this.statusfrm == statusKind.update)
            {
                btnAdd.Visible = false;
                btnDelet.Visible = false;
                btnUpdate.Enabled = false;
                grpBoxHazmana.Enabled = false;
                cmbMazmin.Enabled = false;
            }

            else if (this.statusfrm == statusKind.delet)
            {
                btnAdd.Visible = false;
                btnDelet.Visible = true;
                btnUpdate.Visible = false;
                grpBoxHazmana.Enabled = false;
            }

            else if(this.statusfrm==statusKind.show)
            {
                btnAdd.Visible = false;
                btnDelet.Visible = false;
                btnUpdate.Visible = false;
                grpBoxHazmana.Enabled = false;
            }
        }
        public void fillComboBoxSelectPro()
        {
            cmbHazmana.DataSource = myMazminims.getPhones();
            cmbHazmana.DisplayMember = "phoneNumber";
            cmbHazmana.ValueMember = "kodMaznim";
            cmbHazmana.Text = "-בחר מזמין-";

        }
        public void fillcmbMazminRight(string numPhone)//שיטה שמקבלת מספר טלפון ומחזירה את שם הבעל טלפון
        {

        }
        private void frmHazmana_Load(object sender, EventArgs e)
        {
            fillComboBoxSelectPro();
            ManegeFieldByStatusFrm();
            cmbMazmin.Text = "-בחר מזמין-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            hazmanot h1 = new hazmanot();

            try//קוד הזמנה
            {
                h1.KodHazmana = Convert.ToInt32(lblKod.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKod, ex.Message);
            }

            try//תאריך הזמנה
            {
                h1.DateHazmana = Convert.ToDateTime(txtDate.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDate, ex.Message);
            }

            try//קוד מזמין
            {
                h1.KodMazmin = Convert.ToInt32(cmbMazmin.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbMazmin, ex.Message);
            }

            bool ok = BuildObjectByFields();
            if (ok == true)
            {
                DataRow dr = this.myHazmana.BuildRow();
                if (this.myHazmanots.Add(dr))
                    MessageBox.Show("ההזמנה התווספה בהצלחה");
                else
                    MessageBox.Show("קיים במאגר");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields() == true)
            {
                DataRow dr = this.myHazmana.BuildRow();
                if (this.myHazmanots.update(dr) == true)
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFields() == true)
                {
                    DataRow dr = this.myHazmana.BuildRow(); //
                    this.myHazmanots.Delete(dr);
                    MessageBox.Show(" נמחק");
                    fillComboBoxSelectPro();

                }

            }
        }

        private void cmbHazmana_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int kod = Convert.ToInt32(cmbHazmana.SelectedValue);
            //DataRow dr = myHazmanots.Find(kod);
            //this.myHazmana = new hazmanot(dr);
            //FillFields();
            //grpBoxHazmana.Enabled = true;
            //btnUpdate.Enabled = true;

            cmbPirteiHazmanatLakoach.Enabled = true;
            cmbPirteiHazmanatLakoach.DataSource = myMazminims.getPirteyHazmana(Convert.ToInt32(cmbHazmana.SelectedValue));
            cmbPirteiHazmanatLakoach.DisplayMember = "nameOfAboda";
            cmbPirteiHazmanatLakoach.ValueMember = "kodAboda";

            cmbPirteiHazmanatLakoach.Text = "-בחר הזמנה-";

        }

        private void cmbPirteiHazmanatLakoach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(cmbHazmana.SelectedValue);
            DataRow dr = myHazmanots.Find(kod);
            this.myHazmana = new hazmanot(dr);
            FillFields();
            grpBoxHazmana.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void cmbHazmana_Leave(object sender, EventArgs e)
        {
           // cmbPirteiHazmanatLakoach.Text = "-בחר הזמנה-";
        }

        private void cmbPirteiHazmanatLakoach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
