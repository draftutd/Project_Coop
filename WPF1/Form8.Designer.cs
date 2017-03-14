namespace WPF1
{
    partial class Form8
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.fundCodeList = new System.Windows.Forms.TextBox();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.statusemp = new System.Windows.Forms.Label();
            this.fundCode = new System.Windows.Forms.Label();
            this.companyList = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.Label();
            this.fundName = new System.Windows.Forms.Label();
            this.fundNameList = new System.Windows.Forms.TextBox();
            this.dateOff = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.codetransfer = new System.Windows.Forms.Label();
            this.codetransferList = new System.Windows.Forms.ComboBox();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(125, 22);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 33);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "ยกเลิก";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.codetransferList);
            this.pnlData.Controls.Add(this.codetransfer);
            this.pnlData.Controls.Add(this.dateTimePicker1);
            this.pnlData.Controls.Add(this.dateOff);
            this.pnlData.Controls.Add(this.fundNameList);
            this.pnlData.Controls.Add(this.fundName);
            this.pnlData.Controls.Add(this.fundCodeList);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.statusemp);
            this.pnlData.Controls.Add(this.fundCode);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Location = new System.Drawing.Point(17, 69);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(485, 239);
            this.pnlData.TabIndex = 1;
            // 
            // fundCodeList
            // 
            this.fundCodeList.Location = new System.Drawing.Point(174, 62);
            this.fundCodeList.Name = "fundCodeList";
            this.fundCodeList.Size = new System.Drawing.Size(285, 20);
            this.fundCodeList.TabIndex = 9;
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(174, 195);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(285, 21);
            this.statusList.TabIndex = 8;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Location = new System.Drawing.Point(31, 198);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(63, 13);
            this.statusemp.TabIndex = 7;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // fundCode
            // 
            this.fundCode.AutoSize = true;
            this.fundCode.Location = new System.Drawing.Point(31, 65);
            this.fundCode.Name = "fundCode";
            this.fundCode.Size = new System.Drawing.Size(72, 13);
            this.fundCode.TabIndex = 5;
            this.fundCode.Text = "รหัสกองทุน (*)";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(174, 27);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(285, 21);
            this.companyList.TabIndex = 1;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(31, 30);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(88, 13);
            this.company.TabIndex = 0;
            this.company.Text = "บริษัทต้นสังกัด (*)";
            // 
            // fundName
            // 
            this.fundName.AutoSize = true;
            this.fundName.Location = new System.Drawing.Point(31, 98);
            this.fundName.Name = "fundName";
            this.fundName.Size = new System.Drawing.Size(66, 13);
            this.fundName.TabIndex = 10;
            this.fundName.Text = "ชื่อกองทุน (*)";
            // 
            // fundNameList
            // 
            this.fundNameList.Location = new System.Drawing.Point(174, 95);
            this.fundNameList.Name = "fundNameList";
            this.fundNameList.Size = new System.Drawing.Size(285, 20);
            this.fundNameList.TabIndex = 11;
            // 
            // dateOff
            // 
            this.dateOff.AutoSize = true;
            this.dateOff.Location = new System.Drawing.Point(31, 132);
            this.dateOff.Name = "dateOff";
            this.dateOff.Size = new System.Drawing.Size(68, 13);
            this.dateOff.TabIndex = 12;
            this.dateOff.Text = "วันปิดกองทุน";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // codetransfer
            // 
            this.codetransfer.AutoSize = true;
            this.codetransfer.Location = new System.Drawing.Point(31, 162);
            this.codetransfer.Name = "codetransfer";
            this.codetransfer.Size = new System.Drawing.Size(121, 13);
            this.codetransfer.TabIndex = 14;
            this.codetransfer.Text = "รหัสกองทุนที่ต้องการโอน";
            // 
            // codetransferList
            // 
            this.codetransferList.FormattingEnabled = true;
            this.codetransferList.Location = new System.Drawing.Point(174, 159);
            this.codetransferList.Name = "codetransferList";
            this.codetransferList.Size = new System.Drawing.Size(284, 21);
            this.codetransferList.TabIndex = 15;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 327);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.Name = "Form8";
            this.Text = "Form8";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Panel pnlData;
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