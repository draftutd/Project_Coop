namespace WPF1
{
    partial class Form1_1
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
            this.file = new System.Windows.Forms.Label();
            this.positionList = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "เพิ่มรายการ";
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
            this.pnlData.Controls.Add(this.btnAdd);
            this.pnlData.Controls.Add(this.positionList);
            this.pnlData.Controls.Add(this.file);
            this.pnlData.Location = new System.Drawing.Point(17, 69);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(407, 108);
            this.pnlData.TabIndex = 1;
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(14, 42);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(40, 13);
            this.file.TabIndex = 0;
            this.file.Text = "ชื่อไฟล์";
            // 
            // positionList
            // 
            this.positionList.Location = new System.Drawing.Point(60, 39);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(228, 20);
            this.positionList.TabIndex = 9;
            this.positionList.Text = " กรุณาเลือกไฟล์";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(306, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 20);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "เลือกไฟล์";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 202);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.Name = "Form7";
            this.Text = "Form6";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox positionList;
    }
}