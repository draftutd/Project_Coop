namespace WPF1.Transaction.UI
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
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.navList);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.Controls.Add(this.nav);
            this.pnlData.Controls.Add(this.codeFund);
            this.pnlData.Controls.Add(this.codeFundList);
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.TabIndex = 33;
            this.pnlData.Controls.SetChildIndex(this.compaList, 0);
            this.pnlData.Controls.SetChildIndex(this.codeFundList, 0);
            this.pnlData.Controls.SetChildIndex(this.codeFund, 0);
            this.pnlData.Controls.SetChildIndex(this.nav, 0);
            this.pnlData.Controls.SetChildIndex(this.compa, 0);
            this.pnlData.Controls.SetChildIndex(this.navList, 0);
            // 
            // navList
            // 
            this.navList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.navList.Location = new System.Drawing.Point(618, 20);
            this.navList.Name = "navList";
            this.navList.Size = new System.Drawing.Size(293, 22);
            this.navList.TabIndex = 32;
            // 
            // nav
            // 
            this.nav.AutoSize = true;
            this.nav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nav.Location = new System.Drawing.Point(494, 22);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(92, 20);
            this.nav.TabIndex = 31;
            this.nav.Text = "วันที่ NAV (*)";
            // 
            // codeFundList
            // 
            this.codeFundList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeFundList.Location = new System.Drawing.Point(134, 64);
            this.codeFundList.Name = "codeFundList";
            this.codeFundList.Size = new System.Drawing.Size(293, 22);
            this.codeFundList.TabIndex = 30;
            // 
            // codeFund
            // 
            this.codeFund.AutoSize = true;
            this.codeFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeFund.Location = new System.Drawing.Point(16, 67);
            this.codeFund.Name = "codeFund";
            this.codeFund.Size = new System.Drawing.Size(96, 20);
            this.codeFund.TabIndex = 29;
            this.codeFund.Text = "รหัสกองทุน (*)";
            // 
            // compaList
            // 
            this.compaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(134, 19);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(293, 24);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(16, 22);
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
            this.Name = "Form13";
            this.Text = "NavList";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

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