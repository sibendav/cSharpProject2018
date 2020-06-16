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
    public partial class frmHosafaKolectivit : Form
    {
        private mazminim myMazmin;
        private mazminimTable myMazminims;

        private hazmanot myHazmana;
        private hazmanotTable myHazmanots;

        private pirteHazmana mypirteHazmana;
        private pirteHazmanaTable mypirteHazmanots;

        private statusKind statusFrm;

        public frmHosafaKolectivit(statusKind sta)
        {
            InitializeComponent();
            this.myMazminims = new mazminimTable();
            this.myHazmanots = new hazmanotTable();
            this.mypirteHazmanots = new pirteHazmanaTable();

            this.statusFrm = sta;

        }
        public frmHosafaKolectivit(statusKind sta, mazminim lakoah)
        {
            InitializeComponent();
            this.myMazminims = new mazminimTable();
            this.myHazmanots = new hazmanotTable();
            this.mypirteHazmanots = new pirteHazmanaTable();

            this.statusFrm = sta;
            this.myMazmin = lakoah;
            FillFieldsMazminimInformationTraveling(lakoah);
            btnClearH.Enabled = true;
            grpbMazmin.Enabled = false;
            btnUpM.Enabled = true;

        }

        public void FillFieldsMazminimInformationTraveling(mazminim m)
        {
            lblKodMazmin.Text = Convert.ToString(m.KodMaznim);
            txtName.Text = m.NameOfMazmin;
            txtFName.Text = m.NameOfFamily1;
            txtPhone.Text = Convert.ToString(m.PhoneNumber);
            txtAPhone.Text = Convert.ToString(m.AnotherPhone);
            txtStreet.Text = m.Street;
            txtHouseNum.Text = Convert.ToString(m.NumberOfHouse);
            txtCity.Text = m.City;

        }

        public void FillFieldsMazminim()
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

        public void FillFieldsHazmanot()
        {
            lblKodHazmana.Text = Convert.ToString(this.myHazmana.KodHazmana);//dgvHazmanoySelMazminim.Rows[e.rowindex].Cells["kodHazmana"].Value.ToString();
            txtDate.Text = Convert.ToString(this.myHazmana.DateHazmana.ToShortDateString());
            //cmbMazmin.DataSource = myMazminims.getNameLakoah(this.myHazmana.KodMazmin);
            //cmbMazmin.DisplayMember = "fullName";
            //cmbMazmin.ValueMember = "";
            lblKodMazminSelHazmana.Text = Convert.ToString(this.myHazmana.KodMazmin);
        }

        public bool BuildObjectByFieldsPirteHazmana()
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
                this.mypirteHazmana.KodHazmana = Convert.ToInt32(lblkodHazmanaSelPirteHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblkodHazmanaSelPirteHazmana, ex.Message);
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
        public bool BuildObjectByFieldsHazmana()
        {
            errorProvider1.Clear();
            bool ok = true;
            this.myHazmana = new hazmanot();

            try//קוד הזמנה
            {
                this.myHazmana.KodHazmana = Convert.ToInt32(lblKodHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKodHazmana, ex.Message);
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
                this.myHazmana.KodMazmin = Convert.ToInt32(lblKodMazminSelHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKodMazminSelHazmana, ex.Message);
                ok = false;
            }
            return ok;
        }
        public void ManegeFieldByStatusFrm()
        {
            if (this.statusFrm == statusKind.add)
            {
                lblMazabFrm.Text = "הוספת הזמנה";
                movingThings();
                label7.Visible = false;
                dgvHarbePirtiHazmanaSelHazmanaAhat.Enabled = false;
                btnDelP.Visible = false;
                btnUpP.Visible = false;
                btnHespekim.Visible = false;
                btnClearP.Enabled = false;

            }
            else if (this.statusFrm == statusKind.update)
            {
                lblMazabFrm.Text = "עדכון הזמנה";
                btnAddH.Visible = false;
                btnClearH.Visible = false;
                btnDelH.Visible = false;

                btnAddP.Visible = false;
                btnClearP.Visible = false;
                btnDelP.Visible = false;

                btnHespekim.Visible = false;
                


            }
            else if (this.statusFrm == statusKind.delet)
            {
                lblMazabFrm.Text = "מחיקת הזמנה";

                btnAddH.Visible = false;
                btnClearH.Visible = false;
                btnUpH.Visible = false;

                btnAddP.Visible = false;
                btnClearP.Visible = false;
                btnUpP.Visible = false;
                btnHespekim.Visible = false;
            }
            else if (this.statusFrm == statusKind.show)
            {
                lblMazabFrm.Text = "מצב הזמנה";

                btnAddH.Visible = false;
                btnDelH.Visible = false;
                btnUpH.Visible = false;
                btnClearH.Visible = false;

                btnAddP.Visible = false;
                btnDelP.Visible = false;
                btnUpP.Visible = false;
                btnClearP.Visible = false;

                btnUpM.Visible = false;
            }
        }
        public void FillComboxMazminim()
        {
            cmbMazminim.DataSource = myMazminims.getFullName();
            cmbMazminim.DisplayMember = "fullName";
            cmbMazminim.ValueMember = "kodMaznim";
            cmbMazminim.Text = "-בחר לקוח-";
        }

        public void FillComboximSelGrpbPirteHazmana()
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
        

        //public void ClearFields()
        //{
        //    lblKodMazmin.Text = "";
        //    txtName.Text = "";
        //    txtFName.Text = "";
        //    txtPhone.Text = "";
        //    txtAPhone.Text = "";
        //    txtStreet.Text = "";
        //    txtHouseNum.Text = "";
        //    txtCity.Text = "";
        //    FillComboxSelectedPro();
        //}

        private void frmHosafaKolectivit_Load(object sender, EventArgs e)
        {
            
            ManegeFieldByStatusFrm();
            FillComboxMazminim();
            FillComboximSelGrpbPirteHazmana();
             
        }

        private void grpBoxHazmana_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnDelet_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //if (BuildObjectByFieldsHazmana()==true &&BuildObjectByFieldsPirteHazmana()==true)
            //{
            //    //DataRow drm = this.myMazmin.BuildRow();
            //    DataRow drh = this.myHazmana.BuildRow();
            //    DataRow drp = this.mypirteHazmana.BuildRow();
            //    if (this.myHazmanots.update(drh) == true && this.mypirteHazmanots.update(drp) == true)
            //    {
            //        MessageBox.Show("העדכון בוצע בהצלחה!");
            //        //ClearFields();
            //    }

            //    MessageBox.Show("הפעולה נכשלה!");
            //}
            
        }

        private void cmbMazminim_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(cmbMazminim.SelectedValue);
            DataRow dr = myMazminims.Find(kod);
            this.myMazmin = new mazminim(dr);

            FillFieldsMazminim();

            grpbMazmin.Enabled = true;
            btnClearH.Enabled = true;

            filldgvHazmanoySelMazminim();
            btnUpM.Enabled = true;
            lblKodMazminSelHazmana.Text = lblKodMazmin.Text;
        }

        private void lblKodMazmin_TextChanged(object sender, EventArgs e)
        {
            //filldgvHazmanoySelMazminim();
            //btnUpM.Enabled = true;
            //lblKodMazminSelHazmana.Text = lblKodMazmin.Text;
            
        }
        public void filldgvHazmanoySelMazminim()
        {
            DataTable dt=DAL.dal.GetTableFromSQL("SELECT hazmanot.kodHazmana, hazmanot.dateHazmana, hazmanot.kodMazmin FROM hazmanot WHERE (((hazmanot.kodMazmin)=" + lblKodMazmin.Text + "))");
            dgvHazmanoySelMazminim.DataSource =  dt;
            dgvHazmanoySelMazminim.Columns[0].Visible = false;
            dgvHazmanoySelMazminim.Columns[1].HeaderText = "תאריך הזמנה";
            dgvHazmanoySelMazminim.Columns[2].HeaderText = "קוד לקוח";
            if (dt == null)
            {
                dgvHazmanoySelMazminim.Enabled = false;
            }
        }

        private void lblKodMazmin_Click(object sender, EventArgs e)
        {

        }

        private void dgvHazmanoySelMazminim_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAddH.Enabled = false;
            btnUpH.Enabled = true;
            btnDelH.Enabled = true;

            if (dgvHazmanoySelMazminim.Rows.Count-1!=0)
            {
                grpBoxHazmana.Enabled = true;
            lblKodHazmana.Text = dgvHazmanoySelMazminim.Rows[e.RowIndex].Cells["kodHazmana"].Value.ToString();
            DateTime d = Convert.ToDateTime(dgvHazmanoySelMazminim.Rows[e.RowIndex].Cells["dateHazmana"].Value.ToString());
            txtDate.Text = d.ToShortDateString();
            lblKodMazminSelHazmana.Text = dgvHazmanoySelMazminim.Rows[e.RowIndex].Cells["kodMazmin"].Value.ToString();
            lblkodHazmanaSelPirteHazmana.Text = dgvHazmanoySelMazminim.Rows[e.RowIndex].Cells["kodHazmana"].Value.ToString();
            clearFieldsOfPirteHazmana();
             
            }
            if (this.statusFrm == statusKind.add)
                grpbPirteHazmana.Enabled = false;
        }

        private void dgvHarbePirtiHazmanaSelHazmanaAhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvHazmanoySelMazminim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void lblKod_TextChanged(object sender, EventArgs e)
        {
            if (lblKodHazmana.Text != "")
            {
                lblkodHazmanaSelPirteHazmana.Text = lblKodHazmana.Text;
                if (this.statusFrm == statusKind.add)
                {
                    grpbPirteHazmana.Enabled = false;
                }
                fillDgvPirteHazmana();
                btnClearP.Enabled = true;
            }
             
        }
        public void fillDgvPirteHazmana()
        {
            if (Convert.ToInt32(lblkodHazmanaSelPirteHazmana.Text) > 0)
            {
                dgvHarbePirtiHazmanaSelHazmanaAhat.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.kodPirteyHazmana, pirteHazmana.kodHazmana, pirteHazmana.kodAboda, abodotStam.nameOfAboda, pirteHazmana.destinationDate, pirteHazmana.amount, pirteHazmana.kodSogKlaf, sogKlaf.nameSogKlaf, pirteHazmana.price, pirteHazmana.status FROM sogKlaf INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON sogKlaf.kodSogKlaf = pirteHazmana.kodSogKlaf WHERE (((pirteHazmana.kodHazmana)=" + lblkodHazmanaSelPirteHazmana.Text + "))");
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[0].Visible = false;
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[1].Visible = false;
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[2].Visible = false;
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[3].HeaderText = "עבודת סת'ם";
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[4].HeaderText = "תאריך יעד";
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[5].HeaderText = "כמות";
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[6].Visible = false;
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[7].HeaderText = "סוג קלף";
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[8].HeaderText = "מחיר";
                dgvHarbePirtiHazmanaSelHazmanaAhat.Columns[9].HeaderText = "בוצע/לא בוצע";
            }
            if (dgvHarbePirtiHazmanaSelHazmanaAhat.Rows.Count - 1 != 0)
                btnKabala.Enabled = true;
        }

        private void dgvHarbePirtiHazmanaSelHazmanaAhat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHarbePirtiHazmanaSelHazmanaAhat.Rows.Count - 1 != 0)
            {
                grpbPirteHazmana.Enabled = true;
                lblKodPirteHazmana.Text = dgvHarbePirtiHazmanaSelHazmanaAhat.Rows[e.RowIndex].Cells["kodPirteyHazmana"].Value.ToString();
                lblkodHazmanaSelPirteHazmana.Text = dgvHarbePirtiHazmanaSelHazmanaAhat.Rows[e.RowIndex].Cells["kodHazmana"].Value.ToString();
                cmbKodAboda.Text = dgvHarbePirtiHazmanaSelHazmanaAhat.Rows[e.RowIndex].Cells["nameOfAboda"].Value.ToString();
                txtDestinationDate.Text = Convert.ToDateTime(dgvHarbePirtiHazmanaSelHazmanaAhat.Rows[e.RowIndex].Cells["destinationDate"].Value.ToString()).ToShortDateString();
                txtAmount.Text = dgvHarbePirtiHazmanaSelHazmanaAhat.Rows[e.RowIndex].Cells["amount"].Value.ToString();
                cmbSogKlaf.Text = dgvHarbePirtiHazmanaSelHazmanaAhat.Rows[e.RowIndex].Cells["nameSogKlaf"].Value.ToString();
                txtPrice.Text = dgvHarbePirtiHazmanaSelHazmanaAhat.Rows[e.RowIndex].Cells["price"].Value.ToString();
                checkBoxMade.Checked = Convert.ToBoolean(dgvHarbePirtiHazmanaSelHazmanaAhat.Rows[e.RowIndex].Cells["status"].Value);
                btnHespekim.Enabled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMazmin f = new frmMazmin(statusKind.addAndBack);
            f.Show();
        }

        private void btnUpM_Click(object sender, EventArgs e)
        {
            mazminim m = new mazminim(Convert.ToInt32(lblKodMazmin.Text), txtName.Text, txtFName.Text, txtPhone.Text, txtAPhone.Text, txtStreet.Text, Convert.ToInt32(txtHouseNum.Text), txtCity.Text);
            frmMazmin f = new frmMazmin(statusKind.updateAndBack, m, this.statusFrm);
            f.Show();
            this.Close();
        }

        private void btnDelM_Click(object sender, EventArgs e)
        {
            frmMazmin f = new frmMazmin(statusKind.delet);
            f.Show();
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {

        }

        private void lblKodPirteHazmana_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHespekim_Click(object sender, EventArgs e)
        {
            frmHespekiHazmana f = new frmHespekiHazmana(Convert.ToInt32(lblKodPirteHazmana.Text));
            f.Show();
        }

        public void movingThings()
        {
            label12.Location = new Point(477, 254);
            dgvHazmanoySelMazminim.Location = new Point(384, 274);

            grpBoxHazmana.Location = new Point(400, 107);
            btnClearH.Location = new Point(347, 114);


            label13.Location = new Point(145, 298);
            dgvHarbePirtiHazmanaSelHazmanaAhat.Location = new Point(56, 320);

            grpbPirteHazmana.Location = new Point(69, 68);
            btnClearP.Location = new Point(16, 79);
            
        }

        private void grpbPirteHazmana_Enter(object sender, EventArgs e)
        {

        }

        private void lblMazabFrm_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            grpBoxHazmana.Enabled = true;
            lblKodHazmana.Text = Convert.ToString(this.myHazmanots.GetNextCode());
            txtDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
            lblKodMazminSelHazmana.Text = lblKodMazmin.Text;
            btnAddH.Enabled = true;
            btnUpH.Enabled = false;
            btnDelH.Enabled = false;
        }

        private void btnAddH_Click(object sender, EventArgs e)
        {
            hazmanot h1 = new hazmanot();

            try//קוד הזמנה
            {
                h1.KodHazmana = Convert.ToInt32(lblKodHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKodHazmana, ex.Message);
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
                h1.KodMazmin = Convert.ToInt32(lblKodMazminSelHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKodMazminSelHazmana, ex.Message);
            }

            bool ok = BuildObjectByFieldsHazmana();
            if (ok == true)
            {
                DataRow dr = this.myHazmana.BuildRow();
                if (this.myHazmanots.Add(dr))
                {
                    MessageBox.Show("ההזמנה התווספה בהצלחה");
                    clearFieldsOfHazmana();
                    grpBoxHazmana.Enabled = false;
                    lblkodHazmanaSelPirteHazmana.Text = lblKodHazmana.Text;
                    
                }
                else
                    MessageBox.Show("קיים במאגר");
            }
            filldgvHazmanoySelMazminim();
        }
        public void clearFieldsOfHazmana()
        {
            lblKodHazmana.Text = "";
            txtDate.Text = "";
            lblKodMazminSelHazmana.Text = "";
        }

        private void btnUpH_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFieldsHazmana() == true)
            {
                DataRow dr = this.myHazmana.BuildRow();
                if (this.myHazmanots.update(dr) == true)
                {
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                    filldgvHazmanoySelMazminim();
                }
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
        }

        private void btnDelH_Click(object sender, EventArgs e)
        {
            bool degel = true;
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFieldsHazmana() == true)
                {
                    DataRow dr = this.myHazmana.BuildRow(); //
                    this.myHazmanots.Delete(dr);
                    DataTable dt = new pirteHazmanaTable().getPirteyHazmanaByHazmana(this.myHazmana.KodHazmana);
                    foreach (DataRow d in dt.Rows)
                    {
                        //DataRow d2 = new pirteHazmanaTable().Find(dr["kodPirteyHazmana"]);
                        if (true != this.mypirteHazmanots.Delete(d))
                        {
                            degel = false;
                        }

                    }

                    if (degel == true)
                        //if (this.myHazmanots.Delete(dr) == true)
                    {
                        MessageBox.Show(" נמחק");
                        clearFieldsOfHazmana();
                        clearFieldsOfPirteHazmana();
                        filldgvHazmanoySelMazminim();
                        //fillDgvPirteHazmana();
                        dgvHarbePirtiHazmanaSelHazmanaAhat.DataSource =  new DataTable();
                        
                    }

                }

            }
        }

        private void cmbMazminim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearP_Click(object sender, EventArgs e)
        {
            clearFieldsOfPirteHazmana();
            grpbPirteHazmana.Enabled=true;
        }

        public void clearFieldsOfPirteHazmana()
        {
            //if (this)
            lblKodPirteHazmana.Text = Convert.ToString(this.mypirteHazmanots.GetNextCode());
            lblkodHazmanaSelPirteHazmana.Text = lblKodHazmana.Text;
            //cmbKodAboda.SelectedValue = Convert.ToString(this.mypirteHazmana.KodAboda);
            txtDestinationDate.Text = DateTime.Today. ToShortDateString();
            txtAmount.Text = "";
            //cmbSogKlaf.SelectedValue = Convert.ToString(this.mypirteHazmana.KodSogKlaf);
            txtPrice.Text = "";
            checkBoxMade.Checked = false;
            FillComboximSelGrpbPirteHazmana();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            pirteHazmana p1 = new pirteHazmana();
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
                p1.KodHazmana = Convert.ToInt32(lblkodHazmanaSelPirteHazmana.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblkodHazmanaSelPirteHazmana, ex.Message);

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
            bool ok = BuildObjectByFieldsPirteHazmana();
            if (ok == true)
            {
                DataRow dr = this.mypirteHazmana.BuildRow();
                if (this.mypirteHazmanots.Add(dr))
                {
                    MessageBox.Show("פרטי ההזמנה התווספו בהצלחה");
                    clearFieldsOfPirteHazmana();
                    fillDgvPirteHazmana();

                }
                else
                    MessageBox.Show("הפרטים קיימים במאגר");

            }
        }

        private void btnUpP_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFieldsPirteHazmana() == true)
            {
                DataRow dr = this.mypirteHazmana.BuildRow();
                if (this.mypirteHazmanots.update(dr) == true)
                {
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                    //clearFieldsOfPirteHazmana();
                    fillDgvPirteHazmana();
                }
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק פרטי הזמנה זו?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFieldsPirteHazmana() == true)
                {
                    DataRow dr = this.mypirteHazmana.BuildRow(); //
                    this.mypirteHazmanots.Delete(dr);
                    MessageBox.Show("פרטי הזמנה נמחקו!");
                    clearFieldsOfPirteHazmana();
                    fillDgvPirteHazmana();

                }

            }
        }

        private void btnKabala_Click(object sender, EventArgs e)
        {
            DataTable dt=DAL.dal.GetTableFromSQL("SELECT pirteHazmana.kodPirteyHazmana, pirteHazmana.kodHazmana, pirteHazmana.kodAboda, abodotStam.nameOfAboda, pirteHazmana.destinationDate, pirteHazmana.amount, pirteHazmana.kodSogKlaf, sogKlaf.nameSogKlaf, pirteHazmana.price, pirteHazmana.status FROM sogKlaf INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON sogKlaf.kodSogKlaf = pirteHazmana.kodSogKlaf WHERE (((pirteHazmana.kodHazmana)=" + lblkodHazmanaSelPirteHazmana.Text + "))");
            kabala k = new kabala(Convert.ToInt32(lblKodHazmana.Text), dt);
            k.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMazminim_Click(object sender, EventArgs e)
        {
            clearFieldsOfHazmana();
            grpBoxHazmana.Enabled = false;
            btnClearH.Enabled = false;
            dgvHazmanoySelMazminim.DataSource = new DataTable();
            grpbPirteHazmana.Enabled = false;
            btnClearP.Enabled = false;
            dgvHarbePirtiHazmanaSelHazmanaAhat.DataSource = new DataTable();
        }

        private void lblkodHazmanaSelPirteHazmana_TextChanged(object sender, EventArgs e)
        {
            btnClearP.Enabled = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '\n'))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '\n'))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '\n'))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsHebrew(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '\n'))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void cmbKodAboda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtHouseNum_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!validation.IsNum(e.KeyChar) && (e.KeyChar != '\b'))
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
    }
   
}