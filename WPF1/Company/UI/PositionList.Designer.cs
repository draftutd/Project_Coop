namespace WPF1
{
    partial class PositionList
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
            this.compaList = new System.Windows.Forms.ComboBox();
            this.compa = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // compaList
            // 
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(167, 24);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(324, 21);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(18, 24);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(95, 20);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัทต้นสังกัด";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.status.Location = new System.Drawing.Point(18, 64);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(84, 20);
            this.status.TabIndex = 17;
            this.status.Text = "สถานะข้อมูล";
            // 
            // statusList
            // 
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(167, 64);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(324, 21);
            this.statusList.TabIndex = 18;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // PositionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.compaList);
            this.Controls.Add(this.compa);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusList);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "PositionList";
            this.Text = "PositionList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label compa;
        private System.Windows.Forms.ComboBox compaList;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox statusList;
    }
}