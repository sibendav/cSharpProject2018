namespace soferStam.GUI
{
    partial class frmAbodatStam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbodatStam));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbBoxAboda = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtWritingType = new System.Windows.Forms.TextBox();
            this.grpboxAboda = new System.Windows.Forms.GroupBox();
            this.btnKlaf = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKlaf = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpboxAboda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "בס\"ד";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "עבודת סת\"ם";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 52);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "בחר עבודה:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "קוד עבודה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "שם עבודה";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(165, 16);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(0, 13);
            this.lblKod.TabIndex = 5;
            this.lblKod.Click += new System.EventHandler(this.lblKod_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "קלף";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "כמות קלפים";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "סוג כתיבה";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(171, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 52);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 53);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(246, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 52);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "מחק";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbBoxAboda
            // 
            this.cmbBoxAboda.FormattingEnabled = true;
            this.cmbBoxAboda.Location = new System.Drawing.Point(115, 47);
            this.cmbBoxAboda.Name = "cmbBoxAboda";
            this.cmbBoxAboda.Size = new System.Drawing.Size(93, 21);
            this.cmbBoxAboda.TabIndex = 12;
            this.cmbBoxAboda.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxAboda_SelectionChangeCommitted);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 20);
            this.txtName.TabIndex = 13;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(88, 79);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(110, 20);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtWritingType
            // 
            this.txtWritingType.Location = new System.Drawing.Point(88, 101);
            this.txtWritingType.Name = "txtWritingType";
            this.txtWritingType.Size = new System.Drawing.Size(110, 20);
            this.txtWritingType.TabIndex = 16;
            this.txtWritingType.TextChanged += new System.EventHandler(this.txtWritingType_TextChanged);
            this.txtWritingType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWritingType_KeyPress);
            // 
            // grpboxAboda
            // 
            this.grpboxAboda.Controls.Add(this.label14);
            this.grpboxAboda.Controls.Add(this.label13);
            this.grpboxAboda.Controls.Add(this.label12);
            this.grpboxAboda.Controls.Add(this.label11);
            this.grpboxAboda.Controls.Add(this.label10);
            this.grpboxAboda.Controls.Add(this.btnKlaf);
            this.grpboxAboda.Controls.Add(this.txtTime);
            this.grpboxAboda.Controls.Add(this.label6);
            this.grpboxAboda.Controls.Add(this.cmbKlaf);
            this.grpboxAboda.Controls.Add(this.txtWritingType);
            this.grpboxAboda.Controls.Add(this.txtAmount);
            this.grpboxAboda.Controls.Add(this.txtName);
            this.grpboxAboda.Controls.Add(this.label9);
            this.grpboxAboda.Controls.Add(this.label8);
            this.grpboxAboda.Controls.Add(this.label7);
            this.grpboxAboda.Controls.Add(this.lblKod);
            this.grpboxAboda.Controls.Add(this.label5);
            this.grpboxAboda.Controls.Add(this.label4);
            this.grpboxAboda.Location = new System.Drawing.Point(44, 71);
            this.grpboxAboda.Name = "grpboxAboda";
            this.grpboxAboda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpboxAboda.Size = new System.Drawing.Size(325, 154);
            this.grpboxAboda.TabIndex = 17;
            this.grpboxAboda.TabStop = false;
            this.grpboxAboda.Text = "פרטי עבודת סת\"ם";
            // 
            // btnKlaf
            // 
            this.btnKlaf.Location = new System.Drawing.Point(17, 53);
            this.btnKlaf.Name = "btnKlaf";
            this.btnKlaf.Size = new System.Drawing.Size(65, 26);
            this.btnKlaf.TabIndex = 21;
            this.btnKlaf.Text = "הוסף";
            this.btnKlaf.UseVisualStyleBackColor = true;
            this.btnKlaf.Click += new System.EventHandler(this.btnKlaf_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(88, 124);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(110, 20);
            this.txtTime.TabIndex = 20;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "מספר שעות העבודה";
            // 
            // cmbKlaf
            // 
            this.cmbKlaf.FormattingEnabled = true;
            this.cmbKlaf.Location = new System.Drawing.Point(88, 57);
            this.cmbKlaf.Name = "cmbKlaf";
            this.cmbKlaf.Size = new System.Drawing.Size(110, 21);
            this.cmbKlaf.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(12, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "יציאה";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(198, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(198, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(198, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(198, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(198, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "*";
            // 
            // frmAbodatStam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 358);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpboxAboda);
            this.Controls.Add(this.cmbBoxAboda);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbodatStam";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "עבודת סת\"ם";
            this.Load += new System.EventHandler(this.frmAbodatStam_Load);
            this.grpboxAboda.ResumeLayout(false);
            this.grpboxAboda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbBoxAboda;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtWritingType;
        private System.Windows.Forms.GroupBox grpboxAboda;
        private System.Windows.Forms.ComboBox cmbKlaf;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKlaf;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}