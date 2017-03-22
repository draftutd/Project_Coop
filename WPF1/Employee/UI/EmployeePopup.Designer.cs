namespace WPF1
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
            this.SuspendLayout();
            // 
            // positionList
            // 
            this.positionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.positionList.Location = new System.Drawing.Point(103, 68);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(324, 22);
            this.positionList.TabIndex = 9;
            this.positionList.Text = " กรุณาเลือกไฟล์";
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.file.Location = new System.Drawing.Point(22, 68);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(51, 20);
            this.file.TabIndex = 0;
            this.file.Text = "ชื่อไฟล์";
            // 
            // compaList
            // 
            this.compaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compaList.FormattingEnabled = true;
            this.compaList.Location = new System.Drawing.Point(103, 26);
            this.compaList.Name = "compaList";
            this.compaList.Size = new System.Drawing.Size(324, 24);
            this.compaList.TabIndex = 10;
            this.compaList.Text = " ระบุเลือกบริษัท";
            // 
            // compa
            // 
            this.compa.AutoSize = true;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.compa.Location = new System.Drawing.Point(22, 30);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(44, 20);
            this.compa.TabIndex = 11;
            this.compa.Text = "บริษัท";
            // 
            // EmployeePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 217);
            this.Controls.Add(this.compaList);
            this.Controls.Add(this.compa);
            this.Controls.Add(this.positionList);
            this.Controls.Add(this.file);
            this.Name = "EmployeePopup";
            this.Text = "EmployeePopup";
            this.Load += new System.EventHandler(this.Form1_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.TextBox positionList;
        private System.Windows.Forms.ComboBox compaList;
        private System.Windows.Forms.Label compa;
    }
}