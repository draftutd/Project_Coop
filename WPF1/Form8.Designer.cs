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
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Location = new System.Drawing.Point(35, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btncancel.Location = new System.Drawing.Point(125, 39);
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
            this.pnlData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pnlData.Location = new System.Drawing.Point(12, 92);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(960, 173);
            this.pnlData.TabIndex = 1;
            // 
            // codetransferList
            // 
            this.codetransferList.FormattingEnabled = true;
            this.codetransferList.Location = new System.Drawing.Point(660, 68);
            this.codetransferList.Name = "codetransferList";
            this.codetransferList.Size = new System.Drawing.Size(259, 24);
            this.codetransferList.TabIndex = 15;
            // 
            // codetransfer
            // 
            this.codetransfer.AutoSize = true;
            this.codetransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codetransfer.Location = new System.Drawing.Point(495, 70);
            this.codetransfer.Name = "codetransfer";
            this.codetransfer.Size = new System.Drawing.Size(157, 20);
            this.codetransfer.TabIndex = 14;
            this.codetransfer.Text = "รหัสกองทุนที่ต้องการโอน";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(660, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateOff
            // 
            this.dateOff.AutoSize = true;
            this.dateOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateOff.Location = new System.Drawing.Point(495, 30);
            this.dateOff.Name = "dateOff";
            this.dateOff.Size = new System.Drawing.Size(86, 20);
            this.dateOff.TabIndex = 12;
            this.dateOff.Text = "วันปิดกองทุน";
            // 
            // fundNameList
            // 
            this.fundNameList.Location = new System.Drawing.Point(196, 109);
            this.fundNameList.Name = "fundNameList";
            this.fundNameList.Size = new System.Drawing.Size(260, 22);
            this.fundNameList.TabIndex = 11;
            // 
            // fundName
            // 
            this.fundName.AutoSize = true;
            this.fundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundName.Location = new System.Drawing.Point(31, 109);
            this.fundName.Name = "fundName";
            this.fundName.Size = new System.Drawing.Size(89, 20);
            this.fundName.TabIndex = 10;
            this.fundName.Text = "ชื่อกองทุน (*)";
            // 
            // fundCodeList
            // 
            this.fundCodeList.Location = new System.Drawing.Point(196, 70);
            this.fundCodeList.Name = "fundCodeList";
            this.fundCodeList.Size = new System.Drawing.Size(260, 22);
            this.fundCodeList.TabIndex = 9;
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " Active",
            " Inactive"});
            this.statusList.Location = new System.Drawing.Point(659, 109);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(260, 24);
            this.statusList.TabIndex = 8;
            this.statusList.Text = " Active";
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusemp.Location = new System.Drawing.Point(497, 109);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(84, 20);
            this.statusemp.TabIndex = 7;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // fundCode
            // 
            this.fundCode.AutoSize = true;
            this.fundCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundCode.Location = new System.Drawing.Point(31, 70);
            this.fundCode.Name = "fundCode";
            this.fundCode.Size = new System.Drawing.Size(96, 20);
            this.fundCode.TabIndex = 5;
            this.fundCode.Text = "รหัสกองทุน (*)";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(196, 30);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(260, 24);
            this.companyList.TabIndex = 1;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.company.Location = new System.Drawing.Point(31, 30);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(115, 20);
            this.company.TabIndex = 0;
            this.company.Text = "บริษัทต้นสังกัด (*)";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
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