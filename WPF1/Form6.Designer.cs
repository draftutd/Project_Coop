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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btnSave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.positionList = new System.Windows.Forms.TextBox();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.statusemp = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.companyList = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลแผนกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลตำแหนงToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลพนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลกองทนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เงอนไขการสะสมเงนฝากToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เงอนไขการจายเงนคนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลNAVตอหนวยของกองทนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายการสะสมเงนฝากและจายคนเขาระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายการสะสมเงนฝากและจายคนแบบกลมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายการสะสมเงนฝากและจายคนแบบรายบคคลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.การจดสรรหนวยลงทนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.การเตรยมรายการจายเงนคนผานเชคToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.การเตรยมรายการจายเงนคนผานการโอนเงนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.การปรบปรงขอมลสำหรบการปดกองทนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlData.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Location = new System.Drawing.Point(38, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btncancel.Location = new System.Drawing.Point(128, 39);
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
            this.pnlData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pnlData.Location = new System.Drawing.Point(20, 86);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(516, 165);
            this.pnlData.TabIndex = 1;
            // 
            // positionList
            // 
            this.positionList.Location = new System.Drawing.Point(186, 65);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(285, 22);
            this.positionList.TabIndex = 9;
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(186, 100);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(285, 24);
            this.statusList.TabIndex = 8;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusemp.Location = new System.Drawing.Point(31, 100);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(84, 20);
            this.statusemp.TabIndex = 7;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.position.Location = new System.Drawing.Point(32, 65);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(76, 20);
            this.position.TabIndex = 5;
            this.position.Text = "ชื่อตำแหน่ง";
            // 
            // companyList
            // 
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(186, 30);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(285, 24);
            this.companyList.TabIndex = 1;
            this.companyList.Text = " ระบุเลือกบริษัท";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.company.Location = new System.Drawing.Point(31, 30);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(115, 20);
            this.company.TabIndex = 0;
            this.company.Text = "บริษัทต้นสังกัด (*)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลแผนกToolStripMenuItem,
            this.ขอมลตำแหนงToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masterToolStripMenuItem.Image")));
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // ขอมลแผนกToolStripMenuItem
            // 
            this.ขอมลแผนกToolStripMenuItem.Name = "ขอมลแผนกToolStripMenuItem";
            this.ขอมลแผนกToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ขอมลแผนกToolStripMenuItem.Text = "ข้อมูลแผนก";
            // 
            // ขอมลตำแหนงToolStripMenuItem
            // 
            this.ขอมลตำแหนงToolStripMenuItem.Name = "ขอมลตำแหนงToolStripMenuItem";
            this.ขอมลตำแหนงToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ขอมลตำแหนงToolStripMenuItem.Text = "ข้อมูลตำแหน่ง";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลพนกงานToolStripMenuItem,
            this.ขอมลกองทนToolStripMenuItem,
            this.เงอนไขการสะสมเงนฝากToolStripMenuItem,
            this.เงอนไขการจายเงนคนToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeToolStripMenuItem.Image")));
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(93, 21);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // ขอมลพนกงานToolStripMenuItem
            // 
            this.ขอมลพนกงานToolStripMenuItem.Name = "ขอมลพนกงานToolStripMenuItem";
            this.ขอมลพนกงานToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ขอมลพนกงานToolStripMenuItem.Text = "ข้อมูลพนักงาน";
            // 
            // ขอมลกองทนToolStripMenuItem
            // 
            this.ขอมลกองทนToolStripMenuItem.Name = "ขอมลกองทนToolStripMenuItem";
            this.ขอมลกองทนToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ขอมลกองทนToolStripMenuItem.Text = "ข้อมูลกองทุน";
            // 
            // เงอนไขการสะสมเงนฝากToolStripMenuItem
            // 
            this.เงอนไขการสะสมเงนฝากToolStripMenuItem.Name = "เงอนไขการสะสมเงนฝากToolStripMenuItem";
            this.เงอนไขการสะสมเงนฝากToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.เงอนไขการสะสมเงนฝากToolStripMenuItem.Text = "เงื่อนไขการสะสมเงินฝาก";
            // 
            // เงอนไขการจายเงนคนToolStripMenuItem
            // 
            this.เงอนไขการจายเงนคนToolStripMenuItem.Name = "เงอนไขการจายเงนคนToolStripMenuItem";
            this.เงอนไขการจายเงนคนToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.เงอนไขการจายเงนคนToolStripMenuItem.Text = "เงื่อนไขการจ่ายเงินคืน";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลNAVตอหนวยของกองทนToolStripMenuItem,
            this.รายการสะสมเงนฝากและจายคนเขาระบบToolStripMenuItem,
            this.รายการสะสมเงนฝากและจายคนแบบกลมToolStripMenuItem,
            this.รายการสะสมเงนฝากและจายคนแบบรายบคคลToolStripMenuItem,
            this.การจดสรรหนวยลงทนToolStripMenuItem,
            this.การเตรยมรายการจายเงนคนผานเชคToolStripMenuItem,
            this.การเตรยมรายการจายเงนคนผานการโอนเงนToolStripMenuItem,
            this.การปรบปรงขอมลสำหรบการปดกองทนToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transactionToolStripMenuItem.Image")));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // ขอมลNAVตอหนวยของกองทนToolStripMenuItem
            // 
            this.ขอมลNAVตอหนวยของกองทนToolStripMenuItem.Name = "ขอมลNAVตอหนวยของกองทนToolStripMenuItem";
            this.ขอมลNAVตอหนวยของกองทนToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.ขอมลNAVตอหนวยของกองทนToolStripMenuItem.Text = "ข้อมูล NAV ต่อหน่วยของกองทุน";
            // 
            // รายการสะสมเงนฝากและจายคนเขาระบบToolStripMenuItem
            // 
            this.รายการสะสมเงนฝากและจายคนเขาระบบToolStripMenuItem.Name = "รายการสะสมเงนฝากและจายคนเขาระบบToolStripMenuItem";
            this.รายการสะสมเงนฝากและจายคนเขาระบบToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.รายการสะสมเงนฝากและจายคนเขาระบบToolStripMenuItem.Text = "รายการสะสมเงินฝาก และจ่ายคืนเข้าระบบ";
            // 
            // รายการสะสมเงนฝากและจายคนแบบกลมToolStripMenuItem
            // 
            this.รายการสะสมเงนฝากและจายคนแบบกลมToolStripMenuItem.Name = "รายการสะสมเงนฝากและจายคนแบบกลมToolStripMenuItem";
            this.รายการสะสมเงนฝากและจายคนแบบกลมToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.รายการสะสมเงนฝากและจายคนแบบกลมToolStripMenuItem.Text = "รายการสะสมเงินฝาก และจ่ายคืนแบบกลุ่ม";
            // 
            // รายการสะสมเงนฝากและจายคนแบบรายบคคลToolStripMenuItem
            // 
            this.รายการสะสมเงนฝากและจายคนแบบรายบคคลToolStripMenuItem.Name = "รายการสะสมเงนฝากและจายคนแบบรายบคคลToolStripMenuItem";
            this.รายการสะสมเงนฝากและจายคนแบบรายบคคลToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.รายการสะสมเงนฝากและจายคนแบบรายบคคลToolStripMenuItem.Text = "รายการสะสมเงินฝาก และจ่ายคืนแบบรายบุคคล";
            // 
            // การจดสรรหนวยลงทนToolStripMenuItem
            // 
            this.การจดสรรหนวยลงทนToolStripMenuItem.Name = "การจดสรรหนวยลงทนToolStripMenuItem";
            this.การจดสรรหนวยลงทนToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.การจดสรรหนวยลงทนToolStripMenuItem.Text = "การจัดสรรหน่วยลงทุน";
            // 
            // การเตรยมรายการจายเงนคนผานเชคToolStripMenuItem
            // 
            this.การเตรยมรายการจายเงนคนผานเชคToolStripMenuItem.Name = "การเตรยมรายการจายเงนคนผานเชคToolStripMenuItem";
            this.การเตรยมรายการจายเงนคนผานเชคToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.การเตรยมรายการจายเงนคนผานเชคToolStripMenuItem.Text = "การเตรียมรายการจ่ายเงินคืนผ่านเช็ค";
            // 
            // การเตรยมรายการจายเงนคนผานการโอนเงนToolStripMenuItem
            // 
            this.การเตรยมรายการจายเงนคนผานการโอนเงนToolStripMenuItem.Name = "การเตรยมรายการจายเงนคนผานการโอนเงนToolStripMenuItem";
            this.การเตรยมรายการจายเงนคนผานการโอนเงนToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.การเตรยมรายการจายเงนคนผานการโอนเงนToolStripMenuItem.Text = "การเตรียมรายการจ่ายเงินคืนผ่านการโอนเงิน";
            // 
            // การปรบปรงขอมลสำหรบการปดกองทนToolStripMenuItem
            // 
            this.การปรบปรงขอมลสำหรบการปดกองทนToolStripMenuItem.Name = "การปรบปรงขอมลสำหรบการปดกองทนToolStripMenuItem";
            this.การปรบปรงขอมลสำหรบการปดกองทนToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.การปรบปรงขอมลสำหรบการปดกองทนToolStripMenuItem.Text = "การปรับปรุงข้อมูลสำหรับการปิดกองทุน";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaiToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("languageToolStripMenuItem.Image")));
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(93, 21);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // thaiToolStripMenuItem
            // 
            this.thaiToolStripMenuItem.Name = "thaiToolStripMenuItem";
            this.thaiToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.thaiToolStripMenuItem.Text = "Thai";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form6";
            this.Text = "Form6";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลแผนกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลตำแหนงToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลพนกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลกองทนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เงอนไขการสะสมเงนฝากToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เงอนไขการจายเงนคนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลNAVตอหนวยของกองทนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายการสะสมเงนฝากและจายคนเขาระบบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายการสะสมเงนฝากและจายคนแบบกลมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายการสะสมเงนฝากและจายคนแบบรายบคคลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem การจดสรรหนวยลงทนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem การเตรยมรายการจายเงนคนผานเชคToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem การเตรยมรายการจายเงนคนผานการโอนเงนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem การปรบปรงขอมลสำหรบการปดกองทนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}