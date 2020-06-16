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
    public partial class frmMazmin : Form
    {
        private mazminim myMazmin;
        private mazminimTable myMazminims;
        private statusKind statusFrm;
        private statusKind priviousFrm;

        public frmMazmin(statusKind sta)
        {
            InitializeComponent();
            this.myMazminims = new mazminimTable();
            this.statusFrm = sta;
        }

        public frmMazmin(statusKind sta, mazminim mUpdate)
        {
            InitializeComponent();
            this.myMazmin = mUpdate;
            this.myMazminims = new mazminimTable();
            this.statusFrm = sta;
            
        }

        public frmMazmin(statusKind sta, mazminim mUpdate, statusKind priviousFrm)
        {
            InitializeComponent();
            this.myMazmin = mUpdate;
            this.myMazminims = new mazminimTable();
            this.statusFrm = sta;
            this.priviousFrm = priviousFrm;
        }

        public void FillFields()
        {
            lblKodMazmin.Text = Convert.ToString(this.myMazmin.KodMaznim);
            txtName.Text = this.myMazmin.NameOfMazmin;
            txtFName.Text = this.myMazmin.NameOfFamily1;
            txtPhone.Text = Convert.ToString(this.myMazmin.PhoneNumber);
            txtAPhone.Text = Convert.ToString(this.myMazmin.AnotherPhone);
            txtStreet.Text = this.myMazmin.Street;
            txtHouseNum.Text = Convert.ToString(this.myMazmin.NumberOfHouse);
            txtCity.Text = this.myMazmin.City;

        }

        public void FillFieldsInformationTraveling()
        {
            lblKodMazmin.Text = Convert.ToString(this.myMazmin.KodMaznim);
            txtName.Text = this.myMazmin.NameOfMazmin;
            txtFName.Text = this.myMazmin.NameOfFamily1;
            txtPhone.Text = Convert.ToString(this.myMazmin.PhoneNumber);
            txtAPhone.Text = Convert.ToString(this.myMazmin.AnotherPhone);
            txtStreet.Text = this.myMazmin.Street;
            txtHouseNum.Text = Convert.ToString(this.myMazmin.NumberOfHouse);
            txtCity.Text = this.myMazmin.City;

        }

        public bool BuildObjectByFileds()
        {
            errorProvider1.Clear();
            bool ok = true;
            this.myMazmin = new mazminim();

            try //קוד
            {
                this.myMazmin.KodMaznim = Convert.ToInt16(lblKodMazmin.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKodMazmin, ex.Message);
                ok = false;
            }
            try //שם פרטי
            {
                this.myMazmin.NameOfMazmin = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }
            try //שם משפחה
            {
                this.myMazmin.NameOfFamily1 = txtFName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFName, ex.Message);
                ok = false;
            }
            try //מספר פאלפון
            {
                this.myMazmin.PhoneNumber = Convert.ToString(txtPhone.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPhone, ex.Message);
                ok = false;
            }
            try //טלפון נוסף
            {
                this.myMazmin.AnotherPhone = Convert.ToString(txtAPhone.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAPhone, ex.Message);
                ok = false;
            }
            try //רחוב
            {
                this.myMazmin.Street = txtStreet.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtStreet, ex.Message);
                ok = false;
            }
            try //מספר בית
            {
                this.myMazmin.NumberOfHouse = Convert.ToInt32(txtHouseNum.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtHouseNum, ex.Message);
                ok = false;
            }
            try //עיר
            {
                this.myMazmin.City = txtCity.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCity, ex.Message);
                ok = false;
            }
            return ok;
        }
        public void ManegeFieldByStatusFrm()
        {
            if (this.statusFrm == statusKind.add || this.statusFrm==statusKind.addAndBack)
            {
                lblKodMazmin.Text = Convert.ToString(this.myMazminims.GetNextCode());
                cmbMazminim.Visible = false;
                label7.Visible = false;
                btnAdd.Visible = true;
                btnDelet.Visible = false;
                btnUpdate.Visible = false;
            }
            else if (this.statusFrm == statusKind.update)
            {
                btnAdd.Visible = false;
                btnDelet.Visible = false;
                btnUpdate.Enabled = false;
                grpbMazmin.Enabled = false;


            }
            else if (this.statusFrm == statusKind.delet)
            {
                btnAdd.Visible = false;
                btnDelet.Visible = true;
                btnUpdate.Visible = false;
            }
            else if (this.statusFrm == statusKind.show)
            {
                btnAdd.Visible = false;
                btnDelet.Visible = false;
                btnUpdate.Visible = false;
            }
            else if (this.statusFrm == statusKind.updateAndBack)
            {
                btnAdd.Visible = false;
                btnDelet.Visible = false;
                cmbMazminim.Visible = false;
                label7.Visible = false;
                FillFieldsInformationTraveling();
            }
        }
        public void FillComboxSelectedPro()
        {
            cmbMazminim.DataSource = myMazminims.getFullName();
            cmbMazminim.DisplayMember = "fullName";
            cmbMazminim.ValueMember = "kodMaznim";
            cmbMazminim.Text = "-בחר לקוח-";
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmMazmin_Load(object sender, EventArgs e)
        {
            FillComboxSelectedPro();
            ManegeFieldByStatusFrm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mazminim m1 = new mazminim();
            try //קוד
            {
                m1.KodMaznim = Convert.ToInt16(lblKodMazmin.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKodMazmin, ex.Message);

            }
            try //שם פרטי
            {
                m1.NameOfMazmin = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);

            }
            try //שם משפחה
            {
                m1.NameOfFamily1 = txtFName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFName, ex.Message);

            }
            try //מספר פאלפון
            {
                m1.PhoneNumber = Convert.ToString(txtPhone.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPhone, ex.Message);

            }
            try //טלפון נוסף
            {
                m1.AnotherPhone = Convert.ToString(txtAPhone.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAPhone, ex.Message);

            }
            try //רחוב
            {
                m1.Street = txtStreet.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtStreet, ex.Message);

            }
            try //מספר בית
            {
                m1.NumberOfHouse = Convert.ToInt32(txtHouseNum.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtHouseNum, ex.Message);

            }
            try //עיר
            {
                m1.City = txtCity.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCity, ex.Message);

            }

            bool ok = BuildObjectByFileds();
            if (ok == true)
            {
                DataRow dr = this.myMazmin.BuildRow();
                if (this.myMazminims.Add(dr)==true)
                {

                    MessageBox.Show("הלקוח התווסף בהצלחה");
                    ClearFields();
                    if (this.statusFrm == statusKind.addAndBack)
                    {
                        frmHosafaKolectivit f = new frmHosafaKolectivit(statusKind.add, m1);
                        f.Show();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("הלקוח קיים במאגר");

            }
            //ClearFields();
            

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק לקוח זה?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFileds() == true)
                {
                    this.myMazmin.Status = false;
                    DataRow dr = this.myMazmin.BuildRow();
                    if (this.myMazminims.update(dr) == true)
                    {
                        //DataRow dr = this.myMazmin.BuildRow(); //
                        //this.myMazminims.Delete(dr);
                        MessageBox.Show("הלקוח נמחק!");
                        FillComboxSelectedPro();
                    }

                }

            }
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFileds() == true)
            {
                DataRow dr = this.myMazmin.BuildRow();
                if (this.myMazminims.update(dr) == true)
                {
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                    ClearFields();
                    if (this.statusFrm == statusKind.updateAndBack)
                    {
                        frmHosafaKolectivit f = new frmHosafaKolectivit(this.priviousFrm, myMazmin);
                        f.Show();
                        this.Close();
                    }
                  
                }
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
            //ClearFields();
        }

        private void cmbMazminim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(cmbMazminim.SelectedValue);
            DataRow dr = myMazminims.Find(kod);
            this.myMazmin = new mazminim(dr);

            FillFields();

            grpbMazmin.Enabled = true;
            btnUpdate.Enabled = true;
        }

        public void ClearFields()
        {
            if (this.statusFrm == statusKind.add)
                lblKodMazmin.Text = Convert.ToString(this.myMazminims.GetNextCode());
            else
                lblKodMazmin.Text = "";
            txtName.Text = "";
            txtFName.Text = "";
            txtPhone.Text = "";
            txtAPhone.Text = "";
            txtStreet.Text = "";
            txtHouseNum.Text = "";
            txtCity.Text = "";
            FillComboxSelectedPro();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar!=' '))
            {
                e.Handled = true;
                Console.Beep();
            }
            
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsNum(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtAPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsNum(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtHouseNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsNum(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
