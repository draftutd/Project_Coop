namespace WPF1
{
    partial class Form13
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
            this.compaList = new System.Windows.Forms.ComboBox();
            this.compa = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.navList = new System.Windows.Forms.DateTimePicker();
            this.nav = new System.Windows.Forms.Label();
            this.codeFundList = new System.Windows.Forms.TextBox();
            this.codeFund = new System.Windows.Forms.Label();
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
            this.btnExit.Location = new System.Drawing.Point(936, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ออกจากหน้าจอ";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.navList);
            this.pnlData.Controls.Add(this.nav);
            this.pnlData.Controls.Add(this.codeFundList);
            this.pnlData.Controls.Add(this.codeFund);
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.Controls.Add(this.btnsearch);
            this.pnlData.Location = new System.Drawing.Point(30, 73);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(472, 185);
            this.pnlData.TabIndex = 6;
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
            this.btnsearch.Location = new System.Drawing.Point(348, 125);
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
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Location = new System.Drawing.Point(31, 276);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(1004, 325);
            this.grdList.TabIndex = 20;
            // 
            // navList
            // 
            this.navList.Location = new System.Drawing.Point(122, 80);
            this.navList.Name = "navList";
            this.navList.Size = new System.Drawing.Size(324, 20);
            this.navList.TabIndex = 32;
            // 
            // nav
            // 
            this.nav.AutoSize = true;
            this.nav.Location = new System.Drawing.Point(24, 86);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(66, 13);
            this.nav.TabIndex = 31;
            this.nav.Text = "วันที่ NAV (*)";
            // 
            // codeFundList
            // 
            this.codeFundList.Location = new System.Drawing.Point(122, 54);
            this.codeFundList.Name = "codeFundList";
            this.codeFundList.Size = new System.Drawing.Size(324, 20);
            this.codeFundList.TabIndex = 30;
            // 
            // codeFund
            // 
            this.codeFund.AutoSize = true;
            this.codeFund.Location = new System.Drawing.Point(24, 57);
            this.codeFund.Name = "codeFund";
            this.codeFund.Size = new System.Drawing.Size(72, 13);
            this.codeFund.TabIndex = 29;
            this.codeFund.Text = "รหัสกองทุน (*)";
            // 
            // Form13
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
            this.Name = "Form13";
            this.Text = "Form13";
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
        private System.Windows.Forms.DateTimePicker navList;
        private System.Windows.Forms.Label nav;
        private System.Windows.Forms.TextBox codeFundList;
        private System.Windows.Forms.Label codeFund;
    }
}