namespace WPF1.Fund.UI
{
    partial class FundList
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
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateOffList
            // 
            this.dateOffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateOffList.Location = new System.Drawing.Point(639, 24);
            this.dateOffList.Name = "dateOffList";
            this.dateOffList.Size = new System.Drawing.Size(255, 22);
            this.dateOffList.TabIndex = 25;
            // 
            // dateOff
            // 
            this.dateOff.AutoSize = true;
            this.dateOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateOff.Location = new System.Drawing.Point(526, 24);
            this.dateOff.Name = "dateOff";
            this.dateOff.Size = new System.Drawing.Size(96, 20);
            this.dateOff.TabIndex = 24;
            this.dateOff.Text = "วันที่ปิดกองทุน";
            // 
            // fundNameList
            // 
            this.fundNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundNameList.Location = new System.Drawing.Point(122, 99);
            this.fundNameList.Name = "fundNameList";
            this.fundNameList.Size = new System.Drawing.Size(271, 22);
            this.fundNameList.TabIndex = 23;
            // 
            // fundName
            // 
            this.fundName.AutoSize = true;
            this.fundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundName.Location = new System.Drawing.Point(24, 99);
            this.fundName.Name = "fundName";
            this.fundName.Size = new System.Drawing.Size(69, 20);
            this.fundName.TabIndex = 22;
            this.fundName.Text = "ชื่อกองทุน";
            // 
            // fundCodeList
            // 
            this.fundCodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundCodeList.Location = new System.Drawing.Point(122, 60);
            this.fundCodeList.Name = "fundCodeList";
            this.fundCodeList.Size = new System.Drawing.Size(271, 22);
            this.fundCodeList.TabIndex = 21;
            // 
            // fundCode
            // 
            this.fundCode.AutoSize = true;
            this.fundCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fundCode.Location = new System.Drawing.Point(24, 60);
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
            this.compaList.Location = new System.Drawing.Point(122, 21);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(271, 24);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(24, 24);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(95, 20);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัทต้นสังกัด";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.status.Location = new System.Drawing.Point(526, 64);
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
            this.statusList.Location = new System.Drawing.Point(639, 60);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(255, 24);
            this.statusList.TabIndex = 18;
            this.statusList.Text = " Active";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnsearch);
            this.pnlData.Controls.Add(this.dateOffList);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.Controls.Add(this.dateOff);
            this.pnlData.Controls.Add(this.fundCodeList);
            this.pnlData.Controls.Add(this.status);
            this.pnlData.Controls.Add(this.fundCode);
            this.pnlData.Controls.Add(this.fundName);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.Controls.Add(this.fundNameList);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnsearch.Location = new System.Drawing.Point(827, 108);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(84, 33);
            this.btnsearch.TabIndex = 19;
            this.btnsearch.Text = "ค้นหารายการ";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // FundList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlData);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FundList";
            this.Text = "FundList";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label compa;
        private System.Windows.Forms.ComboBox compaList;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Label fundCode;
        private System.Windows.Forms.TextBox fundCodeList;
        private System.Windows.Forms.DateTimePicker dateOffList;
        private System.Windows.Forms.Label dateOff;
        private System.Windows.Forms.TextBox fundNameList;
        private System.Windows.Forms.Label fundName;
        private System.Windows.Forms.Button btnsearch;
    }
}