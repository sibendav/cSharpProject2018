namespace soferStam.GUI
{
    partial class frmHespekiHazmana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHespekiHazmana));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKodHazmana = new System.Windows.Forms.ComboBox();
            this.dgvHespekiHazmana = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZover = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHefres = new System.Windows.Forms.Label();
            this.btnAddHespek = new System.Windows.Forms.Button();
            this.proBTahalichHazmana = new System.Windows.Forms.ProgressBar();
            this.lblHoursRequiered = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHariga = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHespekiHazmana)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "הספקי הזמנה מסוימת";
            // 
            // cmbKodHazmana
            // 
            this.cmbKodHazmana.FormattingEnabled = true;
            this.cmbKodHazmana.Location = new System.Drawing.Point(23, 38);
            this.cmbKodHazmana.Name = "cmbKodHazmana";
            this.cmbKodHazmana.Size = new System.Drawing.Size(361, 21);
            this.cmbKodHazmana.TabIndex = 1;
            this.cmbKodHazmana.SelectionChangeCommitted += new System.EventHandler(this.cmbKodHazmana_SelectionChangeCommitted);
            // 
            // dgvHespekiHazmana
            // 
            this.dgvHespekiHazmana.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvHespekiHazmana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHespekiHazmana.Location = new System.Drawing.Point(12, 67);
            this.dgvHespekiHazmana.Name = "dgvHespekiHazmana";
            this.dgvHespekiHazmana.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvHespekiHazmana.Size = new System.Drawing.Size(395, 143);
            this.dgvHespekiHazmana.TabIndex = 2;
            this.dgvHespekiHazmana.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHespekiHazmana_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "סה\"כ השעות שנעשו:";
            // 
            // lblZover
            // 
            this.lblZover.AutoSize = true;
            this.lblZover.Location = new System.Drawing.Point(164, 244);
            this.lblZover.Name = "lblZover";
            this.lblZover.Size = new System.Drawing.Size(10, 13);
            this.lblZover.TabIndex = 4;
            this.lblZover.Text = " ";
            this.lblZover.Click += new System.EventHandler(this.lblZover_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "מספר השעות שנותרו לעבודה:";
            // 
            // lblHefres
            // 
            this.lblHefres.AutoSize = true;
            this.lblHefres.Location = new System.Drawing.Point(167, 265);
            this.lblHefres.Name = "lblHefres";
            this.lblHefres.Size = new System.Drawing.Size(0, 13);
            this.lblHefres.TabIndex = 6;
            // 
            // btnAddHespek
            // 
            this.btnAddHespek.Location = new System.Drawing.Point(23, 244);
            this.btnAddHespek.Name = "btnAddHespek";
            this.btnAddHespek.Size = new System.Drawing.Size(89, 41);
            this.btnAddHespek.TabIndex = 7;
            this.btnAddHespek.Text = "הוסף הספק";
            this.btnAddHespek.UseVisualStyleBackColor = true;
            this.btnAddHespek.Click += new System.EventHandler(this.btnAddHespek_Click);
            // 
            // proBTahalichHazmana
            // 
            this.proBTahalichHazmana.Location = new System.Drawing.Point(149, 310);
            this.proBTahalichHazmana.Name = "proBTahalichHazmana";
            this.proBTahalichHazmana.Size = new System.Drawing.Size(225, 36);
            this.proBTahalichHazmana.TabIndex = 8;
            // 
            // lblHoursRequiered
            // 
            this.lblHoursRequiered.AutoSize = true;
            this.lblHoursRequiered.Location = new System.Drawing.Point(163, 223);
            this.lblHoursRequiered.Name = "lblHoursRequiered";
            this.lblHoursRequiered.Size = new System.Drawing.Size(10, 13);
            this.lblHoursRequiered.TabIndex = 9;
            this.lblHoursRequiered.Text = " ";
            this.lblHoursRequiered.Click += new System.EventHandler(this.lblHoursRequiered_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 223);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "מספר שעות הכרחי:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(23, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "יציאה";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHariga
            // 
            this.lblHariga.AutoSize = true;
            this.lblHariga.Location = new System.Drawing.Point(166, 284);
            this.lblHariga.Name = "lblHariga";
            this.lblHariga.Size = new System.Drawing.Size(0, 13);
            this.lblHariga.TabIndex = 21;
            this.lblHariga.Visible = false;
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Location = new System.Drawing.Point(231, 284);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(161, 13);
            this.LB.TabIndex = 20;
            this.LB.Text = "מספר השעות שחרגו מהעבודה:";
            this.LB.Visible = false;
            // 
            // frmHespekiHazmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 379);
            this.Controls.Add(this.lblHariga);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHoursRequiered);
            this.Controls.Add(this.proBTahalichHazmana);
            this.Controls.Add(this.btnAddHespek);
            this.Controls.Add(this.lblHefres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblZover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHespekiHazmana);
            this.Controls.Add(this.cmbKodHazmana);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHespekiHazmana";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "רשימת הספקי הזמנה";
            this.Load += new System.EventHandler(this.frmHespekiHazmana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHespekiHazmana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKodHazmana;
        private System.Windows.Forms.DataGridView dgvHespekiHazmana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHefres;
        private System.Windows.Forms.Button btnAddHespek;
        private System.Windows.Forms.ProgressBar proBTahalichHazmana;
        private System.Windows.Forms.Label lblHoursRequiered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHariga;
        private System.Windows.Forms.Label LB;
    }
}