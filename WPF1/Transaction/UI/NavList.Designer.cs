namespace WPF1
{
    partial class Form13
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
            this.navList = new System.Windows.Forms.DateTimePicker();
            this.nav = new System.Windows.Forms.Label();
            this.codeFundList = new System.Windows.Forms.TextBox();
            this.codeFund = new System.Windows.Forms.Label();
            this.compaList = new System.Windows.Forms.ComboBox();
            this.compa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navList
            // 
            this.navList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.navList.Location = new System.Drawing.Point(622, 35);
            this.navList.Name = "navList";
            this.navList.Size = new System.Drawing.Size(293, 22);
            this.navList.TabIndex = 32;
            // 
            // nav
            // 
            this.nav.AutoSize = true;
            this.nav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nav.Location = new System.Drawing.Point(497, 37);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(92, 20);
            this.nav.TabIndex = 31;
            this.nav.Text = "วันที่ NAV (*)";
            // 
            // codeFundList
            // 
            this.codeFundList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeFundList.Location = new System.Drawing.Point(138, 82);
            this.codeFundList.Name = "codeFundList";
            this.codeFundList.Size = new System.Drawing.Size(293, 22);
            this.codeFundList.TabIndex = 30;
            // 
            // codeFund
            // 
            this.codeFund.AutoSize = true;
            this.codeFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeFund.Location = new System.Drawing.Point(20, 85);
            this.codeFund.Name = "codeFund";
            this.codeFund.Size = new System.Drawing.Size(96, 20);
            this.codeFund.TabIndex = 29;
            this.codeFund.Text = "รหัสกองทุน (*)";
            // 
            // compaList
            // 
            this.compaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(138, 37);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(293, 24);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(20, 40);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(95, 20);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัทต้นสังกัด";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.navList);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.codeFundList);
            this.Controls.Add(this.compaList);
            this.Controls.Add(this.codeFund);
            this.Controls.Add(this.compa);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form13";
            this.Text = "NavList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label compa;
        private System.Windows.Forms.ComboBox compaList;
        private System.Windows.Forms.DateTimePicker navList;
        private System.Windows.Forms.Label nav;
        private System.Windows.Forms.TextBox codeFundList;
        private System.Windows.Forms.Label codeFund;
    }
}