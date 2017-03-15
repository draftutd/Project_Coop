namespace WPF1
{
    partial class Form16
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
            this.extraList = new System.Windows.Forms.ComboBox();
            this.extra = new System.Windows.Forms.Label();
            this.dateList = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.Transaction2List = new System.Windows.Forms.DateTimePicker();
            this.Transaction2 = new System.Windows.Forms.Label();
            this.transaction1List = new System.Windows.Forms.DateTimePicker();
            this.transaction1 = new System.Windows.Forms.Label();
            this.companyList = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.Label();
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
            this.pnlData.Controls.Add(this.extraList);
            this.pnlData.Controls.Add(this.extra);
            this.pnlData.Controls.Add(this.dateList);
            this.pnlData.Controls.Add(this.date);
            this.pnlData.Controls.Add(this.Transaction2List);
            this.pnlData.Controls.Add(this.Transaction2);
            this.pnlData.Controls.Add(this.transaction1List);
            this.pnlData.Controls.Add(this.transaction1);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Location = new System.Drawing.Point(17, 69);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(504, 192);
            this.pnlData.TabIndex = 1;
            // 
            // extraList
            // 
            this.extraList.FormattingEnabled = true;
            this.extraList.Items.AddRange(new object[] {
            " Normal",
            " Additional"});
            this.extraList.Location = new System.Drawing.Point(228, 136);
            this.extraList.Name = "extraList";
            this.extraList.Size = new System.Drawing.Size(246, 21);
            this.extraList.TabIndex = 9;
            this.extraList.Text = " Normal";
            // 
            // extra
            // 
            this.extra.AutoSize = true;
            this.extra.Location = new System.Drawing.Point(31, 139);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(95, 13);
            this.extra.TabIndex = 8;
            this.extra.Text = "รายการเพิ่มเติม (*)";
            // 
            // dateList
            // 
            this.dateList.Location = new System.Drawing.Point(228, 107);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(246, 20);
            this.dateList.TabIndex = 7;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(31, 113);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(89, 13);
            this.date.TabIndex = 6;
            this.date.Text = "วันที่ทำรายการ (*)";
            // 
            // Transaction2List
            // 
            this.Transaction2List.Location = new System.Drawing.Point(228, 81);
            this.Transaction2List.Name = "Transaction2List";
            this.Transaction2List.Size = new System.Drawing.Size(246, 20);
            this.Transaction2List.TabIndex = 5;
            // 
            // Transaction2
            // 
            this.Transaction2.AutoSize = true;
            this.Transaction2.Location = new System.Drawing.Point(31, 87);
            this.Transaction2.Name = "Transaction2";
            this.Transaction2.Size = new System.Drawing.Size(138, 13);
            this.Transaction2.TabIndex = 4;
            this.Transaction2.Text = "รอบการทำรายการถึงวันที่ (*)";
            // 
            // transaction1List
            // 
            this.transaction1List.Location = new System.Drawing.Point(228, 54);
            this.transaction1List.Name = "transaction1List";
            this.transaction1List.Size = new System.Drawing.Size(246, 20);
            this.transaction1List.TabIndex = 3;
            // 
            // transaction1
            // 
            this.transaction1.AutoSize = true;
            this.transaction1.Location = new System.Drawing.Point(31, 60);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(153, 13);
            this.transaction1.TabIndex = 2;
            this.transaction1.Text = "รอบการทำรายการตั้งแต่วันที่ (*)";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(228, 27);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(246, 21);
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
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 285);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.Name = "Form16";
            this.Text = "Form16";
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
        private System.Windows.Forms.Label transaction1;
        private System.Windows.Forms.Label Transaction2;
        private System.Windows.Forms.DateTimePicker transaction1List;
        private System.Windows.Forms.ComboBox extraList;
        private System.Windows.Forms.Label extra;
        private System.Windows.Forms.DateTimePicker dateList;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker Transaction2List;
    }
}