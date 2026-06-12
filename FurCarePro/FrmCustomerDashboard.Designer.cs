namespace FurCarePro
{
    partial class FrmCustomerDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnPets = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabPets = new System.Windows.Forms.TabPage();
            this.grpPetInfo = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.btnClearPet = new System.Windows.Forms.Button();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnUpdatePet = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lblPetName = new System.Windows.Forms.Label();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.grpAppointmentBooking = new System.Windows.Forms.GroupBox();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.txtAppointmentSearch = new System.Windows.Forms.TextBox();
            this.lblSearchAppointment = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.cmbPet = new System.Windows.Forms.ComboBox();
            this.btnQueueCount = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPetInformation = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.tabPayments = new System.Windows.Forms.TabPage();
            this.tabFeedback = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();
            this.txtPaymentSearch = new System.Windows.Forms.TextBox();
            this.lblPaymentSearch = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnClearPayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.lblPaymentAppointment = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbPaymentAppointment = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.grpStaffManagement = new System.Windows.Forms.GroupBox();
            this.cmbGroomingStatus = new System.Windows.Forms.ComboBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.dgvGroomingRecords = new System.Windows.Forms.DataGridView();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblGroomingStatus = new System.Windows.Forms.Label();
            this.lblStaffManagement = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblStaffAppointment = new System.Windows.Forms.Label();
            this.cmbStaffAppointment = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpCustomerFeedback = new System.Windows.Forms.GroupBox();
            this.cmbFeedbackAppointment = new System.Windows.Forms.ComboBox();
            this.txtFeedbackSearch = new System.Windows.Forms.TextBox();
            this.lblFeedbackSearch = new System.Windows.Forms.Label();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.btnClearFeedback = new System.Windows.Forms.Button();
            this.btnDeleteFeedback = new System.Windows.Forms.Button();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblCustomerFeedback = new System.Windows.Forms.Label();
            this.lblFeedbackAppointment = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPopularService = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCustomerGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAppointmentStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStaffPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabChart = new System.Windows.Forms.TabControl();
            this.tabRevenue = new System.Windows.Forms.TabPage();
            this.tabPopularService = new System.Windows.Forms.TabPage();
            this.tabCustomerGrowth = new System.Windows.Forms.TabPage();
            this.tabAppointmentStatus = new System.Windows.Forms.TabPage();
            this.tabStaffPerformance = new System.Windows.Forms.TabPage();
            this.lblUpcomingAppointments = new System.Windows.Forms.Label();
            this.lblTodayAppointments = new System.Windows.Forms.Label();
            this.grpAnalytics = new System.Windows.Forms.GroupBox();
            this.lblTodayApp = new System.Windows.Forms.Label();
            this.lblUpcomingApp = new System.Windows.Forms.Label();
            this.lblCompletedGroom = new System.Windows.Forms.Label();
            this.lblPendingGrooming = new System.Windows.Forms.Label();
            this.lblCompletedGrooming = new System.Windows.Forms.Label();
            this.lblPendingGroom = new System.Windows.Forms.Label();
            this.lblLowRatings = new System.Windows.Forms.Label();
            this.lblHighRatings = new System.Windows.Forms.Label();
            this.lblHighRate = new System.Windows.Forms.Label();
            this.lblLowRate = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblPaidTransactions = new System.Windows.Forms.Label();
            this.lblPaidTransact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalRevenues = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAverageRate = new System.Windows.Forms.Label();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblPopularService = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPets.SuspendLayout();
            this.grpPetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.tabAppointments.SuspendLayout();
            this.grpAppointmentBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.tabPayments.SuspendLayout();
            this.tabFeedback.SuspendLayout();
            this.grpPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.tabStaff.SuspendLayout();
            this.grpStaffManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroomingRecords)).BeginInit();
            this.grpCustomerFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointmentStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaffPerformance)).BeginInit();
            this.tabChart.SuspendLayout();
            this.tabRevenue.SuspendLayout();
            this.tabPopularService.SuspendLayout();
            this.tabCustomerGrowth.SuspendLayout();
            this.tabAppointmentStatus.SuspendLayout();
            this.tabStaffPerformance.SuspendLayout();
            this.grpAnalytics.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.petToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logToolStripMenuItem.Text = "Logout";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Profile";
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPetToolStripMenuItem});
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.petToolStripMenuItem.Text = "Pet";
            // 
            // registerPetToolStripMenuItem
            // 
            this.registerPetToolStripMenuItem.Name = "registerPetToolStripMenuItem";
            this.registerPetToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.registerPetToolStripMenuItem.Text = "Register Pet";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookAppointmentToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // bookAppointmentToolStripMenuItem
            // 
            this.bookAppointmentToolStripMenuItem.Name = "bookAppointmentToolStripMenuItem";
            this.bookAppointmentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bookAppointmentToolStripMenuItem.Text = "Book Appointment";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makePaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // makePaymentToolStripMenuItem
            // 
            this.makePaymentToolStripMenuItem.Name = "makePaymentToolStripMenuItem";
            this.makePaymentToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.makePaymentToolStripMenuItem.Text = "Make Payment";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1384, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton1.Text = "New Pet";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton2.Text = "Book Appointment";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton3.Text = "Payment";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton4.Text = "Refresh";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.lblDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1384, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 17);
            this.lblUser.Text = "lblUser";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(71, 17);
            this.lblDateTime.Text = "lblDateTime";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnProfile);
            this.splitContainer1.Panel1.Controls.Add(this.btnFeedback);
            this.splitContainer1.Panel1.Controls.Add(this.btnPayments);
            this.splitContainer1.Panel1.Controls.Add(this.btnAppointments);
            this.splitContainer1.Panel1.Controls.Add(this.btnPets);
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1384, 690);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(48, 511);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(109, 45);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(48, 433);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(109, 45);
            this.btnFeedback.TabIndex = 4;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(48, 354);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(109, 45);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Location = new System.Drawing.Point(48, 283);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(109, 45);
            this.btnAppointments.TabIndex = 2;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnPets
            // 
            this.btnPets.Location = new System.Drawing.Point(48, 208);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(109, 45);
            this.btnPets.TabIndex = 1;
            this.btnPets.Text = "Pets";
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            this.btnPets.MouseEnter += new System.EventHandler(this.btnPets_MouseEnter);
            this.btnPets.MouseLeave += new System.EventHandler(this.btnPets_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(48, 132);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabHome);
            this.tabMain.Controls.Add(this.tabPets);
            this.tabMain.Controls.Add(this.tabAppointments);
            this.tabMain.Controls.Add(this.tabPayments);
            this.tabMain.Controls.Add(this.tabFeedback);
            this.tabMain.Controls.Add(this.tabProfile);
            this.tabMain.Controls.Add(this.tabStaff);
            this.tabMain.Controls.Add(this.tabReports);
            this.tabMain.Location = new System.Drawing.Point(71, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1031, 660);
            this.tabMain.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1023, 634);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabPets
            // 
            this.tabPets.Controls.Add(this.grpPetInfo);
            this.tabPets.Location = new System.Drawing.Point(4, 22);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPets.Size = new System.Drawing.Size(1023, 634);
            this.tabPets.TabIndex = 1;
            this.tabPets.Text = "Pets";
            this.tabPets.UseVisualStyleBackColor = true;
            // 
            // grpPetInfo
            // 
            this.grpPetInfo.Controls.Add(this.txtSearch);
            this.grpPetInfo.Controls.Add(this.lblSearch);
            this.grpPetInfo.Controls.Add(this.dgvPets);
            this.grpPetInfo.Controls.Add(this.btnClearPet);
            this.grpPetInfo.Controls.Add(this.btnDeletePet);
            this.grpPetInfo.Controls.Add(this.btnUpdatePet);
            this.grpPetInfo.Controls.Add(this.btnAddPet);
            this.grpPetInfo.Controls.Add(this.numWeight);
            this.grpPetInfo.Controls.Add(this.lblWeight);
            this.grpPetInfo.Controls.Add(this.rbFemale);
            this.grpPetInfo.Controls.Add(this.rbMale);
            this.grpPetInfo.Controls.Add(this.lblGender);
            this.grpPetInfo.Controls.Add(this.txtBreed);
            this.grpPetInfo.Controls.Add(this.lblBreed);
            this.grpPetInfo.Controls.Add(this.lblTitle);
            this.grpPetInfo.Controls.Add(this.txtPetName);
            this.grpPetInfo.Controls.Add(this.lblPetName);
            this.grpPetInfo.Controls.Add(this.cmbSpecies);
            this.grpPetInfo.Controls.Add(this.lblSpecies);
            this.grpPetInfo.Location = new System.Drawing.Point(19, 20);
            this.grpPetInfo.Name = "grpPetInfo";
            this.grpPetInfo.Size = new System.Drawing.Size(985, 608);
            this.grpPetInfo.TabIndex = 10;
            this.grpPetInfo.TabStop = false;
            this.grpPetInfo.Text = "Pet Info";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 401);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(414, 20);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(45, 401);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 23;
            this.lblSearch.Text = "Search:";
            // 
            // dgvPets
            // 
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Location = new System.Drawing.Point(49, 442);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.Size = new System.Drawing.Size(881, 143);
            this.dgvPets.TabIndex = 22;
            this.dgvPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellContentClick);
            // 
            // btnClearPet
            // 
            this.btnClearPet.Location = new System.Drawing.Point(370, 353);
            this.btnClearPet.Name = "btnClearPet";
            this.btnClearPet.Size = new System.Drawing.Size(75, 23);
            this.btnClearPet.TabIndex = 21;
            this.btnClearPet.Text = "Clear";
            this.btnClearPet.UseVisualStyleBackColor = true;
            this.btnClearPet.Click += new System.EventHandler(this.btnClearPet_Click);
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Location = new System.Drawing.Point(257, 353);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePet.TabIndex = 20;
            this.btnDeletePet.Text = "Delete";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // btnUpdatePet
            // 
            this.btnUpdatePet.Location = new System.Drawing.Point(150, 353);
            this.btnUpdatePet.Name = "btnUpdatePet";
            this.btnUpdatePet.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePet.TabIndex = 19;
            this.btnUpdatePet.Text = "Update";
            this.btnUpdatePet.UseVisualStyleBackColor = true;
            this.btnUpdatePet.Click += new System.EventHandler(this.btnUpdatePet_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(49, 353);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(75, 23);
            this.btnAddPet.TabIndex = 18;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(49, 308);
            this.numWeight.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(120, 20);
            this.numWeight.TabIndex = 17;
            this.numWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(45, 285);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 20);
            this.lblWeight.TabIndex = 16;
            this.lblWeight.Text = "Weight";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(156, 256);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(49, 256);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(45, 231);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(49, 194);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(402, 20);
            this.txtBreed.TabIndex = 11;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.Location = new System.Drawing.Point(45, 171);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(52, 20);
            this.lblBreed.TabIndex = 10;
            this.lblBreed.Text = "Breed";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(49, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "PET INFORMATION";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(52, 79);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(402, 20);
            this.txtPetName.TabIndex = 6;
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(48, 56);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(79, 20);
            this.lblPetName.TabIndex = 5;
            this.lblPetName.Text = "Pet Name";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Rabbit",
            "Bird",
            "Hamster"});
            this.cmbSpecies.Location = new System.Drawing.Point(49, 133);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(121, 21);
            this.cmbSpecies.TabIndex = 8;
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies_SelectedIndexChanged);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(45, 110);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(66, 20);
            this.lblSpecies.TabIndex = 7;
            this.lblSpecies.Text = "Species";
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.grpAppointmentBooking);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointments.Size = new System.Drawing.Size(1023, 634);
            this.tabAppointments.TabIndex = 2;
            this.tabAppointments.Text = "Appointments";
            this.tabAppointments.UseVisualStyleBackColor = true;
            // 
            // grpAppointmentBooking
            // 
            this.grpAppointmentBooking.Controls.Add(this.dgvAppointments);
            this.grpAppointmentBooking.Controls.Add(this.txtAppointmentSearch);
            this.grpAppointmentBooking.Controls.Add(this.lblSearchAppointment);
            this.grpAppointmentBooking.Controls.Add(this.cmbStatus);
            this.grpAppointmentBooking.Controls.Add(this.lblStatus);
            this.grpAppointmentBooking.Controls.Add(this.dtpAppointment);
            this.grpAppointmentBooking.Controls.Add(this.txtDuration);
            this.grpAppointmentBooking.Controls.Add(this.cmbPet);
            this.grpAppointmentBooking.Controls.Add(this.btnQueueCount);
            this.grpAppointmentBooking.Controls.Add(this.btnDeleteAppointment);
            this.grpAppointmentBooking.Controls.Add(this.btnUpdateAppointment);
            this.grpAppointmentBooking.Controls.Add(this.btnBookAppointment);
            this.grpAppointmentBooking.Controls.Add(this.lblDate);
            this.grpAppointmentBooking.Controls.Add(this.lblDuration);
            this.grpAppointmentBooking.Controls.Add(this.txtPrice);
            this.grpAppointmentBooking.Controls.Add(this.lblPrice);
            this.grpAppointmentBooking.Controls.Add(this.lblPetInformation);
            this.grpAppointmentBooking.Controls.Add(this.lblPet);
            this.grpAppointmentBooking.Controls.Add(this.cmbService);
            this.grpAppointmentBooking.Controls.Add(this.lblService);
            this.grpAppointmentBooking.Location = new System.Drawing.Point(19, 20);
            this.grpAppointmentBooking.Name = "grpAppointmentBooking";
            this.grpAppointmentBooking.Size = new System.Drawing.Size(985, 608);
            this.grpAppointmentBooking.TabIndex = 11;
            this.grpAppointmentBooking.TabStop = false;
            this.grpAppointmentBooking.Text = "Appointment Booking";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(50, 443);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(876, 159);
            this.dgvAppointments.TabIndex = 33;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // txtAppointmentSearch
            // 
            this.txtAppointmentSearch.Location = new System.Drawing.Point(207, 417);
            this.txtAppointmentSearch.Name = "txtAppointmentSearch";
            this.txtAppointmentSearch.Size = new System.Drawing.Size(402, 20);
            this.txtAppointmentSearch.TabIndex = 32;
            this.txtAppointmentSearch.TextChanged += new System.EventHandler(this.txtAppointmentSearch_TextChanged);
            // 
            // lblSearchAppointment
            // 
            this.lblSearchAppointment.AutoSize = true;
            this.lblSearchAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAppointment.Location = new System.Drawing.Point(45, 417);
            this.lblSearchAppointment.Name = "lblSearchAppointment";
            this.lblSearchAppointment.Size = new System.Drawing.Size(159, 20);
            this.lblSearchAppointment.TabIndex = 31;
            this.lblSearchAppointment.Text = "Search Appointment:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(50, 343);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(176, 21);
            this.cmbStatus.TabIndex = 30;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(46, 320);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(49, 287);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointment.TabIndex = 27;
            this.dtpAppointment.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(49, 231);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(402, 20);
            this.txtDuration.TabIndex = 26;
            // 
            // cmbPet
            // 
            this.cmbPet.FormattingEnabled = true;
            this.cmbPet.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Rabbit",
            "Bird",
            "Hamster"});
            this.cmbPet.Location = new System.Drawing.Point(49, 77);
            this.cmbPet.Name = "cmbPet";
            this.cmbPet.Size = new System.Drawing.Size(176, 21);
            this.cmbPet.TabIndex = 25;
            // 
            // btnQueueCount
            // 
            this.btnQueueCount.Location = new System.Drawing.Point(376, 379);
            this.btnQueueCount.Name = "btnQueueCount";
            this.btnQueueCount.Size = new System.Drawing.Size(93, 23);
            this.btnQueueCount.TabIndex = 21;
            this.btnQueueCount.Text = "Queue Count";
            this.btnQueueCount.UseVisualStyleBackColor = true;
            this.btnQueueCount.Click += new System.EventHandler(this.btnQueueCount_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(258, 379);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAppointment.TabIndex = 20;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Location = new System.Drawing.Point(151, 379);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAppointment.TabIndex = 19;
            this.btnUpdateAppointment.Text = "Update";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(50, 379);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnBookAppointment.TabIndex = 18;
            this.btnBookAppointment.Text = "Book";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(45, 264);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(45, 208);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(70, 20);
            this.lblDuration.TabIndex = 12;
            this.lblDuration.Text = "Duration";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(49, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(402, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(45, 154);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblPetInformation
            // 
            this.lblPetInformation.AutoSize = true;
            this.lblPetInformation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetInformation.Location = new System.Drawing.Point(49, 16);
            this.lblPetInformation.Name = "lblPetInformation";
            this.lblPetInformation.Size = new System.Drawing.Size(307, 32);
            this.lblPetInformation.TabIndex = 9;
            this.lblPetInformation.Text = "APPOINTMENT BOOKING";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.Location = new System.Drawing.Point(45, 54);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(33, 20);
            this.lblPet.TabIndex = 5;
            this.lblPet.Text = "Pet";
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(49, 127);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(176, 21);
            this.cmbService.TabIndex = 8;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(45, 104);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(61, 20);
            this.lblService.TabIndex = 7;
            this.lblService.Text = "Service";
            // 
            // tabPayments
            // 
            this.tabPayments.Controls.Add(this.grpPaymentInfo);
            this.tabPayments.Location = new System.Drawing.Point(4, 22);
            this.tabPayments.Name = "tabPayments";
            this.tabPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayments.Size = new System.Drawing.Size(1023, 634);
            this.tabPayments.TabIndex = 3;
            this.tabPayments.Text = "Payments";
            this.tabPayments.UseVisualStyleBackColor = true;
            // 
            // tabFeedback
            // 
            this.tabFeedback.Controls.Add(this.grpCustomerFeedback);
            this.tabFeedback.Location = new System.Drawing.Point(4, 22);
            this.tabFeedback.Name = "tabFeedback";
            this.tabFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeedback.Size = new System.Drawing.Size(1023, 634);
            this.tabFeedback.TabIndex = 4;
            this.tabFeedback.Text = "Feedback";
            this.tabFeedback.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(1023, 634);
            this.tabProfile.TabIndex = 5;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // grpPaymentInfo
            // 
            this.grpPaymentInfo.Controls.Add(this.cmbPaymentStatus);
            this.grpPaymentInfo.Controls.Add(this.cmbPaymentMethod);
            this.grpPaymentInfo.Controls.Add(this.txtAmount);
            this.grpPaymentInfo.Controls.Add(this.cmbPaymentAppointment);
            this.grpPaymentInfo.Controls.Add(this.txtPaymentSearch);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentSearch);
            this.grpPaymentInfo.Controls.Add(this.dgvPayments);
            this.grpPaymentInfo.Controls.Add(this.btnClearPayment);
            this.grpPaymentInfo.Controls.Add(this.btnDeletePayment);
            this.grpPaymentInfo.Controls.Add(this.btnPay);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentStatus);
            this.grpPaymentInfo.Controls.Add(this.lblMethod);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentInfo);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentAppointment);
            this.grpPaymentInfo.Controls.Add(this.lblAmount);
            this.grpPaymentInfo.Location = new System.Drawing.Point(19, 20);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Size = new System.Drawing.Size(985, 608);
            this.grpPaymentInfo.TabIndex = 11;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Payment Info";
            // 
            // txtPaymentSearch
            // 
            this.txtPaymentSearch.Location = new System.Drawing.Point(55, 364);
            this.txtPaymentSearch.Name = "txtPaymentSearch";
            this.txtPaymentSearch.Size = new System.Drawing.Size(414, 20);
            this.txtPaymentSearch.TabIndex = 24;
            this.txtPaymentSearch.TextChanged += new System.EventHandler(this.txtPaymentSearch_TextChanged);
            // 
            // lblPaymentSearch
            // 
            this.lblPaymentSearch.AutoSize = true;
            this.lblPaymentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentSearch.Location = new System.Drawing.Point(51, 340);
            this.lblPaymentSearch.Name = "lblPaymentSearch";
            this.lblPaymentSearch.Size = new System.Drawing.Size(64, 20);
            this.lblPaymentSearch.TabIndex = 23;
            this.lblPaymentSearch.Text = "Search:";
            // 
            // dgvPayments
            // 
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(49, 400);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Size = new System.Drawing.Size(881, 185);
            this.dgvPayments.TabIndex = 22;
            // 
            // btnClearPayment
            // 
            this.btnClearPayment.Location = new System.Drawing.Point(260, 296);
            this.btnClearPayment.Name = "btnClearPayment";
            this.btnClearPayment.Size = new System.Drawing.Size(75, 23);
            this.btnClearPayment.TabIndex = 21;
            this.btnClearPayment.Text = "Clear";
            this.btnClearPayment.UseVisualStyleBackColor = true;
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(150, 296);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePayment.TabIndex = 19;
            this.btnDeletePayment.Text = "Delete";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(49, 296);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(45, 231);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(56, 20);
            this.lblPaymentStatus.TabIndex = 12;
            this.lblPaymentStatus.Text = "Status";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(45, 171);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(63, 20);
            this.lblMethod.TabIndex = 10;
            this.lblMethod.Text = "Method";
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentInfo.Location = new System.Drawing.Point(49, 16);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(304, 32);
            this.lblPaymentInfo.TabIndex = 9;
            this.lblPaymentInfo.Text = "PAYMENT INFORMATION";
            // 
            // lblPaymentAppointment
            // 
            this.lblPaymentAppointment.AutoSize = true;
            this.lblPaymentAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAppointment.Location = new System.Drawing.Point(45, 56);
            this.lblPaymentAppointment.Name = "lblPaymentAppointment";
            this.lblPaymentAppointment.Size = new System.Drawing.Size(100, 20);
            this.lblPaymentAppointment.TabIndex = 5;
            this.lblPaymentAppointment.Text = "Appointment";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(45, 110);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // cmbPaymentAppointment
            // 
            this.cmbPaymentAppointment.FormattingEnabled = true;
            this.cmbPaymentAppointment.Location = new System.Drawing.Point(49, 79);
            this.cmbPaymentAppointment.Name = "cmbPaymentAppointment";
            this.cmbPaymentAppointment.Size = new System.Drawing.Size(201, 21);
            this.cmbPaymentAppointment.TabIndex = 25;
            this.cmbPaymentAppointment.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentAppointment_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(49, 133);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(402, 20);
            this.txtAmount.TabIndex = 26;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(49, 194);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(201, 21);
            this.cmbPaymentMethod.TabIndex = 27;
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(49, 254);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(201, 21);
            this.cmbPaymentStatus.TabIndex = 28;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.grpStaffManagement);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(1023, 634);
            this.tabStaff.TabIndex = 6;
            this.tabStaff.Text = "Staff";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // grpStaffManagement
            // 
            this.grpStaffManagement.Controls.Add(this.txtNotes);
            this.grpStaffManagement.Controls.Add(this.lblNotes);
            this.grpStaffManagement.Controls.Add(this.cmbStaffAppointment);
            this.grpStaffManagement.Controls.Add(this.cmbGroomingStatus);
            this.grpStaffManagement.Controls.Add(this.cmbStaff);
            this.grpStaffManagement.Controls.Add(this.dgvGroomingRecords);
            this.grpStaffManagement.Controls.Add(this.btnComplete);
            this.grpStaffManagement.Controls.Add(this.btnAssign);
            this.grpStaffManagement.Controls.Add(this.lblGroomingStatus);
            this.grpStaffManagement.Controls.Add(this.lblStaffManagement);
            this.grpStaffManagement.Controls.Add(this.lblStaff);
            this.grpStaffManagement.Controls.Add(this.lblStaffAppointment);
            this.grpStaffManagement.Location = new System.Drawing.Point(19, 20);
            this.grpStaffManagement.Name = "grpStaffManagement";
            this.grpStaffManagement.Size = new System.Drawing.Size(985, 608);
            this.grpStaffManagement.TabIndex = 12;
            this.grpStaffManagement.TabStop = false;
            this.grpStaffManagement.Text = "Payment Info";
            // 
            // cmbGroomingStatus
            // 
            this.cmbGroomingStatus.FormattingEnabled = true;
            this.cmbGroomingStatus.Location = new System.Drawing.Point(49, 214);
            this.cmbGroomingStatus.Name = "cmbGroomingStatus";
            this.cmbGroomingStatus.Size = new System.Drawing.Size(201, 21);
            this.cmbGroomingStatus.TabIndex = 27;
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(49, 79);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(201, 21);
            this.cmbStaff.TabIndex = 25;
            // 
            // dgvGroomingRecords
            // 
            this.dgvGroomingRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroomingRecords.Location = new System.Drawing.Point(49, 364);
            this.dgvGroomingRecords.Name = "dgvGroomingRecords";
            this.dgvGroomingRecords.Size = new System.Drawing.Size(881, 221);
            this.dgvGroomingRecords.TabIndex = 22;
            this.dgvGroomingRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroomingRecords_CellContentClick);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(150, 323);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 19;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(49, 323);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 18;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblGroomingStatus
            // 
            this.lblGroomingStatus.AutoSize = true;
            this.lblGroomingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroomingStatus.Location = new System.Drawing.Point(45, 191);
            this.lblGroomingStatus.Name = "lblGroomingStatus";
            this.lblGroomingStatus.Size = new System.Drawing.Size(130, 20);
            this.lblGroomingStatus.TabIndex = 10;
            this.lblGroomingStatus.Text = "Grooming Status";
            // 
            // lblStaffManagement
            // 
            this.lblStaffManagement.AutoSize = true;
            this.lblStaffManagement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffManagement.Location = new System.Drawing.Point(49, 16);
            this.lblStaffManagement.Name = "lblStaffManagement";
            this.lblStaffManagement.Size = new System.Drawing.Size(304, 32);
            this.lblStaffManagement.TabIndex = 9;
            this.lblStaffManagement.Text = "PAYMENT INFORMATION";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(45, 56);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(44, 20);
            this.lblStaff.TabIndex = 5;
            this.lblStaff.Text = "Staff";
            // 
            // lblStaffAppointment
            // 
            this.lblStaffAppointment.AutoSize = true;
            this.lblStaffAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffAppointment.Location = new System.Drawing.Point(45, 125);
            this.lblStaffAppointment.Name = "lblStaffAppointment";
            this.lblStaffAppointment.Size = new System.Drawing.Size(100, 20);
            this.lblStaffAppointment.TabIndex = 7;
            this.lblStaffAppointment.Text = "Appointment";
            // 
            // cmbStaffAppointment
            // 
            this.cmbStaffAppointment.FormattingEnabled = true;
            this.cmbStaffAppointment.Location = new System.Drawing.Point(49, 148);
            this.cmbStaffAppointment.Name = "cmbStaffAppointment";
            this.cmbStaffAppointment.Size = new System.Drawing.Size(201, 21);
            this.cmbStaffAppointment.TabIndex = 29;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(45, 257);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 30;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(49, 281);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(304, 20);
            this.txtNotes.TabIndex = 31;
            // 
            // grpCustomerFeedback
            // 
            this.grpCustomerFeedback.Controls.Add(this.txtComments);
            this.grpCustomerFeedback.Controls.Add(this.numRating);
            this.grpCustomerFeedback.Controls.Add(this.cmbFeedbackAppointment);
            this.grpCustomerFeedback.Controls.Add(this.txtFeedbackSearch);
            this.grpCustomerFeedback.Controls.Add(this.lblFeedbackSearch);
            this.grpCustomerFeedback.Controls.Add(this.dgvFeedback);
            this.grpCustomerFeedback.Controls.Add(this.btnClearFeedback);
            this.grpCustomerFeedback.Controls.Add(this.btnDeleteFeedback);
            this.grpCustomerFeedback.Controls.Add(this.btnSubmitFeedback);
            this.grpCustomerFeedback.Controls.Add(this.lblComments);
            this.grpCustomerFeedback.Controls.Add(this.lblCustomerFeedback);
            this.grpCustomerFeedback.Controls.Add(this.lblFeedbackAppointment);
            this.grpCustomerFeedback.Controls.Add(this.lblRating);
            this.grpCustomerFeedback.Location = new System.Drawing.Point(19, 20);
            this.grpCustomerFeedback.Name = "grpCustomerFeedback";
            this.grpCustomerFeedback.Size = new System.Drawing.Size(985, 608);
            this.grpCustomerFeedback.TabIndex = 12;
            this.grpCustomerFeedback.TabStop = false;
            this.grpCustomerFeedback.Text = "Customer Feedback";
            // 
            // cmbFeedbackAppointment
            // 
            this.cmbFeedbackAppointment.FormattingEnabled = true;
            this.cmbFeedbackAppointment.Location = new System.Drawing.Point(49, 79);
            this.cmbFeedbackAppointment.Name = "cmbFeedbackAppointment";
            this.cmbFeedbackAppointment.Size = new System.Drawing.Size(201, 21);
            this.cmbFeedbackAppointment.TabIndex = 25;
            // 
            // txtFeedbackSearch
            // 
            this.txtFeedbackSearch.Location = new System.Drawing.Point(55, 364);
            this.txtFeedbackSearch.Name = "txtFeedbackSearch";
            this.txtFeedbackSearch.Size = new System.Drawing.Size(414, 20);
            this.txtFeedbackSearch.TabIndex = 24;
            this.txtFeedbackSearch.TextChanged += new System.EventHandler(this.txtFeedbackSearch_TextChanged);
            // 
            // lblFeedbackSearch
            // 
            this.lblFeedbackSearch.AutoSize = true;
            this.lblFeedbackSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackSearch.Location = new System.Drawing.Point(51, 340);
            this.lblFeedbackSearch.Name = "lblFeedbackSearch";
            this.lblFeedbackSearch.Size = new System.Drawing.Size(64, 20);
            this.lblFeedbackSearch.TabIndex = 23;
            this.lblFeedbackSearch.Text = "Search:";
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(49, 400);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.Size = new System.Drawing.Size(881, 185);
            this.dgvFeedback.TabIndex = 22;
            // 
            // btnClearFeedback
            // 
            this.btnClearFeedback.Location = new System.Drawing.Point(260, 296);
            this.btnClearFeedback.Name = "btnClearFeedback";
            this.btnClearFeedback.Size = new System.Drawing.Size(75, 23);
            this.btnClearFeedback.TabIndex = 21;
            this.btnClearFeedback.Text = "Clear";
            this.btnClearFeedback.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFeedback
            // 
            this.btnDeleteFeedback.Location = new System.Drawing.Point(150, 296);
            this.btnDeleteFeedback.Name = "btnDeleteFeedback";
            this.btnDeleteFeedback.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFeedback.TabIndex = 19;
            this.btnDeleteFeedback.Text = "Delete";
            this.btnDeleteFeedback.UseVisualStyleBackColor = true;
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Location = new System.Drawing.Point(49, 296);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitFeedback.TabIndex = 18;
            this.btnSubmitFeedback.Text = "Submit";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(45, 171);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(86, 20);
            this.lblComments.TabIndex = 10;
            this.lblComments.Text = "Comments";
            // 
            // lblCustomerFeedback
            // 
            this.lblCustomerFeedback.AutoSize = true;
            this.lblCustomerFeedback.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFeedback.Location = new System.Drawing.Point(49, 16);
            this.lblCustomerFeedback.Name = "lblCustomerFeedback";
            this.lblCustomerFeedback.Size = new System.Drawing.Size(268, 32);
            this.lblCustomerFeedback.TabIndex = 9;
            this.lblCustomerFeedback.Text = "CUSTOMER FEEDBACK";
            // 
            // lblFeedbackAppointment
            // 
            this.lblFeedbackAppointment.AutoSize = true;
            this.lblFeedbackAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackAppointment.Location = new System.Drawing.Point(45, 56);
            this.lblFeedbackAppointment.Name = "lblFeedbackAppointment";
            this.lblFeedbackAppointment.Size = new System.Drawing.Size(100, 20);
            this.lblFeedbackAppointment.TabIndex = 5;
            this.lblFeedbackAppointment.Text = "Appointment";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(45, 110);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(56, 20);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Rating";
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(49, 133);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(120, 20);
            this.numRating.TabIndex = 29;
            this.numRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(49, 194);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(402, 87);
            this.txtComments.TabIndex = 30;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.grpAnalytics);
            this.tabReports.Controls.Add(this.tabChart);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(1023, 634);
            this.tabReports.TabIndex = 7;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // chartRevenue
            // 
            chartArea16.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend16);
            this.chartRevenue.Location = new System.Drawing.Point(319, 26);
            this.chartRevenue.Name = "chartRevenue";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chartRevenue.Series.Add(series16);
            this.chartRevenue.Size = new System.Drawing.Size(320, 210);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart2";
            // 
            // chartPopularService
            // 
            chartArea17.Name = "ChartArea1";
            this.chartPopularService.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chartPopularService.Legends.Add(legend17);
            this.chartPopularService.Location = new System.Drawing.Point(319, 26);
            this.chartPopularService.Name = "chartPopularService";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            this.chartPopularService.Series.Add(series17);
            this.chartPopularService.Size = new System.Drawing.Size(320, 210);
            this.chartPopularService.TabIndex = 2;
            this.chartPopularService.Text = "chart2";
            // 
            // chartCustomerGrowth
            // 
            chartArea18.Name = "ChartArea1";
            this.chartCustomerGrowth.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chartCustomerGrowth.Legends.Add(legend18);
            this.chartCustomerGrowth.Location = new System.Drawing.Point(319, 26);
            this.chartCustomerGrowth.Name = "chartCustomerGrowth";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chartCustomerGrowth.Series.Add(series18);
            this.chartCustomerGrowth.Size = new System.Drawing.Size(320, 210);
            this.chartCustomerGrowth.TabIndex = 3;
            this.chartCustomerGrowth.Text = "chart2";
            // 
            // chartAppointmentStatus
            // 
            chartArea19.Name = "ChartArea1";
            this.chartAppointmentStatus.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chartAppointmentStatus.Legends.Add(legend19);
            this.chartAppointmentStatus.Location = new System.Drawing.Point(319, 26);
            this.chartAppointmentStatus.Name = "chartAppointmentStatus";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chartAppointmentStatus.Series.Add(series19);
            this.chartAppointmentStatus.Size = new System.Drawing.Size(320, 210);
            this.chartAppointmentStatus.TabIndex = 4;
            this.chartAppointmentStatus.Text = "chart2";
            // 
            // chartStaffPerformance
            // 
            chartArea20.Name = "ChartArea1";
            this.chartStaffPerformance.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chartStaffPerformance.Legends.Add(legend20);
            this.chartStaffPerformance.Location = new System.Drawing.Point(319, 26);
            this.chartStaffPerformance.Name = "chartStaffPerformance";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chartStaffPerformance.Series.Add(series20);
            this.chartStaffPerformance.Size = new System.Drawing.Size(320, 210);
            this.chartStaffPerformance.TabIndex = 5;
            this.chartStaffPerformance.Text = "chart2";
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.tabRevenue);
            this.tabChart.Controls.Add(this.tabPopularService);
            this.tabChart.Controls.Add(this.tabCustomerGrowth);
            this.tabChart.Controls.Add(this.tabAppointmentStatus);
            this.tabChart.Controls.Add(this.tabStaffPerformance);
            this.tabChart.Location = new System.Drawing.Point(6, 336);
            this.tabChart.Name = "tabChart";
            this.tabChart.SelectedIndex = 0;
            this.tabChart.Size = new System.Drawing.Size(1011, 292);
            this.tabChart.TabIndex = 6;
            // 
            // tabRevenue
            // 
            this.tabRevenue.Controls.Add(this.chartRevenue);
            this.tabRevenue.Location = new System.Drawing.Point(4, 22);
            this.tabRevenue.Name = "tabRevenue";
            this.tabRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevenue.Size = new System.Drawing.Size(964, 250);
            this.tabRevenue.TabIndex = 0;
            this.tabRevenue.Text = "Revenue Chart";
            this.tabRevenue.UseVisualStyleBackColor = true;
            // 
            // tabPopularService
            // 
            this.tabPopularService.Controls.Add(this.chartPopularService);
            this.tabPopularService.Location = new System.Drawing.Point(4, 22);
            this.tabPopularService.Name = "tabPopularService";
            this.tabPopularService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopularService.Size = new System.Drawing.Size(964, 250);
            this.tabPopularService.TabIndex = 1;
            this.tabPopularService.Text = "Popular Service Chart";
            this.tabPopularService.UseVisualStyleBackColor = true;
            // 
            // tabCustomerGrowth
            // 
            this.tabCustomerGrowth.Controls.Add(this.chartCustomerGrowth);
            this.tabCustomerGrowth.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerGrowth.Name = "tabCustomerGrowth";
            this.tabCustomerGrowth.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerGrowth.Size = new System.Drawing.Size(1003, 266);
            this.tabCustomerGrowth.TabIndex = 2;
            this.tabCustomerGrowth.Text = "Customer Growth Chart";
            this.tabCustomerGrowth.UseVisualStyleBackColor = true;
            // 
            // tabAppointmentStatus
            // 
            this.tabAppointmentStatus.Controls.Add(this.chartAppointmentStatus);
            this.tabAppointmentStatus.Location = new System.Drawing.Point(4, 22);
            this.tabAppointmentStatus.Name = "tabAppointmentStatus";
            this.tabAppointmentStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointmentStatus.Size = new System.Drawing.Size(964, 250);
            this.tabAppointmentStatus.TabIndex = 3;
            this.tabAppointmentStatus.Text = "Appointment Status Chart";
            this.tabAppointmentStatus.UseVisualStyleBackColor = true;
            // 
            // tabStaffPerformance
            // 
            this.tabStaffPerformance.Controls.Add(this.chartStaffPerformance);
            this.tabStaffPerformance.Location = new System.Drawing.Point(4, 22);
            this.tabStaffPerformance.Name = "tabStaffPerformance";
            this.tabStaffPerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaffPerformance.Size = new System.Drawing.Size(1003, 266);
            this.tabStaffPerformance.TabIndex = 4;
            this.tabStaffPerformance.Text = "Staff Performance Chart";
            this.tabStaffPerformance.UseVisualStyleBackColor = true;
            // 
            // lblUpcomingAppointments
            // 
            this.lblUpcomingAppointments.AutoSize = true;
            this.lblUpcomingAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingAppointments.Location = new System.Drawing.Point(227, 48);
            this.lblUpcomingAppointments.Name = "lblUpcomingAppointments";
            this.lblUpcomingAppointments.Size = new System.Drawing.Size(14, 20);
            this.lblUpcomingAppointments.TabIndex = 37;
            this.lblUpcomingAppointments.Text = "-";
            // 
            // lblTodayAppointments
            // 
            this.lblTodayAppointments.AutoSize = true;
            this.lblTodayAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayAppointments.Location = new System.Drawing.Point(227, 16);
            this.lblTodayAppointments.Name = "lblTodayAppointments";
            this.lblTodayAppointments.Size = new System.Drawing.Size(14, 20);
            this.lblTodayAppointments.TabIndex = 36;
            this.lblTodayAppointments.Text = "-";
            // 
            // grpAnalytics
            // 
            this.grpAnalytics.Controls.Add(this.label12);
            this.grpAnalytics.Controls.Add(this.label11);
            this.grpAnalytics.Controls.Add(this.label10);
            this.grpAnalytics.Controls.Add(this.lblPopularService);
            this.grpAnalytics.Controls.Add(this.lblAverageRating);
            this.grpAnalytics.Controls.Add(this.lblAverageRate);
            this.grpAnalytics.Controls.Add(this.label9);
            this.grpAnalytics.Controls.Add(this.lblTotalRevenues);
            this.grpAnalytics.Controls.Add(this.label8);
            this.grpAnalytics.Controls.Add(this.label7);
            this.grpAnalytics.Controls.Add(this.label6);
            this.grpAnalytics.Controls.Add(this.label5);
            this.grpAnalytics.Controls.Add(this.label4);
            this.grpAnalytics.Controls.Add(this.label3);
            this.grpAnalytics.Controls.Add(this.label1);
            this.grpAnalytics.Controls.Add(this.lblPaidTransact);
            this.grpAnalytics.Controls.Add(this.lblRevenue);
            this.grpAnalytics.Controls.Add(this.lblPaidTransactions);
            this.grpAnalytics.Controls.Add(this.lblLowRate);
            this.grpAnalytics.Controls.Add(this.lblHighRate);
            this.grpAnalytics.Controls.Add(this.lblLowRatings);
            this.grpAnalytics.Controls.Add(this.lblHighRatings);
            this.grpAnalytics.Controls.Add(this.lblPendingGroom);
            this.grpAnalytics.Controls.Add(this.lblPendingGrooming);
            this.grpAnalytics.Controls.Add(this.lblCompletedGrooming);
            this.grpAnalytics.Controls.Add(this.lblCompletedGroom);
            this.grpAnalytics.Controls.Add(this.lblUpcomingApp);
            this.grpAnalytics.Controls.Add(this.lblTodayApp);
            this.grpAnalytics.Controls.Add(this.lblTodayAppointments);
            this.grpAnalytics.Controls.Add(this.lblUpcomingAppointments);
            this.grpAnalytics.Location = new System.Drawing.Point(10, 6);
            this.grpAnalytics.Name = "grpAnalytics";
            this.grpAnalytics.Size = new System.Drawing.Size(1000, 324);
            this.grpAnalytics.TabIndex = 38;
            this.grpAnalytics.TabStop = false;
            this.grpAnalytics.Text = "Analytics";
            // 
            // lblTodayApp
            // 
            this.lblTodayApp.AutoSize = true;
            this.lblTodayApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayApp.Location = new System.Drawing.Point(17, 16);
            this.lblTodayApp.Name = "lblTodayApp";
            this.lblTodayApp.Size = new System.Drawing.Size(166, 20);
            this.lblTodayApp.TabIndex = 38;
            this.lblTodayApp.Text = "Today\'s Appointments";
            // 
            // lblUpcomingApp
            // 
            this.lblUpcomingApp.AutoSize = true;
            this.lblUpcomingApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingApp.Location = new System.Drawing.Point(17, 48);
            this.lblUpcomingApp.Name = "lblUpcomingApp";
            this.lblUpcomingApp.Size = new System.Drawing.Size(188, 20);
            this.lblUpcomingApp.TabIndex = 39;
            this.lblUpcomingApp.Text = "Upcoming Appointments ";
            // 
            // lblCompletedGroom
            // 
            this.lblCompletedGroom.AutoSize = true;
            this.lblCompletedGroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedGroom.Location = new System.Drawing.Point(17, 77);
            this.lblCompletedGroom.Name = "lblCompletedGroom";
            this.lblCompletedGroom.Size = new System.Drawing.Size(160, 20);
            this.lblCompletedGroom.TabIndex = 40;
            this.lblCompletedGroom.Text = "Completed Grooming";
            // 
            // lblPendingGrooming
            // 
            this.lblPendingGrooming.AutoSize = true;
            this.lblPendingGrooming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingGrooming.Location = new System.Drawing.Point(227, 107);
            this.lblPendingGrooming.Name = "lblPendingGrooming";
            this.lblPendingGrooming.Size = new System.Drawing.Size(14, 20);
            this.lblPendingGrooming.TabIndex = 42;
            this.lblPendingGrooming.Text = "-";
            // 
            // lblCompletedGrooming
            // 
            this.lblCompletedGrooming.AutoSize = true;
            this.lblCompletedGrooming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedGrooming.Location = new System.Drawing.Point(227, 77);
            this.lblCompletedGrooming.Name = "lblCompletedGrooming";
            this.lblCompletedGrooming.Size = new System.Drawing.Size(14, 20);
            this.lblCompletedGrooming.TabIndex = 41;
            this.lblCompletedGrooming.Text = "-";
            // 
            // lblPendingGroom
            // 
            this.lblPendingGroom.AutoSize = true;
            this.lblPendingGroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingGroom.Location = new System.Drawing.Point(17, 107);
            this.lblPendingGroom.Name = "lblPendingGroom";
            this.lblPendingGroom.Size = new System.Drawing.Size(141, 20);
            this.lblPendingGroom.TabIndex = 43;
            this.lblPendingGroom.Text = "Pending Grooming";
            // 
            // lblLowRatings
            // 
            this.lblLowRatings.AutoSize = true;
            this.lblLowRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowRatings.Location = new System.Drawing.Point(227, 167);
            this.lblLowRatings.Name = "lblLowRatings";
            this.lblLowRatings.Size = new System.Drawing.Size(14, 20);
            this.lblLowRatings.TabIndex = 45;
            this.lblLowRatings.Text = "-";
            // 
            // lblHighRatings
            // 
            this.lblHighRatings.AutoSize = true;
            this.lblHighRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighRatings.Location = new System.Drawing.Point(227, 137);
            this.lblHighRatings.Name = "lblHighRatings";
            this.lblHighRatings.Size = new System.Drawing.Size(14, 20);
            this.lblHighRatings.TabIndex = 44;
            this.lblHighRatings.Text = "-";
            this.lblHighRatings.Click += new System.EventHandler(this.lblHighRatings_Click);
            // 
            // lblHighRate
            // 
            this.lblHighRate.AutoSize = true;
            this.lblHighRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighRate.Location = new System.Drawing.Point(17, 137);
            this.lblHighRate.Name = "lblHighRate";
            this.lblHighRate.Size = new System.Drawing.Size(101, 20);
            this.lblHighRate.TabIndex = 46;
            this.lblHighRate.Text = "High Ratings";
            // 
            // lblLowRate
            // 
            this.lblLowRate.AutoSize = true;
            this.lblLowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowRate.Location = new System.Drawing.Point(17, 167);
            this.lblLowRate.Name = "lblLowRate";
            this.lblLowRate.Size = new System.Drawing.Size(97, 20);
            this.lblLowRate.TabIndex = 47;
            this.lblLowRate.Text = "Low Ratings";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(227, 227);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(14, 20);
            this.lblRevenue.TabIndex = 49;
            this.lblRevenue.Text = "-";
            // 
            // lblPaidTransactions
            // 
            this.lblPaidTransactions.AutoSize = true;
            this.lblPaidTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidTransactions.Location = new System.Drawing.Point(227, 197);
            this.lblPaidTransactions.Name = "lblPaidTransactions";
            this.lblPaidTransactions.Size = new System.Drawing.Size(14, 20);
            this.lblPaidTransactions.TabIndex = 48;
            this.lblPaidTransactions.Text = "-";
            // 
            // lblPaidTransact
            // 
            this.lblPaidTransact.AutoSize = true;
            this.lblPaidTransact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidTransact.Location = new System.Drawing.Point(17, 197);
            this.lblPaidTransact.Name = "lblPaidTransact";
            this.lblPaidTransact.Size = new System.Drawing.Size(135, 20);
            this.lblPaidTransact.TabIndex = 50;
            this.lblPaidTransact.Text = "Paid Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = ":";
            // 
            // lblTotalRevenues
            // 
            this.lblTotalRevenues.AutoSize = true;
            this.lblTotalRevenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenues.Location = new System.Drawing.Point(17, 228);
            this.lblTotalRevenues.Name = "lblTotalRevenues";
            this.lblTotalRevenues.Size = new System.Drawing.Size(112, 20);
            this.lblTotalRevenues.TabIndex = 58;
            this.lblTotalRevenues.Text = "Total Revenue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(208, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = ":";
            // 
            // lblAverageRate
            // 
            this.lblAverageRate.AutoSize = true;
            this.lblAverageRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageRate.Location = new System.Drawing.Point(17, 259);
            this.lblAverageRate.Name = "lblAverageRate";
            this.lblAverageRate.Size = new System.Drawing.Size(119, 20);
            this.lblAverageRate.TabIndex = 60;
            this.lblAverageRate.Text = "Average Rating";
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.AutoSize = true;
            this.lblAverageRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageRating.Location = new System.Drawing.Point(227, 259);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(14, 20);
            this.lblAverageRating.TabIndex = 61;
            this.lblAverageRating.Text = "-";
            // 
            // lblPopularService
            // 
            this.lblPopularService.AutoSize = true;
            this.lblPopularService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularService.Location = new System.Drawing.Point(227, 288);
            this.lblPopularService.Name = "lblPopularService";
            this.lblPopularService.Size = new System.Drawing.Size(14, 20);
            this.lblPopularService.TabIndex = 62;
            this.lblPopularService.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Most Popular Service";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(208, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 64;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(208, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = ":";
            // 
            // FrmCustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomerDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmCustomerDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPets.ResumeLayout(false);
            this.grpPetInfo.ResumeLayout(false);
            this.grpPetInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.tabAppointments.ResumeLayout(false);
            this.grpAppointmentBooking.ResumeLayout(false);
            this.grpAppointmentBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.tabPayments.ResumeLayout(false);
            this.tabFeedback.ResumeLayout(false);
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.tabStaff.ResumeLayout(false);
            this.grpStaffManagement.ResumeLayout(false);
            this.grpStaffManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroomingRecords)).EndInit();
            this.grpCustomerFeedback.ResumeLayout(false);
            this.grpCustomerFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.tabReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointmentStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaffPerformance)).EndInit();
            this.tabChart.ResumeLayout(false);
            this.tabRevenue.ResumeLayout(false);
            this.tabPopularService.ResumeLayout(false);
            this.tabCustomerGrowth.ResumeLayout(false);
            this.tabAppointmentStatus.ResumeLayout(false);
            this.tabStaffPerformance.ResumeLayout(false);
            this.grpAnalytics.ResumeLayout(false);
            this.grpAnalytics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnPets;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabPets;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.TabPage tabPayments;
        private System.Windows.Forms.TabPage tabFeedback;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPetInfo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnUpdatePet;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button btnClearPet;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.GroupBox grpAppointmentBooking;
        private System.Windows.Forms.ComboBox cmbPet;
        private System.Windows.Forms.Button btnQueueCount;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPetInformation;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblSearchAppointment;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TextBox txtAppointmentSearch;
        private System.Windows.Forms.GroupBox grpPaymentInfo;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbPaymentAppointment;
        private System.Windows.Forms.TextBox txtPaymentSearch;
        private System.Windows.Forms.Label lblPaymentSearch;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnClearPayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblPaymentInfo;
        private System.Windows.Forms.Label lblPaymentAppointment;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.GroupBox grpStaffManagement;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cmbStaffAppointment;
        private System.Windows.Forms.ComboBox cmbGroomingStatus;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.DataGridView dgvGroomingRecords;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblGroomingStatus;
        private System.Windows.Forms.Label lblStaffManagement;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblStaffAppointment;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox grpCustomerFeedback;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.ComboBox cmbFeedbackAppointment;
        private System.Windows.Forms.TextBox txtFeedbackSearch;
        private System.Windows.Forms.Label lblFeedbackSearch;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.Button btnClearFeedback;
        private System.Windows.Forms.Button btnDeleteFeedback;
        private System.Windows.Forms.Button btnSubmitFeedback;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblCustomerFeedback;
        private System.Windows.Forms.Label lblFeedbackAppointment;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStaffPerformance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointmentStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomerGrowth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopularService;
        private System.Windows.Forms.TabControl tabChart;
        private System.Windows.Forms.TabPage tabRevenue;
        private System.Windows.Forms.TabPage tabPopularService;
        private System.Windows.Forms.TabPage tabCustomerGrowth;
        private System.Windows.Forms.TabPage tabAppointmentStatus;
        private System.Windows.Forms.TabPage tabStaffPerformance;
        private System.Windows.Forms.GroupBox grpAnalytics;
        private System.Windows.Forms.Label lblCompletedGroom;
        private System.Windows.Forms.Label lblUpcomingApp;
        private System.Windows.Forms.Label lblTodayApp;
        private System.Windows.Forms.Label lblTodayAppointments;
        private System.Windows.Forms.Label lblUpcomingAppointments;
        private System.Windows.Forms.Label lblPendingGrooming;
        private System.Windows.Forms.Label lblCompletedGrooming;
        private System.Windows.Forms.Label lblLowRate;
        private System.Windows.Forms.Label lblHighRate;
        private System.Windows.Forms.Label lblLowRatings;
        private System.Windows.Forms.Label lblHighRatings;
        private System.Windows.Forms.Label lblPendingGroom;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblPaidTransactions;
        private System.Windows.Forms.Label lblAverageRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalRevenues;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaidTransact;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPopularService;
        private System.Windows.Forms.Label lblAverageRating;
    }
}