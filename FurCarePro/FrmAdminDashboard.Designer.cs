namespace FurCarePro
{
    partial class FrmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.tsbNewPet = new System.Windows.Forms.ToolStripButton();
            this.tsbNewAppointment = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.cmbCustomerStatus = new System.Windows.Forms.ComboBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
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
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbPaymentAppointment = new System.Windows.Forms.ComboBox();
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
            this.tabFeedback = new System.Windows.Forms.TabPage();
            this.grpCustomerFeedback = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.numRating = new System.Windows.Forms.NumericUpDown();
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
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.grpStaffManagement = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cmbStaffAppointment = new System.Windows.Forms.ComboBox();
            this.cmbGroomingStatus = new System.Windows.Forms.ComboBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.dgvGroomingRecords = new System.Windows.Forms.DataGridView();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblGroomingStatus = new System.Windows.Forms.Label();
            this.lblStaffManagement = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblStaffAppointment = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.grpAnalytics = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPopularService = new System.Windows.Forms.Label();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblAverageRate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalRevenues = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPaidTransact = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblPaidTransactions = new System.Windows.Forms.Label();
            this.lblLowRate = new System.Windows.Forms.Label();
            this.lblHighRate = new System.Windows.Forms.Label();
            this.lblLowRatings = new System.Windows.Forms.Label();
            this.lblHighRatings = new System.Windows.Forms.Label();
            this.lblPendingGroom = new System.Windows.Forms.Label();
            this.lblPendingGrooming = new System.Windows.Forms.Label();
            this.lblCompletedGrooming = new System.Windows.Forms.Label();
            this.lblCompletedGroom = new System.Windows.Forms.Label();
            this.lblUpcomingApp = new System.Windows.Forms.Label();
            this.lblTodayApp = new System.Windows.Forms.Label();
            this.lblTodayAppointments = new System.Windows.Forms.Label();
            this.lblUpcomingAppointments = new System.Windows.Forms.Label();
            this.tabChart = new System.Windows.Forms.TabControl();
            this.tabRevenue = new System.Windows.Forms.TabPage();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPopularService = new System.Windows.Forms.TabPage();
            this.chartPopularService = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabCustomerGrowth = new System.Windows.Forms.TabPage();
            this.chartCustomerGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabAppointmentStatus = new System.Windows.Forms.TabPage();
            this.chartAppointmentStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabStaffPerformance = new System.Windows.Forms.TabPage();
            this.chartStaffPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPets.SuspendLayout();
            this.grpPetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.tabAppointments.SuspendLayout();
            this.grpAppointmentBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.tabPayments.SuspendLayout();
            this.grpPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.tabFeedback.SuspendLayout();
            this.grpCustomerFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.tabStaff.SuspendLayout();
            this.grpStaffManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroomingRecords)).BeginInit();
            this.tabReports.SuspendLayout();
            this.grpAnalytics.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.tabRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.tabPopularService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularService)).BeginInit();
            this.tabCustomerGrowth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerGrowth)).BeginInit();
            this.tabAppointmentStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointmentStatus)).BeginInit();
            this.tabStaffPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaffPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exportReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exportReportToolStripMenuItem.Text = "Export Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueReportToolStripMenuItem,
            this.appointmentReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.revenueReportToolStripMenuItem.Text = "Revenue Report";
            // 
            // appointmentReportToolStripMenuItem
            // 
            this.appointmentReportToolStripMenuItem.Name = "appointmentReportToolStripMenuItem";
            this.appointmentReportToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.appointmentReportToolStripMenuItem.Text = "Appointment Report";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewCustomer,
            this.tsbNewPet,
            this.tsbNewAppointment,
            this.tsbRefresh,
            this.tsbExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1384, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewCustomer
            // 
            this.tsbNewCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCustomer.Image")));
            this.tsbNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCustomer.Name = "tsbNewCustomer";
            this.tsbNewCustomer.Size = new System.Drawing.Size(90, 22);
            this.tsbNewCustomer.Text = "New Customer";
            // 
            // tsbNewPet
            // 
            this.tsbNewPet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewPet.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewPet.Image")));
            this.tsbNewPet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewPet.Name = "tsbNewPet";
            this.tsbNewPet.Size = new System.Drawing.Size(55, 22);
            this.tsbNewPet.Text = "New Pet";
            // 
            // tsbNewAppointment
            // 
            this.tsbNewAppointment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewAppointment.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewAppointment.Image")));
            this.tsbNewAppointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewAppointment.Name = "tsbNewAppointment";
            this.tsbNewAppointment.Size = new System.Drawing.Size(109, 22);
            this.tsbNewAppointment.Text = "New Appointment";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(50, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(44, 22);
            this.tsbExport.Text = "Export";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleName = "leftPanel";
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleName = "rightPanel";
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Size = new System.Drawing.Size(1384, 712);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCustomer);
            this.tabMain.Controls.Add(this.tabPets);
            this.tabMain.Controls.Add(this.tabAppointments);
            this.tabMain.Controls.Add(this.tabPayments);
            this.tabMain.Controls.Add(this.tabFeedback);
            this.tabMain.Controls.Add(this.tabProfile);
            this.tabMain.Controls.Add(this.tabStaff);
            this.tabMain.Controls.Add(this.tabReports);
            this.tabMain.Controls.Add(this.tabServices);
            this.tabMain.Location = new System.Drawing.Point(57, 15);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1031, 660);
            this.tabMain.TabIndex = 1;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.grpCustomerDetails);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1023, 634);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customer Management";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.txtSearchCustomer);
            this.grpCustomerDetails.Controls.Add(this.btnSearchCustomer);
            this.grpCustomerDetails.Controls.Add(this.lblTotalCustomers);
            this.grpCustomerDetails.Controls.Add(this.cmbCustomerStatus);
            this.grpCustomerDetails.Controls.Add(this.txtCustomerPhone);
            this.grpCustomerDetails.Controls.Add(this.txtCustomerName);
            this.grpCustomerDetails.Controls.Add(this.lblSearchCustomer);
            this.grpCustomerDetails.Controls.Add(this.dgvCustomers);
            this.grpCustomerDetails.Controls.Add(this.btnClearCustomer);
            this.grpCustomerDetails.Controls.Add(this.btnDeleteCustomer);
            this.grpCustomerDetails.Controls.Add(this.btnUpdateCustomer);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerStatus);
            this.grpCustomerDetails.Controls.Add(this.lblPhone);
            this.grpCustomerDetails.Controls.Add(this.txtCustomerEmail);
            this.grpCustomerDetails.Controls.Add(this.lblEmail);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerDetails);
            this.grpCustomerDetails.Controls.Add(this.txtCustomerID);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerID);
            this.grpCustomerDetails.Controls.Add(this.lblFullName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(19, 20);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(985, 608);
            this.grpCustomerDetails.TabIndex = 11;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // cmbCustomerStatus
            // 
            this.cmbCustomerStatus.FormattingEnabled = true;
            this.cmbCustomerStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbCustomerStatus.Location = new System.Drawing.Point(49, 308);
            this.cmbCustomerStatus.Name = "cmbCustomerStatus";
            this.cmbCustomerStatus.Size = new System.Drawing.Size(218, 21);
            this.cmbCustomerStatus.TabIndex = 27;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(49, 254);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(402, 20);
            this.txtCustomerPhone.TabIndex = 26;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(49, 133);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(402, 20);
            this.txtCustomerName.TabIndex = 25;
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.Location = new System.Drawing.Point(49, 398);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(137, 20);
            this.lblSearchCustomer.TabIndex = 23;
            this.lblSearchCustomer.Text = "Search Customer:";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(49, 427);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(881, 178);
            this.dgvCustomers.TabIndex = 22;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(270, 353);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnClearCustomer.TabIndex = 21;
            this.btnClearCustomer.Text = "Clear";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(157, 353);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 20;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(50, 353);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 19;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // lblCustomerStatus
            // 
            this.lblCustomerStatus.AutoSize = true;
            this.lblCustomerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerStatus.Location = new System.Drawing.Point(45, 285);
            this.lblCustomerStatus.Name = "lblCustomerStatus";
            this.lblCustomerStatus.Size = new System.Drawing.Size(56, 20);
            this.lblCustomerStatus.TabIndex = 16;
            this.lblCustomerStatus.Text = "Status";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(45, 231);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(49, 194);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(402, 20);
            this.txtCustomerEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(45, 171);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.Location = new System.Drawing.Point(49, 16);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(242, 32);
            this.lblCustomerDetails.TabIndex = 9;
            this.lblCustomerDetails.Text = "CUSTOMER DETAILS";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(52, 79);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(402, 20);
            this.txtCustomerID.TabIndex = 6;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(48, 56);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerID.TabIndex = 5;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(45, 110);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 20);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Full Name";
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
            // 
            // btnClearPet
            // 
            this.btnClearPet.Location = new System.Drawing.Point(370, 353);
            this.btnClearPet.Name = "btnClearPet";
            this.btnClearPet.Size = new System.Drawing.Size(75, 23);
            this.btnClearPet.TabIndex = 21;
            this.btnClearPet.Text = "Clear";
            this.btnClearPet.UseVisualStyleBackColor = true;
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Location = new System.Drawing.Point(257, 353);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePet.TabIndex = 20;
            this.btnDeletePet.Text = "Delete";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePet
            // 
            this.btnUpdatePet.Location = new System.Drawing.Point(150, 353);
            this.btnUpdatePet.Name = "btnUpdatePet";
            this.btnUpdatePet.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePet.TabIndex = 19;
            this.btnUpdatePet.Text = "Update";
            this.btnUpdatePet.UseVisualStyleBackColor = true;
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(49, 353);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(75, 23);
            this.btnAddPet.TabIndex = 18;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
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
            this.cmbSpecies.Location = new System.Drawing.Point(49, 133);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(121, 21);
            this.cmbSpecies.TabIndex = 8;
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
            // 
            // txtAppointmentSearch
            // 
            this.txtAppointmentSearch.Location = new System.Drawing.Point(207, 417);
            this.txtAppointmentSearch.Name = "txtAppointmentSearch";
            this.txtAppointmentSearch.Size = new System.Drawing.Size(402, 20);
            this.txtAppointmentSearch.TabIndex = 32;
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
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(258, 379);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAppointment.TabIndex = 20;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Location = new System.Drawing.Point(151, 379);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAppointment.TabIndex = 19;
            this.btnUpdateAppointment.Text = "Update";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(50, 379);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnBookAppointment.TabIndex = 18;
            this.btnBookAppointment.Text = "Book";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
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
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(49, 254);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(201, 21);
            this.cmbPaymentStatus.TabIndex = 28;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(49, 194);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(201, 21);
            this.cmbPaymentMethod.TabIndex = 27;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(49, 133);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(402, 20);
            this.txtAmount.TabIndex = 26;
            // 
            // cmbPaymentAppointment
            // 
            this.cmbPaymentAppointment.FormattingEnabled = true;
            this.cmbPaymentAppointment.Location = new System.Drawing.Point(49, 79);
            this.cmbPaymentAppointment.Name = "cmbPaymentAppointment";
            this.cmbPaymentAppointment.Size = new System.Drawing.Size(201, 21);
            this.cmbPaymentAppointment.TabIndex = 25;
            // 
            // txtPaymentSearch
            // 
            this.txtPaymentSearch.Location = new System.Drawing.Point(55, 364);
            this.txtPaymentSearch.Name = "txtPaymentSearch";
            this.txtPaymentSearch.Size = new System.Drawing.Size(414, 20);
            this.txtPaymentSearch.TabIndex = 24;
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
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(49, 194);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(402, 87);
            this.txtComments.TabIndex = 30;
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
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(49, 281);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(304, 20);
            this.txtNotes.TabIndex = 31;
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
            // cmbStaffAppointment
            // 
            this.cmbStaffAppointment.FormattingEnabled = true;
            this.cmbStaffAppointment.Location = new System.Drawing.Point(49, 148);
            this.cmbStaffAppointment.Name = "cmbStaffAppointment";
            this.cmbStaffAppointment.Size = new System.Drawing.Size(201, 21);
            this.cmbStaffAppointment.TabIndex = 29;
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
            // tabReports
            // 
            this.tabReports.Controls.Add(this.grpAnalytics);
            this.tabReports.Controls.Add(this.tabChart);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(1023, 634);
            this.tabReports.TabIndex = 7;
            this.tabReports.Text = "Reports & Analytics";
            this.tabReports.UseVisualStyleBackColor = true;
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
            this.tabRevenue.Size = new System.Drawing.Size(1003, 266);
            this.tabRevenue.TabIndex = 0;
            this.tabRevenue.Text = "Revenue Chart";
            this.tabRevenue.UseVisualStyleBackColor = true;
            // 
            // chartRevenue
            // 
            chartArea6.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend6);
            this.chartRevenue.Location = new System.Drawing.Point(319, 26);
            this.chartRevenue.Name = "chartRevenue";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartRevenue.Series.Add(series6);
            this.chartRevenue.Size = new System.Drawing.Size(320, 210);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart2";
            // 
            // tabPopularService
            // 
            this.tabPopularService.Controls.Add(this.chartPopularService);
            this.tabPopularService.Location = new System.Drawing.Point(4, 22);
            this.tabPopularService.Name = "tabPopularService";
            this.tabPopularService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopularService.Size = new System.Drawing.Size(1003, 266);
            this.tabPopularService.TabIndex = 1;
            this.tabPopularService.Text = "Popular Service Chart";
            this.tabPopularService.UseVisualStyleBackColor = true;
            // 
            // chartPopularService
            // 
            chartArea7.Name = "ChartArea1";
            this.chartPopularService.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartPopularService.Legends.Add(legend7);
            this.chartPopularService.Location = new System.Drawing.Point(319, 26);
            this.chartPopularService.Name = "chartPopularService";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartPopularService.Series.Add(series7);
            this.chartPopularService.Size = new System.Drawing.Size(320, 210);
            this.chartPopularService.TabIndex = 2;
            this.chartPopularService.Text = "chart2";
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
            // chartCustomerGrowth
            // 
            chartArea8.Name = "ChartArea1";
            this.chartCustomerGrowth.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartCustomerGrowth.Legends.Add(legend8);
            this.chartCustomerGrowth.Location = new System.Drawing.Point(319, 26);
            this.chartCustomerGrowth.Name = "chartCustomerGrowth";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartCustomerGrowth.Series.Add(series8);
            this.chartCustomerGrowth.Size = new System.Drawing.Size(320, 210);
            this.chartCustomerGrowth.TabIndex = 3;
            this.chartCustomerGrowth.Text = "chart2";
            // 
            // tabAppointmentStatus
            // 
            this.tabAppointmentStatus.Controls.Add(this.chartAppointmentStatus);
            this.tabAppointmentStatus.Location = new System.Drawing.Point(4, 22);
            this.tabAppointmentStatus.Name = "tabAppointmentStatus";
            this.tabAppointmentStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointmentStatus.Size = new System.Drawing.Size(1003, 266);
            this.tabAppointmentStatus.TabIndex = 3;
            this.tabAppointmentStatus.Text = "Appointment Status Chart";
            this.tabAppointmentStatus.UseVisualStyleBackColor = true;
            // 
            // chartAppointmentStatus
            // 
            chartArea9.Name = "ChartArea1";
            this.chartAppointmentStatus.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartAppointmentStatus.Legends.Add(legend9);
            this.chartAppointmentStatus.Location = new System.Drawing.Point(319, 26);
            this.chartAppointmentStatus.Name = "chartAppointmentStatus";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartAppointmentStatus.Series.Add(series9);
            this.chartAppointmentStatus.Size = new System.Drawing.Size(320, 210);
            this.chartAppointmentStatus.TabIndex = 4;
            this.chartAppointmentStatus.Text = "chart2";
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
            // chartStaffPerformance
            // 
            chartArea10.Name = "ChartArea1";
            this.chartStaffPerformance.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartStaffPerformance.Legends.Add(legend10);
            this.chartStaffPerformance.Location = new System.Drawing.Point(319, 26);
            this.chartStaffPerformance.Name = "chartStaffPerformance";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartStaffPerformance.Series.Add(series10);
            this.chartStaffPerformance.Size = new System.Drawing.Size(320, 210);
            this.chartStaffPerformance.TabIndex = 5;
            this.chartStaffPerformance.Text = "chart2";
            // 
            // tabServices
            // 
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(1023, 634);
            this.tabServices.TabIndex = 8;
            this.tabServices.Text = "Services";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.Location = new System.Drawing.Point(705, 398);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(142, 20);
            this.lblTotalCustomers.TabIndex = 28;
            this.lblTotalCustomers.Text = "Total Customers: 0";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(192, 398);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomer.TabIndex = 29;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(273, 398);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(402, 20);
            this.txtSearchCustomer.TabIndex = 30;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminDashboard";
            this.Load += new System.EventHandler(this.FrmAdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
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
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.tabFeedback.ResumeLayout(false);
            this.grpCustomerFeedback.ResumeLayout(false);
            this.grpCustomerFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.tabStaff.ResumeLayout(false);
            this.grpStaffManagement.ResumeLayout(false);
            this.grpStaffManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroomingRecords)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.grpAnalytics.ResumeLayout(false);
            this.grpAnalytics.PerformLayout();
            this.tabChart.ResumeLayout(false);
            this.tabRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.tabPopularService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularService)).EndInit();
            this.tabCustomerGrowth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerGrowth)).EndInit();
            this.tabAppointmentStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointmentStatus)).EndInit();
            this.tabStaffPerformance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStaffPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewCustomer;
        private System.Windows.Forms.ToolStripButton tsbNewPet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsbNewAppointment;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabPets;
        private System.Windows.Forms.GroupBox grpPetInfo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Button btnClearPet;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.Button btnUpdatePet;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.GroupBox grpAppointmentBooking;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TextBox txtAppointmentSearch;
        private System.Windows.Forms.Label lblSearchAppointment;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.TextBox txtDuration;
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
        private System.Windows.Forms.TabPage tabPayments;
        private System.Windows.Forms.GroupBox grpPaymentInfo;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
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
        private System.Windows.Forms.TabPage tabFeedback;
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
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.GroupBox grpStaffManagement;
        private System.Windows.Forms.TextBox txtNotes;
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
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.GroupBox grpAnalytics;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPopularService;
        private System.Windows.Forms.Label lblAverageRating;
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
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblPaidTransactions;
        private System.Windows.Forms.Label lblLowRate;
        private System.Windows.Forms.Label lblHighRate;
        private System.Windows.Forms.Label lblLowRatings;
        private System.Windows.Forms.Label lblHighRatings;
        private System.Windows.Forms.Label lblPendingGroom;
        private System.Windows.Forms.Label lblPendingGrooming;
        private System.Windows.Forms.Label lblCompletedGrooming;
        private System.Windows.Forms.Label lblCompletedGroom;
        private System.Windows.Forms.Label lblUpcomingApp;
        private System.Windows.Forms.Label lblTodayApp;
        private System.Windows.Forms.Label lblTodayAppointments;
        private System.Windows.Forms.Label lblUpcomingAppointments;
        private System.Windows.Forms.TabControl tabChart;
        private System.Windows.Forms.TabPage tabRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.TabPage tabPopularService;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopularService;
        private System.Windows.Forms.TabPage tabCustomerGrowth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomerGrowth;
        private System.Windows.Forms.TabPage tabAppointmentStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointmentStatus;
        private System.Windows.Forms.TabPage tabStaffPerformance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStaffPerformance;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.ComboBox cmbCustomerStatus;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
    }
}