namespace WPF1
{
    partial class Form10
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
            this.orderList = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.Label();
            this.reserve2List = new System.Windows.Forms.TextBox();
            this.reserve2 = new System.Windows.Forms.Label();
            this.reserve1List = new System.Windows.Forms.TextBox();
            this.reserve1 = new System.Windows.Forms.Label();
            this.ageWork2List = new System.Windows.Forms.TextBox();
            this.ageWork2 = new System.Windows.Forms.Label();
            this.ageWork1List = new System.Windows.Forms.TextBox();
            this.ageWork1 = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.positionList = new System.Windows.Forms.ComboBox();
            this.branchList = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.conditionList = new System.Windows.Forms.TextBox();
            this.condition = new System.Windows.Forms.Label();
            this.codeConditionList = new System.Windows.Forms.TextBox();
            this.statusemp = new System.Windows.Forms.Label();
            this.codeCondition = new System.Windows.Forms.Label();
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
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.orderList);
            this.pnlData.Controls.Add(this.order);
            this.pnlData.Controls.Add(this.reserve2List);
            this.pnlData.Controls.Add(this.reserve2);
            this.pnlData.Controls.Add(this.reserve1List);
            this.pnlData.Controls.Add(this.reserve1);
            this.pnlData.Controls.Add(this.ageWork2List);
            this.pnlData.Controls.Add(this.ageWork2);
            this.pnlData.Controls.Add(this.ageWork1List);
            this.pnlData.Controls.Add(this.ageWork1);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.positionList);
            this.pnlData.Controls.Add(this.branchList);
            this.pnlData.Controls.Add(this.position);
            this.pnlData.Controls.Add(this.branch);
            this.pnlData.Controls.Add(this.conditionList);
            this.pnlData.Controls.Add(this.condition);
            this.pnlData.Controls.Add(this.codeConditionList);
            this.pnlData.Controls.Add(this.statusemp);
            this.pnlData.Controls.Add(this.codeCondition);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Location = new System.Drawing.Point(17, 69);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(606, 341);
            this.pnlData.TabIndex = 1;
            // 
            // orderList
            // 
            this.orderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderList.Location = new System.Drawing.Point(174, 264);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(405, 20);
            this.orderList.TabIndex = 27;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(31, 267);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(85, 13);
            this.order.TabIndex = 26;
            this.order.Text = "ลำดับการคำนวณ";
            // 
            // reserve2List
            // 
            this.reserve2List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reserve2List.Location = new System.Drawing.Point(174, 238);
            this.reserve2List.Name = "reserve2List";
            this.reserve2List.Size = new System.Drawing.Size(405, 20);
            this.reserve2List.TabIndex = 25;
            // 
            // reserve2
            // 
            this.reserve2.AutoSize = true;
            this.reserve2.Location = new System.Drawing.Point(31, 241);
            this.reserve2.Name = "reserve2";
            this.reserve2.Size = new System.Drawing.Size(82, 13);
            this.reserve2.TabIndex = 24;
            this.reserve2.Text = "จำนวนเงินสะสม";
            // 
            // reserve1List
            // 
            this.reserve1List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reserve1List.Location = new System.Drawing.Point(174, 212);
            this.reserve1List.Name = "reserve1List";
            this.reserve1List.Size = new System.Drawing.Size(405, 20);
            this.reserve1List.TabIndex = 23;
            // 
            // reserve1
            // 
            this.reserve1.AutoSize = true;
            this.reserve1.Location = new System.Drawing.Point(31, 215);
            this.reserve1.Name = "reserve1";
            this.reserve1.Size = new System.Drawing.Size(82, 13);
            this.reserve1.TabIndex = 22;
            this.reserve1.Text = "เปอร์เซ็นต์สะสม";
            // 
            // ageWork2List
            // 
            this.ageWork2List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageWork2List.Location = new System.Drawing.Point(174, 186);
            this.ageWork2List.Name = "ageWork2List";
            this.ageWork2List.Size = new System.Drawing.Size(405, 20);
            this.ageWork2List.TabIndex = 21;
            // 
            // ageWork2
            // 
            this.ageWork2.AutoSize = true;
            this.ageWork2.Location = new System.Drawing.Point(31, 189);
            this.ageWork2.Name = "ageWork2";
            this.ageWork2.Size = new System.Drawing.Size(71, 13);
            this.ageWork2.TabIndex = 20;
            this.ageWork2.Text = "อายุงานถึง (ปี)";
            // 
            // ageWork1List
            // 
            this.ageWork1List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageWork1List.Location = new System.Drawing.Point(174, 160);
            this.ageWork1List.Name = "ageWork1List";
            this.ageWork1List.Size = new System.Drawing.Size(405, 20);
            this.ageWork1List.TabIndex = 19;
            // 
            // ageWork1
            // 
            this.ageWork1.AutoSize = true;
            this.ageWork1.Location = new System.Drawing.Point(31, 163);
            this.ageWork1.Name = "ageWork1";
            this.ageWork1.Size = new System.Drawing.Size(86, 13);
            this.ageWork1.TabIndex = 18;
            this.ageWork1.Text = "อายุงานตั่งแต่ (ปี)";
            // 
            // statusList
            // 
            this.statusList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(174, 290);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(405, 21);
            this.statusList.TabIndex = 17;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // positionList
            // 
            this.positionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionList.FormattingEnabled = true;
            this.positionList.Location = new System.Drawing.Point(174, 133);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(405, 21);
            this.positionList.TabIndex = 16;
            // 
            // branchList
            // 
            this.branchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.branchList.FormattingEnabled = true;
            this.branchList.Location = new System.Drawing.Point(174, 106);
            this.branchList.Name = "branchList";
            this.branchList.Size = new System.Drawing.Size(405, 21);
            this.branchList.TabIndex = 15;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(31, 136);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(47, 13);
            this.position.TabIndex = 14;
            this.position.Text = "ตำแหน่ง";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Location = new System.Drawing.Point(31, 109);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(37, 13);
            this.branch.TabIndex = 12;
            this.branch.Text = "แผนก";
            // 
            // conditionList
            // 
            this.conditionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionList.Location = new System.Drawing.Point(174, 80);
            this.conditionList.Name = "conditionList";
            this.conditionList.Size = new System.Drawing.Size(405, 20);
            this.conditionList.TabIndex = 11;
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Location = new System.Drawing.Point(31, 83);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(56, 13);
            this.condition.TabIndex = 10;
            this.condition.Text = "เงื่อนไข (*)";
            // 
            // codeConditionList
            // 
            this.codeConditionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeConditionList.Location = new System.Drawing.Point(174, 54);
            this.codeConditionList.Name = "codeConditionList";
            this.codeConditionList.Size = new System.Drawing.Size(405, 20);
            this.codeConditionList.TabIndex = 9;
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Location = new System.Drawing.Point(31, 293);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(63, 13);
            this.statusemp.TabIndex = 7;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // codeCondition
            // 
            this.codeCondition.AutoSize = true;
            this.codeCondition.Location = new System.Drawing.Point(31, 57);
            this.codeCondition.Name = "codeCondition";
            this.codeCondition.Size = new System.Drawing.Size(75, 13);
            this.codeCondition.TabIndex = 5;
            this.codeCondition.Text = "รหัสเงื่อนไข (*)";
            // 
            // companyList
            // 
            this.companyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(174, 27);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(405, 21);
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
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 425);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.Name = "Form10";
            this.Text = "Form10";
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
        private System.Windows.Forms.Label codeCondition;
        private System.Windows.Forms.Label statusemp;
        private System.Windows.Forms.TextBox codeConditionList;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.TextBox conditionList;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.ComboBox positionList;
        private System.Windows.Forms.ComboBox branchList;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.TextBox ageWork2List;
        private System.Windows.Forms.Label ageWork2;
        private System.Windows.Forms.TextBox ageWork1List;
        private System.Windows.Forms.Label ageWork1;
        private System.Windows.Forms.TextBox orderList;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.TextBox reserve2List;
        private System.Windows.Forms.Label reserve2;
        private System.Windows.Forms.TextBox reserve1List;
        private System.Windows.Forms.Label reserve1;
    }
}