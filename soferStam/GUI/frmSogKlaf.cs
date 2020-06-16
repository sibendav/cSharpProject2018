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
    public partial class frmSogKlaf : Form
    {
        private sogKlaf mySogKlaf;
        private sogKlafTable mySogeKlafim;
        private statusKind statusFrm;

        public frmSogKlaf(statusKind sta)
        {
            InitializeComponent();
            this.mySogeKlafim = new sogKlafTable();
            this.statusFrm = sta;
        }
        public void FillFields()
        {
            lblKod.Text = Convert.ToString(this.mySogKlaf.KodSogKlaf);
            txtName.Text = this.mySogKlaf.NameSogKlaf;
            
            

        }
        public bool BuildObjectByFields()
        {
            errorProvider1.Clear();
            bool ok = true;
            this.mySogKlaf = new sogKlaf();

            try //קוד
            {
                this.mySogKlaf.KodSogKlaf = Convert.ToInt16(lblKod.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKod, ex.Message);
                ok = false;
            }

            try  //שם
            {
                this.mySogKlaf.NameSogKlaf = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }

            //try //מחיר
            //{
            //    this.mySogKlaf.Price = Convert.ToInt32(txtprice.Text);
            //}
            //catch (Exception ex)
            //{
            //    errorProvider1.SetError(txtprice, ex.Message);
            //    ok = false;
            //}

            
            
            return ok;


        }
        public void ManegeFieldByStatusFrm()
        {
            if (this.statusFrm == statusKind.add)
            {
                lblKod.Text = Convert.ToString(this.mySogeKlafim.GetNextCode());
                cmbSogKlaf.Visible = false;
                label3.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                lblKod.Text = Convert.ToString(mySogeKlafim.GetNextCode());
            }
            else if (this.statusFrm == statusKind.update)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Enabled = false;
                grpboxAboda.Enabled = false;


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
        public void fillComboBoxSelectPro()
        {
            cmbSogKlaf.DataSource = this.mySogeKlafim.getSogeKlaf();
            cmbSogKlaf.DisplayMember = "nameSogKlaf"; //"fullName"; nameSogKlaf
            cmbSogKlaf.ValueMember = "kodSogKlaf";
            cmbSogKlaf.Text = "-בחר סוג קלף-";
           

        }

        private void frmSogKlaf_Load(object sender, EventArgs e)
        {
            fillComboBoxSelectPro();
            ManegeFieldByStatusFrm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sogKlaf s1 = new sogKlaf();
            try //קוד
            {
                s1.KodSogKlaf = Convert.ToInt16(lblKod.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKod, ex.Message);
               
            }

            try  //שם
            {
                s1.NameSogKlaf = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                
            }

            //try //מחיר
            //{
            //    s1.Price = Convert.ToInt32(txtprice.Text);
            //}
            //catch (Exception ex)
            //{
            //    errorProvider1.SetError(txtprice, ex.Message);
                
            //}
            bool ok = BuildObjectByFields();
            if (ok == true)
            {
                DataRow dr = this.mySogKlaf.BuildRow();
                if (this.mySogeKlafim.Add(dr))
                {
                    MessageBox.Show("סוג קלף חדש התווסף למאגר בהצלחה");
                    clearFields();
                }
                else
                    MessageBox.Show("קיים במאגר");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFields() == true)
                {
                    this.mySogKlaf.Status = false;
                    DataRow dr = this.mySogKlaf.BuildRow();
                    if (this.mySogeKlafim.update(dr) == true)
                    {
                        clearFields();
                        MessageBox.Show(" נמחק");
                        fillComboBoxSelectPro();
                    }
                    

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields() == true)
            {
                DataRow dr = this.mySogKlaf.BuildRow();
                if (this.mySogeKlafim.update(dr) == true)
                {
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                    clearFields();
                }
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
        }

        private void cmbSogKlaf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(cmbSogKlaf.SelectedValue);
            DataRow dr = mySogeKlafim.Find(kod);
            this.mySogKlaf = new sogKlaf(dr);

            FillFields();

            grpboxAboda.Enabled = true;
            btnUpdate.Enabled = true;
        }
        public void clearFields()
        {
            if (this.statusFrm == statusKind.add)
            {
                lblKod.Text = Convert.ToString(mySogeKlafim.GetNextCode());
            }
            else 
                lblKod.Text = "";
            txtName.Text = "";
            cmbSogKlaf.Text = "-בחר סוג קלף-";
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
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
