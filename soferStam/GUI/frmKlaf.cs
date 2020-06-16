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
    public partial class frmKlaf : Form
    {
        private klafim myKlaf;
        private klafimTable myKlafim;
        private statusKind statusFrm;


        public frmKlaf(statusKind sta)
        {
            InitializeComponent();
            this.myKlaf = new klafim();
            this.myKlafim = new klafimTable();//*
            this.statusFrm = sta;


        }
        public void FillFields()
        {
            lblkodKlaf.Text = Convert.ToString(this.myKlaf.KodKlaf);
            txtName.Text = this.myKlaf.NameOfKlaf;
            txtSize.Text = Convert.ToString(this.myKlaf.SizeOfKlaf);
            //txtTime.Text = Convert.ToString(this.myKlaf.TheAmountOfTimeToWriteEach);
        }
        public bool BuildObjectByFields()
        {
            errorProvider1.Clear();
            bool ok = true;
            this.myKlaf = new klafim();
            try  //קוד
            {
                this.myKlaf.KodKlaf = Convert.ToInt32(lblkodKlaf.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblkodKlaf, ex.Message);
                ok = false;
            }

            try  //שם
            {
                this.myKlaf.NameOfKlaf = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }

            try  //גודל
            {
                this.myKlaf.SizeOfKlaf = txtSize.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSize, ex.Message);
                ok = false;
            }

            //try //זמן לכתיבת אחד
            //{
            //    this.myKlaf.TheAmountOfTimeToWriteEach =txtTime.Text;
            //}
            //catch (Exception ex)
            //{
            //    errorProvider1.SetError(txtTime, ex.Message);
            //    ok = false;
            //}
            return ok;
        }
        public void fillComboBoxSelectPro()
        {
            comboBoxKlaf.DataSource = myKlafim.klafimForCombobox();
            comboBoxKlaf.DisplayMember = "nameOfKlaf";
            comboBoxKlaf.ValueMember = "kodKlaf";
            comboBoxKlaf.Text = "-בחר קלף-";

        }
        public void ManegeFieldsByStatusFrm()
        {
            if (this.statusFrm == statusKind.add || this.statusFrm==statusKind.addAndUpdate)
            {
                lblkodKlaf.Text = Convert.ToString(this.myKlafim.GetNextCode());
                comboBoxKlaf.Visible = false;
                label4.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;

            }
            else if (this.statusFrm == statusKind.update)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Enabled = false;
                grpBoxKlaf.Enabled = false;
            }
            else if (this.statusFrm == statusKind.delet)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = true;
                btnUpdate.Visible = false;
            }
            else if (this.statusFrm == statusKind.show)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }

        }

        private void frmKlaf_Load(object sender, EventArgs e)
        {
            fillComboBoxSelectPro();
            ManegeFieldsByStatusFrm();
        }
        private void comboBoxKlaf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(comboBoxKlaf.SelectedValue);
            DataRow dr = myKlafim.Find(kod);
            this.myKlaf = new klafim(dr);

            FillFields();

            grpBoxKlaf.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            klafim k1 = new klafim();

            try//קוד קלף
            {
                k1.KodKlaf = Convert.ToInt32(lblkodKlaf.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblkodKlaf, ex.Message);
            }
            try//שם קלף
            {
                k1.NameOfKlaf = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
            }
            try//גודל
            {
                k1.SizeOfKlaf = txtSize.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSize, ex.Message);
            }
      
            bool ok = BuildObjectByFields();
            if (ok == true)
            {
                DataRow dr = this.myKlaf.BuildRow();
                if (this.myKlafim.Add(dr))
                {
                    MessageBox.Show("הקלף התווסף בהצלחה למאגר");
                    clearFields();

                }
                else
                    MessageBox.Show("המוצר קיים במאגר", "שים לב");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields() == true)
            {
                DataRow dr = this.myKlaf.BuildRow();
                if (this.myKlafim.update(dr) == true)
                {
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                    clearFields();
                    fillComboBoxSelectPro();
                }
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק מוצר זה?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFields() == true)
                {
                    this.myKlaf.Status = false;
                    DataRow dr = this.myKlaf.BuildRow();
                    if (this.myKlafim.update(dr) == true)
                    {
                        MessageBox.Show("המוצר נמחק!");
                        clearFields();
                        fillComboBoxSelectPro();
                    }

                }

            }
        }
        public void clearFields()
        {
            if (this.statusFrm == statusKind.add)
                lblkodKlaf.Text = Convert.ToString(this.myKlafim.GetNextCode());
            else
                lblkodKlaf.Text = "";
            txtName.Text = "";
            txtSize.Text = "";
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar !='\n'))
            {
                e.Handled = true;
                Console.Beep();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
