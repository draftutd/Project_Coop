namespace WPF1.Company.UI
{
    partial class Branchlist
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
            this.statusList = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.compa = new System.Windows.Forms.Label();
            this.compaList = new System.Windows.Forms.ComboBox();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.Controls.Add(this.status);
            this.pnlData.TabIndex = 19;
            this.pnlData.Controls.SetChildIndex(this.status, 0);
            this.pnlData.Controls.SetChildIndex(this.compa, 0);
            this.pnlData.Controls.SetChildIndex(this.statusList, 0);
            this.pnlData.Controls.SetChildIndex(this.compaList, 0);
            // 
            // statusList
            // 
            this.statusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusList.Items.AddRange(new object[] {
            " Active",
            " Inactive"});
            this.statusList.Location = new System.Drawing.Point(161, 65);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(324, 24);
            this.statusList.TabIndex = 18;
            this.statusList.Text = "  Active";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.status.Location = new System.Drawing.Point(20, 65);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(84, 20);
            this.status.TabIndex = 17;
            this.status.Text = "สถานะข้อมูล";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(20, 25);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(95, 20);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัทต้นสังกัด";
            // 
            // compaList
            // 
            this.compaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(161, 25);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(324, 24);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // Branchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Name = "Branchlist";
            this.Text = "Branchlist";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label compa;
        private System.Windows.Forms.ComboBox compaList;
        //protected System.Windows.Forms.Panel pnlData;
    }
}