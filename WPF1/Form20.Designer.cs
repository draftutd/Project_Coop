﻿namespace WPF1
{
    partial class Form20
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
            this.refer = new System.Windows.Forms.Label();
            this.nameEnd = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.referList = new System.Windows.Forms.TextBox();
            this.nameEndList = new System.Windows.Forms.TextBox();
            this.unitList = new System.Windows.Forms.TextBox();
            this.moneyList = new System.Windows.Forms.TextBox();
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
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Location = new System.Drawing.Point(38, 53);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btncancel.Location = new System.Drawing.Point(128, 53);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 33);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "ยกเลิก";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.refer);
            this.pnlData.Controls.Add(this.nameEnd);
            this.pnlData.Controls.Add(this.unit);
            this.pnlData.Controls.Add(this.money);
            this.pnlData.Controls.Add(this.referList);
            this.pnlData.Controls.Add(this.nameEndList);
            this.pnlData.Controls.Add(this.unitList);
            this.pnlData.Controls.Add(this.moneyList);
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
            this.pnlData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pnlData.Location = new System.Drawing.Point(12, 100);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(960, 312);
            this.pnlData.TabIndex = 1;
            // 
            // refer
            // 
            this.refer.AutoSize = true;
            this.refer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.refer.Location = new System.Drawing.Point(32, 236);
            this.refer.Name = "refer";
            this.refer.Size = new System.Drawing.Size(69, 20);
            this.refer.TabIndex = 29;
            this.refer.Text = "เลขอ้างอิง";
            // 
            // nameEnd
            // 
            this.nameEnd.AutoSize = true;
            this.nameEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nameEnd.Location = new System.Drawing.Point(512, 194);
            this.nameEnd.Name = "nameEnd";
            this.nameEnd.Size = new System.Drawing.Size(140, 20);
            this.nameEnd.TabIndex = 28;
            this.nameEnd.Text = "รหัสพนักงานปลายทาง";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.unit.Location = new System.Drawing.Point(32, 194);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(82, 20);
            this.unit.TabIndex = 27;
            this.unit.Text = "จำนวนหน่วย";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.money.Location = new System.Drawing.Point(512, 153);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(71, 20);
            this.money.TabIndex = 26;
            this.money.Text = "จำนวนเงิน";
            // 
            // referList
            // 
            this.referList.Location = new System.Drawing.Point(228, 236);
            this.referList.Name = "referList";
            this.referList.Size = new System.Drawing.Size(246, 22);
            this.referList.TabIndex = 25;
            // 
            // nameEndList
            // 
            this.nameEndList.Location = new System.Drawing.Point(679, 191);
            this.nameEndList.Name = "nameEndList";
            this.nameEndList.Size = new System.Drawing.Size(246, 22);
            this.nameEndList.TabIndex = 24;
            // 
            // unitList
            // 
            this.unitList.Location = new System.Drawing.Point(228, 194);
            this.unitList.Name = "unitList";
            this.unitList.Size = new System.Drawing.Size(246, 22);
            this.unitList.TabIndex = 23;
            // 
            // moneyList
            // 
            this.moneyList.Location = new System.Drawing.Point(679, 153);
            this.moneyList.Name = "moneyList";
            this.moneyList.Size = new System.Drawing.Size(246, 22);
            this.moneyList.TabIndex = 22;
            // 
            // fundList
            // 
            this.fundList.FormattingEnabled = true;
            this.fundList.Location = new System.Drawing.Point(228, 69);
            this.fundList.Name = "fundList";
            this.fundList.Size = new System.Drawing.Size(246, 24);
            this.fundList.TabIndex = 21;
            this.fundList.Text = "ระบุเลือกกองทุน";
            // 
            // fund
            // 
            this.fund.AutoSize = true;
            this.fund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fund.Location = new System.Drawing.Point(32, 69);
            this.fund.Name = "fund";
            this.fund.Size = new System.Drawing.Size(52, 20);
            this.fund.TabIndex = 20;
            this.fund.Text = "กองทุน";
            // 
            // codeEmpList
            // 
            this.codeEmpList.Location = new System.Drawing.Point(679, 30);
            this.codeEmpList.Name = "codeEmpList";
            this.codeEmpList.Size = new System.Drawing.Size(246, 22);
            this.codeEmpList.TabIndex = 13;
            // 
            // codeEmp
            // 
            this.codeEmp.AutoSize = true;
            this.codeEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeEmp.Location = new System.Drawing.Point(512, 30);
            this.codeEmp.Name = "codeEmp";
            this.codeEmp.Size = new System.Drawing.Size(84, 20);
            this.codeEmp.TabIndex = 12;
            this.codeEmp.Text = "รหัสพนักงาน";
            // 
            // dateList
            // 
            this.dateList.Location = new System.Drawing.Point(228, 154);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(246, 22);
            this.dateList.TabIndex = 11;
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Items.AddRange(new object[] {
            " Buy",
            " Sell",
            " Transfer"});
            this.categoryList.Location = new System.Drawing.Point(679, 69);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(246, 24);
            this.categoryList.TabIndex = 10;
            this.categoryList.Text = " Buy";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.date.Location = new System.Drawing.Point(32, 156);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(117, 20);
            this.date.TabIndex = 8;
            this.date.Text = "วันที่ทำรายการ (*)";
            // 
            // transaction2List
            // 
            this.transaction2List.Location = new System.Drawing.Point(679, 111);
            this.transaction2List.Name = "transaction2List";
            this.transaction2List.Size = new System.Drawing.Size(246, 22);
            this.transaction2List.TabIndex = 7;
            // 
            // transaction2
            // 
            this.transaction2.AutoSize = true;
            this.transaction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction2.Location = new System.Drawing.Point(512, 113);
            this.transaction2.Name = "transaction2";
            this.transaction2.Size = new System.Drawing.Size(163, 20);
            this.transaction2.TabIndex = 6;
            this.transaction2.Text = "รอบการจ่ายเงินถึงวันที่ (*)";
            // 
            // transaction1List
            // 
            this.transaction1List.Location = new System.Drawing.Point(228, 112);
            this.transaction1List.Name = "transaction1List";
            this.transaction1List.Size = new System.Drawing.Size(246, 22);
            this.transaction1List.TabIndex = 5;
            // 
            // transaction1
            // 
            this.transaction1.AutoSize = true;
            this.transaction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.transaction1.Location = new System.Drawing.Point(32, 113);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(181, 20);
            this.transaction1.TabIndex = 4;
            this.transaction1.Text = "รอบการจ่ายเงินตั้งแต่วันที่ (*)";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.category.Location = new System.Drawing.Point(512, 69);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(122, 20);
            this.category.TabIndex = 2;
            this.category.Text = "ประเภทรายการ (*)";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(228, 27);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(246, 24);
            this.companyList.TabIndex = 1;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.company.Location = new System.Drawing.Point(32, 27);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(95, 20);
            this.company.TabIndex = 0;
            this.company.Text = "บริษัทต้นสังกัด";
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form20";
            this.Text = "Form20";
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
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label transaction1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker transaction2List;
        private System.Windows.Forms.Label transaction2;
        private System.Windows.Forms.DateTimePicker transaction1List;
        private System.Windows.Forms.DateTimePicker dateList;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.TextBox codeEmpList;
        private System.Windows.Forms.Label codeEmp;
        private System.Windows.Forms.ComboBox fundList;
        private System.Windows.Forms.Label fund;
        private System.Windows.Forms.Label refer;
        private System.Windows.Forms.Label nameEnd;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox referList;
        private System.Windows.Forms.TextBox nameEndList;
        private System.Windows.Forms.TextBox unitList;
        private System.Windows.Forms.TextBox moneyList;
    }
}