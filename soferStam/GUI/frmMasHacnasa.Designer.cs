namespace soferStam.GUI
{
    partial class frmMasHacnasa
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMounth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHacnasot = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblZover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHacnasot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "התראת הכנסה";
            // 
            // cmbMounth
            // 
            this.cmbMounth.FormattingEnabled = true;
            this.cmbMounth.Items.AddRange(new object[] {
            "ינואר",
            "פברואר",
            "מרץ",
            "אפריל",
            "מאי",
            "יוני",
            "יולי",
            "אוגוסט",
            "ספטמבר",
            "אוקטובר",
            "נובמבר",
            "דצמבר"});
            this.cmbMounth.Location = new System.Drawing.Point(58, 43);
            this.cmbMounth.Name = "cmbMounth";
            this.cmbMounth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMounth.Size = new System.Drawing.Size(160, 21);
            this.cmbMounth.TabIndex = 2;
            this.cmbMounth.SelectionChangeCommitted += new System.EventHandler(this.cmbMounth_SelectionChangeCommitted);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
            this.cmbYear.Location = new System.Drawing.Point(100, 43);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYear.Size = new System.Drawing.Size(117, 21);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.SelectionChangeCommitted += new System.EventHandler(this.cmbYear_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 46);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "בחר חודש:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 46);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "בחר שנה:";
            // 
            // dgvHacnasot
            // 
            this.dgvHacnasot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHacnasot.Location = new System.Drawing.Point(12, 70);
            this.dgvHacnasot.Name = "dgvHacnasot";
            this.dgvHacnasot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvHacnasot.Size = new System.Drawing.Size(265, 165);
            this.dgvHacnasot.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(12, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "יציאה";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblZover
            // 
            this.lblZover.AutoSize = true;
            this.lblZover.Location = new System.Drawing.Point(207, 250);
            this.lblZover.Name = "lblZover";
            this.lblZover.Size = new System.Drawing.Size(10, 13);
            this.lblZover.TabIndex = 21;
            this.lblZover.Text = " ";
            // 
            // frmMasHacnasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 290);
            this.Controls.Add(this.lblZover);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvHacnasot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMounth);
            this.Controls.Add(this.label1);
            this.Name = "frmMasHacnasa";
            this.Text = "frmMasHacnasa";
            this.Load += new System.EventHandler(this.frmMasHacnasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHacnasot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMounth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHacnasot;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblZover;

    }
}