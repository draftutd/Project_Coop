namespace WPF1.Transaction.UI
{
    partial class ReserveObject
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
            this.company = new System.Windows.Forms.Label();
            this.companyList = new System.Windows.Forms.ComboBox();
            this.transaction1 = new System.Windows.Forms.Label();
            this.transaction1List = new System.Windows.Forms.DateTimePicker();
            this.Transaction2 = new System.Windows.Forms.Label();
            this.Transaction2List = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.dateList = new System.Windows.Forms.DateTimePicker();
            this.extra = new System.Windows.Forms.Label();
            this.extraList = new System.Windows.Forms.ComboBox();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Controls.Add(this.extraList);
            this.pnlData.Controls.Add(this.Transaction2);
            this.pnlData.Controls.Add(this.extra);
            this.pnlData.Controls.Add(this.transaction1List);
            this.pnlData.Controls.Add(this.Transaction2List);
            this.pnlData.Controls.Add(this.dateList);
            this.pnlData.Controls.Add(this.transaction1);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.date);
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.company.Location = new System.Drawing.Point(17, 22);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(115, 20);
            this.company.TabIndex = 0;
            this.company.Text = "บริษัทต้นสังกัด (*)";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(220, 19);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(246, 21);
            this.companyList.TabIndex = 1;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // transaction1
            // 
            this.transaction1.AutoSize = true;
            this.transaction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction1.Location = new System.Drawing.Point(13, 61);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(198, 20);
            this.transaction1.TabIndex = 2;
            this.transaction1.Text = "รอบการทำรายการตั้งแต่วันที่ (*)";
            // 
            // transaction1List
            // 
            this.transaction1List.Location = new System.Drawing.Point(220, 59);
            this.transaction1List.Name = "transaction1List";
            this.transaction1List.Size = new System.Drawing.Size(246, 20);
            this.transaction1List.TabIndex = 3;
            // 
            // Transaction2
            // 
            this.Transaction2.AutoSize = true;
            this.Transaction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Transaction2.Location = new System.Drawing.Point(13, 99);
            this.Transaction2.Name = "Transaction2";
            this.Transaction2.Size = new System.Drawing.Size(180, 20);
            this.Transaction2.TabIndex = 4;
            this.Transaction2.Text = "รอบการทำรายการถึงวันที่ (*)";
            // 
            // Transaction2List
            // 
            this.Transaction2List.Location = new System.Drawing.Point(220, 97);
            this.Transaction2List.Name = "Transaction2List";
            this.Transaction2List.Size = new System.Drawing.Size(246, 20);
            this.Transaction2List.TabIndex = 5;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.date.Location = new System.Drawing.Point(498, 61);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(117, 20);
            this.date.TabIndex = 6;
            this.date.Text = "วันที่ทำรายการ (*)";
            // 
            // dateList
            // 
            this.dateList.Location = new System.Drawing.Point(659, 59);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(246, 20);
            this.dateList.TabIndex = 7;
            // 
            // extra
            // 
            this.extra.AutoSize = true;
            this.extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.extra.Location = new System.Drawing.Point(498, 95);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(125, 20);
            this.extra.TabIndex = 8;
            this.extra.Text = "รายการเพิ่มเติม (*)";
            // 
            // extraList
            // 
            this.extraList.FormattingEnabled = true;
            this.extraList.Items.AddRange(new object[] {
            " Normal",
            " Additional"});
            this.extraList.Location = new System.Drawing.Point(659, 95);
            this.extraList.Name = "extraList";
            this.extraList.Size = new System.Drawing.Size(246, 21);
            this.extraList.TabIndex = 9;
            this.extraList.Text = " Normal";
            // 
            // ReserveObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Name = "ReserveObject";
            this.Text = "ReserveObject";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label company;
        private System.Windows.Forms.ComboBox companyList;
        private System.Windows.Forms.Label transaction1;
        private System.Windows.Forms.DateTimePicker transaction1List;
        private System.Windows.Forms.Label Transaction2;
        private System.Windows.Forms.DateTimePicker Transaction2List;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateList;
        private System.Windows.Forms.Label extra;
        private System.Windows.Forms.ComboBox extraList;        
    }
}