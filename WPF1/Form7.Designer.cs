namespace WPF1
{
    partial class Form7
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
            this.dateOffList = new System.Windows.Forms.DateTimePicker();
            this.dateOff = new System.Windows.Forms.Label();
            this.fundNameList = new System.Windows.Forms.TextBox();
            this.fundName = new System.Windows.Forms.Label();
            this.fundCodeList = new System.Windows.Forms.TextBox();
            this.fundCode = new System.Windows.Forms.Label();
            this.compaList = new System.Windows.Forms.ComboBox();
            this.compa = new System.Windows.Forms.Label();
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
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAdd.Location = new System.Drawing.Point(31, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "เพิ่มรายการ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEdit.Location = new System.Drawing.Point(219, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "แก้ไขรายการ";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnView.Location = new System.Drawing.Point(309, 39);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(84, 33);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "ดูรายการ";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDel.Location = new System.Drawing.Point(399, 39);
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
            this.btnExit.Location = new System.Drawing.Point(888, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ออกจากหน้าจอ";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.dateOffList);
            this.pnlData.Controls.Add(this.dateOff);
            this.pnlData.Controls.Add(this.fundNameList);
            this.pnlData.Controls.Add(this.fundName);
            this.pnlData.Controls.Add(this.fundCodeList);
            this.pnlData.Controls.Add(this.fundCode);
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.Controls.Add(this.status);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.btnsearch);
            this.pnlData.Location = new System.Drawing.Point(12, 92);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(960, 166);
            this.pnlData.TabIndex = 6;
            // 
            // dateOffList
            // 
            this.dateOffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateOffList.Location = new System.Drawing.Point(621, 30);
            this.dateOffList.Name = "dateOffList";
            this.dateOffList.Size = new System.Drawing.Size(255, 22);
            this.dateOffList.TabIndex = 25;
            // 
            // dateOff
            // 
            this.dateOff.AutoSize = true;
            this.dateOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateOff.Location = new System.Drawing.Point(508, 30);
            this.dateOff.Name = "dateOff";
            this.dateOff.Size = new System.Drawing.Size(96, 20);
            this.dateOff.TabIndex = 24;
            this.dateOff.Text = "วันที่ปิดกองทุน";
            // 
            // fundNameList
            // 
            this.fundNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundNameList.Location = new System.Drawing.Point(122, 105);
            this.fundNameList.Name = "fundNameList";
            this.fundNameList.Size = new System.Drawing.Size(271, 22);
            this.fundNameList.TabIndex = 23;
            // 
            // fundName
            // 
            this.fundName.AutoSize = true;
            this.fundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundName.Location = new System.Drawing.Point(24, 105);
            this.fundName.Name = "fundName";
            this.fundName.Size = new System.Drawing.Size(69, 20);
            this.fundName.TabIndex = 22;
            this.fundName.Text = "ชื่อกองทุน";
            // 
            // fundCodeList
            // 
            this.fundCodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundCodeList.Location = new System.Drawing.Point(122, 66);
            this.fundCodeList.Name = "fundCodeList";
            this.fundCodeList.Size = new System.Drawing.Size(271, 22);
            this.fundCodeList.TabIndex = 21;
            // 
            // fundCode
            // 
            this.fundCode.AutoSize = true;
            this.fundCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundCode.Location = new System.Drawing.Point(24, 66);
            this.fundCode.Name = "fundCode";
            this.fundCode.Size = new System.Drawing.Size(76, 20);
            this.fundCode.TabIndex = 20;
            this.fundCode.Text = "รหัสกองทุน";
            this.fundCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // compaList
            // 
            this.compaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(122, 27);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(271, 24);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(24, 30);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(95, 20);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัทต้นสังกัด";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.status.Location = new System.Drawing.Point(508, 70);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(84, 20);
            this.status.TabIndex = 17;
            this.status.Text = "สถานะข้อมูล";
            // 
            // statusList
            // 
            this.statusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusList.Items.AddRange(new object[] {
            " Active",
            " Inactive"});
            this.statusList.Location = new System.Drawing.Point(621, 66);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(255, 24);
            this.statusList.TabIndex = 18;
            this.statusList.Text = " Active";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnsearch.Location = new System.Drawing.Point(792, 105);
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
            this.grdList.Location = new System.Drawing.Point(12, 274);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(960, 375);
            this.grdList.TabIndex = 20;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddFile.Location = new System.Drawing.Point(121, 39);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(92, 33);
            this.btnAddFile.TabIndex = 26;
            this.btnAddFile.Text = "เพิ่มไฟล์รายการ";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlData);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form7";
            this.Text = "Form7";
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
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Button btnsearch;
        protected System.Windows.Forms.Panel pnlData;
        protected System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Label fundCode;
        private System.Windows.Forms.TextBox fundCodeList;
        private System.Windows.Forms.DateTimePicker dateOffList;
        private System.Windows.Forms.Label dateOff;
        private System.Windows.Forms.TextBox fundNameList;
        private System.Windows.Forms.Label fundName;
        private System.Windows.Forms.Button btnAddFile;
    }
}