﻿namespace WPF1
{
    partial class Form1
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
            this.perList = new System.Windows.Forms.TextBox();
            this.compaList = new System.Windows.Forms.ComboBox();
            this.compa = new System.Windows.Forms.Label();
            this.posit = new System.Windows.Forms.Label();
            this.positList = new System.Windows.Forms.ComboBox();
            this.perName = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.branchList = new System.Windows.Forms.ComboBox();
            this.codeName = new System.Windows.Forms.Label();
            this.codeNameList = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.btnAddFile = new System.Windows.Forms.Button();
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
            this.btnEdit.Location = new System.Drawing.Point(234, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "แก้ไขรายการ";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(324, 21);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(84, 33);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "ดูรายการ";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(414, 21);
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
            this.pnlData.Controls.Add(this.perList);
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.Controls.Add(this.posit);
            this.pnlData.Controls.Add(this.positList);
            this.pnlData.Controls.Add(this.perName);
            this.pnlData.Controls.Add(this.branch);
            this.pnlData.Controls.Add(this.branchList);
            this.pnlData.Controls.Add(this.codeName);
            this.pnlData.Controls.Add(this.codeNameList);
            this.pnlData.Controls.Add(this.status);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.btnsearch);
            this.pnlData.Location = new System.Drawing.Point(30, 73);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1004, 160);
            this.pnlData.TabIndex = 6;
            // 
            // perList
            // 
            this.perList.Location = new System.Drawing.Point(105, 112);
            this.perList.Name = "perList";
            this.perList.Size = new System.Drawing.Size(324, 20);
            this.perList.TabIndex = 7;
            // 
            // compaList
            // 
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(105, 27);
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
            this.compa.Size = new System.Drawing.Size(35, 13);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัท";
            // 
            // posit
            // 
            this.posit.AutoSize = true;
            this.posit.Location = new System.Drawing.Point(24, 73);
            this.posit.Name = "posit";
            this.posit.Size = new System.Drawing.Size(47, 13);
            this.posit.TabIndex = 10;
            this.posit.Text = "ตำแหน่ง";
            // 
            // positList
            // 
            this.positList.FormattingEnabled = true;
            this.positList.Location = new System.Drawing.Point(105, 70);
            this.positList.Name = "positList";
            this.positList.Size = new System.Drawing.Size(324, 21);
            this.positList.TabIndex = 11;
            this.positList.Text = " ระบุเลือกตำแหน่ง";
            // 
            // perName
            // 
            this.perName.AutoSize = true;
            this.perName.Location = new System.Drawing.Point(24, 115);
            this.perName.Name = "perName";
            this.perName.Size = new System.Drawing.Size(61, 13);
            this.perName.TabIndex = 12;
            this.perName.Text = "ชื่อพนักงาน";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Location = new System.Drawing.Point(531, 30);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(62, 13);
            this.branch.TabIndex = 13;
            this.branch.Text = "สังกัดแผนก";
            // 
            // branchList
            // 
            this.branchList.FormattingEnabled = true;
            this.branchList.Location = new System.Drawing.Point(638, 27);
            this.branchList.Name = "branchList";
            this.branchList.Size = new System.Drawing.Size(324, 21);
            this.branchList.TabIndex = 14;
            this.branchList.Text = "ระบุเลือกแผนกต้นสังกัด";
            // 
            // codeName
            // 
            this.codeName.AutoSize = true;
            this.codeName.Location = new System.Drawing.Point(531, 74);
            this.codeName.Name = "codeName";
            this.codeName.Size = new System.Drawing.Size(67, 13);
            this.codeName.TabIndex = 15;
            this.codeName.Text = "รหัสพนักงาน";
            // 
            // codeNameList
            // 
            this.codeNameList.Location = new System.Drawing.Point(638, 71);
            this.codeNameList.Name = "codeNameList";
            this.codeNameList.Size = new System.Drawing.Size(324, 20);
            this.codeNameList.TabIndex = 16;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(531, 119);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(79, 13);
            this.status.TabIndex = 17;
            this.status.Text = "สถานะพนักงาน";
            // 
            // statusList
            // 
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(638, 115);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(161, 21);
            this.statusList.TabIndex = 18;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(878, 108);
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
            this.grdList.Location = new System.Drawing.Point(30, 251);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(1005, 350);
            this.grdList.TabIndex = 20;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(136, 21);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(92, 33);
            this.btnAddFile.TabIndex = 21;
            this.btnAddFile.Text = "เพิ่มไฟล์รายการ";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 623);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlData);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label posit;
        private System.Windows.Forms.Label perName;
        private System.Windows.Forms.ComboBox positList;
        private System.Windows.Forms.ComboBox compaList;
        private System.Windows.Forms.TextBox perList;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.ComboBox branchList;
        private System.Windows.Forms.Label codeName;
        private System.Windows.Forms.TextBox codeNameList;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Button btnsearch;
        protected System.Windows.Forms.Panel pnlData;
        protected System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Button btnAddFile;
    }
}