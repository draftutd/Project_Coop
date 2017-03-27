namespace WPF1.Fund.UI
{
    partial class FundObject
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
            this.codetransferList = new System.Windows.Forms.ComboBox();
            this.codetransfer = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateOff = new System.Windows.Forms.Label();
            this.fundNameList = new System.Windows.Forms.TextBox();
            this.fundName = new System.Windows.Forms.Label();
            this.fundCodeList = new System.Windows.Forms.TextBox();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.statusemp = new System.Windows.Forms.Label();
            this.fundCode = new System.Windows.Forms.Label();
            this.companyList = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // codetransferList
            // 
            this.codetransferList.FormattingEnabled = true;
            this.codetransferList.Location = new System.Drawing.Point(653, 64);
            this.codetransferList.Name = "codetransferList";
            this.codetransferList.Size = new System.Drawing.Size(259, 21);
            this.codetransferList.TabIndex = 15;
            // 
            // codetransfer
            // 
            this.codetransfer.AutoSize = true;
            this.codetransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codetransfer.Location = new System.Drawing.Point(488, 66);
            this.codetransfer.Name = "codetransfer";
            this.codetransfer.Size = new System.Drawing.Size(157, 20);
            this.codetransfer.TabIndex = 14;
            this.codetransfer.Text = "รหัสกองทุนที่ต้องการโอน";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(653, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateOff
            // 
            this.dateOff.AutoSize = true;
            this.dateOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateOff.Location = new System.Drawing.Point(488, 26);
            this.dateOff.Name = "dateOff";
            this.dateOff.Size = new System.Drawing.Size(86, 20);
            this.dateOff.TabIndex = 12;
            this.dateOff.Text = "วันปิดกองทุน";
            // 
            // fundNameList
            // 
            this.fundNameList.Location = new System.Drawing.Point(189, 105);
            this.fundNameList.Name = "fundNameList";
            this.fundNameList.Size = new System.Drawing.Size(260, 20);
            this.fundNameList.TabIndex = 11;
            // 
            // fundName
            // 
            this.fundName.AutoSize = true;
            this.fundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundName.Location = new System.Drawing.Point(24, 105);
            this.fundName.Name = "fundName";
            this.fundName.Size = new System.Drawing.Size(89, 20);
            this.fundName.TabIndex = 10;
            this.fundName.Text = "ชื่อกองทุน (*)";
            // 
            // fundCodeList
            // 
            this.fundCodeList.Location = new System.Drawing.Point(189, 66);
            this.fundCodeList.Name = "fundCodeList";
            this.fundCodeList.Size = new System.Drawing.Size(260, 20);
            this.fundCodeList.TabIndex = 9;
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " Active",
            " Inactive"});
            this.statusList.Location = new System.Drawing.Point(652, 105);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(260, 21);
            this.statusList.TabIndex = 8;
            this.statusList.Text = " Active";
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusemp.Location = new System.Drawing.Point(490, 105);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(84, 20);
            this.statusemp.TabIndex = 7;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // fundCode
            // 
            this.fundCode.AutoSize = true;
            this.fundCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundCode.Location = new System.Drawing.Point(24, 66);
            this.fundCode.Name = "fundCode";
            this.fundCode.Size = new System.Drawing.Size(96, 20);
            this.fundCode.TabIndex = 5;
            this.fundCode.Text = "รหัสกองทุน (*)";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(189, 26);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(260, 21);
            this.companyList.TabIndex = 1;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.company.Location = new System.Drawing.Point(24, 26);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(115, 20);
            this.company.TabIndex = 0;
            this.company.Text = "บริษัทต้นสังกัด (*)";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Controls.Add(this.codetransferList);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.codetransfer);
            this.pnlData.Controls.Add(this.fundCodeList);
            this.pnlData.Controls.Add(this.dateTimePicker1);
            this.pnlData.Controls.Add(this.statusemp);
            this.pnlData.Controls.Add(this.fundName);
            this.pnlData.Controls.Add(this.dateOff);
            this.pnlData.Controls.Add(this.fundCode);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.fundNameList);
            // 
            // FundObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlData);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FundObject";
            this.Text = "FundObject";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.ComboBox companyList;
        private System.Windows.Forms.Label fundCode;
        private System.Windows.Forms.Label statusemp;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.TextBox fundCodeList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateOff;
        private System.Windows.Forms.TextBox fundNameList;
        private System.Windows.Forms.Label fundName;
        private System.Windows.Forms.ComboBox codetransferList;
        private System.Windows.Forms.Label codetransfer;
    }
}