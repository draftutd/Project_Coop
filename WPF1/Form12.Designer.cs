namespace WPF1
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.btnSave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.orderList = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.Label();
            this.reserve2List = new System.Windows.Forms.TextBox();
            this.reserve2 = new System.Windows.Forms.Label();
            this.reserve1List = new System.Windows.Forms.TextBox();
            this.reserve1 = new System.Windows.Forms.Label();
            this.ageWork2List = new System.Windows.Forms.TextBox();
            this.ageWork2 = new System.Windows.Forms.Label();
            this.ageWork1List = new System.Windows.Forms.TextBox();
            this.ageWork1 = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.positionList = new System.Windows.Forms.ComboBox();
            this.branchList = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.conditionList = new System.Windows.Forms.TextBox();
            this.condition = new System.Windows.Forms.Label();
            this.codeConditionList = new System.Windows.Forms.TextBox();
            this.statusemp = new System.Windows.Forms.Label();
            this.codeCondition = new System.Windows.Forms.Label();
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
            this.btnSave.Location = new System.Drawing.Point(35, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btncancel.Location = new System.Drawing.Point(125, 38);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 33);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "ยกเลิก";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.orderList);
            this.pnlData.Controls.Add(this.order);
            this.pnlData.Controls.Add(this.reserve2List);
            this.pnlData.Controls.Add(this.reserve2);
            this.pnlData.Controls.Add(this.reserve1List);
            this.pnlData.Controls.Add(this.reserve1);
            this.pnlData.Controls.Add(this.ageWork2List);
            this.pnlData.Controls.Add(this.ageWork2);
            this.pnlData.Controls.Add(this.ageWork1List);
            this.pnlData.Controls.Add(this.ageWork1);
            this.pnlData.Controls.Add(this.statusList);
            this.pnlData.Controls.Add(this.positionList);
            this.pnlData.Controls.Add(this.branchList);
            this.pnlData.Controls.Add(this.position);
            this.pnlData.Controls.Add(this.branch);
            this.pnlData.Controls.Add(this.conditionList);
            this.pnlData.Controls.Add(this.condition);
            this.pnlData.Controls.Add(this.codeConditionList);
            this.pnlData.Controls.Add(this.statusemp);
            this.pnlData.Controls.Add(this.codeCondition);
            this.pnlData.Controls.Add(this.companyList);
            this.pnlData.Controls.Add(this.company);
            this.pnlData.Location = new System.Drawing.Point(17, 85);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(951, 276);
            this.pnlData.TabIndex = 1;
            this.pnlData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlData_Paint);
            // 
            // orderList
            // 
            this.orderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.orderList.Location = new System.Drawing.Point(640, 186);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(294, 22);
            this.orderList.TabIndex = 27;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.order.Location = new System.Drawing.Point(497, 188);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(109, 20);
            this.order.TabIndex = 26;
            this.order.Text = "ลำดับการคำนวณ";
            // 
            // reserve2List
            // 
            this.reserve2List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.reserve2List.Location = new System.Drawing.Point(640, 144);
            this.reserve2List.Name = "reserve2List";
            this.reserve2List.Size = new System.Drawing.Size(294, 22);
            this.reserve2List.TabIndex = 25;
            // 
            // reserve2
            // 
            this.reserve2.AutoSize = true;
            this.reserve2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.reserve2.Location = new System.Drawing.Point(497, 144);
            this.reserve2.Name = "reserve2";
            this.reserve2.Size = new System.Drawing.Size(89, 20);
            this.reserve2.TabIndex = 24;
            this.reserve2.Text = "จำนวนเงินคืน\r\n";
            // 
            // reserve1List
            // 
            this.reserve1List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.reserve1List.Location = new System.Drawing.Point(640, 106);
            this.reserve1List.Name = "reserve1List";
            this.reserve1List.Size = new System.Drawing.Size(294, 22);
            this.reserve1List.TabIndex = 23;
            // 
            // reserve1
            // 
            this.reserve1.AutoSize = true;
            this.reserve1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.reserve1.Location = new System.Drawing.Point(497, 106);
            this.reserve1.Name = "reserve1";
            this.reserve1.Size = new System.Drawing.Size(112, 20);
            this.reserve1.TabIndex = 22;
            this.reserve1.Text = "เปอร์เซ็นต์เงินคืน";
            // 
            // ageWork2List
            // 
            this.ageWork2List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ageWork2List.Location = new System.Drawing.Point(640, 68);
            this.ageWork2List.Name = "ageWork2List";
            this.ageWork2List.Size = new System.Drawing.Size(294, 22);
            this.ageWork2List.TabIndex = 21;
            // 
            // ageWork2
            // 
            this.ageWork2.AutoSize = true;
            this.ageWork2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ageWork2.Location = new System.Drawing.Point(497, 68);
            this.ageWork2.Name = "ageWork2";
            this.ageWork2.Size = new System.Drawing.Size(94, 20);
            this.ageWork2.TabIndex = 20;
            this.ageWork2.Text = "อายุงานถึง (ปี)";
            // 
            // ageWork1List
            // 
            this.ageWork1List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ageWork1List.Location = new System.Drawing.Point(640, 30);
            this.ageWork1List.Name = "ageWork1List";
            this.ageWork1List.Size = new System.Drawing.Size(294, 22);
            this.ageWork1List.TabIndex = 19;
            // 
            // ageWork1
            // 
            this.ageWork1.AutoSize = true;
            this.ageWork1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ageWork1.Location = new System.Drawing.Point(497, 30);
            this.ageWork1.Name = "ageWork1";
            this.ageWork1.Size = new System.Drawing.Size(112, 20);
            this.ageWork1.TabIndex = 18;
            this.ageWork1.Text = "อายุงานตั่งแต่ (ปี)";
            // 
            // statusList
            // 
            this.statusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            " (1) Status = \'Active\'",
            " (2) Status = \'Inactive\'"});
            this.statusList.Location = new System.Drawing.Point(174, 224);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(293, 24);
            this.statusList.TabIndex = 17;
            this.statusList.Text = " (1) Status = \'Active\'";
            // 
            // positionList
            // 
            this.positionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.positionList.FormattingEnabled = true;
            this.positionList.Location = new System.Drawing.Point(174, 183);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(293, 24);
            this.positionList.TabIndex = 16;
            // 
            // branchList
            // 
            this.branchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.branchList.FormattingEnabled = true;
            this.branchList.Location = new System.Drawing.Point(174, 144);
            this.branchList.Name = "branchList";
            this.branchList.Size = new System.Drawing.Size(293, 24);
            this.branchList.TabIndex = 15;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.position.Location = new System.Drawing.Point(31, 186);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(59, 20);
            this.position.TabIndex = 14;
            this.position.Text = "ตำแหน่ง";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.branch.Location = new System.Drawing.Point(31, 147);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(45, 20);
            this.branch.TabIndex = 12;
            this.branch.Text = "แผนก";
            // 
            // conditionList
            // 
            this.conditionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.conditionList.Location = new System.Drawing.Point(174, 106);
            this.conditionList.Name = "conditionList";
            this.conditionList.Size = new System.Drawing.Size(293, 22);
            this.conditionList.TabIndex = 11;
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.condition.Location = new System.Drawing.Point(31, 109);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(75, 20);
            this.condition.TabIndex = 10;
            this.condition.Text = "เงื่อนไข (*)";
            // 
            // codeConditionList
            // 
            this.codeConditionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeConditionList.Location = new System.Drawing.Point(174, 68);
            this.codeConditionList.Name = "codeConditionList";
            this.codeConditionList.Size = new System.Drawing.Size(293, 22);
            this.codeConditionList.TabIndex = 9;
            // 
            // statusemp
            // 
            this.statusemp.AutoSize = true;
            this.statusemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusemp.Location = new System.Drawing.Point(31, 227);
            this.statusemp.Name = "statusemp";
            this.statusemp.Size = new System.Drawing.Size(84, 20);
            this.statusemp.TabIndex = 7;
            this.statusemp.Text = "สถานะข้อมูล";
            // 
            // codeCondition
            // 
            this.codeCondition.AutoSize = true;
            this.codeCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.codeCondition.Location = new System.Drawing.Point(31, 71);
            this.codeCondition.Name = "codeCondition";
            this.codeCondition.Size = new System.Drawing.Size(99, 20);
            this.codeCondition.TabIndex = 5;
            this.codeCondition.Text = "รหัสเงื่อนไข (*)";
            // 
            // companyList
            // 
            this.companyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.companyList.FormattingEnabled = true;
            this.companyList.Location = new System.Drawing.Point(174, 27);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(293, 24);
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
            this.menuStrip1.TabIndex = 23;
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
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btncancel);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form12";
            this.Text = "Form12";
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
        private System.Windows.Forms.Label codeCondition;
        private System.Windows.Forms.Label statusemp;
        private System.Windows.Forms.TextBox codeConditionList;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.TextBox conditionList;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.ComboBox positionList;
        private System.Windows.Forms.ComboBox branchList;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.TextBox ageWork2List;
        private System.Windows.Forms.Label ageWork2;
        private System.Windows.Forms.TextBox ageWork1List;
        private System.Windows.Forms.Label ageWork1;
        private System.Windows.Forms.TextBox orderList;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.TextBox reserve2List;
        private System.Windows.Forms.Label reserve2;
        private System.Windows.Forms.TextBox reserve1List;
        private System.Windows.Forms.Label reserve1;
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