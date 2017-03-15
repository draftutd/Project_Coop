namespace WPF1
{
    partial class Form11
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
            this.statusList = new System.Windows.Forms.ComboBox();
            this.statusemp = new System.Windows.Forms.Label();
            this.ageWork2List = new System.Windows.Forms.TextBox();
            this.ageWork2 = new System.Windows.Forms.Label();
            this.ageWork1List = new System.Windows.Forms.TextBox();
            this.ageWork1 = new System.Windows.Forms.Label();
            this.positionList = new System.Windows.Forms.ComboBox();
            this.branchList = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.conditionList = new System.Windows.Forms.TextBox();
            this.condition = new System.Windows.Forms.Label();
            this.codeConditionList = new System.Windows.Forms.TextBox();
            this.codeCondition = new System.Windows.Forms.Label();
            this.compaList = new System.Windows.Forms.ComboBox();
            this.compa = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "เพิ่มรายการ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(136, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "แก้ไขรายการ";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(226, 21);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(84, 33);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "ดูรายการ";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(316, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(84, 33);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "ลบรายการ";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(936, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ออกจากหน้าจอ";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.statusemp);
            this.pnlData.Controls.Add(this.ageWork2List);
            this.pnlData.Controls.Add(this.ageWork2);
            this.pnlData.Controls.Add(this.ageWork1List);
            this.pnlData.Controls.Add(this.ageWork1);
            this.pnlData.Controls.Add(this.positionList);
            this.pnlData.Controls.Add(this.branchList);
            this.pnlData.Controls.Add(this.position);
            this.pnlData.Controls.Add(this.branch);
            this.pnlData.Controls.Add(this.conditionList);
            this.pnlData.Controls.Add(this.condition);
            this.pnlData.Controls.Add(this.codeConditionList);
            this.pnlData.Controls.Add(this.codeCondition);
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.Controls.Add(this.btnsearch);
            this.pnlData.Location = new System.Drawing.Point(30, 73);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1005, 197);
            this.pnlData.TabIndex = 6;
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(632, 117);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(324, 21);
            this.statusList.TabIndex = 39;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Location = new System.Drawing.Point(508, 120);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(63, 13);
            this.statusemp.TabIndex = 38;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // ageWork2List
            // 
            this.ageWork2List.Location = new System.Drawing.Point(632, 87);
            this.ageWork2List.Name = "ageWork2List";
            this.ageWork2List.Size = new System.Drawing.Size(324, 20);
            this.ageWork2List.TabIndex = 37;
            // 
            // ageWork2
            // 
            this.ageWork2.AutoSize = true;
            this.ageWork2.Location = new System.Drawing.Point(508, 90);
            this.ageWork2.Name = "ageWork2";
            this.ageWork2.Size = new System.Drawing.Size(71, 13);
            this.ageWork2.TabIndex = 36;
            this.ageWork2.Text = "อายุงานถึง (ปี)";
            // 
            // ageWork1List
            // 
            this.ageWork1List.Location = new System.Drawing.Point(632, 57);
            this.ageWork1List.Name = "ageWork1List";
            this.ageWork1List.Size = new System.Drawing.Size(324, 20);
            this.ageWork1List.TabIndex = 35;
            // 
            // ageWork1
            // 
            this.ageWork1.AutoSize = true;
            this.ageWork1.Location = new System.Drawing.Point(508, 60);
            this.ageWork1.Name = "ageWork1";
            this.ageWork1.Size = new System.Drawing.Size(86, 13);
            this.ageWork1.TabIndex = 34;
            this.ageWork1.Text = "อายุงานตั่งแต่ (ปี)";
            // 
            // positionList
            // 
            this.positionList.FormattingEnabled = true;
            this.positionList.Location = new System.Drawing.Point(632, 27);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(324, 21);
            this.positionList.TabIndex = 33;
            // 
            // branchList
            // 
            this.branchList.FormattingEnabled = true;
            this.branchList.Location = new System.Drawing.Point(122, 117);
            this.branchList.Name = "branchList";
            this.branchList.Size = new System.Drawing.Size(324, 21);
            this.branchList.TabIndex = 32;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(508, 30);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(47, 13);
            this.position.TabIndex = 31;
            this.position.Text = "ตำแหน่ง";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Location = new System.Drawing.Point(24, 120);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(37, 13);
            this.branch.TabIndex = 30;
            this.branch.Text = "แผนก";
            // 
            // conditionList
            // 
            this.conditionList.Location = new System.Drawing.Point(122, 87);
            this.conditionList.Name = "conditionList";
            this.conditionList.Size = new System.Drawing.Size(324, 20);
            this.conditionList.TabIndex = 29;
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Location = new System.Drawing.Point(24, 90);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(56, 13);
            this.condition.TabIndex = 28;
            this.condition.Text = "เงื่อนไข (*)";
            // 
            // codeConditionList
            // 
            this.codeConditionList.Location = new System.Drawing.Point(122, 57);
            this.codeConditionList.Name = "codeConditionList";
            this.codeConditionList.Size = new System.Drawing.Size(323, 20);
            this.codeConditionList.TabIndex = 27;
            // 
            // codeCondition
            // 
            this.codeCondition.AutoSize = true;
            this.codeCondition.Location = new System.Drawing.Point(24, 60);
            this.codeCondition.Name = "codeCondition";
            this.codeCondition.Size = new System.Drawing.Size(75, 13);
            this.codeCondition.TabIndex = 26;
            this.codeCondition.Text = "รหัสเงื่อนไข (*)";
            // 
            // compaList
            // 
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(122, 27);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(324, 21);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Location = new System.Drawing.Point(24, 30);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(75, 13);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัทต้นสังกัด";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(872, 144);
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
            this.grdList.Location = new System.Drawing.Point(31, 276);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(1004, 325);
            this.grdList.TabIndex = 20;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 623);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlData);
            this.Name = "Form11";
            this.Text = "Form11";
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
        private System.Windows.Forms.Label compa;
        private System.Windows.Forms.ComboBox compaList;
        private System.Windows.Forms.Button btnsearch;
        protected System.Windows.Forms.Panel pnlData;
        protected System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.TextBox codeConditionList;
        private System.Windows.Forms.Label codeCondition;
        private System.Windows.Forms.TextBox conditionList;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.ComboBox positionList;
        private System.Windows.Forms.ComboBox branchList;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.TextBox ageWork2List;
        private System.Windows.Forms.Label ageWork2;
        private System.Windows.Forms.TextBox ageWork1List;
        private System.Windows.Forms.Label ageWork1;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Label statusemp;
    }
}