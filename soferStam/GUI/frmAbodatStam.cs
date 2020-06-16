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
    public partial class frmAbodatStam : Form
    {
        private abodotStam myAboda;
        private abodotStamTable myAbodots;
        private statusKind statusfrm;
       
        public frmAbodatStam(statusKind sta)
        {
            InitializeComponent();
            this.myAbodots = new abodotStamTable();
            this.statusfrm = sta;

            cmbKlaf.DataSource = new klafimTable().GetTableTrue();
            cmbKlaf.DisplayMember = "nameOfKlaf";
            cmbKlaf.ValueMember = "kodKlaf";
        }
        public frmAbodatStam(statusKind sta, int kod)
        {
            InitializeComponent();
            this.myAbodots = new abodotStamTable();
            this.myAboda = new abodotStam(myAbodots.Find(kod));
            this.statusfrm = sta;
            FillFields();
            //cmbKlaf.DataSource = new klafimTable().GetTableTrue();
            //cmbKlaf.DisplayMember = "nameOfKlaf";
            //cmbKlaf.ValueMember = "kodKlaf";

        }
        
        public void FillFields()
        {
            lblKod.Text = Convert.ToString(this.myAboda.KodAboda);
            txtName.Text = this.myAboda.NameOfAboda;
            if (this.statusfrm == statusKind.showRow)
            {
                cmbKlaf.DataSource = DAL.dal.GetTableFromSQL("SELECT klafim.kodKlaf, klafim.nameOfKlaf FROM klafim WHERE (((klafim.kodKlaf)=" + this.myAboda.KodKlaf + "))");
                cmbKlaf.DisplayMember = "nameOfKlaf";
                cmbKlaf.ValueMember = "kodKlaf";
                btnKlaf.Visible = false;
            }
            cmbKlaf.SelectedValue = this.myAboda.KodKlaf;
            txtAmount.Text = Convert.ToString(this.myAboda.AmountOfKlafim);
            txtWritingType.Text = this.myAboda.WritingType;
            txtTime.Text = Convert.ToString(this.myAboda.TheTimeToWrite);
        }
        public bool BuildObjectByFields()
        {
            errorProvider1.Clear();
            bool ok = true;
            this.myAboda = new abodotStam();

            try //קוד
            {
                this.myAboda.KodAboda = Convert.ToInt16(lblKod.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKod, ex.Message);
                ok = false;
            }
            try //שם
            {
                this.myAboda.NameOfAboda = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }
            try //קוד קלף
            {
                this.myAboda.KodKlaf = Convert.ToInt32(cmbKlaf.SelectedValue);
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(cmbKlaf, ex.Message);
                ok = false;
            }
            try //כמות
            {
                this.myAboda.AmountOfKlafim = Convert.ToInt32(txtAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAmount, ex.Message);
                ok = false;
            }
            try //סוג כתיבה
            {
                this.myAboda.WritingType = Convert.ToString(txtWritingType.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtWritingType, ex.Message);
                ok = false;
            }
            try//זמן הכתיבה
            {
                this.myAboda.TheTimeToWrite = Convert.ToDouble(txtTime.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTime, ex.Message);
                ok = false;
            }
            return ok;
        }
        public void ManegeFieldByStatusFrm()
        {
            if (this.statusfrm == statusKind.add)
            {
                lblKod.Text = Convert.ToString(this.myAbodots.GetNextCode());
                cmbBoxAboda.Visible = false;
                label3.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;

            }
            else if (this.statusfrm == statusKind.update)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Enabled = false;
                grpboxAboda.Enabled = false;
                cmbKlaf.Text = "-בחר קלף-";
                cmbBoxAboda.Text = "-בחר עבודת סת'ם-";


            }
            else if (this.statusfrm == statusKind.delet)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = true;
                btnUpdate.Visible = false;
                cmbBoxAboda.Text = "-בחר עבודת סת'ם-";
            }
            else if (this.statusfrm == statusKind.show )
            {
                grpboxAboda.Enabled = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            else if (this.statusfrm == statusKind.showRow)
            {
                grpboxAboda.Enabled = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                cmbBoxAboda.Visible = false;
                label3.Visible = false;
            }
        }
        public void fillComboBoxSelectPro()
        {
            cmbBoxAboda.DataSource = this.myAbodots.getAbodotStam();
            cmbBoxAboda.DisplayMember = "nameOfAboda";
            cmbBoxAboda.ValueMember = "kodAboda";
           

        }

        private void frmAbodatStam_Load(object sender, EventArgs e)
        {
            fillComboBoxSelectPro();
            ManegeFieldByStatusFrm();

            //if (this.statusfrm != statusKind.showRow)
            //{
            //    fillComboBoxSelectPro();
            //    cmbKlaf.Text = "-בחר קלף-";
            //    cmbBoxAboda.Text = "-בחר עבודת סת'ם-";
            //}
            //else
            //    cmbBoxAboda.Visible = false;

        }

        private void lblKod_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            abodotStam a1 = new abodotStam();
            try //קוד
            {
                a1.KodAboda = Convert.ToInt16(lblKod.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKod, ex.Message);
                
            }
            try //שם
            {
                a1.NameOfAboda = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
               
            }
            try //קוד קלף
            {
                a1.KodKlaf = Convert.ToInt32(cmbKlaf.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbKlaf, ex.Message);
                
            }
            try //כמות
            {
                a1.AmountOfKlafim = Convert.ToInt32(txtAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAmount, ex.Message);
                 
            }
            try //סוג כתיבה
            {
                a1.WritingType = Convert.ToString(txtWritingType.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtWritingType, ex.Message);
                
            }
            try//זמן הכתיבה
            {
                this.myAboda.TheTimeToWrite = Convert.ToDouble(txtTime.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTime, ex.Message);
            }
            bool ok = BuildObjectByFields();
            if (ok == true)
            {
                DataRow dr = this.myAboda.BuildRow();
                if (this.myAbodots.Add(dr))
                { 
                    MessageBox.Show("עבודת הסת'ם התווספה בהצלחה");
                    ClearFields();
                }
                else
                    MessageBox.Show("קיים במאגר");
            }
            
        }

        private void cmbBoxAboda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(cmbBoxAboda.SelectedValue);
            DataRow dr = myAbodots.Find(kod);
            this.myAboda = new abodotStam(dr);
            FillFields();
            grpboxAboda.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFields() == true)
                {
                    this.myAboda.Status = false;
                    DataRow dr = this.myAboda.BuildRow();
                    if (this.myAbodots.update(dr) == true)
                    MessageBox.Show(" נמחק");
                    fillComboBoxSelectPro();

                }

            }
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields() == true)
            {
                DataRow dr = this.myAboda.BuildRow();
                if (this.myAbodots.update(dr) == true)
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
            ClearFields();
        }

        public void ClearFields()
        {
            cmbBoxAboda.Text = "-בחר עבודת סת'ם-";
            lblKod.Text = "";
            txtName.Text = "";
            cmbKlaf.DataSource = new klafimTable().GetTableTrue();
            cmbKlaf.DisplayMember = "nameOfKlaf";
            cmbKlaf.ValueMember = "kodKlaf";
            txtAmount.Text = "";
            txtWritingType.Text = "";
            txtTime.Text = "";
        }

        private void btnKlaf_Click(object sender, EventArgs e)
        {
            frmKlaf f = new frmKlaf(statusKind.addAndUpdate);
            f.ShowDialog();// כדי שטעינת הקומבובוקס תתבצע רק אחרי שהדיאלוג הסתיים ולא לפני או תוך כדי
            cmbKlaf.DataSource = new klafimTable().GetTableTrue();
            cmbKlaf.DisplayMember = "nameOfKlaf";
            cmbKlaf.ValueMember = "kodKlaf";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!validation.IsNum(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    Console.Beep();
                }
                
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar!=' ') )
                {
                    e.Handled = true;
                    Console.Beep();
                }
            
            
        }

        private void txtWritingType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWritingType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsNum(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
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
