namespace WPF1
{
    partial class Employeelist
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
            this.statusList = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.codeNameList = new System.Windows.Forms.TextBox();
            this.codeName = new System.Windows.Forms.Label();
            this.branchList = new System.Windows.Forms.ComboBox();
            this.branch = new System.Windows.Forms.Label();
            this.perName = new System.Windows.Forms.Label();
            this.positList = new System.Windows.Forms.ComboBox();
            this.posit = new System.Windows.Forms.Label();
            this.compa = new System.Windows.Forms.Label();
            this.compaList = new System.Windows.Forms.ComboBox();
            this.perList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusList
            // 
            this.statusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(602, 115);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(161, 24);
            this.statusList.TabIndex = 18;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.status.Location = new System.Drawing.Point(495, 119);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(100, 20);
            this.status.TabIndex = 17;
            this.status.Text = "สถานะพนักงาน";
            // 
            // codeNameList
            // 
            this.codeNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeNameList.Location = new System.Drawing.Point(602, 71);
            this.codeNameList.Name = "codeNameList";
            this.codeNameList.Size = new System.Drawing.Size(324, 22);
            this.codeNameList.TabIndex = 16;
            // 
            // codeName
            // 
            this.codeName.AutoSize = true;
            this.codeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeName.Location = new System.Drawing.Point(495, 74);
            this.codeName.Name = "codeName";
            this.codeName.Size = new System.Drawing.Size(84, 20);
            this.codeName.TabIndex = 15;
            this.codeName.Text = "รหัสพนักงาน";
            // 
            // branchList
            // 
            this.branchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.branchList.FormattingEnabled = true;
            this.branchList.Location = new System.Drawing.Point(602, 27);
            this.branchList.Name = "branchList";
            this.branchList.Size = new System.Drawing.Size(324, 24);
            this.branchList.TabIndex = 14;
            this.branchList.Text = "ระบุเลือกแผนกต้นสังกัด";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.branch.Location = new System.Drawing.Point(495, 30);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(78, 20);
            this.branch.TabIndex = 13;
            this.branch.Text = "สังกัดแผนก";
            // 
            // perName
            // 
            this.perName.AutoSize = true;
            this.perName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.perName.Location = new System.Drawing.Point(24, 115);
            this.perName.Name = "perName";
            this.perName.Size = new System.Drawing.Size(77, 20);
            this.perName.TabIndex = 12;
            this.perName.Text = "ชื่อพนักงาน";
            // 
            // positList
            // 
            this.positList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.positList.FormattingEnabled = true;
            this.positList.Location = new System.Drawing.Point(105, 73);
            this.positList.Name = "positList";
            this.positList.Size = new System.Drawing.Size(324, 24);
            this.positList.TabIndex = 11;
            this.positList.Text = " ระบุเลือกตำแหน่ง";
            // 
            // posit
            // 
            this.posit.AutoSize = true;
            this.posit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.posit.Location = new System.Drawing.Point(24, 73);
            this.posit.Name = "posit";
            this.posit.Size = new System.Drawing.Size(59, 20);
            this.posit.TabIndex = 10;
            this.posit.Text = "ตำแหน่ง";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(24, 30);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(44, 20);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัท";
            // 
            // compaList
            // 
            this.compaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(105, 30);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(324, 24);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // perList
            // 
            this.perList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.perList.Location = new System.Drawing.Point(105, 112);
            this.perList.Name = "perList";
            this.perList.Size = new System.Drawing.Size(324, 22);
            this.perList.TabIndex = 7;
            // 
            // Employeelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.perList);
            this.Controls.Add(this.compaList);
            this.Controls.Add(this.compa);
            this.Controls.Add(this.posit);
            this.Controls.Add(this.positList);
            this.Controls.Add(this.perName);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.branchList);
            this.Controls.Add(this.codeName);
            this.Controls.Add(this.codeNameList);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusList);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Employeelist";
            this.Text = "Employeelist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox codeNameList;
        private System.Windows.Forms.Label codeName;
        private System.Windows.Forms.ComboBox branchList;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label perName;
        private System.Windows.Forms.ComboBox positList;
        private System.Windows.Forms.Label posit;
        private System.Windows.Forms.Label compa;
        private System.Windows.Forms.ComboBox compaList;
        private System.Windows.Forms.TextBox perList;
    }
}