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
    public partial class frmHespekim : Form
    {
        private hespekim myHespek;
        private hespekimTable myHespekims;
        private statusKind statusfrm;

        public frmHespekim(statusKind sta)
        {
            InitializeComponent();
            this.myHespekims = new hespekimTable();
            this.statusfrm = sta;

            cmbKodHazmana.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.kodPirteyHazmana, mazminim.NameOfFamily+' '+mazminim.nameOfMazmin+'-'+abodotStam.nameOfAboda AS fullName FROM mazminim INNER JOIN (hazmanot INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin ORDER BY mazminim.nameOfMazmin+' '+mazminim.NameOfFamily+'-'+abodotStam.nameOfAboda");
            cmbKodHazmana.DisplayMember = "fullName";
            cmbKodHazmana.ValueMember = "kodPirteyHazmana";

            
        }

        public frmHespekim(statusKind sta, int kodPirteHazmana)
        {
            InitializeComponent();
            this.myHespekims = new hespekimTable();
            this.statusfrm = sta;

            cmbKodHazmana.Text = Convert.ToString(kodPirteHazmana);
            //cmbKodHazmana.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.kodPirteyHazmana, mazminim.NameOfFamily+' '+mazminim.nameOfMazmin+'-'+abodotStam.nameOfAboda AS fullName FROM mazminim INNER JOIN (hazmanot INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin ORDER BY mazminim.nameOfMazmin+' '+mazminim.NameOfFamily+'-'+abodotStam.nameOfAboda");
            //cmbKodHazmana.DisplayMember = "fullName";
            //cmbKodHazmana.ValueMember = "kodPirteyHazmana";
            cmbKodHazmana.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.kodPirteyHazmana, mazminim.NameOfFamily+' '+mazminim.nameOfMazmin+'-'+abodotStam.nameOfAboda AS fullname FROM mazminim INNER JOIN (hazmanot INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin WHERE (((pirteHazmana.kodPirteyHazmana)="+kodPirteHazmana+")) ORDER BY mazminim.nameOfMazmin+' '+mazminim.NameOfFamily+'-'+abodotStam.nameOfAboda");
            cmbKodHazmana.DisplayMember = "fullName";
            cmbKodHazmana.ValueMember = "kodPirteyHazmana";
            cmbKodHazmana.Text = Convert.ToString( kodPirteHazmana);

        }

        public void FillFields()
        {
            lblKod.Text = Convert.ToString(this.myHespek.KodHespek);
            cmbKodHazmana.SelectedValue = this.myHespek.KodParitHazmana;
            txtDate.Text= Convert.ToString(this.myHespek.TheDate.ToShortDateString());
            txtfromTime.Text = Convert.ToString(this.myHespek.FromTime);
            txtTillTime.Text = Convert.ToString(this.myHespek.TillTime);
            
        }
        public bool BuildObjectByFields()
        {
            errorProvider1.Clear();
            bool ok = true;
            this.myHespek = new hespekim();

            try //קוד
            {
                this.myHespek.KodHespek = Convert.ToInt16(lblKod.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKod, ex.Message);
                ok = false;
            }

            try  //קוד הזמנה
            {
                this.myHespek.KodParitHazmana = Convert.ToInt32(cmbKodHazmana.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbKodHazmana, ex.Message);
                ok = false;
            }

            
            try  // תאריך
            {
                this.myHespek.TheDate = Convert.ToDateTime(txtDate.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDate, ex.Message);
                ok = false;
            }


            try  // משעה
            {
                this.myHespek.FromTime = Convert.ToDateTime(txtfromTime.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtfromTime, ex.Message);
                ok = false;
            }

            
                try  // עד שעה
                {
                    //if (HoursFigureForAdd() == false)
                    //    throw new Exception("לא מילאת את השעות כראוי");
                    //else
                        this.myHespek.TillTime = Convert.ToDateTime(txtTillTime.Text);
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtTillTime, ex.Message);
                    ok = false;
                }
           

            return ok;


        }
        public void ManegeFieldByStatusFrm()
        {
            if (this.statusfrm == statusKind.add)
            {
                lblKod.Text = Convert.ToString(this.myHespekims.GetNextCode());
                cmbHspek.Visible = false;
                label3.Visible = false;
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                lblKod.Text = Convert.ToString(myHespekims.GetNextCode());
                txtDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
                txtfromTime.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
                txtTillTime.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
            }
            else if (this.statusfrm == statusKind.update)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Enabled = false;
                grpboxHespek.Enabled = false;
                cmbKodHazmana.Enabled = false;


            }
            else if (this.statusfrm == statusKind.delet)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = true;
                btnUpdate.Visible = false;
            }
            else if (this.statusfrm == statusKind.show)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
        }
        public void fillComboBoxSelectPro()
        {
            cmbHspek.DataSource = myHespekims.getTableForComboBox("theDate");
            cmbHspek.DisplayMember = "fullName";
            cmbHspek.ValueMember = "kodHespek";
            //cmbKodHazmana.Text = "-בחר הזמנה-";
            

        }

        private void frmHespekim_Load(object sender, EventArgs e)
        {
            fillComboBoxSelectPro();
            ManegeFieldByStatusFrm();
            cmbKodHazmana.Text = "-בחר הזמנה-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            hespekim h1=new hespekim();

            
            try //קוד
            {
                h1.KodHespek = Convert.ToInt16(lblKod.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lblKod, ex.Message);
               
            }

            try  //קוד הזמנה
            {
                h1.KodParitHazmana = Convert.ToInt32(cmbKodHazmana.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbKodHazmana, ex.Message);
              
            }

            

            try  // תאריך
            {
                h1.TheDate = Convert.ToDateTime(txtDate.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDate, ex.Message);
                
            }


            try  // משעה
            {
                h1.FromTime = Convert.ToDateTime(txtfromTime.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtfromTime, ex.Message);
                
            }

            
                try  // עד שעה
                {

                        h1.TillTime = Convert.ToDateTime(txtTillTime.Text);
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtTillTime, ex.Message);

                }
           


           
            bool ok=BuildObjectByFields();
            if (ok == true)
            {
                DataRow dr = this.myHespek.BuildRow();
                if (this.myHespekims.Add(dr))
                {
                    MessageBox.Show("ההספק התווסף בהצלחה");
                    clearFields();
                }
                else
                    MessageBox.Show(" קיים במאגר");
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields() == true)
            {
                DataRow dr = this.myHespek.BuildRow();
                if (this.myHespekims.update(dr) == true)
                    MessageBox.Show("העדכון בוצע בהצלחה!");
                else
                    MessageBox.Show("הפעולה נכשלה!");
            }
            clearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("האם אתה בטוח שברצונך למחוק הספק זה?", "שים לב!!!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (BuildObjectByFields() == true)
                {
                    DataRow dr = this.myHespek.BuildRow(); //
                    this.myHespekims.Delete(dr);
                    clearFields();
                    MessageBox.Show("ההספק נמחק!");
                    fillComboBoxSelectPro();
                    //clearFields();
                    //cmbKodHazmana.Text = "-בחר הזמנה-";

                }

            }
        }

        private void cmbHspek_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(cmbHspek.SelectedValue);
            DataRow dr = myHespekims.Find(kod);
            this.myHespek = new hespekim(dr);

            FillFields();

            grpboxHespek.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void cmbKodAboda_SelectionChangeCommitted(object sender, EventArgs e)//טעות
        {
            
        }

        private void grpboxHespek_Enter(object sender, EventArgs e)
        {

        }

        private void txtfromTime_Leave(object sender, EventArgs e)
        {
            
        }

        private void lblKod_Click(object sender, EventArgs e)
        {

        }

        private void cmbKodHazmana_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //lblNameAboda.Text=DAL.dal.GetTableFromSQL(" SELECT abodotStam.nameOfAboda FROM abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda WHERE (((pirteHazmana.kodPirteyHazmana)="+Convert.ToInt32(cmbKodHazmana.SelectedValue)+"))").Rows[0].ToString();
            //לשאול את נעמה איל שולפים את הנתון הבודד!!!
        }

        private void cmbKodHazmana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public bool HoursFigureForAdd()
        //{
        //    bool ok = true;
        //    if (txtfromTime.Text != "" && txtTillTime.Text != "" && Convert.ToDateTime(txtTillTime.Text) >= Convert.ToDateTime(txtfromTime.Text))
        //    {
        //        DateTime a = Convert.ToDateTime(txtTillTime.Text);
        //        DateTime b = Convert.ToDateTime(txtfromTime.Text);

        //        double c = Convert.ToDouble(a.Hour - b.Hour) + ((Convert.ToDouble(a.Minute) - Convert.ToDouble(b.Minute)) / 60);
        //        if (c <= 0)
        //        {
                    
        //            ok = false;
        //        }

        //        //throw new Exception("הקש שעות תקינות");
        //        //errorProvider1.SetError(txtDate, new Exception("הקש שעות תקינות"));
        //        else
        //            lblMis.Text = Convert.ToString(Math.Round(c, 2));
        //    }
        //    else
        //    {
        //        throw new Exception("לא מילאת את השעות כראוי");
        //        ok =  false;
        //    }
        //    return ok;
        //}

        public void HoursFigure()
        {
            if (txtfromTime.Text != "" && txtTillTime.Text != "" && Convert.ToDateTime(txtTillTime.Text) >= Convert.ToDateTime(txtfromTime.Text))
            {
                DateTime a = Convert.ToDateTime(txtTillTime.Text);
                DateTime b = Convert.ToDateTime(txtfromTime.Text);

                double c = Convert.ToDouble(a.Hour - b.Hour) + ((Convert.ToDouble(a.Minute) - Convert.ToDouble(b.Minute)) / 60);
                if (c <= 0)
                {

                    MessageBox.Show("לא מילאת את השעות כראוי");
                }

                //throw new Exception("הקש שעות תקינות");
                //errorProvider1.SetError(txtDate, new Exception("הקש שעות תקינות"));
                else
                    lblMis.Text = Convert.ToString(Math.Round(c, 2));
            }
            else
           
                MessageBox.Show("לא מילאת את השעות כראוי");
                
           
            
        }
        private void BDIKA_Click(object sender, EventArgs e)
        {
            HoursFigure();
        }

        private void txtTillTime_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTillTime_MouseLeave(object sender, EventArgs e)
        {
            

               
        }
        public void clearFields()
        {
            if (this.statusfrm == statusKind.add)
            {
                lblKod.Text = Convert.ToString(myHespekims.GetNextCode());
            }
            else 
                lblKod.Text = "";
            cmbKodHazmana.DataSource = DAL.dal.GetTableFromSQL("SELECT pirteHazmana.kodPirteyHazmana, mazminim.NameOfFamily+' '+mazminim.nameOfMazmin+'-'+abodotStam.nameOfAboda AS fullName FROM mazminim INNER JOIN (hazmanot INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin ORDER BY mazminim.nameOfMazmin+' '+mazminim.NameOfFamily+'-'+abodotStam.nameOfAboda");
            cmbKodHazmana.DisplayMember = "fullName";
            cmbKodHazmana.ValueMember = "kodPirteyHazmana";
           
            cmbHspek.Text = "";
            txtDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
            txtfromTime.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
            txtTillTime.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
            lblMis.Text = "";
            cmbKodHazmana.Text = "-בחר הזמנה-";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
