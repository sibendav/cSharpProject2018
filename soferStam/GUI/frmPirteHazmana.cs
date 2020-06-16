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
    public partial class frmPirteHazmana : Form
    {
        private pirteHazmana mypirteHazmana;
        private pirteHazmanaTable mypirteHazmanots;
        private statusKind statusFrm;

        public frmPirteHazmana(statusKind sta)
        {
            InitializeComponent();
            this.mypirteHazmanots = new pirteHazmanaTable();
            this.statusFrm = sta;

            cmbKodAboda.DataSource = new abodotStamTable().GetTableTrue();
            cmbKodAboda.DisplayMember = "nameOfAboda";
            cmbKodAboda.ValueMember = "kodAboda";

            
        }
        public void FillFields()
        {
            lblKodPirteHazmana.Text = Convert.ToString(this.mypirteHazmana.KodPirteyHazmana);// KodHazmana);
            lblHazmana.Text = Convert.ToString(this.mypirteHazmana.KodHazmana);//);
            cmbKodAboda.SelectedValue = Convert.ToString(this.mypirteHazmana.KodAboda);
            txtDestinationDate.Text = Convert.ToString(this.mypirteHazmana.DestinationDate);
            txtAmount.Text = Convert.ToString(this.mypirteHazmana.Amount);
            cmbSogKlaf.SelectedValue = Convert.ToString(this.mypirteHazmana.KodSogKlaf);
            txtPrice.Text = Convert.ToString(this.mypirteHazmana.Price);
            checkBoxMade.Checked = this.mypirteHazmana.Status;


        }
        public bool BuildObjectByFields()
        {
            errorProvider1.Clear();
            bool ok = true;
            this.mypirteHazmana = new pirteHazmana();

            try 
            {
                this.mypirteHazmana.KodPirteyHazmana = Convert.ToInt32(lblKodPirteHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKodPirteHazmana, ex.Message);
                ok = false;
            }
            try
            {
                this.mypirteHazmana.KodHazmana = Convert.ToInt32(lblHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblHazmana, ex.Message);
                ok = false;
            }
            try 
            {
                this.mypirteHazmana.KodAboda = Convert.ToInt32(cmbKodAboda.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbKodAboda, ex.Message);
                ok = false;
            }
            try 
            {
                this.mypirteHazmana.DestinationDate = Convert.ToDateTime(txtDestinationDate.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDestinationDate, ex.Message);
                ok = false;
            }
            try 
            {
                this.mypirteHazmana.Amount = Convert.ToInt32(txtAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAmount, ex.Message);
                ok = false;
            }
            try 
            {
                this.mypirteHazmana.KodSogKlaf = Convert.ToInt32(cmbSogKlaf.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbSogKlaf, ex.Message);
                ok = false;
            }
            try 
            {
                this.mypirteHazmana.Price = Convert.ToInt32(txtPrice.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPrice, ex.Message);
                ok = false;
            }
            try 
            {
                this.mypirteHazmana.Status = Convert.ToBoolean(checkBoxMade.Checked);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(checkBoxMade, ex.Message);
                ok = false;
            }
            return ok;
        }
        public void ManegeFieldByStatusFrm()
        {
            if (this.statusFrm == statusKind.add)
            {
                lblKodPirteHazmana.Text = Convert.ToString(this.mypirteHazmanots.GetNextCode());
                txtDestinationDate.Text = DateTime.Today.ToShortDateString();
                grbPirteHazmana.Enabled = false;
                label12.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                cmbPirty.Visible = false;
            }
            else if (this.statusFrm == statusKind.update)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Enabled = false;
                grbPirteHazmana.Enabled = false;
                //cmbHazmzna.DataSource = new hazmanotTable().getAllHazmanot();
                //cmbPirty.DataSource=new 
                //cmbMazmin.DataSource = DAL.dal.GetTableFromSQL("SELECT mazminim.nameOfMazmin, mazminim.NameOfFamily, mazminim.kodMaznim FROM mazminim INNER JOIN hazmanot ON mazminim.kodMaznim = hazmanot.kodMazmin");
                //cmbMazmin.DisplayMember = "fullName";
                //cmbMazmin.ValueMember = "kodMaznim";
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
        public void fillComboBoxMazminim()
        {
            cmbMazmin.DataSource = new mazminimTable().getLakohot();
            cmbMazmin.DisplayMember = "fullName";
            cmbMazmin.ValueMember = "kodMaznim";
            cmbMazmin.Text = "-בחר מזמין-";

            //cmbHazmzna.DataSource = mypirteHazmanots.getTableForComboBox("kodPirteyHazmana");
            //cmbHazmzna.DisplayMember = "fullName";
            //cmbHazmzna.ValueMember = "kodPirteyHazmana";
            //cmbKodAboda.Text = "-בחר עבודה-";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pirteHazmana p1=new pirteHazmana();
            try 
            {
                p1.KodPirteyHazmana = Convert.ToInt32(lblKodPirteHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKodPirteHazmana, ex.Message);
                
            }
            try
            {
                p1.KodHazmana = Convert.ToInt32(lblHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblHazmana, ex.Message);
                
            }
            try 
            {
                p1.KodAboda = Convert.ToInt32(cmbKodAboda.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbKodAboda, ex.Message);
                
            }
            try 
            {
                p1.DestinationDate = Convert.ToDateTime(txtDestinationDate.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDestinationDate, ex.Message);
                
            }
            try 
            {
                p1.Amount = Convert.ToInt32(txtAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAmount, ex.Message);
                
            }
            try 
            {
                p1.KodSogKlaf = Convert.ToInt32(cmbSogKlaf.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbSogKlaf, ex.Message);
                
            }
            try 
            {
                p1.Price = Convert.ToInt32(txtPrice.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPrice, ex.Message);
               
            }
            try 
            {
                p1.Status = Convert.ToBoolean(checkBoxMade.Checked);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(checkBoxMade, ex.Message);
                
            }
            bool ok = BuildObjectByFields();
            if (ok == true)
            {
                DataRow dr = this.mypirteHazmana.BuildRow();
                if (this.mypirteHazmanots.Add(dr))
                {
                    MessageBox.Show("פרטי ההזמנה התווספו בהצלחה");
                    clearFields();
                }
                else
                    MessageBox.Show("הפרטים קיימים במאגר");

            }
        }

        private void frmPirteHazmana_Load(object sender, EventArgs e)
        {
            fillComboBoxMazminim();
            ManegeFieldByStatusFrm();
            fillGrpbCmbxim();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק פרטי הזמנה זו?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFields() == true)
                {
                    DataRow dr = this.mypirteHazmana.BuildRow(); //
                    this.mypirteHazmanots.Delete(dr);
                    MessageBox.Show("פרטי הזמנה נמחקו!");
                    fillComboBoxMazminim();
                    clearFields();

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields() == true)
            {
                DataRow dr = this.mypirteHazmana.BuildRow();
                if (this.mypirteHazmanots.update(dr) == true)
                {
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                    clearFields();
                }
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
        }

        private void cmbBoxAboda_SelectedValueChanged(object sender, EventArgs e)
        {
            //int kod = Convert.ToInt32(cmbBoxAboda.SelectedValue);
            //DataRow dr = mypirteHazmanots.Find(kod);
            //this.mypirteHazmana = new pirteHazmana(dr);

            //FillFields();

            //grpboxAboda.Enabled = true;
            //btnUpdate.Enabled = true;

        }

        private void cmbBoxAboda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(cmbHazmzna.SelectedValue);
            DataRow dr = mypirteHazmanots.Find(kod);
            this.mypirteHazmana = new pirteHazmana(dr);

            FillFields();

            grbPirteHazmana.Enabled = true;
            btnUpdate.Enabled = true;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxAboda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMazmin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbHazmzna.Visible = true;
            cmbHazmzna.DataSource = new hazmanotTable().getAllHazmanot(Convert.ToInt32(cmbMazmin.SelectedValue));
            cmbHazmzna.DisplayMember = "dateHazmana";
            cmbHazmzna.ValueMember = "kodHazmana";
            cmbHazmzna.Text = "-בחר הזמנת מזמין-";

            cmbPirty.DataSource = new DataTable();
        }

        private void cmbHazmzna_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblHazmana.Text = Convert.ToString(cmbHazmzna.SelectedValue);
            grbPirteHazmana.Enabled = true;

            if (this.statusFrm != statusKind.add)
            {
                //cmbPirty.Visible = true; מיותר
                cmbPirty.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.kodPirteyHazmana, pirteHazmana.kodHazmana, abodotStam.nameOfAboda FROM abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda WHERE (((pirteHazmana.kodHazmana)="+cmbHazmzna.SelectedValue+"))");
                cmbPirty.DisplayMember = "nameOfAboda";
                cmbPirty.ValueMember = "kodPirteyHazmana";
            }
        }

        private void cmbPirty_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(cmbPirty.SelectedValue);
            DataRow dr = mypirteHazmanots.Find(kod);
            this.mypirteHazmana = new pirteHazmana(dr);//חיפשתי את השורה שבה הקוד פרטי הזמנה הוא כמו שבחרתי בקומבובוקס

            FillFields();

            grbPirteHazmana.Enabled = true;
            btnUpdate.Enabled = true;
        }
        public void clearFields()
        {
            if(this.statusFrm==statusKind.add)
                lblKodPirteHazmana.Text = Convert.ToString(this.mypirteHazmanots.GetNextCode());
            else
                lblKodPirteHazmana.Text = "";
            lblHazmana.Text = "";
            //cmbKodAboda.SelectedValue = Convert.ToString(this.mypirteHazmana.KodAboda);
            txtDestinationDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
            txtAmount.Text = "";
            //cmbSogKlaf.SelectedValue = Convert.ToString(this.mypirteHazmana.KodSogKlaf);
            txtPrice.Text = "";
            checkBoxMade.Checked = false;
            fillGrpbCmbxim();
            //fillComboBoxMazminim();
        }
        public void fillGrpbCmbxim()
        {
            cmbKodAboda.DataSource = new abodotStamTable().getAbodotStam();
            cmbKodAboda.DisplayMember = "nameOfAboda";
            cmbKodAboda.ValueMember = "kodAboda";
            cmbKodAboda.Text = "-בחר קוד עבודה-";

            cmbSogKlaf.DataSource = new sogKlafTable().getSogeKlaf();
            cmbSogKlaf.DisplayMember = "nameSogKlaf";
            cmbSogKlaf.ValueMember = "kodSogKlaf";
            cmbSogKlaf.Text = "-בחר סוג קלף-";
        }

        private void cmbMazmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsNum(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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

