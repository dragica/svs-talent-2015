namespace BankSystemExample
{
    partial class frmMain
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
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLimitCurrency = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblPeriodUnitOfTime = new System.Windows.Forms.Label();
            this.lblPercentUnitOfTime = new System.Windows.Forms.Label();
            this.cbPeriodUnitOfTime = new System.Windows.Forms.ComboBox();
            this.cbInterestUnitOfTime = new System.Windows.Forms.ComboBox();
            this.lblDisplayId = new System.Windows.Forms.Label();
            this.lblDisplayNumber = new System.Windows.Forms.Label();
            this.lblDisplayCurrency = new System.Windows.Forms.Label();
            this.lblDisplayBalance = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblDisplayLimit = new System.Windows.Forms.Label();
            this.lblDisplayPeriod = new System.Windows.Forms.Label();
            this.lblDisplayInterest = new System.Windows.Forms.Label();
            this.lblDisplayStart = new System.Windows.Forms.Label();
            this.lblDisplayEnd = new System.Windows.Forms.Label();
            this.lbl_DisplayToEndDate = new System.Windows.Forms.Label();
            this.lbl_DisplayToStartDate = new System.Windows.Forms.Label();
            this.lbl_DisplayToInterest = new System.Windows.Forms.Label();
            this.lbl_DisplayToPeriod = new System.Windows.Forms.Label();
            this.lbl_DisplayToLimit = new System.Windows.Forms.Label();
            this.lbl_DisplayToBalance = new System.Windows.Forms.Label();
            this.lbl_DisplayToCurrency = new System.Windows.Forms.Label();
            this.lbl_DisplayToNumber = new System.Windows.Forms.Label();
            this.lbl_DisplayToId = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_ToEndDate = new System.Windows.Forms.Label();
            this.lbl_ToStartDate = new System.Windows.Forms.Label();
            this.lbl_ToInterest = new System.Windows.Forms.Label();
            this.lbl_ToPeriod = new System.Windows.Forms.Label();
            this.lbl_ToLimit = new System.Windows.Forms.Label();
            this.lbl_ToBalance = new System.Windows.Forms.Label();
            this.lbl_ToCurrency = new System.Windows.Forms.Label();
            this.lbl_ToNumber = new System.Windows.Forms.Label();
            this.lbl_ToId = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.lbl_ToDetails = new System.Windows.Forms.Label();
            this.btnMakeGroupTransaction = new System.Windows.Forms.Button();
            this.lblTotalTransactionCount = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(78, 182);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(149, 25);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(278, 185);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(149, 22);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(115, 51);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(58, 20);
            this.txtCurrency.TabIndex = 2;
            this.txtCurrency.Text = "MKD";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(115, 73);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(58, 20);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account Currency:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Limit: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create a Transaction Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(278, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Create a Deposit Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Period Duration:";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(367, 43);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(45, 20);
            this.txtPeriod.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "and the associated unit of time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Interest rate:";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(350, 73);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(60, 20);
            this.txtInterest.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "and the corresponding unit of time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Enter the Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(388, 95);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Enter the End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(385, 123);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(72, 263);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 20;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(89, 286);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 21;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(96, 311);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblCurrency.TabIndex = 22;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(99, 340);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 23;
            // 
            // lblLimitCurrency
            // 
            this.lblLimitCurrency.AutoSize = true;
            this.lblLimitCurrency.Location = new System.Drawing.Point(118, 367);
            this.lblLimitCurrency.Name = "lblLimitCurrency";
            this.lblLimitCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurrency.TabIndex = 25;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(351, 311);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblStartDate.TabIndex = 28;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(345, 340);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblEndDate.TabIndex = 29;
            // 
            // lblPeriodUnitOfTime
            // 
            this.lblPeriodUnitOfTime.AutoSize = true;
            this.lblPeriodUnitOfTime.Location = new System.Drawing.Point(379, 262);
            this.lblPeriodUnitOfTime.Name = "lblPeriodUnitOfTime";
            this.lblPeriodUnitOfTime.Size = new System.Drawing.Size(0, 13);
            this.lblPeriodUnitOfTime.TabIndex = 30;
            // 
            // lblPercentUnitOfTime
            // 
            this.lblPercentUnitOfTime.AutoSize = true;
            this.lblPercentUnitOfTime.Location = new System.Drawing.Point(365, 286);
            this.lblPercentUnitOfTime.Name = "lblPercentUnitOfTime";
            this.lblPercentUnitOfTime.Size = new System.Drawing.Size(0, 13);
            this.lblPercentUnitOfTime.TabIndex = 31;
            // 
            // cbPeriodUnitOfTime
            // 
            this.cbPeriodUnitOfTime.FormattingEnabled = true;
            this.cbPeriodUnitOfTime.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.cbPeriodUnitOfTime.Location = new System.Drawing.Point(578, 43);
            this.cbPeriodUnitOfTime.Name = "cbPeriodUnitOfTime";
            this.cbPeriodUnitOfTime.Size = new System.Drawing.Size(66, 21);
            this.cbPeriodUnitOfTime.TabIndex = 32;
            // 
            // cbInterestUnitOfTime
            // 
            this.cbInterestUnitOfTime.FormattingEnabled = true;
            this.cbInterestUnitOfTime.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.cbInterestUnitOfTime.Location = new System.Drawing.Point(594, 72);
            this.cbInterestUnitOfTime.Name = "cbInterestUnitOfTime";
            this.cbInterestUnitOfTime.Size = new System.Drawing.Size(64, 21);
            this.cbInterestUnitOfTime.TabIndex = 33;
            // 
            // lblDisplayId
            // 
            this.lblDisplayId.AutoSize = true;
            this.lblDisplayId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayId.Location = new System.Drawing.Point(28, 263);
            this.lblDisplayId.Name = "lblDisplayId";
            this.lblDisplayId.Size = new System.Drawing.Size(28, 13);
            this.lblDisplayId.TabIndex = 34;
            this.lblDisplayId.Text = " ID:";
            // 
            // lblDisplayNumber
            // 
            this.lblDisplayNumber.AutoSize = true;
            this.lblDisplayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayNumber.Location = new System.Drawing.Point(29, 286);
            this.lblDisplayNumber.Name = "lblDisplayNumber";
            this.lblDisplayNumber.Size = new System.Drawing.Size(54, 13);
            this.lblDisplayNumber.TabIndex = 35;
            this.lblDisplayNumber.Text = "Number:";
            // 
            // lblDisplayCurrency
            // 
            this.lblDisplayCurrency.AutoSize = true;
            this.lblDisplayCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayCurrency.Location = new System.Drawing.Point(29, 311);
            this.lblDisplayCurrency.Name = "lblDisplayCurrency";
            this.lblDisplayCurrency.Size = new System.Drawing.Size(61, 13);
            this.lblDisplayCurrency.TabIndex = 36;
            this.lblDisplayCurrency.Text = "Currency:";
            // 
            // lblDisplayBalance
            // 
            this.lblDisplayBalance.AutoSize = true;
            this.lblDisplayBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayBalance.Location = new System.Drawing.Point(29, 340);
            this.lblDisplayBalance.Name = "lblDisplayBalance";
            this.lblDisplayBalance.Size = new System.Drawing.Size(57, 13);
            this.lblDisplayBalance.TabIndex = 37;
            this.lblDisplayBalance.Text = "Balance:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetails.Location = new System.Drawing.Point(28, 227);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(48, 15);
            this.lblDetails.TabIndex = 38;
            this.lblDetails.Text = "Details:";
            this.lblDetails.Visible = false;
            // 
            // lblDisplayLimit
            // 
            this.lblDisplayLimit.AutoSize = true;
            this.lblDisplayLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayLimit.Location = new System.Drawing.Point(29, 367);
            this.lblDisplayLimit.Name = "lblDisplayLimit";
            this.lblDisplayLimit.Size = new System.Drawing.Size(83, 13);
            this.lblDisplayLimit.TabIndex = 39;
            this.lblDisplayLimit.Text = "Limit Amount:";
            // 
            // lblDisplayPeriod
            // 
            this.lblDisplayPeriod.AutoSize = true;
            this.lblDisplayPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayPeriod.Location = new System.Drawing.Point(275, 262);
            this.lblDisplayPeriod.Name = "lblDisplayPeriod";
            this.lblDisplayPeriod.Size = new System.Drawing.Size(99, 13);
            this.lblDisplayPeriod.TabIndex = 40;
            this.lblDisplayPeriod.Text = "Period Duration:";
            // 
            // lblDisplayInterest
            // 
            this.lblDisplayInterest.AutoSize = true;
            this.lblDisplayInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayInterest.Location = new System.Drawing.Point(275, 286);
            this.lblDisplayInterest.Name = "lblDisplayInterest";
            this.lblDisplayInterest.Size = new System.Drawing.Size(85, 13);
            this.lblDisplayInterest.TabIndex = 41;
            this.lblDisplayInterest.Text = "Interest Rate:";
            // 
            // lblDisplayStart
            // 
            this.lblDisplayStart.AutoSize = true;
            this.lblDisplayStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayStart.Location = new System.Drawing.Point(276, 311);
            this.lblDisplayStart.Name = "lblDisplayStart";
            this.lblDisplayStart.Size = new System.Drawing.Size(69, 13);
            this.lblDisplayStart.TabIndex = 42;
            this.lblDisplayStart.Text = "Start Date:";
            // 
            // lblDisplayEnd
            // 
            this.lblDisplayEnd.AutoSize = true;
            this.lblDisplayEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayEnd.Location = new System.Drawing.Point(275, 340);
            this.lblDisplayEnd.Name = "lblDisplayEnd";
            this.lblDisplayEnd.Size = new System.Drawing.Size(64, 13);
            this.lblDisplayEnd.TabIndex = 43;
            this.lblDisplayEnd.Text = "End Date:";
            // 
            // lbl_DisplayToEndDate
            // 
            this.lbl_DisplayToEndDate.AutoSize = true;
            this.lbl_DisplayToEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToEndDate.Location = new System.Drawing.Point(280, 580);
            this.lbl_DisplayToEndDate.Name = "lbl_DisplayToEndDate";
            this.lbl_DisplayToEndDate.Size = new System.Drawing.Size(64, 13);
            this.lbl_DisplayToEndDate.TabIndex = 64;
            this.lbl_DisplayToEndDate.Text = "End Date:";
            // 
            // lbl_DisplayToStartDate
            // 
            this.lbl_DisplayToStartDate.AutoSize = true;
            this.lbl_DisplayToStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToStartDate.Location = new System.Drawing.Point(281, 551);
            this.lbl_DisplayToStartDate.Name = "lbl_DisplayToStartDate";
            this.lbl_DisplayToStartDate.Size = new System.Drawing.Size(69, 13);
            this.lbl_DisplayToStartDate.TabIndex = 63;
            this.lbl_DisplayToStartDate.Text = "Start Date:";
            // 
            // lbl_DisplayToInterest
            // 
            this.lbl_DisplayToInterest.AutoSize = true;
            this.lbl_DisplayToInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToInterest.Location = new System.Drawing.Point(280, 526);
            this.lbl_DisplayToInterest.Name = "lbl_DisplayToInterest";
            this.lbl_DisplayToInterest.Size = new System.Drawing.Size(85, 13);
            this.lbl_DisplayToInterest.TabIndex = 62;
            this.lbl_DisplayToInterest.Text = "Interest Rate:";
            // 
            // lbl_DisplayToPeriod
            // 
            this.lbl_DisplayToPeriod.AutoSize = true;
            this.lbl_DisplayToPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToPeriod.Location = new System.Drawing.Point(280, 502);
            this.lbl_DisplayToPeriod.Name = "lbl_DisplayToPeriod";
            this.lbl_DisplayToPeriod.Size = new System.Drawing.Size(99, 13);
            this.lbl_DisplayToPeriod.TabIndex = 61;
            this.lbl_DisplayToPeriod.Text = "Period Duration:";
            // 
            // lbl_DisplayToLimit
            // 
            this.lbl_DisplayToLimit.AutoSize = true;
            this.lbl_DisplayToLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToLimit.Location = new System.Drawing.Point(28, 582);
            this.lbl_DisplayToLimit.Name = "lbl_DisplayToLimit";
            this.lbl_DisplayToLimit.Size = new System.Drawing.Size(83, 13);
            this.lbl_DisplayToLimit.TabIndex = 60;
            this.lbl_DisplayToLimit.Text = "Limit Amount:";
            // 
            // lbl_DisplayToBalance
            // 
            this.lbl_DisplayToBalance.AutoSize = true;
            this.lbl_DisplayToBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToBalance.Location = new System.Drawing.Point(28, 555);
            this.lbl_DisplayToBalance.Name = "lbl_DisplayToBalance";
            this.lbl_DisplayToBalance.Size = new System.Drawing.Size(57, 13);
            this.lbl_DisplayToBalance.TabIndex = 59;
            this.lbl_DisplayToBalance.Text = "Balance:";
            // 
            // lbl_DisplayToCurrency
            // 
            this.lbl_DisplayToCurrency.AutoSize = true;
            this.lbl_DisplayToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToCurrency.Location = new System.Drawing.Point(28, 526);
            this.lbl_DisplayToCurrency.Name = "lbl_DisplayToCurrency";
            this.lbl_DisplayToCurrency.Size = new System.Drawing.Size(61, 13);
            this.lbl_DisplayToCurrency.TabIndex = 58;
            this.lbl_DisplayToCurrency.Text = "Currency:";
            // 
            // lbl_DisplayToNumber
            // 
            this.lbl_DisplayToNumber.AutoSize = true;
            this.lbl_DisplayToNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToNumber.Location = new System.Drawing.Point(28, 501);
            this.lbl_DisplayToNumber.Name = "lbl_DisplayToNumber";
            this.lbl_DisplayToNumber.Size = new System.Drawing.Size(54, 13);
            this.lbl_DisplayToNumber.TabIndex = 57;
            this.lbl_DisplayToNumber.Text = "Number:";
            // 
            // lbl_DisplayToId
            // 
            this.lbl_DisplayToId.AutoSize = true;
            this.lbl_DisplayToId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DisplayToId.Location = new System.Drawing.Point(27, 478);
            this.lbl_DisplayToId.Name = "lbl_DisplayToId";
            this.lbl_DisplayToId.Size = new System.Drawing.Size(28, 13);
            this.lbl_DisplayToId.TabIndex = 56;
            this.lbl_DisplayToId.Text = " ID:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(398, 501);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(402, 478);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 54;
            // 
            // lbl_ToEndDate
            // 
            this.lbl_ToEndDate.AutoSize = true;
            this.lbl_ToEndDate.Location = new System.Drawing.Point(350, 580);
            this.lbl_ToEndDate.Name = "lbl_ToEndDate";
            this.lbl_ToEndDate.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToEndDate.TabIndex = 53;
            // 
            // lbl_ToStartDate
            // 
            this.lbl_ToStartDate.AutoSize = true;
            this.lbl_ToStartDate.Location = new System.Drawing.Point(356, 551);
            this.lbl_ToStartDate.Name = "lbl_ToStartDate";
            this.lbl_ToStartDate.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToStartDate.TabIndex = 52;
            // 
            // lbl_ToInterest
            // 
            this.lbl_ToInterest.AutoSize = true;
            this.lbl_ToInterest.Location = new System.Drawing.Point(371, 526);
            this.lbl_ToInterest.Name = "lbl_ToInterest";
            this.lbl_ToInterest.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToInterest.TabIndex = 51;
            // 
            // lbl_ToPeriod
            // 
            this.lbl_ToPeriod.AutoSize = true;
            this.lbl_ToPeriod.Location = new System.Drawing.Point(379, 501);
            this.lbl_ToPeriod.Name = "lbl_ToPeriod";
            this.lbl_ToPeriod.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToPeriod.TabIndex = 50;
            // 
            // lbl_ToLimit
            // 
            this.lbl_ToLimit.AutoSize = true;
            this.lbl_ToLimit.Location = new System.Drawing.Point(116, 582);
            this.lbl_ToLimit.Name = "lbl_ToLimit";
            this.lbl_ToLimit.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToLimit.TabIndex = 48;
            // 
            // lbl_ToBalance
            // 
            this.lbl_ToBalance.AutoSize = true;
            this.lbl_ToBalance.Location = new System.Drawing.Point(98, 555);
            this.lbl_ToBalance.Name = "lbl_ToBalance";
            this.lbl_ToBalance.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToBalance.TabIndex = 47;
            // 
            // lbl_ToCurrency
            // 
            this.lbl_ToCurrency.AutoSize = true;
            this.lbl_ToCurrency.Location = new System.Drawing.Point(95, 526);
            this.lbl_ToCurrency.Name = "lbl_ToCurrency";
            this.lbl_ToCurrency.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToCurrency.TabIndex = 46;
            // 
            // lbl_ToNumber
            // 
            this.lbl_ToNumber.AutoSize = true;
            this.lbl_ToNumber.Location = new System.Drawing.Point(88, 501);
            this.lbl_ToNumber.Name = "lbl_ToNumber";
            this.lbl_ToNumber.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToNumber.TabIndex = 45;
            // 
            // lbl_ToId
            // 
            this.lbl_ToId.AutoSize = true;
            this.lbl_ToId.Location = new System.Drawing.Point(71, 478);
            this.lbl_ToId.Name = "lbl_ToId";
            this.lbl_ToId.Size = new System.Drawing.Size(0, 13);
            this.lbl_ToId.TabIndex = 44;
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(74, 397);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(127, 26);
            this.btnMakeTransaction.TabIndex = 65;
            this.btnMakeTransaction.Text = "Transfer Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // lbl_ToDetails
            // 
            this.lbl_ToDetails.AutoSize = true;
            this.lbl_ToDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ToDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ToDetails.Location = new System.Drawing.Point(29, 445);
            this.lbl_ToDetails.Name = "lbl_ToDetails";
            this.lbl_ToDetails.Size = new System.Drawing.Size(48, 15);
            this.lbl_ToDetails.TabIndex = 66;
            this.lbl_ToDetails.Text = "Details:";
            // 
            // btnMakeGroupTransaction
            // 
            this.btnMakeGroupTransaction.Location = new System.Drawing.Point(274, 399);
            this.btnMakeGroupTransaction.Name = "btnMakeGroupTransaction";
            this.btnMakeGroupTransaction.Size = new System.Drawing.Size(153, 24);
            this.btnMakeGroupTransaction.TabIndex = 67;
            this.btnMakeGroupTransaction.Text = "Make Group Transaction";
            this.btnMakeGroupTransaction.UseVisualStyleBackColor = true;
            this.btnMakeGroupTransaction.Click += new System.EventHandler(this.btnMakeGroupTransaction_Click);
            // 
            // lblTotalTransactionCount
            // 
            this.lblTotalTransactionCount.AutoSize = true;
            this.lblTotalTransactionCount.Location = new System.Drawing.Point(498, 405);
            this.lblTotalTransactionCount.Name = "lblTotalTransactionCount";
            this.lblTotalTransactionCount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalTransactionCount.TabIndex = 68;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Location = new System.Drawing.Point(603, 404);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(41, 13);
            this.lblTransactionType.TabIndex = 69;
            this.lblTransactionType.Text = "label12";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(606, 431);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(41, 13);
            this.lblAmount.TabIndex = 70;
            this.lblAmount.Text = "label11";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(606, 457);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 72;
            this.lblStatus.Text = "label11";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 661);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.lblTotalTransactionCount);
            this.Controls.Add(this.btnMakeGroupTransaction);
            this.Controls.Add(this.lbl_ToDetails);
            this.Controls.Add(this.btnMakeTransaction);
            this.Controls.Add(this.lbl_DisplayToEndDate);
            this.Controls.Add(this.lbl_DisplayToStartDate);
            this.Controls.Add(this.lbl_DisplayToInterest);
            this.Controls.Add(this.lbl_DisplayToPeriod);
            this.Controls.Add(this.lbl_DisplayToLimit);
            this.Controls.Add(this.lbl_DisplayToBalance);
            this.Controls.Add(this.lbl_DisplayToCurrency);
            this.Controls.Add(this.lbl_DisplayToNumber);
            this.Controls.Add(this.lbl_DisplayToId);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbl_ToEndDate);
            this.Controls.Add(this.lbl_ToStartDate);
            this.Controls.Add(this.lbl_ToInterest);
            this.Controls.Add(this.lbl_ToPeriod);
            this.Controls.Add(this.lbl_ToLimit);
            this.Controls.Add(this.lbl_ToBalance);
            this.Controls.Add(this.lbl_ToCurrency);
            this.Controls.Add(this.lbl_ToNumber);
            this.Controls.Add(this.lbl_ToId);
            this.Controls.Add(this.lblDisplayEnd);
            this.Controls.Add(this.lblDisplayStart);
            this.Controls.Add(this.lblDisplayInterest);
            this.Controls.Add(this.lblDisplayPeriod);
            this.Controls.Add(this.lblDisplayLimit);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblDisplayBalance);
            this.Controls.Add(this.lblDisplayCurrency);
            this.Controls.Add(this.lblDisplayNumber);
            this.Controls.Add(this.lblDisplayId);
            this.Controls.Add(this.cbInterestUnitOfTime);
            this.Controls.Add(this.cbPeriodUnitOfTime);
            this.Controls.Add(this.lblPercentUnitOfTime);
            this.Controls.Add(this.lblPeriodUnitOfTime);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLimitCurrency);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblLimitCurrency;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblPeriodUnitOfTime;
        private System.Windows.Forms.Label lblPercentUnitOfTime;
        private System.Windows.Forms.ComboBox cbPeriodUnitOfTime;
        private System.Windows.Forms.ComboBox cbInterestUnitOfTime;
        private System.Windows.Forms.Label lblDisplayId;
        private System.Windows.Forms.Label lblDisplayNumber;
        private System.Windows.Forms.Label lblDisplayCurrency;
        private System.Windows.Forms.Label lblDisplayBalance;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblDisplayLimit;
        private System.Windows.Forms.Label lblDisplayPeriod;
        private System.Windows.Forms.Label lblDisplayInterest;
        private System.Windows.Forms.Label lblDisplayStart;
        private System.Windows.Forms.Label lblDisplayEnd;
        private System.Windows.Forms.Label lbl_DisplayToEndDate;
        private System.Windows.Forms.Label lbl_DisplayToStartDate;
        private System.Windows.Forms.Label lbl_DisplayToInterest;
        private System.Windows.Forms.Label lbl_DisplayToPeriod;
        private System.Windows.Forms.Label lbl_DisplayToLimit;
        private System.Windows.Forms.Label lbl_DisplayToBalance;
        private System.Windows.Forms.Label lbl_DisplayToCurrency;
        private System.Windows.Forms.Label lbl_DisplayToNumber;
        private System.Windows.Forms.Label lbl_DisplayToId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_ToEndDate;
        private System.Windows.Forms.Label lbl_ToStartDate;
        private System.Windows.Forms.Label lbl_ToInterest;
        private System.Windows.Forms.Label lbl_ToPeriod;
        private System.Windows.Forms.Label lbl_ToLimit;
        private System.Windows.Forms.Label lbl_ToBalance;
        private System.Windows.Forms.Label lbl_ToCurrency;
        private System.Windows.Forms.Label lbl_ToNumber;
        private System.Windows.Forms.Label lbl_ToId;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Label lbl_ToDetails;
        private System.Windows.Forms.Button btnMakeGroupTransaction;
        private System.Windows.Forms.Label lblTotalTransactionCount;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatus;
    }
}

