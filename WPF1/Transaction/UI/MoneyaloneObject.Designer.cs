namespace WPF1.Transaction.UI
{
    partial class MoneyaloneObject
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
            this.dateList = new System.Windows.Forms.DateTimePicker();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.Label();
            this.transaction2List = new System.Windows.Forms.DateTimePicker();
            this.transaction2 = new System.Windows.Forms.Label();
            this.transaction1List = new System.Windows.Forms.DateTimePicker();
            this.transaction1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.companyList = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Controls.Add(this.dateList);
            this.pnlData.Controls.Add(this.transaction1List);
            this.pnlData.Controls.Add(this.categoryList);
            this.pnlData.Controls.Add(this.transaction1);
            this.pnlData.Controls.Add(this.transaction2);
            this.pnlData.Controls.Add(this.date);
            this.pnlData.Controls.Add(this.category);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.transaction2List);
            // 
            // dateList
            // 
            this.dateList.Location = new System.Drawing.Point(155, 105);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(246, 20);
            this.dateList.TabIndex = 11;
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Items.AddRange(new object[] {
            " Buy",
            " Sell"});
            this.categoryList.Location = new System.Drawing.Point(155, 63);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(246, 21);
            this.categoryList.TabIndex = 10;
            this.categoryList.Text = " Buy";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.date.Location = new System.Drawing.Point(18, 107);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(117, 20);
            this.date.TabIndex = 8;
            this.date.Text = "วันที่ทำรายการ (*)";
            // 
            // transaction2List
            // 
            this.transaction2List.Location = new System.Drawing.Point(660, 65);
            this.transaction2List.Name = "transaction2List";
            this.transaction2List.Size = new System.Drawing.Size(246, 20);
            this.transaction2List.TabIndex = 7;
            // 
            // transaction2
            // 
            this.transaction2.AutoSize = true;
            this.transaction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction2.Location = new System.Drawing.Point(463, 67);
            this.transaction2.Name = "transaction2";
            this.transaction2.Size = new System.Drawing.Size(163, 20);
            this.transaction2.TabIndex = 6;
            this.transaction2.Text = "รอบการจ่ายเงินถึงวันที่ (*)";
            // 
            // transaction1List
            // 
            this.transaction1List.Location = new System.Drawing.Point(660, 24);
            this.transaction1List.Name = "transaction1List";
            this.transaction1List.Size = new System.Drawing.Size(246, 20);
            this.transaction1List.TabIndex = 5;
            // 
            // transaction1
            // 
            this.transaction1.AutoSize = true;
            this.transaction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction1.Location = new System.Drawing.Point(463, 26);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(181, 20);
            this.transaction1.TabIndex = 4;
            this.transaction1.Text = "รอบการจ่ายเงินตั้งแต่วันที่ (*)";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.category.Location = new System.Drawing.Point(18, 63);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(102, 20);
            this.category.TabIndex = 2;
            this.category.Text = "ประเภทรายการ";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(155, 22);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(246, 21);
            this.companyList.TabIndex = 1;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.company.Location = new System.Drawing.Point(18, 26);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(115, 20);
            this.company.TabIndex = 0;
            this.company.Text = "บริษัทต้นสังกัด (*)";
            // 
            // MoneyaloneObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Name = "MoneyaloneObject";
            this.Text = "MoneyaloneObject";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.ComboBox companyList;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label transaction1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker transaction2List;
        private System.Windows.Forms.Label transaction2;
        private System.Windows.Forms.DateTimePicker transaction1List;
        private System.Windows.Forms.DateTimePicker dateList;
        private System.Windows.Forms.ComboBox categoryList;
    }
}