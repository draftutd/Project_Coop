﻿namespace WPF1.Employee.UI
{
    partial class EmployeePopup
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
            this.positionList = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.Label();
            this.compaList = new System.Windows.Forms.ComboBox();
            this.compa = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.positionList);
            this.pnlData.Controls.Add(this.file);
            this.pnlData.Controls.Add(this.compaList);
            this.pnlData.Controls.Add(this.compa);
            this.pnlData.TabIndex = 0;
            // 
            // positionList
            // 
            this.positionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.positionList.Location = new System.Drawing.Point(103, 62);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(327, 22);
            this.positionList.TabIndex = 9;
            this.positionList.Text = " กรุณาเลือกไฟล์";
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.file.Location = new System.Drawing.Point(22, 62);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(51, 20);
            this.file.TabIndex = 0;
            this.file.Text = "ชื่อไฟล์";
            // 
            // compaList
            // 
            this.compaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(103, 20);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(327, 24);
            this.compaList.TabIndex = 10;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(22, 24);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(44, 20);
            this.compa.TabIndex = 11;
            this.compa.Text = "บริษัท";
            // 
            // EmployeePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Name = "EmployeePopup";
            this.Text = "EmployeePopup";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.TextBox positionList;
        private System.Windows.Forms.ComboBox compaList;
        private System.Windows.Forms.Label compa;
    }
}