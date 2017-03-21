namespace WPF1
{
    partial class MoneygroupList
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
            this.fundList = new System.Windows.Forms.ComboBox();
            this.fund = new System.Windows.Forms.Label();
            this.codeEmpList = new System.Windows.Forms.TextBox();
            this.codeEmp = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // fundList
            // 
            this.fundList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundList.FormattingEnabled = true;
            this.fundList.Location = new System.Drawing.Point(160, 98);
            this.fundList.Name = "fundList";
            this.fundList.Size = new System.Drawing.Size(246, 24);
            this.fundList.TabIndex = 35;
            this.fundList.Text = "ระบุเลือกกองทุน";
            // 
            // fund
            // 
            this.fund.AutoSize = true;
            this.fund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fund.Location = new System.Drawing.Point(26, 98);
            this.fund.Name = "fund";
            this.fund.Size = new System.Drawing.Size(52, 20);
            this.fund.TabIndex = 34;
            this.fund.Text = "กองทุน";
            // 
            // codeEmpList
            // 
            this.codeEmpList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeEmpList.Location = new System.Drawing.Point(160, 60);
            this.codeEmpList.Name = "codeEmpList";
            this.codeEmpList.Size = new System.Drawing.Size(246, 22);
            this.codeEmpList.TabIndex = 33;
            // 
            // codeEmp
            // 
            this.codeEmp.AutoSize = true;
            this.codeEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeEmp.Location = new System.Drawing.Point(26, 60);
            this.codeEmp.Name = "codeEmp";
            this.codeEmp.Size = new System.Drawing.Size(84, 20);
            this.codeEmp.TabIndex = 32;
            this.codeEmp.Text = "รหัสพนักงาน";
            // 
            // dateList
            // 
            this.dateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateList.Location = new System.Drawing.Point(693, 100);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(246, 22);
            this.dateList.TabIndex = 31;
            // 
            // categoryList
            // 
            this.categoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Items.AddRange(new object[] {
            " Buy",
            " Sell",
            " Transfer"});
            this.categoryList.Location = new System.Drawing.Point(160, 140);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(246, 24);
            this.categoryList.TabIndex = 30;
            this.categoryList.Text = " Buy";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.date.Location = new System.Drawing.Point(474, 98);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(117, 20);
            this.date.TabIndex = 29;
            this.date.Text = "วันที่ทำรายการ (*)";
            // 
            // transaction2List
            // 
            this.transaction2List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction2List.Location = new System.Drawing.Point(693, 60);
            this.transaction2List.Name = "transaction2List";
            this.transaction2List.Size = new System.Drawing.Size(246, 22);
            this.transaction2List.TabIndex = 28;
            // 
            // transaction2
            // 
            this.transaction2.AutoSize = true;
            this.transaction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction2.Location = new System.Drawing.Point(474, 60);
            this.transaction2.Name = "transaction2";
            this.transaction2.Size = new System.Drawing.Size(163, 20);
            this.transaction2.TabIndex = 27;
            this.transaction2.Text = "รอบการจ่ายเงินถึงวันที่ (*)";
            // 
            // transaction1List
            // 
            this.transaction1List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction1List.Location = new System.Drawing.Point(693, 19);
            this.transaction1List.Name = "transaction1List";
            this.transaction1List.Size = new System.Drawing.Size(246, 22);
            this.transaction1List.TabIndex = 26;
            // 
            // transaction1
            // 
            this.transaction1.AutoSize = true;
            this.transaction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction1.Location = new System.Drawing.Point(474, 22);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(181, 20);
            this.transaction1.TabIndex = 25;
            this.transaction1.Text = "รอบการจ่ายเงินตั้งแต่วันที่ (*)";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.category.Location = new System.Drawing.Point(26, 140);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(122, 20);
            this.category.TabIndex = 24;
            this.category.Text = "ประเภทรายการ (*)";
            // 
            // companyList
            // 
            this.companyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(160, 21);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(246, 24);
            this.companyList.TabIndex = 23;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.company.Location = new System.Drawing.Point(26, 25);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(95, 20);
            this.company.TabIndex = 22;
            this.company.Text = "บริษัทต้นสังกัด";
            // 
            // MoneygroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.fundList);
            this.Controls.Add(this.fund);
            this.Controls.Add(this.codeEmpList);
            this.Controls.Add(this.company);
            this.Controls.Add(this.codeEmp);
            this.Controls.Add(this.companyList);
            this.Controls.Add(this.dateList);
            this.Controls.Add(this.category);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.transaction1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.transaction1List);
            this.Controls.Add(this.transaction2List);
            this.Controls.Add(this.transaction2);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MoneygroupList";
            this.Text = "MoneygroupList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox fundList;
        private System.Windows.Forms.Label fund;
        private System.Windows.Forms.TextBox codeEmpList;
        private System.Windows.Forms.Label codeEmp;
        private System.Windows.Forms.DateTimePicker dateList;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker transaction2List;
        private System.Windows.Forms.Label transaction2;
        private System.Windows.Forms.DateTimePicker transaction1List;
        private System.Windows.Forms.Label transaction1;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.ComboBox companyList;
        private System.Windows.Forms.Label company;
    }
}