namespace soferStam.GUI
{
    partial class frmHazmana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHazmana));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbHazmana = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.grpBoxHazmana = new System.Windows.Forms.GroupBox();
            this.cmbMazmin = new System.Windows.Forms.ComboBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbPirteiHazmanatLakoach = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBoxHazmana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "בס\"ד";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "תאריך הזמנה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "קוד מזמין";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(115, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "הזמנה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "קוד הזמנה";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 43);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(34, 232);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(75, 43);
            this.btnDelet.TabIndex = 11;
            this.btnDelet.Text = "מחק";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 44);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbHazmana
            // 
            this.cmbHazmana.FormattingEnabled = true;
            this.cmbHazmana.Location = new System.Drawing.Point(95, 58);
            this.cmbHazmana.Name = "cmbHazmana";
            this.cmbHazmana.Size = new System.Drawing.Size(99, 21);
            this.cmbHazmana.TabIndex = 13;
            this.cmbHazmana.SelectionChangeCommitted += new System.EventHandler(this.cmbHazmana_SelectionChangeCommitted);
            this.cmbHazmana.Leave += new System.EventHandler(this.cmbHazmana_Leave);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(23, 47);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 15;
            // 
            // grpBoxHazmana
            // 
            this.grpBoxHazmana.Controls.Add(this.label5);
            this.grpBoxHazmana.Controls.Add(this.cmbMazmin);
            this.grpBoxHazmana.Controls.Add(this.label4);
            this.grpBoxHazmana.Controls.Add(this.lblKod);
            this.grpBoxHazmana.Controls.Add(this.txtDate);
            this.grpBoxHazmana.Controls.Add(this.label10);
            this.grpBoxHazmana.Controls.Add(this.label3);
            this.grpBoxHazmana.Controls.Add(this.label2);
            this.grpBoxHazmana.Location = new System.Drawing.Point(43, 115);
            this.grpBoxHazmana.Name = "grpBoxHazmana";
            this.grpBoxHazmana.Size = new System.Drawing.Size(214, 111);
            this.grpBoxHazmana.TabIndex = 17;
            this.grpBoxHazmana.TabStop = false;
            this.grpBoxHazmana.Text = "הזמנה";
            // 
            // cmbMazmin
            // 
            this.cmbMazmin.FormattingEnabled = true;
            this.cmbMazmin.Location = new System.Drawing.Point(24, 73);
            this.cmbMazmin.Name = "cmbMazmin";
            this.cmbMazmin.Size = new System.Drawing.Size(99, 21);
            this.cmbMazmin.TabIndex = 18;
            // 
            // lblKod
            // 
            this.lblKod.Location = new System.Drawing.Point(46, 24);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(60, 13);
            this.lblKod.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbPirteiHazmanatLakoach
            // 
            this.cmbPirteiHazmanatLakoach.Enabled = false;
            this.cmbPirteiHazmanatLakoach.FormattingEnabled = true;
            this.cmbPirteiHazmanatLakoach.Location = new System.Drawing.Point(95, 84);
            this.cmbPirteiHazmanatLakoach.Name = "cmbPirteiHazmanatLakoach";
            this.cmbPirteiHazmanatLakoach.Size = new System.Drawing.Size(99, 21);
            this.cmbPirteiHazmanatLakoach.TabIndex = 19;
            this.cmbPirteiHazmanatLakoach.SelectedIndexChanged += new System.EventHandler(this.cmbPirteiHazmanatLakoach_SelectedIndexChanged);
            this.cmbPirteiHazmanatLakoach.SelectionChangeCommitted += new System.EventHandler(this.cmbPirteiHazmanatLakoach_SelectionChangeCommitted);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(12, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "יציאה";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(123, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(123, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "*";
            // 
            // frmHazmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 433);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbPirteiHazmanatLakoach);
            this.Controls.Add(this.grpBoxHazmana);
            this.Controls.Add(this.cmbHazmana);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHazmana";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "הזמנה";
            this.Load += new System.EventHandler(this.frmHazmana_Load);
            this.grpBoxHazmana.ResumeLayout(false);
            this.grpBoxHazmana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbHazmana;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox grpBoxHazmana;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbMazmin;
        private System.Windows.Forms.ComboBox cmbPirteiHazmanatLakoach;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}