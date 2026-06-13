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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
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
            this.grpPetDetails = new System.Windows.Forms.GroupBox();
            this.txtSearchPet = new System.Windows.Forms.TextBox();
            this.lblSearchPet = new System.Windows.Forms.Label();
            this.dgvAdminPets = new System.Windows.Forms.DataGridView();
            this.btnClearPet = new System.Windows.Forms.Button();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnUpdatePet = new System.Windows.Forms.Button();
            this.lblAdminBreed = new System.Windows.Forms.Label();
            this.lblAdminSpecies = new System.Windows.Forms.Label();
            this.txtAdminPetName = new System.Windows.Forms.TextBox();
            this.lblAdminPetName = new System.Windows.Forms.Label();
            this.lblTitlePetDetails = new System.Windows.Forms.Label();
            this.txtAdminPetID = new System.Windows.Forms.TextBox();
            this.lblPetID = new System.Windows.Forms.Label();
            this.cmbAdminOwner = new System.Windows.Forms.ComboBox();
            this.lblOwnerPet = new System.Windows.Forms.Label();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.grpAppointmentDetails = new System.Windows.Forms.GroupBox();
            this.dgvAdminAppointments = new System.Windows.Forms.DataGridView();
            this.cmbAdminAppointmentStatus = new System.Windows.Forms.ComboBox();
            this.lblAdminAppointmentStatus = new System.Windows.Forms.Label();
            this.dtpAdminAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.btnClearAppointment = new System.Windows.Forms.Button();
            this.lblAdminAppointment = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblAppointmentDetails = new System.Windows.Forms.Label();
            this.lblAdminAppointmentID = new System.Windows.Forms.Label();
            this.lblPetName = new System.Windows.Forms.Label();
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
            this.cmbAdminSpecies = new System.Windows.Forms.ComboBox();
            this.txtAdminBreed = new System.Windows.Forms.TextBox();
            this.lblAdminWeight = new System.Windows.Forms.Label();
            this.btnSearchPet = new System.Windows.Forms.Button();
            this.lblTotalPets = new System.Windows.Forms.Label();
            this.txtAdminWeight = new System.Windows.Forms.TextBox();
            this.cmbAdminGender = new System.Windows.Forms.ComboBox();
            this.lblAdminGender = new System.Windows.Forms.Label();
            this.lblDogs = new System.Windows.Forms.Label();
            this.lblCats = new System.Windows.Forms.Label();
            this.lblBirds = new System.Windows.Forms.Label();
            this.lblMostCommonSpecies = new System.Windows.Forms.Label();
            this.lblTotalDogs = new System.Windows.Forms.Label();
            this.lblTotalCats = new System.Windows.Forms.Label();
            this.lblTotalBirds = new System.Windows.Forms.Label();
            this.lblMostCommonSpeciess = new System.Windows.Forms.Label();
            this.txtAdminAppointmentID = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.btnSearchAppointment = new System.Windows.Forms.Button();
            this.txtSearchAppointment = new System.Windows.Forms.TextBox();
            this.lblSearchPetName = new System.Windows.Forms.Label();
            this.lblTotalAppointments = new System.Windows.Forms.Label();
            this.lblPendingAppointments = new System.Windows.Forms.Label();
            this.lblCompletedAppointments = new System.Windows.Forms.Label();
            this.lblQueueCount = new System.Windows.Forms.Label();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.btnProcessQueue = new System.Windows.Forms.Button();
            this.grpServiceDetails = new System.Windows.Forms.GroupBox();
            this.lblLastAction = new System.Windows.Forms.Label();
            this.lblTotalServices = new System.Windows.Forms.Label();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.txtServiceManagementName = new System.Windows.Forms.TextBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnClearService = new System.Windows.Forms.Button();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.lblServiceDetails = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblServiceManagementName = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.rtxtServiceDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.txtServiceDuration = new System.Windows.Forms.TextBox();
            this.lblServiceDuration = new System.Windows.Forms.Label();
            this.lblUniqueBreeds = new System.Windows.Forms.Label();
            this.btnShowBreeds = new System.Windows.Forms.Button();
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
            this.grpPetDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPets)).BeginInit();
            this.tabAppointments.SuspendLayout();
            this.grpAppointmentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAppointments)).BeginInit();
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
            this.tabServices.SuspendLayout();
            this.grpServiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
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
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(273, 398);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(402, 20);
            this.txtSearchCustomer.TabIndex = 30;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
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
            this.tabPets.Controls.Add(this.grpPetDetails);
            this.tabPets.Location = new System.Drawing.Point(4, 22);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPets.Size = new System.Drawing.Size(1023, 634);
            this.tabPets.TabIndex = 1;
            this.tabPets.Text = "Pet Management";
            this.tabPets.UseVisualStyleBackColor = true;
            this.tabPets.Click += new System.EventHandler(this.tabPets_Click);
            // 
            // grpPetDetails
            // 
            this.grpPetDetails.Controls.Add(this.btnShowBreeds);
            this.grpPetDetails.Controls.Add(this.lblUniqueBreeds);
            this.grpPetDetails.Controls.Add(this.lblMostCommonSpeciess);
            this.grpPetDetails.Controls.Add(this.lblTotalBirds);
            this.grpPetDetails.Controls.Add(this.lblTotalCats);
            this.grpPetDetails.Controls.Add(this.lblTotalDogs);
            this.grpPetDetails.Controls.Add(this.lblMostCommonSpecies);
            this.grpPetDetails.Controls.Add(this.lblBirds);
            this.grpPetDetails.Controls.Add(this.lblCats);
            this.grpPetDetails.Controls.Add(this.lblDogs);
            this.grpPetDetails.Controls.Add(this.lblAdminGender);
            this.grpPetDetails.Controls.Add(this.cmbAdminGender);
            this.grpPetDetails.Controls.Add(this.lblTotalPets);
            this.grpPetDetails.Controls.Add(this.btnSearchPet);
            this.grpPetDetails.Controls.Add(this.txtAdminWeight);
            this.grpPetDetails.Controls.Add(this.lblAdminWeight);
            this.grpPetDetails.Controls.Add(this.txtAdminBreed);
            this.grpPetDetails.Controls.Add(this.cmbAdminSpecies);
            this.grpPetDetails.Controls.Add(this.txtSearchPet);
            this.grpPetDetails.Controls.Add(this.lblSearchPet);
            this.grpPetDetails.Controls.Add(this.dgvAdminPets);
            this.grpPetDetails.Controls.Add(this.btnClearPet);
            this.grpPetDetails.Controls.Add(this.btnDeletePet);
            this.grpPetDetails.Controls.Add(this.btnUpdatePet);
            this.grpPetDetails.Controls.Add(this.lblAdminBreed);
            this.grpPetDetails.Controls.Add(this.lblAdminSpecies);
            this.grpPetDetails.Controls.Add(this.txtAdminPetName);
            this.grpPetDetails.Controls.Add(this.lblAdminPetName);
            this.grpPetDetails.Controls.Add(this.lblTitlePetDetails);
            this.grpPetDetails.Controls.Add(this.txtAdminPetID);
            this.grpPetDetails.Controls.Add(this.lblPetID);
            this.grpPetDetails.Controls.Add(this.cmbAdminOwner);
            this.grpPetDetails.Controls.Add(this.lblOwnerPet);
            this.grpPetDetails.Location = new System.Drawing.Point(19, 20);
            this.grpPetDetails.Name = "grpPetDetails";
            this.grpPetDetails.Size = new System.Drawing.Size(985, 608);
            this.grpPetDetails.TabIndex = 10;
            this.grpPetDetails.TabStop = false;
            this.grpPetDetails.Text = "Pet Details";
            this.grpPetDetails.Enter += new System.EventHandler(this.grpPetDetails_Enter);
            // 
            // txtSearchPet
            // 
            this.txtSearchPet.Location = new System.Drawing.Point(629, 58);
            this.txtSearchPet.Name = "txtSearchPet";
            this.txtSearchPet.Size = new System.Drawing.Size(340, 20);
            this.txtSearchPet.TabIndex = 24;
            this.txtSearchPet.TextChanged += new System.EventHandler(this.txtSearchPet_TextChanged);
            // 
            // lblSearchPet
            // 
            this.lblSearchPet.AutoSize = true;
            this.lblSearchPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPet.Location = new System.Drawing.Point(478, 58);
            this.lblSearchPet.Name = "lblSearchPet";
            this.lblSearchPet.Size = new System.Drawing.Size(64, 20);
            this.lblSearchPet.TabIndex = 23;
            this.lblSearchPet.Text = "Search:";
            // 
            // dgvAdminPets
            // 
            this.dgvAdminPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminPets.Location = new System.Drawing.Point(482, 95);
            this.dgvAdminPets.MultiSelect = false;
            this.dgvAdminPets.Name = "dgvAdminPets";
            this.dgvAdminPets.ReadOnly = true;
            this.dgvAdminPets.Size = new System.Drawing.Size(486, 214);
            this.dgvAdminPets.TabIndex = 22;
            this.dgvAdminPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminPets_CellContentClick);
            // 
            // btnClearPet
            // 
            this.btnClearPet.Location = new System.Drawing.Point(268, 480);
            this.btnClearPet.Name = "btnClearPet";
            this.btnClearPet.Size = new System.Drawing.Size(75, 23);
            this.btnClearPet.TabIndex = 21;
            this.btnClearPet.Text = "Clear";
            this.btnClearPet.UseVisualStyleBackColor = true;
            this.btnClearPet.Click += new System.EventHandler(this.btnClearPet_Click);
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Location = new System.Drawing.Point(155, 480);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePet.TabIndex = 20;
            this.btnDeletePet.Text = "Delete";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // btnUpdatePet
            // 
            this.btnUpdatePet.Location = new System.Drawing.Point(48, 480);
            this.btnUpdatePet.Name = "btnUpdatePet";
            this.btnUpdatePet.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePet.TabIndex = 19;
            this.btnUpdatePet.Text = "Update";
            this.btnUpdatePet.UseVisualStyleBackColor = true;
            this.btnUpdatePet.Click += new System.EventHandler(this.btnUpdatePet_Click);
            // 
            // lblAdminBreed
            // 
            this.lblAdminBreed.AutoSize = true;
            this.lblAdminBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminBreed.Location = new System.Drawing.Point(45, 280);
            this.lblAdminBreed.Name = "lblAdminBreed";
            this.lblAdminBreed.Size = new System.Drawing.Size(52, 20);
            this.lblAdminBreed.TabIndex = 16;
            this.lblAdminBreed.Text = "Breed";
            // 
            // lblAdminSpecies
            // 
            this.lblAdminSpecies.AutoSize = true;
            this.lblAdminSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminSpecies.Location = new System.Drawing.Point(45, 226);
            this.lblAdminSpecies.Name = "lblAdminSpecies";
            this.lblAdminSpecies.Size = new System.Drawing.Size(66, 20);
            this.lblAdminSpecies.TabIndex = 12;
            this.lblAdminSpecies.Text = "Species";
            // 
            // txtAdminPetName
            // 
            this.txtAdminPetName.Location = new System.Drawing.Point(49, 194);
            this.txtAdminPetName.Name = "txtAdminPetName";
            this.txtAdminPetName.Size = new System.Drawing.Size(402, 20);
            this.txtAdminPetName.TabIndex = 11;
            // 
            // lblAdminPetName
            // 
            this.lblAdminPetName.AutoSize = true;
            this.lblAdminPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPetName.Location = new System.Drawing.Point(45, 171);
            this.lblAdminPetName.Name = "lblAdminPetName";
            this.lblAdminPetName.Size = new System.Drawing.Size(79, 20);
            this.lblAdminPetName.TabIndex = 10;
            this.lblAdminPetName.Text = "Pet Name";
            // 
            // lblTitlePetDetails
            // 
            this.lblTitlePetDetails.AutoSize = true;
            this.lblTitlePetDetails.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePetDetails.Location = new System.Drawing.Point(49, 16);
            this.lblTitlePetDetails.Name = "lblTitlePetDetails";
            this.lblTitlePetDetails.Size = new System.Drawing.Size(156, 32);
            this.lblTitlePetDetails.TabIndex = 9;
            this.lblTitlePetDetails.Text = "PET DETAILS";
            // 
            // txtAdminPetID
            // 
            this.txtAdminPetID.Location = new System.Drawing.Point(52, 79);
            this.txtAdminPetID.Name = "txtAdminPetID";
            this.txtAdminPetID.Size = new System.Drawing.Size(402, 20);
            this.txtAdminPetID.TabIndex = 6;
            // 
            // lblPetID
            // 
            this.lblPetID.AutoSize = true;
            this.lblPetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetID.Location = new System.Drawing.Point(48, 56);
            this.lblPetID.Name = "lblPetID";
            this.lblPetID.Size = new System.Drawing.Size(54, 20);
            this.lblPetID.TabIndex = 5;
            this.lblPetID.Text = "Pet ID";
            // 
            // cmbAdminOwner
            // 
            this.cmbAdminOwner.FormattingEnabled = true;
            this.cmbAdminOwner.Location = new System.Drawing.Point(49, 133);
            this.cmbAdminOwner.Name = "cmbAdminOwner";
            this.cmbAdminOwner.Size = new System.Drawing.Size(121, 21);
            this.cmbAdminOwner.TabIndex = 8;
            // 
            // lblOwnerPet
            // 
            this.lblOwnerPet.AutoSize = true;
            this.lblOwnerPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerPet.Location = new System.Drawing.Point(45, 110);
            this.lblOwnerPet.Name = "lblOwnerPet";
            this.lblOwnerPet.Size = new System.Drawing.Size(55, 20);
            this.lblOwnerPet.TabIndex = 7;
            this.lblOwnerPet.Text = "Owner";
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.grpAppointmentDetails);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointments.Size = new System.Drawing.Size(1023, 634);
            this.tabAppointments.TabIndex = 2;
            this.tabAppointments.Text = "Appointment Management";
            this.tabAppointments.UseVisualStyleBackColor = true;
            // 
            // grpAppointmentDetails
            // 
            this.grpAppointmentDetails.Controls.Add(this.btnProcessQueue);
            this.grpAppointmentDetails.Controls.Add(this.btnAddToQueue);
            this.grpAppointmentDetails.Controls.Add(this.lblQueueCount);
            this.grpAppointmentDetails.Controls.Add(this.lblCompletedAppointments);
            this.grpAppointmentDetails.Controls.Add(this.lblPendingAppointments);
            this.grpAppointmentDetails.Controls.Add(this.lblTotalAppointments);
            this.grpAppointmentDetails.Controls.Add(this.btnSearchAppointment);
            this.grpAppointmentDetails.Controls.Add(this.txtSearchAppointment);
            this.grpAppointmentDetails.Controls.Add(this.lblSearchPetName);
            this.grpAppointmentDetails.Controls.Add(this.txtServiceName);
            this.grpAppointmentDetails.Controls.Add(this.txtPetName);
            this.grpAppointmentDetails.Controls.Add(this.txtAdminAppointmentID);
            this.grpAppointmentDetails.Controls.Add(this.dgvAdminAppointments);
            this.grpAppointmentDetails.Controls.Add(this.cmbAdminAppointmentStatus);
            this.grpAppointmentDetails.Controls.Add(this.lblAdminAppointmentStatus);
            this.grpAppointmentDetails.Controls.Add(this.dtpAdminAppointment);
            this.grpAppointmentDetails.Controls.Add(this.btnDeleteAppointment);
            this.grpAppointmentDetails.Controls.Add(this.btnUpdateAppointment);
            this.grpAppointmentDetails.Controls.Add(this.btnClearAppointment);
            this.grpAppointmentDetails.Controls.Add(this.lblAdminAppointment);
            this.grpAppointmentDetails.Controls.Add(this.lblServiceName);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentDetails);
            this.grpAppointmentDetails.Controls.Add(this.lblAdminAppointmentID);
            this.grpAppointmentDetails.Controls.Add(this.lblPetName);
            this.grpAppointmentDetails.Location = new System.Drawing.Point(19, 20);
            this.grpAppointmentDetails.Name = "grpAppointmentDetails";
            this.grpAppointmentDetails.Size = new System.Drawing.Size(985, 608);
            this.grpAppointmentDetails.TabIndex = 11;
            this.grpAppointmentDetails.TabStop = false;
            this.grpAppointmentDetails.Text = "Appointment Details";
            // 
            // dgvAdminAppointments
            // 
            this.dgvAdminAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminAppointments.Location = new System.Drawing.Point(50, 415);
            this.dgvAdminAppointments.MultiSelect = false;
            this.dgvAdminAppointments.Name = "dgvAdminAppointments";
            this.dgvAdminAppointments.ReadOnly = true;
            this.dgvAdminAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminAppointments.Size = new System.Drawing.Size(876, 187);
            this.dgvAdminAppointments.TabIndex = 33;
            this.dgvAdminAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminAppointments_CellContentClick);
            // 
            // cmbAdminAppointmentStatus
            // 
            this.cmbAdminAppointmentStatus.FormattingEnabled = true;
            this.cmbAdminAppointmentStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Completed",
            "Cancelled"});
            this.cmbAdminAppointmentStatus.Location = new System.Drawing.Point(49, 289);
            this.cmbAdminAppointmentStatus.Name = "cmbAdminAppointmentStatus";
            this.cmbAdminAppointmentStatus.Size = new System.Drawing.Size(176, 21);
            this.cmbAdminAppointmentStatus.TabIndex = 30;
            // 
            // lblAdminAppointmentStatus
            // 
            this.lblAdminAppointmentStatus.AutoSize = true;
            this.lblAdminAppointmentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAppointmentStatus.Location = new System.Drawing.Point(45, 266);
            this.lblAdminAppointmentStatus.Name = "lblAdminAppointmentStatus";
            this.lblAdminAppointmentStatus.Size = new System.Drawing.Size(56, 20);
            this.lblAdminAppointmentStatus.TabIndex = 28;
            this.lblAdminAppointmentStatus.Text = "Status";
            // 
            // dtpAdminAppointment
            // 
            this.dtpAdminAppointment.Location = new System.Drawing.Point(49, 232);
            this.dtpAdminAppointment.Name = "dtpAdminAppointment";
            this.dtpAdminAppointment.Size = new System.Drawing.Size(200, 20);
            this.dtpAdminAppointment.TabIndex = 27;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(154, 331);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAppointment.TabIndex = 20;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Location = new System.Drawing.Point(47, 331);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAppointment.TabIndex = 19;
            this.btnUpdateAppointment.Text = "Update";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // btnClearAppointment
            // 
            this.btnClearAppointment.Location = new System.Drawing.Point(263, 331);
            this.btnClearAppointment.Name = "btnClearAppointment";
            this.btnClearAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnClearAppointment.TabIndex = 18;
            this.btnClearAppointment.Text = "Clear";
            this.btnClearAppointment.UseVisualStyleBackColor = true;
            this.btnClearAppointment.Click += new System.EventHandler(this.btnClearAppointment_Click);
            // 
            // lblAdminAppointment
            // 
            this.lblAdminAppointment.AutoSize = true;
            this.lblAdminAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAppointment.Location = new System.Drawing.Point(45, 209);
            this.lblAdminAppointment.Name = "lblAdminAppointment";
            this.lblAdminAppointment.Size = new System.Drawing.Size(139, 20);
            this.lblAdminAppointment.TabIndex = 16;
            this.lblAdminAppointment.Text = "Appointment Date";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(45, 154);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(107, 20);
            this.lblServiceName.TabIndex = 10;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblAppointmentDetails
            // 
            this.lblAppointmentDetails.AutoSize = true;
            this.lblAppointmentDetails.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDetails.Location = new System.Drawing.Point(49, 16);
            this.lblAppointmentDetails.Name = "lblAppointmentDetails";
            this.lblAppointmentDetails.Size = new System.Drawing.Size(307, 32);
            this.lblAppointmentDetails.TabIndex = 9;
            this.lblAppointmentDetails.Text = "APPOINTMENT BOOKING";
            // 
            // lblAdminAppointmentID
            // 
            this.lblAdminAppointmentID.AutoSize = true;
            this.lblAdminAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAppointmentID.Location = new System.Drawing.Point(45, 54);
            this.lblAdminAppointmentID.Name = "lblAdminAppointmentID";
            this.lblAdminAppointmentID.Size = new System.Drawing.Size(121, 20);
            this.lblAdminAppointmentID.TabIndex = 5;
            this.lblAdminAppointmentID.Text = "Appointment ID";
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(45, 104);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(79, 20);
            this.lblPetName.TabIndex = 7;
            this.lblPetName.Text = "Pet Name";
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
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(319, 26);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
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
            chartArea2.Name = "ChartArea1";
            this.chartPopularService.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPopularService.Legends.Add(legend2);
            this.chartPopularService.Location = new System.Drawing.Point(319, 26);
            this.chartPopularService.Name = "chartPopularService";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPopularService.Series.Add(series2);
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
            chartArea3.Name = "ChartArea1";
            this.chartCustomerGrowth.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCustomerGrowth.Legends.Add(legend3);
            this.chartCustomerGrowth.Location = new System.Drawing.Point(319, 26);
            this.chartCustomerGrowth.Name = "chartCustomerGrowth";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCustomerGrowth.Series.Add(series3);
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
            chartArea4.Name = "ChartArea1";
            this.chartAppointmentStatus.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartAppointmentStatus.Legends.Add(legend4);
            this.chartAppointmentStatus.Location = new System.Drawing.Point(319, 26);
            this.chartAppointmentStatus.Name = "chartAppointmentStatus";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartAppointmentStatus.Series.Add(series4);
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
            chartArea5.Name = "ChartArea1";
            this.chartStaffPerformance.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartStaffPerformance.Legends.Add(legend5);
            this.chartStaffPerformance.Location = new System.Drawing.Point(319, 26);
            this.chartStaffPerformance.Name = "chartStaffPerformance";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartStaffPerformance.Series.Add(series5);
            this.chartStaffPerformance.Size = new System.Drawing.Size(320, 210);
            this.chartStaffPerformance.TabIndex = 5;
            this.chartStaffPerformance.Text = "chart2";
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.grpServiceDetails);
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(1023, 634);
            this.tabServices.TabIndex = 8;
            this.tabServices.Text = "Service Management";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // cmbAdminSpecies
            // 
            this.cmbAdminSpecies.FormattingEnabled = true;
            this.cmbAdminSpecies.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Rabbit",
            "Bird",
            "Other"});
            this.cmbAdminSpecies.Location = new System.Drawing.Point(49, 249);
            this.cmbAdminSpecies.Name = "cmbAdminSpecies";
            this.cmbAdminSpecies.Size = new System.Drawing.Size(121, 21);
            this.cmbAdminSpecies.TabIndex = 25;
            // 
            // txtAdminBreed
            // 
            this.txtAdminBreed.Location = new System.Drawing.Point(49, 303);
            this.txtAdminBreed.Name = "txtAdminBreed";
            this.txtAdminBreed.Size = new System.Drawing.Size(402, 20);
            this.txtAdminBreed.TabIndex = 26;
            // 
            // lblAdminWeight
            // 
            this.lblAdminWeight.AutoSize = true;
            this.lblAdminWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminWeight.Location = new System.Drawing.Point(45, 402);
            this.lblAdminWeight.Name = "lblAdminWeight";
            this.lblAdminWeight.Size = new System.Drawing.Size(59, 20);
            this.lblAdminWeight.TabIndex = 27;
            this.lblAdminWeight.Text = "Weight";
            // 
            // btnSearchPet
            // 
            this.btnSearchPet.Location = new System.Drawing.Point(548, 56);
            this.btnSearchPet.Name = "btnSearchPet";
            this.btnSearchPet.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPet.TabIndex = 29;
            this.btnSearchPet.Text = "Search";
            this.btnSearchPet.UseVisualStyleBackColor = true;
            this.btnSearchPet.Click += new System.EventHandler(this.btnSearchPet_Click);
            // 
            // lblTotalPets
            // 
            this.lblTotalPets.AutoSize = true;
            this.lblTotalPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPets.Location = new System.Drawing.Point(790, 324);
            this.lblTotalPets.Name = "lblTotalPets";
            this.lblTotalPets.Size = new System.Drawing.Size(97, 20);
            this.lblTotalPets.TabIndex = 30;
            this.lblTotalPets.Text = "Total Pets: 0";
            // 
            // txtAdminWeight
            // 
            this.txtAdminWeight.Location = new System.Drawing.Point(49, 425);
            this.txtAdminWeight.Name = "txtAdminWeight";
            this.txtAdminWeight.Size = new System.Drawing.Size(402, 20);
            this.txtAdminWeight.TabIndex = 28;
            // 
            // cmbAdminGender
            // 
            this.cmbAdminGender.FormattingEnabled = true;
            this.cmbAdminGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbAdminGender.Location = new System.Drawing.Point(49, 365);
            this.cmbAdminGender.Name = "cmbAdminGender";
            this.cmbAdminGender.Size = new System.Drawing.Size(121, 21);
            this.cmbAdminGender.TabIndex = 31;
            // 
            // lblAdminGender
            // 
            this.lblAdminGender.AutoSize = true;
            this.lblAdminGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminGender.Location = new System.Drawing.Point(45, 342);
            this.lblAdminGender.Name = "lblAdminGender";
            this.lblAdminGender.Size = new System.Drawing.Size(63, 20);
            this.lblAdminGender.TabIndex = 32;
            this.lblAdminGender.Text = "Gender";
            // 
            // lblDogs
            // 
            this.lblDogs.AutoSize = true;
            this.lblDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogs.Location = new System.Drawing.Point(574, 324);
            this.lblDogs.Name = "lblDogs";
            this.lblDogs.Size = new System.Drawing.Size(64, 20);
            this.lblDogs.TabIndex = 35;
            this.lblDogs.Text = "Dogs: 0";
            // 
            // lblCats
            // 
            this.lblCats.AutoSize = true;
            this.lblCats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCats.Location = new System.Drawing.Point(574, 344);
            this.lblCats.Name = "lblCats";
            this.lblCats.Size = new System.Drawing.Size(59, 20);
            this.lblCats.TabIndex = 36;
            this.lblCats.Text = "Cats: 0";
            // 
            // lblBirds
            // 
            this.lblBirds.AutoSize = true;
            this.lblBirds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirds.Location = new System.Drawing.Point(574, 364);
            this.lblBirds.Name = "lblBirds";
            this.lblBirds.Size = new System.Drawing.Size(62, 20);
            this.lblBirds.TabIndex = 37;
            this.lblBirds.Text = "Birds: 0";
            // 
            // lblMostCommonSpecies
            // 
            this.lblMostCommonSpecies.AutoSize = true;
            this.lblMostCommonSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostCommonSpecies.Location = new System.Drawing.Point(661, 384);
            this.lblMostCommonSpecies.Name = "lblMostCommonSpecies";
            this.lblMostCommonSpecies.Size = new System.Drawing.Size(57, 20);
            this.lblMostCommonSpecies.TabIndex = 38;
            this.lblMostCommonSpecies.Text = "Animal";
            // 
            // lblTotalDogs
            // 
            this.lblTotalDogs.AutoSize = true;
            this.lblTotalDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDogs.Location = new System.Drawing.Point(478, 324);
            this.lblTotalDogs.Name = "lblTotalDogs";
            this.lblTotalDogs.Size = new System.Drawing.Size(90, 20);
            this.lblTotalDogs.TabIndex = 39;
            this.lblTotalDogs.Text = "Total Dogs:";
            // 
            // lblTotalCats
            // 
            this.lblTotalCats.AutoSize = true;
            this.lblTotalCats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCats.Location = new System.Drawing.Point(478, 344);
            this.lblTotalCats.Name = "lblTotalCats";
            this.lblTotalCats.Size = new System.Drawing.Size(85, 20);
            this.lblTotalCats.TabIndex = 40;
            this.lblTotalCats.Text = "Total Cats:";
            // 
            // lblTotalBirds
            // 
            this.lblTotalBirds.AutoSize = true;
            this.lblTotalBirds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBirds.Location = new System.Drawing.Point(478, 364);
            this.lblTotalBirds.Name = "lblTotalBirds";
            this.lblTotalBirds.Size = new System.Drawing.Size(88, 20);
            this.lblTotalBirds.TabIndex = 41;
            this.lblTotalBirds.Text = "Total Birds:";
            // 
            // lblMostCommonSpeciess
            // 
            this.lblMostCommonSpeciess.AutoSize = true;
            this.lblMostCommonSpeciess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostCommonSpeciess.Location = new System.Drawing.Point(478, 384);
            this.lblMostCommonSpeciess.Name = "lblMostCommonSpeciess";
            this.lblMostCommonSpeciess.Size = new System.Drawing.Size(177, 20);
            this.lblMostCommonSpeciess.TabIndex = 42;
            this.lblMostCommonSpeciess.Text = "Most Common Species:";
            // 
            // txtAdminAppointmentID
            // 
            this.txtAdminAppointmentID.Location = new System.Drawing.Point(49, 77);
            this.txtAdminAppointmentID.Name = "txtAdminAppointmentID";
            this.txtAdminAppointmentID.ReadOnly = true;
            this.txtAdminAppointmentID.Size = new System.Drawing.Size(402, 20);
            this.txtAdminAppointmentID.TabIndex = 34;
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(49, 127);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.ReadOnly = true;
            this.txtPetName.Size = new System.Drawing.Size(402, 20);
            this.txtPetName.TabIndex = 35;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(49, 177);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.Size = new System.Drawing.Size(402, 20);
            this.txtServiceName.TabIndex = 36;
            // 
            // btnSearchAppointment
            // 
            this.btnSearchAppointment.Location = new System.Drawing.Point(194, 375);
            this.btnSearchAppointment.Name = "btnSearchAppointment";
            this.btnSearchAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAppointment.TabIndex = 39;
            this.btnSearchAppointment.Text = "Search";
            this.btnSearchAppointment.UseVisualStyleBackColor = true;
            this.btnSearchAppointment.Click += new System.EventHandler(this.btnSearchAppointment_Click);
            // 
            // txtSearchAppointment
            // 
            this.txtSearchAppointment.Location = new System.Drawing.Point(275, 377);
            this.txtSearchAppointment.Name = "txtSearchAppointment";
            this.txtSearchAppointment.Size = new System.Drawing.Size(340, 20);
            this.txtSearchAppointment.TabIndex = 38;
            this.txtSearchAppointment.TextChanged += new System.EventHandler(this.txtSearchAppointment_TextChanged);
            // 
            // lblSearchPetName
            // 
            this.lblSearchPetName.AutoSize = true;
            this.lblSearchPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPetName.Location = new System.Drawing.Point(46, 377);
            this.lblSearchPetName.Name = "lblSearchPetName";
            this.lblSearchPetName.Size = new System.Drawing.Size(138, 20);
            this.lblSearchPetName.TabIndex = 37;
            this.lblSearchPetName.Text = "Search Pet Name:";
            // 
            // lblTotalAppointments
            // 
            this.lblTotalAppointments.AutoSize = true;
            this.lblTotalAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAppointments.Location = new System.Drawing.Point(637, 377);
            this.lblTotalAppointments.Name = "lblTotalAppointments";
            this.lblTotalAppointments.Size = new System.Drawing.Size(164, 20);
            this.lblTotalAppointments.TabIndex = 40;
            this.lblTotalAppointments.Text = "Total Appointments: 0";
            // 
            // lblPendingAppointments
            // 
            this.lblPendingAppointments.AutoSize = true;
            this.lblPendingAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingAppointments.Location = new System.Drawing.Point(637, 357);
            this.lblPendingAppointments.Name = "lblPendingAppointments";
            this.lblPendingAppointments.Size = new System.Drawing.Size(84, 20);
            this.lblPendingAppointments.TabIndex = 41;
            this.lblPendingAppointments.Text = "Pending: 0";
            // 
            // lblCompletedAppointments
            // 
            this.lblCompletedAppointments.AutoSize = true;
            this.lblCompletedAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedAppointments.Location = new System.Drawing.Point(637, 337);
            this.lblCompletedAppointments.Name = "lblCompletedAppointments";
            this.lblCompletedAppointments.Size = new System.Drawing.Size(103, 20);
            this.lblCompletedAppointments.TabIndex = 42;
            this.lblCompletedAppointments.Text = "Completed: 0";
            // 
            // lblQueueCount
            // 
            this.lblQueueCount.AutoSize = true;
            this.lblQueueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueCount.Location = new System.Drawing.Point(637, 290);
            this.lblQueueCount.Name = "lblQueueCount";
            this.lblQueueCount.Size = new System.Drawing.Size(121, 20);
            this.lblQueueCount.TabIndex = 43;
            this.lblQueueCount.Text = "Queue Count: 0";
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.Location = new System.Drawing.Point(764, 287);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(85, 23);
            this.btnAddToQueue.TabIndex = 44;
            this.btnAddToQueue.Text = "Add To Queue";
            this.btnAddToQueue.UseVisualStyleBackColor = true;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
            // 
            // btnProcessQueue
            // 
            this.btnProcessQueue.Location = new System.Drawing.Point(864, 287);
            this.btnProcessQueue.Name = "btnProcessQueue";
            this.btnProcessQueue.Size = new System.Drawing.Size(88, 23);
            this.btnProcessQueue.TabIndex = 45;
            this.btnProcessQueue.Text = "Process Queue";
            this.btnProcessQueue.UseVisualStyleBackColor = true;
            this.btnProcessQueue.Click += new System.EventHandler(this.btnProcessQueue_Click);
            // 
            // grpServiceDetails
            // 
            this.grpServiceDetails.Controls.Add(this.txtServiceDuration);
            this.grpServiceDetails.Controls.Add(this.lblServiceDuration);
            this.grpServiceDetails.Controls.Add(this.btnAddService);
            this.grpServiceDetails.Controls.Add(this.rtxtServiceDescription);
            this.grpServiceDetails.Controls.Add(this.txtServiceID);
            this.grpServiceDetails.Controls.Add(this.lblLastAction);
            this.grpServiceDetails.Controls.Add(this.lblTotalServices);
            this.grpServiceDetails.Controls.Add(this.btnSearchService);
            this.grpServiceDetails.Controls.Add(this.txtSearchService);
            this.grpServiceDetails.Controls.Add(this.label16);
            this.grpServiceDetails.Controls.Add(this.txtServicePrice);
            this.grpServiceDetails.Controls.Add(this.txtServiceManagementName);
            this.grpServiceDetails.Controls.Add(this.dgvServices);
            this.grpServiceDetails.Controls.Add(this.btnDeleteService);
            this.grpServiceDetails.Controls.Add(this.btnUpdateService);
            this.grpServiceDetails.Controls.Add(this.btnClearService);
            this.grpServiceDetails.Controls.Add(this.lblServiceDescription);
            this.grpServiceDetails.Controls.Add(this.lblServicePrice);
            this.grpServiceDetails.Controls.Add(this.lblServiceDetails);
            this.grpServiceDetails.Controls.Add(this.lblServiceID);
            this.grpServiceDetails.Controls.Add(this.lblServiceManagementName);
            this.grpServiceDetails.Location = new System.Drawing.Point(19, 20);
            this.grpServiceDetails.Name = "grpServiceDetails";
            this.grpServiceDetails.Size = new System.Drawing.Size(985, 608);
            this.grpServiceDetails.TabIndex = 12;
            this.grpServiceDetails.TabStop = false;
            this.grpServiceDetails.Text = "Service Details";
            // 
            // lblLastAction
            // 
            this.lblLastAction.AutoSize = true;
            this.lblLastAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastAction.Location = new System.Drawing.Point(637, 386);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(135, 20);
            this.lblLastAction.TabIndex = 41;
            this.lblLastAction.Text = "Last Action: None";
            // 
            // lblTotalServices
            // 
            this.lblTotalServices.AutoSize = true;
            this.lblTotalServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalServices.Location = new System.Drawing.Point(637, 442);
            this.lblTotalServices.Name = "lblTotalServices";
            this.lblTotalServices.Size = new System.Drawing.Size(125, 20);
            this.lblTotalServices.TabIndex = 40;
            this.lblTotalServices.Text = "Total Services: 0";
            // 
            // btnSearchService
            // 
            this.btnSearchService.Location = new System.Drawing.Point(167, 442);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(75, 23);
            this.btnSearchService.TabIndex = 39;
            this.btnSearchService.Text = "Search";
            this.btnSearchService.UseVisualStyleBackColor = true;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // txtSearchService
            // 
            this.txtSearchService.Location = new System.Drawing.Point(248, 444);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(340, 20);
            this.txtSearchService.TabIndex = 38;
            this.txtSearchService.TextChanged += new System.EventHandler(this.txtSearchService_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(46, 442);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Search Service:";
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Location = new System.Drawing.Point(49, 177);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(402, 20);
            this.txtServicePrice.TabIndex = 36;
            // 
            // txtServiceManagementName
            // 
            this.txtServiceManagementName.Location = new System.Drawing.Point(49, 127);
            this.txtServiceManagementName.Name = "txtServiceManagementName";
            this.txtServiceManagementName.Size = new System.Drawing.Size(402, 20);
            this.txtServiceManagementName.TabIndex = 35;
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(50, 476);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(876, 126);
            this.dgvServices.TabIndex = 33;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(259, 407);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteService.TabIndex = 20;
            this.btnDeleteService.Text = "Delete";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(152, 407);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateService.TabIndex = 19;
            this.btnUpdateService.Text = "Update";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnClearService
            // 
            this.btnClearService.Location = new System.Drawing.Point(362, 407);
            this.btnClearService.Name = "btnClearService";
            this.btnClearService.Size = new System.Drawing.Size(75, 23);
            this.btnClearService.TabIndex = 18;
            this.btnClearService.Text = "Clear";
            this.btnClearService.UseVisualStyleBackColor = true;
            this.btnClearService.Click += new System.EventHandler(this.btnClearService_Click);
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDescription.Location = new System.Drawing.Point(46, 278);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(89, 20);
            this.lblServiceDescription.TabIndex = 16;
            this.lblServiceDescription.Text = "Description";
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePrice.Location = new System.Drawing.Point(45, 154);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(44, 20);
            this.lblServicePrice.TabIndex = 10;
            this.lblServicePrice.Text = "Price";
            // 
            // lblServiceDetails
            // 
            this.lblServiceDetails.AutoSize = true;
            this.lblServiceDetails.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDetails.Location = new System.Drawing.Point(49, 16);
            this.lblServiceDetails.Name = "lblServiceDetails";
            this.lblServiceDetails.Size = new System.Drawing.Size(208, 32);
            this.lblServiceDetails.TabIndex = 9;
            this.lblServiceDetails.Text = "SERVICE DETAILS";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.Location = new System.Drawing.Point(46, 54);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(82, 20);
            this.lblServiceID.TabIndex = 5;
            this.lblServiceID.Text = "Service ID";
            // 
            // lblServiceManagementName
            // 
            this.lblServiceManagementName.AutoSize = true;
            this.lblServiceManagementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceManagementName.Location = new System.Drawing.Point(45, 104);
            this.lblServiceManagementName.Name = "lblServiceManagementName";
            this.lblServiceManagementName.Size = new System.Drawing.Size(107, 20);
            this.lblServiceManagementName.TabIndex = 7;
            this.lblServiceManagementName.Text = "Service Name";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(50, 77);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(402, 20);
            this.txtServiceID.TabIndex = 46;
            // 
            // rtxtServiceDescription
            // 
            this.rtxtServiceDescription.Location = new System.Drawing.Point(50, 302);
            this.rtxtServiceDescription.Name = "rtxtServiceDescription";
            this.rtxtServiceDescription.Size = new System.Drawing.Size(403, 92);
            this.rtxtServiceDescription.TabIndex = 47;
            this.rtxtServiceDescription.Text = "";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(49, 407);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 48;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtServiceDuration
            // 
            this.txtServiceDuration.Location = new System.Drawing.Point(50, 235);
            this.txtServiceDuration.Name = "txtServiceDuration";
            this.txtServiceDuration.Size = new System.Drawing.Size(402, 20);
            this.txtServiceDuration.TabIndex = 50;
            // 
            // lblServiceDuration
            // 
            this.lblServiceDuration.AutoSize = true;
            this.lblServiceDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDuration.Location = new System.Drawing.Point(46, 212);
            this.lblServiceDuration.Name = "lblServiceDuration";
            this.lblServiceDuration.Size = new System.Drawing.Size(140, 20);
            this.lblServiceDuration.TabIndex = 49;
            this.lblServiceDuration.Text = "Duration (Minutes)";
            // 
            // lblUniqueBreeds
            // 
            this.lblUniqueBreeds.AutoSize = true;
            this.lblUniqueBreeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueBreeds.Location = new System.Drawing.Point(790, 384);
            this.lblUniqueBreeds.Name = "lblUniqueBreeds";
            this.lblUniqueBreeds.Size = new System.Drawing.Size(132, 20);
            this.lblUniqueBreeds.TabIndex = 43;
            this.lblUniqueBreeds.Text = "Unique Breeds: 0";
            // 
            // btnShowBreeds
            // 
            this.btnShowBreeds.Location = new System.Drawing.Point(794, 358);
            this.btnShowBreeds.Name = "btnShowBreeds";
            this.btnShowBreeds.Size = new System.Drawing.Size(93, 23);
            this.btnShowBreeds.TabIndex = 44;
            this.btnShowBreeds.Text = "Show Breeds";
            this.btnShowBreeds.UseVisualStyleBackColor = true;
            this.btnShowBreeds.Click += new System.EventHandler(this.btnShowBreeds_Click);
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
            this.grpPetDetails.ResumeLayout(false);
            this.grpPetDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPets)).EndInit();
            this.tabAppointments.ResumeLayout(false);
            this.grpAppointmentDetails.ResumeLayout(false);
            this.grpAppointmentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAppointments)).EndInit();
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
            this.tabServices.ResumeLayout(false);
            this.grpServiceDetails.ResumeLayout(false);
            this.grpServiceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
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
        private System.Windows.Forms.GroupBox grpPetDetails;
        private System.Windows.Forms.TextBox txtSearchPet;
        private System.Windows.Forms.Label lblSearchPet;
        private System.Windows.Forms.DataGridView dgvAdminPets;
        private System.Windows.Forms.Button btnClearPet;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.Button btnUpdatePet;
        private System.Windows.Forms.Label lblAdminBreed;
        private System.Windows.Forms.Label lblAdminSpecies;
        private System.Windows.Forms.TextBox txtAdminPetName;
        private System.Windows.Forms.Label lblAdminPetName;
        private System.Windows.Forms.Label lblTitlePetDetails;
        private System.Windows.Forms.TextBox txtAdminPetID;
        private System.Windows.Forms.Label lblPetID;
        private System.Windows.Forms.ComboBox cmbAdminOwner;
        private System.Windows.Forms.Label lblOwnerPet;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.GroupBox grpAppointmentDetails;
        private System.Windows.Forms.DataGridView dgvAdminAppointments;
        private System.Windows.Forms.ComboBox cmbAdminAppointmentStatus;
        private System.Windows.Forms.Label lblAdminAppointmentStatus;
        private System.Windows.Forms.DateTimePicker dtpAdminAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnClearAppointment;
        private System.Windows.Forms.Label lblAdminAppointment;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblAppointmentDetails;
        private System.Windows.Forms.Label lblAdminAppointmentID;
        private System.Windows.Forms.Label lblPetName;
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
        private System.Windows.Forms.ComboBox cmbAdminSpecies;
        private System.Windows.Forms.TextBox txtAdminBreed;
        private System.Windows.Forms.Label lblAdminWeight;
        private System.Windows.Forms.Button btnSearchPet;
        private System.Windows.Forms.Label lblTotalPets;
        private System.Windows.Forms.Label lblAdminGender;
        private System.Windows.Forms.ComboBox cmbAdminGender;
        private System.Windows.Forms.TextBox txtAdminWeight;
        private System.Windows.Forms.Label lblBirds;
        private System.Windows.Forms.Label lblCats;
        private System.Windows.Forms.Label lblDogs;
        private System.Windows.Forms.Label lblMostCommonSpecies;
        private System.Windows.Forms.Label lblTotalDogs;
        private System.Windows.Forms.Label lblMostCommonSpeciess;
        private System.Windows.Forms.Label lblTotalBirds;
        private System.Windows.Forms.Label lblTotalCats;
        private System.Windows.Forms.TextBox txtAdminAppointmentID;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Button btnSearchAppointment;
        private System.Windows.Forms.TextBox txtSearchAppointment;
        private System.Windows.Forms.Label lblSearchPetName;
        private System.Windows.Forms.Label lblCompletedAppointments;
        private System.Windows.Forms.Label lblPendingAppointments;
        private System.Windows.Forms.Label lblTotalAppointments;
        private System.Windows.Forms.Button btnProcessQueue;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.Label lblQueueCount;
        private System.Windows.Forms.GroupBox grpServiceDetails;
        private System.Windows.Forms.Label lblLastAction;
        private System.Windows.Forms.Label lblTotalServices;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.TextBox txtSearchService;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.TextBox txtServiceManagementName;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnClearService;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label lblServiceDetails;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblServiceManagementName;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.RichTextBox rtxtServiceDescription;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtServiceDuration;
        private System.Windows.Forms.Label lblServiceDuration;
        private System.Windows.Forms.Label lblUniqueBreeds;
        private System.Windows.Forms.Button btnShowBreeds;
    }
}