namespace soferStam.GUI
{
    partial class kabala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kabala));
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblDatePrint = new System.Windows.Forms.Label();
            this.lblTimePrint = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblNumHazmana = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.printButtom = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Miriam Transparent", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "קבלה";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(79, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(151, 39);
            this.label27.TabIndex = 26;
            this.label27.Text = "מכון סופר סת\"ם\r\nהרצל 17 נס-ציונה\r\nלפרטים והזמנה: 0504158585\r\n";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatePrint
            // 
            this.lblDatePrint.AutoSize = true;
            this.lblDatePrint.Location = new System.Drawing.Point(49, 7);
            this.lblDatePrint.Name = "lblDatePrint";
            this.lblDatePrint.Size = new System.Drawing.Size(63, 13);
            this.lblDatePrint.TabIndex = 27;
            this.lblDatePrint.Text = "<DatePrint>";
            // 
            // lblTimePrint
            // 
            this.lblTimePrint.AutoSize = true;
            this.lblTimePrint.Location = new System.Drawing.Point(114, 7);
            this.lblTimePrint.Name = "lblTimePrint";
            this.lblTimePrint.Size = new System.Drawing.Size(63, 13);
            this.lblTimePrint.TabIndex = 28;
            this.lblTimePrint.Text = "<TimePrint>";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(162, 110);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 13);
            this.label30.TabIndex = 29;
            this.label30.Text = "הזמנה מספר:";
            // 
            // lblNumHazmana
            // 
            this.lblNumHazmana.AutoSize = true;
            this.lblNumHazmana.Location = new System.Drawing.Point(74, 109);
            this.lblNumHazmana.Name = "lblNumHazmana";
            this.lblNumHazmana.Size = new System.Drawing.Size(86, 13);
            this.lblNumHazmana.TabIndex = 30;
            this.lblNumHazmana.Text = "<NumHazmana>";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(134, 437);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(78, 13);
            this.label39.TabIndex = 38;
            this.label39.Text = "לתשלום סה\"כ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "------------------------------------------------------------\r\n";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(88, 437);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(40, 13);
            this.lblSum.TabIndex = 40;
            this.lblSum.Text = "<Sum>";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(12, 468);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "יציאה";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv.Location = new System.Drawing.Point(12, 126);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 35;
            this.dgv.Size = new System.Drawing.Size(266, 295);
            this.dgv.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "ש\"ח";
            // 
            // printButtom
            // 
            this.printButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.printButtom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.printButtom.Location = new System.Drawing.Point(79, 468);
            this.printButtom.Name = "printButtom";
            this.printButtom.Size = new System.Drawing.Size(57, 28);
            this.printButtom.TabIndex = 44;
            this.printButtom.Text = "הדפסה";
            this.printButtom.UseVisualStyleBackColor = true;
            this.printButtom.Click += new System.EventHandler(this.printButtom_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // kabala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 508);
            this.Controls.Add(this.printButtom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.lblNumHazmana);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lblTimePrint);
            this.Controls.Add(this.lblDatePrint);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kabala";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "קבלה";
            this.Load += new System.EventHandler(this.kabala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblDatePrint;
        private System.Windows.Forms.Label lblTimePrint;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblNumHazmana;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button printButtom;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}