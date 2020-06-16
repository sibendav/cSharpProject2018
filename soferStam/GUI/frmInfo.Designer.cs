namespace soferStam.GUI
{
    partial class frmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMazmin = new System.Windows.Forms.Button();
            this.btnHazmana = new System.Windows.Forms.Button();
            this.btnPratim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "תהליך הזמנה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMazmin
            // 
            this.btnMazmin.Location = new System.Drawing.Point(65, 56);
            this.btnMazmin.Name = "btnMazmin";
            this.btnMazmin.Size = new System.Drawing.Size(169, 37);
            this.btnMazmin.TabIndex = 1;
            this.btnMazmin.Text = "הוסף לקוח למאגר";
            this.btnMazmin.UseVisualStyleBackColor = true;
            this.btnMazmin.Click += new System.EventHandler(this.btnMazmin_Click);
            // 
            // btnHazmana
            // 
            this.btnHazmana.Location = new System.Drawing.Point(65, 88);
            this.btnHazmana.Name = "btnHazmana";
            this.btnHazmana.Size = new System.Drawing.Size(169, 34);
            this.btnHazmana.TabIndex = 2;
            this.btnHazmana.Text = "פתח הזמנה חדשה";
            this.btnHazmana.UseVisualStyleBackColor = true;
            this.btnHazmana.Click += new System.EventHandler(this.btnHazmana_Click);
            // 
            // btnPratim
            // 
            this.btnPratim.Location = new System.Drawing.Point(65, 118);
            this.btnPratim.Name = "btnPratim";
            this.btnPratim.Size = new System.Drawing.Size(169, 33);
            this.btnPratim.TabIndex = 3;
            this.btnPratim.Text = "הוספת פירטי הזמנה";
            this.btnPratim.UseVisualStyleBackColor = true;
            this.btnPratim.Click += new System.EventHandler(this.btnPratim_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(31, 172);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(239, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "שים לב כי מלאת אחר כל השלבים\r\n\r\nבהצלחה!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(240, 75);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "1.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(240, 104);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "2.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(240, 133);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "3.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "בס\"ד";
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPratim);
            this.Controls.Add(this.btnHazmana);
            this.Controls.Add(this.btnMazmin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "תהליך הזמנה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMazmin;
        private System.Windows.Forms.Button btnHazmana;
        private System.Windows.Forms.Button btnPratim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}