﻿namespace WPF1.Fund.UI
{
    partial class DepositList
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
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusList
            // 
            this.statusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " Active",
            " Inactive"});
            this.statusList.Location = new System.Drawing.Point(611, 106);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(210, 24);
            this.statusList.TabIndex = 39;
            this.statusList.Text = " Active";
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusemp.Location = new System.Drawing.Point(485, 106);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(84, 20);
            this.statusemp.TabIndex = 38;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // ageWork2List
            // 
            this.ageWork2List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ageWork2List.Location = new System.Drawing.Point(611, 78);
            this.ageWork2List.Name = "ageWork2List";
            this.ageWork2List.Size = new System.Drawing.Size(282, 22);
            this.ageWork2List.TabIndex = 37;
            // 
            // ageWork2
            // 
            this.ageWork2.AutoSize = true;
            this.ageWork2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ageWork2.Location = new System.Drawing.Point(485, 78);
            this.ageWork2.Name = "ageWork2";
            this.ageWork2.Size = new System.Drawing.Size(94, 20);
            this.ageWork2.TabIndex = 36;
            this.ageWork2.Text = "อายุงานถึง (ปี)";
            // 
            // ageWork1List
            // 
            this.ageWork1List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ageWork1List.Location = new System.Drawing.Point(611, 50);
            this.ageWork1List.Name = "ageWork1List";
            this.ageWork1List.Size = new System.Drawing.Size(282, 22);
            this.ageWork1List.TabIndex = 35;
            // 
            // ageWork1
            // 
            this.ageWork1.AutoSize = true;
            this.ageWork1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ageWork1.Location = new System.Drawing.Point(485, 50);
            this.ageWork1.Name = "ageWork1";
            this.ageWork1.Size = new System.Drawing.Size(112, 20);
            this.ageWork1.TabIndex = 34;
            this.ageWork1.Text = "อายุงานตั่งแต่ (ปี)";
            // 
            // positionList
            // 
            this.positionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.positionList.FormattingEnabled = true;
            this.positionList.Location = new System.Drawing.Point(611, 20);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(282, 24);
            this.positionList.TabIndex = 33;
            // 
            // branchList
            // 
            this.branchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.branchList.FormattingEnabled = true;
            this.branchList.Location = new System.Drawing.Point(141, 106);
            this.branchList.Name = "branchList";
            this.branchList.Size = new System.Drawing.Size(282, 24);
            this.branchList.TabIndex = 32;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.position.Location = new System.Drawing.Point(485, 20);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(59, 20);
            this.position.TabIndex = 31;
            this.position.Text = "ตำแหน่ง";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.branch.Location = new System.Drawing.Point(15, 106);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(45, 20);
            this.branch.TabIndex = 30;
            this.branch.Text = "แผนก";
            // 
            // conditionList
            // 
            this.conditionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.conditionList.Location = new System.Drawing.Point(141, 78);
            this.conditionList.Name = "conditionList";
            this.conditionList.Size = new System.Drawing.Size(282, 22);
            this.conditionList.TabIndex = 29;
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.condition.Location = new System.Drawing.Point(15, 78);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(75, 20);
            this.condition.TabIndex = 28;
            this.condition.Text = "เงื่อนไข (*)";
            // 
            // codeConditionList
            // 
            this.codeConditionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeConditionList.Location = new System.Drawing.Point(142, 50);
            this.codeConditionList.Name = "codeConditionList";
            this.codeConditionList.Size = new System.Drawing.Size(281, 22);
            this.codeConditionList.TabIndex = 27;
            // 
            // codeCondition
            // 
            this.codeCondition.AutoSize = true;
            this.codeCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeCondition.Location = new System.Drawing.Point(15, 50);
            this.codeCondition.Name = "codeCondition";
            this.codeCondition.Size = new System.Drawing.Size(99, 20);
            this.codeCondition.TabIndex = 26;
            this.codeCondition.Text = "รหัสเงื่อนไข (*)";
            // 
            // compaList
            // 
            this.compaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(141, 20);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(282, 24);
            this.compaList.TabIndex = 8;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(15, 20);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(95, 20);
            this.compa.TabIndex = 9;
            this.compa.Text = "บริษัทต้นสังกัด";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.statusemp);
            this.pnlData.Controls.Add(this.branch);
            this.pnlData.Controls.Add(this.ageWork2List);
            this.pnlData.Controls.Add(this.position);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.Controls.Add(this.conditionList);
            this.pnlData.Controls.Add(this.ageWork2);
            this.pnlData.Controls.Add(this.branchList);
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.Controls.Add(this.condition);
            this.pnlData.Controls.Add(this.ageWork1List);
            this.pnlData.Controls.Add(this.positionList);
            this.pnlData.Controls.Add(this.codeCondition);
            this.pnlData.Controls.Add(this.codeConditionList);
            this.pnlData.Controls.Add(this.ageWork1);
            // 
            // DepositList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlData);
            this.Name = "DepositList";
            this.Text = "DepositList";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label compa;
        private System.Windows.Forms.ComboBox compaList;
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