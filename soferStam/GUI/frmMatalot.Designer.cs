namespace soferStam.GUI
{
    partial class frmMatalot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatalot));
            this.dvgMatalot = new System.Windows.Forms.DataGridView();
            this.lblTytle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatalot)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgMatalot
            // 
            this.dvgMatalot.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgMatalot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMatalot.Location = new System.Drawing.Point(17, 55);
            this.dvgMatalot.Name = "dvgMatalot";
            this.dvgMatalot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dvgMatalot.Size = new System.Drawing.Size(324, 272);
            this.dvgMatalot.TabIndex = 0;
            // 
            // lblTytle
            // 
            this.lblTytle.AutoSize = true;
            this.lblTytle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTytle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTytle.Location = new System.Drawing.Point(73, 21);
            this.lblTytle.Name = "lblTytle";
            this.lblTytle.Size = new System.Drawing.Size(211, 29);
            this.lblTytle.TabIndex = 1;
            this.lblTytle.Text = "המטלות שלא בוצעו";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(17, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "יציאה";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMatalot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 388);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTytle);
            this.Controls.Add(this.dvgMatalot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMatalot";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "מטלות";
            this.Load += new System.EventHandler(this.frmMatalot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatalot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgMatalot;
        private System.Windows.Forms.Label lblTytle;
        private System.Windows.Forms.Button btnClose;
    }
}