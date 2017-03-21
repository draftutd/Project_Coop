namespace WPF1
{
    partial class Form19
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAdd.Location = new System.Drawing.Point(43, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "เพิ่มรายการ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEdit.Location = new System.Drawing.Point(133, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "แก้ไขรายการ";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnView.Location = new System.Drawing.Point(223, 37);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(84, 33);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "ดูรายการ";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDel.Location = new System.Drawing.Point(313, 37);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(84, 33);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "ลบรายการ";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnExit.Location = new System.Drawing.Point(888, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ออกจากหน้าจอ";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.fundList);
            this.pnlData.Controls.Add(this.fund);
            this.pnlData.Controls.Add(this.codeEmpList);
            this.pnlData.Controls.Add(this.codeEmp);
            this.pnlData.Controls.Add(this.dateList);
            this.pnlData.Controls.Add(this.categoryList);
            this.pnlData.Controls.Add(this.date);
            this.pnlData.Controls.Add(this.transaction2List);
            this.pnlData.Controls.Add(this.transaction2);
            this.pnlData.Controls.Add(this.transaction1List);
            this.pnlData.Controls.Add(this.transaction1);
            this.pnlData.Controls.Add(this.category);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Controls.Add(this.btnsearch);
            this.pnlData.Location = new System.Drawing.Point(15, 92);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(957, 187);
            this.pnlData.TabIndex = 6;
            // 
            // fundList
            // 
            this.fundList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundList.FormattingEnabled = true;
            this.fundList.Location = new System.Drawing.Point(149, 95);
            this.fundList.Name = "fundList";
            this.fundList.Size = new System.Drawing.Size(246, 24);
            this.fundList.TabIndex = 35;
            this.fundList.Text = "ระบุเลือกกองทุน";
            // 
            // fund
            // 
            this.fund.AutoSize = true;
            this.fund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fund.Location = new System.Drawing.Point(15, 95);
            this.fund.Name = "fund";
            this.fund.Size = new System.Drawing.Size(52, 20);
            this.fund.TabIndex = 34;
            this.fund.Text = "กองทุน";
            // 
            // codeEmpList
            // 
            this.codeEmpList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeEmpList.Location = new System.Drawing.Point(149, 57);
            this.codeEmpList.Name = "codeEmpList";
            this.codeEmpList.Size = new System.Drawing.Size(246, 22);
            this.codeEmpList.TabIndex = 33;
            // 
            // codeEmp
            // 
            this.codeEmp.AutoSize = true;
            this.codeEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeEmp.Location = new System.Drawing.Point(15, 57);
            this.codeEmp.Name = "codeEmp";
            this.codeEmp.Size = new System.Drawing.Size(84, 20);
            this.codeEmp.TabIndex = 32;
            this.codeEmp.Text = "รหัสพนักงาน";
            // 
            // dateList
            // 
            this.dateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateList.Location = new System.Drawing.Point(682, 97);
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
            this.categoryList.Location = new System.Drawing.Point(149, 137);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(246, 24);
            this.categoryList.TabIndex = 30;
            this.categoryList.Text = " Buy";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.date.Location = new System.Drawing.Point(463, 95);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(117, 20);
            this.date.TabIndex = 29;
            this.date.Text = "วันที่ทำรายการ (*)";
            // 
            // transaction2List
            // 
            this.transaction2List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction2List.Location = new System.Drawing.Point(682, 57);
            this.transaction2List.Name = "transaction2List";
            this.transaction2List.Size = new System.Drawing.Size(246, 22);
            this.transaction2List.TabIndex = 28;
            // 
            // transaction2
            // 
            this.transaction2.AutoSize = true;
            this.transaction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction2.Location = new System.Drawing.Point(463, 57);
            this.transaction2.Name = "transaction2";
            this.transaction2.Size = new System.Drawing.Size(163, 20);
            this.transaction2.TabIndex = 27;
            this.transaction2.Text = "รอบการจ่ายเงินถึงวันที่ (*)";
            // 
            // transaction1List
            // 
            this.transaction1List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction1List.Location = new System.Drawing.Point(682, 16);
            this.transaction1List.Name = "transaction1List";
            this.transaction1List.Size = new System.Drawing.Size(246, 22);
            this.transaction1List.TabIndex = 26;
            // 
            // transaction1
            // 
            this.transaction1.AutoSize = true;
            this.transaction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction1.Location = new System.Drawing.Point(463, 19);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(181, 20);
            this.transaction1.TabIndex = 25;
            this.transaction1.Text = "รอบการจ่ายเงินตั้งแต่วันที่ (*)";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.category.Location = new System.Drawing.Point(15, 137);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(122, 20);
            this.category.TabIndex = 24;
            this.category.Text = "ประเภทรายการ (*)";
            // 
            // companyList
            // 
            this.companyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(149, 18);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(246, 24);
            this.companyList.TabIndex = 23;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.company.Location = new System.Drawing.Point(15, 22);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(95, 20);
            this.company.TabIndex = 22;
            this.company.Text = "บริษัทต้นสังกัด";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnsearch.Location = new System.Drawing.Point(844, 137);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(84, 33);
            this.btnsearch.TabIndex = 19;
            this.btnsearch.Text = "ค้นหารายการ";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.AllowUserToResizeRows = false;
            this.grdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Location = new System.Drawing.Point(12, 295);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(960, 354);
            this.grdList.TabIndex = 20;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlData);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form19";
            this.Text = "Form19";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnsearch;
        protected System.Windows.Forms.Panel pnlData;
        protected System.Windows.Forms.DataGridView grdList;
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