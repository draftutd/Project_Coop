namespace WPF1
{
    partial class Form6
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
            this.positionList = new System.Windows.Forms.TextBox();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.statusemp = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
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
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.positionList);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.statusemp);
            this.pnlData.Controls.Add(this.position);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Location = new System.Drawing.Point(17, 69);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(485, 154);
            this.pnlData.TabIndex = 1;
            // 
            // positionList
            // 
            this.positionList.Location = new System.Drawing.Point(174, 62);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(285, 20);
            this.positionList.TabIndex = 9;
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(174, 97);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(285, 21);
            this.statusList.TabIndex = 8;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Location = new System.Drawing.Point(31, 100);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(63, 13);
            this.statusemp.TabIndex = 7;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(32, 65);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(60, 13);
            this.position.TabIndex = 5;
            this.position.Text = "ชื่อตำแหน่ง";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(174, 27);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(285, 21);
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
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 252);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.Name = "Form6";
            this.Text = "Form6";
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
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label statusemp;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.TextBox positionList;
    }
}