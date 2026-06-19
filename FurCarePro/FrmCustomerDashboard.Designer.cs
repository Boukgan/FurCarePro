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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.petToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.grpCustomerProfile = new System.Windows.Forms.GroupBox();
            this.txtCustomerProfileStatus = new System.Windows.Forms.TextBox();
            this.lblProfileStatus = new System.Windows.Forms.Label();
            this.btnCustomerRefreshProfile = new System.Windows.Forms.Button();
            this.txtCustomerProfileName = new System.Windows.Forms.TextBox();
            this.txtCustomerProfileRole = new System.Windows.Forms.TextBox();
            this.txtCustomerProfileEmail = new System.Windows.Forms.TextBox();
            this.btnCustomerUpdateProfile = new System.Windows.Forms.Button();
            this.lblProfileRole = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblCustomerCurrentTime = new System.Windows.Forms.Label();
            this.lblCustomerCurrentDate = new System.Windows.Forms.Label();
            this.lblCustomerPayments = new System.Windows.Forms.Label();
            this.lblCustomerAppointments = new System.Windows.Forms.Label();
            this.lblCustomerTotalPets = new System.Windows.Forms.Label();
            this.lblCustomerWelcome = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
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
            this.grpPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.tabFeedback.SuspendLayout();
            this.grpCustomerFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.grpCustomerProfile.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.petToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1845, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logToolStripMenuItem.Text = "Logout";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Profile";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // petToolStripMenuItem
            // 
            this.petToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPetToolStripMenuItem});
            this.petToolStripMenuItem.Name = "petToolStripMenuItem";
            this.petToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.petToolStripMenuItem.Text = "Pet";
            // 
            // registerPetToolStripMenuItem
            // 
            this.registerPetToolStripMenuItem.Name = "registerPetToolStripMenuItem";
            this.registerPetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registerPetToolStripMenuItem.Text = "Register Pet";
            this.registerPetToolStripMenuItem.Click += new System.EventHandler(this.registerPetToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookAppointmentToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // bookAppointmentToolStripMenuItem
            // 
            this.bookAppointmentToolStripMenuItem.Name = "bookAppointmentToolStripMenuItem";
            this.bookAppointmentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookAppointmentToolStripMenuItem.Text = "Book Appointment";
            this.bookAppointmentToolStripMenuItem.Click += new System.EventHandler(this.bookAppointmentToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makePaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // makePaymentToolStripMenuItem
            // 
            this.makePaymentToolStripMenuItem.Name = "makePaymentToolStripMenuItem";
            this.makePaymentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.makePaymentToolStripMenuItem.Text = "Make Payment";
            this.makePaymentToolStripMenuItem.Click += new System.EventHandler(this.makePaymentToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1845, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.lblDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 911);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1845, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 20);
            this.lblUser.Text = "lblUser";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(91, 20);
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btnProfile);
            this.splitContainer1.Panel1.Controls.Add(this.btnFeedback);
            this.splitContainer1.Panel1.Controls.Add(this.btnPayments);
            this.splitContainer1.Panel1.Controls.Add(this.btnAppointments);
            this.splitContainer1.Panel1.Controls.Add(this.btnPets);
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel2.BackgroundImage = global::FurCarePro.Properties.Resources._8;
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1845, 856);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProfile.Location = new System.Drawing.Point(64, 629);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(145, 55);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFeedback.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFeedback.Location = new System.Drawing.Point(64, 533);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(145, 55);
            this.btnFeedback.TabIndex = 4;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            this.btnFeedback.MouseEnter += new System.EventHandler(this.btnFeedback_MouseEnter);
            this.btnFeedback.MouseLeave += new System.EventHandler(this.btnFeedback_MouseLeave);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPayments.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPayments.Location = new System.Drawing.Point(64, 436);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(145, 55);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            this.btnPayments.MouseEnter += new System.EventHandler(this.btnPayments_MouseEnter);
            this.btnPayments.MouseLeave += new System.EventHandler(this.btnPayments_MouseLeave);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAppointments.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAppointments.Location = new System.Drawing.Point(64, 348);
            this.btnAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(145, 55);
            this.btnAppointments.TabIndex = 2;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            this.btnAppointments.MouseEnter += new System.EventHandler(this.btnAppointments_MouseEnter);
            this.btnAppointments.MouseLeave += new System.EventHandler(this.btnAppointments_MouseLeave);
            // 
            // btnPets
            // 
            this.btnPets.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPets.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPets.Location = new System.Drawing.Point(64, 256);
            this.btnPets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(145, 55);
            this.btnPets.TabIndex = 1;
            this.btnPets.Text = "Pets";
            this.btnPets.UseVisualStyleBackColor = false;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            this.btnPets.MouseEnter += new System.EventHandler(this.btnPets_MouseEnter);
            this.btnPets.MouseLeave += new System.EventHandler(this.btnPets_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHome.Location = new System.Drawing.Point(64, 162);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(145, 55);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabHome);
            this.tabMain.Controls.Add(this.tabPets);
            this.tabMain.Controls.Add(this.tabAppointments);
            this.tabMain.Controls.Add(this.tabPayments);
            this.tabMain.Controls.Add(this.tabFeedback);
            this.tabMain.Controls.Add(this.tabProfile);
            this.tabMain.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(95, 33);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1375, 812);
            this.tabMain.TabIndex = 0;
            // 
            // tabPets
            // 
            this.tabPets.BackColor = System.Drawing.Color.LightBlue;
            this.tabPets.Controls.Add(this.grpPetInfo);
            this.tabPets.Location = new System.Drawing.Point(4, 23);
            this.tabPets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPets.Size = new System.Drawing.Size(1367, 785);
            this.tabPets.TabIndex = 1;
            this.tabPets.Text = "Pets";
            // 
            // grpPetInfo
            // 
            this.grpPetInfo.BackColor = System.Drawing.Color.LightBlue;
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
            this.grpPetInfo.Location = new System.Drawing.Point(25, 25);
            this.grpPetInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPetInfo.Name = "grpPetInfo";
            this.grpPetInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPetInfo.Size = new System.Drawing.Size(1313, 748);
            this.grpPetInfo.TabIndex = 10;
            this.grpPetInfo.TabStop = false;
            this.grpPetInfo.Text = "Pet Info";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(153, 494);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(551, 22);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(60, 494);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 23);
            this.lblSearch.TabIndex = 23;
            this.lblSearch.Text = "Search:";
            // 
            // dgvPets
            // 
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Location = new System.Drawing.Point(65, 544);
            this.dgvPets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.RowHeadersWidth = 51;
            this.dgvPets.Size = new System.Drawing.Size(1175, 176);
            this.dgvPets.TabIndex = 22;
            this.dgvPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellContentClick);
            // 
            // btnClearPet
            // 
            this.btnClearPet.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPet.Location = new System.Drawing.Point(493, 434);
            this.btnClearPet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearPet.Name = "btnClearPet";
            this.btnClearPet.Size = new System.Drawing.Size(100, 28);
            this.btnClearPet.TabIndex = 21;
            this.btnClearPet.Text = "Clear";
            this.btnClearPet.UseVisualStyleBackColor = true;
            this.btnClearPet.Click += new System.EventHandler(this.btnClearPet_Click);
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePet.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePet.Location = new System.Drawing.Point(343, 434);
            this.btnDeletePet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(100, 28);
            this.btnDeletePet.TabIndex = 20;
            this.btnDeletePet.Text = "Delete";
            this.btnDeletePet.UseVisualStyleBackColor = false;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // btnUpdatePet
            // 
            this.btnUpdatePet.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePet.Location = new System.Drawing.Point(200, 434);
            this.btnUpdatePet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdatePet.Name = "btnUpdatePet";
            this.btnUpdatePet.Size = new System.Drawing.Size(100, 28);
            this.btnUpdatePet.TabIndex = 19;
            this.btnUpdatePet.Text = "Update";
            this.btnUpdatePet.UseVisualStyleBackColor = true;
            this.btnUpdatePet.Click += new System.EventHandler(this.btnUpdatePet_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPet.Location = new System.Drawing.Point(65, 434);
            this.btnAddPet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(100, 28);
            this.btnAddPet.TabIndex = 18;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(65, 379);
            this.numWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numWeight.Size = new System.Drawing.Size(160, 22);
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
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(60, 351);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(68, 23);
            this.lblWeight.TabIndex = 16;
            this.lblWeight.Text = "Weight";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbFemale.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(208, 315);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(66, 18);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbMale.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(65, 315);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(55, 18);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(60, 284);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 23);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(65, 239);
            this.txtBreed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(535, 22);
            this.txtBreed.TabIndex = 11;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.BackColor = System.Drawing.Color.Transparent;
            this.lblBreed.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.Location = new System.Drawing.Point(60, 210);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(58, 23);
            this.lblBreed.TabIndex = 10;
            this.lblBreed.Text = "Breed";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 34);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "PET INFORMATION";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(69, 97);
            this.txtPetName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(535, 22);
            this.txtPetName.TabIndex = 6;
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.BackColor = System.Drawing.Color.Transparent;
            this.lblPetName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(64, 69);
            this.lblPetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(90, 23);
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
            this.cmbSpecies.Location = new System.Drawing.Point(65, 164);
            this.cmbSpecies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(160, 22);
            this.cmbSpecies.TabIndex = 8;
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbSpecies_SelectedIndexChanged);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecies.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(60, 135);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(68, 23);
            this.lblSpecies.TabIndex = 7;
            this.lblSpecies.Text = "Species";
            // 
            // tabAppointments
            // 
            this.tabAppointments.BackColor = System.Drawing.Color.LightBlue;
            this.tabAppointments.Controls.Add(this.grpAppointmentBooking);
            this.tabAppointments.Location = new System.Drawing.Point(4, 23);
            this.tabAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAppointments.Size = new System.Drawing.Size(1367, 785);
            this.tabAppointments.TabIndex = 2;
            this.tabAppointments.Text = "Appointments";
            // 
            // grpAppointmentBooking
            // 
            this.grpAppointmentBooking.BackColor = System.Drawing.Color.LightBlue;
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
            this.grpAppointmentBooking.Location = new System.Drawing.Point(25, 25);
            this.grpAppointmentBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAppointmentBooking.Name = "grpAppointmentBooking";
            this.grpAppointmentBooking.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAppointmentBooking.Size = new System.Drawing.Size(1313, 748);
            this.grpAppointmentBooking.TabIndex = 11;
            this.grpAppointmentBooking.TabStop = false;
            this.grpAppointmentBooking.Text = "Appointment Booking";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(67, 545);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.Size = new System.Drawing.Size(1168, 196);
            this.dgvAppointments.TabIndex = 33;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // txtAppointmentSearch
            // 
            this.txtAppointmentSearch.Location = new System.Drawing.Point(276, 513);
            this.txtAppointmentSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAppointmentSearch.Name = "txtAppointmentSearch";
            this.txtAppointmentSearch.Size = new System.Drawing.Size(535, 22);
            this.txtAppointmentSearch.TabIndex = 32;
            this.txtAppointmentSearch.TextChanged += new System.EventHandler(this.txtAppointmentSearch_TextChanged);
            // 
            // lblSearchAppointment
            // 
            this.lblSearchAppointment.AutoSize = true;
            this.lblSearchAppointment.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAppointment.Location = new System.Drawing.Point(60, 513);
            this.lblSearchAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchAppointment.Name = "lblSearchAppointment";
            this.lblSearchAppointment.Size = new System.Drawing.Size(177, 23);
            this.lblSearchAppointment.TabIndex = 31;
            this.lblSearchAppointment.Text = "Search Appointment:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(67, 422);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(233, 22);
            this.cmbStatus.TabIndex = 30;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(61, 394);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 23);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(65, 353);
            this.dtpAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(265, 22);
            this.dtpAppointment.TabIndex = 27;
            this.dtpAppointment.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(65, 284);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(535, 22);
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
            this.cmbPet.Location = new System.Drawing.Point(65, 95);
            this.cmbPet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPet.Name = "cmbPet";
            this.cmbPet.Size = new System.Drawing.Size(233, 22);
            this.cmbPet.TabIndex = 25;
            // 
            // btnQueueCount
            // 
            this.btnQueueCount.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueueCount.Location = new System.Drawing.Point(501, 466);
            this.btnQueueCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQueueCount.Name = "btnQueueCount";
            this.btnQueueCount.Size = new System.Drawing.Size(124, 28);
            this.btnQueueCount.TabIndex = 21;
            this.btnQueueCount.Text = "Queue Count";
            this.btnQueueCount.UseVisualStyleBackColor = true;
            this.btnQueueCount.Click += new System.EventHandler(this.btnQueueCount_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAppointment.Location = new System.Drawing.Point(344, 466);
            this.btnDeleteAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteAppointment.TabIndex = 20;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAppointment.Location = new System.Drawing.Point(201, 466);
            this.btnUpdateAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateAppointment.TabIndex = 19;
            this.btnUpdateAppointment.Text = "Update";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAppointment.Location = new System.Drawing.Point(67, 466);
            this.btnBookAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(100, 28);
            this.btnBookAppointment.TabIndex = 18;
            this.btnBookAppointment.Text = "Book";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(60, 325);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 23);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(60, 256);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(81, 23);
            this.lblDuration.TabIndex = 12;
            this.lblDuration.Text = "Duration";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(65, 218);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(535, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(60, 190);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 23);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblPetInformation
            // 
            this.lblPetInformation.AutoSize = true;
            this.lblPetInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblPetInformation.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetInformation.Location = new System.Drawing.Point(65, 20);
            this.lblPetInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPetInformation.Name = "lblPetInformation";
            this.lblPetInformation.Size = new System.Drawing.Size(412, 34);
            this.lblPetInformation.TabIndex = 9;
            this.lblPetInformation.Text = "APPOINTMENT BOOKING";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.BackColor = System.Drawing.Color.Transparent;
            this.lblPet.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.Location = new System.Drawing.Point(60, 66);
            this.lblPet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(36, 23);
            this.lblPet.TabIndex = 5;
            this.lblPet.Text = "Pet";
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(65, 156);
            this.cmbService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(233, 22);
            this.cmbService.TabIndex = 8;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(60, 128);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(66, 23);
            this.lblService.TabIndex = 7;
            this.lblService.Text = "Service";
            // 
            // tabPayments
            // 
            this.tabPayments.BackColor = System.Drawing.Color.LightBlue;
            this.tabPayments.Controls.Add(this.grpPaymentInfo);
            this.tabPayments.Location = new System.Drawing.Point(4, 23);
            this.tabPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPayments.Name = "tabPayments";
            this.tabPayments.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPayments.Size = new System.Drawing.Size(1367, 785);
            this.tabPayments.TabIndex = 3;
            this.tabPayments.Text = "Payments";
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
            this.grpPaymentInfo.Location = new System.Drawing.Point(25, 25);
            this.grpPaymentInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPaymentInfo.Size = new System.Drawing.Size(1313, 748);
            this.grpPaymentInfo.TabIndex = 11;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Payment Info";
            this.grpPaymentInfo.Enter += new System.EventHandler(this.grpPaymentInfo_Enter);
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(65, 313);
            this.cmbPaymentStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(267, 22);
            this.cmbPaymentStatus.TabIndex = 28;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(65, 239);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(267, 22);
            this.cmbPaymentMethod.TabIndex = 27;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(65, 164);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(535, 22);
            this.txtAmount.TabIndex = 26;
            // 
            // cmbPaymentAppointment
            // 
            this.cmbPaymentAppointment.FormattingEnabled = true;
            this.cmbPaymentAppointment.Location = new System.Drawing.Point(65, 97);
            this.cmbPaymentAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentAppointment.Name = "cmbPaymentAppointment";
            this.cmbPaymentAppointment.Size = new System.Drawing.Size(267, 22);
            this.cmbPaymentAppointment.TabIndex = 25;
            this.cmbPaymentAppointment.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentAppointment_SelectedIndexChanged);
            // 
            // txtPaymentSearch
            // 
            this.txtPaymentSearch.Location = new System.Drawing.Point(73, 448);
            this.txtPaymentSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaymentSearch.Name = "txtPaymentSearch";
            this.txtPaymentSearch.Size = new System.Drawing.Size(551, 22);
            this.txtPaymentSearch.TabIndex = 24;
            this.txtPaymentSearch.TextChanged += new System.EventHandler(this.txtPaymentSearch_TextChanged);
            // 
            // lblPaymentSearch
            // 
            this.lblPaymentSearch.AutoSize = true;
            this.lblPaymentSearch.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentSearch.Location = new System.Drawing.Point(68, 418);
            this.lblPaymentSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentSearch.Name = "lblPaymentSearch";
            this.lblPaymentSearch.Size = new System.Drawing.Size(68, 23);
            this.lblPaymentSearch.TabIndex = 23;
            this.lblPaymentSearch.Text = "Search:";
            // 
            // dgvPayments
            // 
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(65, 492);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.Size = new System.Drawing.Size(1175, 228);
            this.dgvPayments.TabIndex = 22;
            // 
            // btnClearPayment
            // 
            this.btnClearPayment.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPayment.Location = new System.Drawing.Point(347, 364);
            this.btnClearPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearPayment.Name = "btnClearPayment";
            this.btnClearPayment.Size = new System.Drawing.Size(100, 28);
            this.btnClearPayment.TabIndex = 21;
            this.btnClearPayment.Text = "Clear";
            this.btnClearPayment.UseVisualStyleBackColor = true;
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePayment.Location = new System.Drawing.Point(200, 364);
            this.btnDeletePayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(100, 28);
            this.btnDeletePayment.TabIndex = 19;
            this.btnDeletePayment.Text = "Delete";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(65, 364);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 28);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(60, 284);
            this.lblPaymentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(56, 23);
            this.lblPaymentStatus.TabIndex = 12;
            this.lblPaymentStatus.Text = "Status";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(60, 210);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(72, 23);
            this.lblMethod.TabIndex = 10;
            this.lblMethod.Text = "Method";
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentInfo.Location = new System.Drawing.Point(65, 20);
            this.lblPaymentInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(410, 34);
            this.lblPaymentInfo.TabIndex = 9;
            this.lblPaymentInfo.Text = "PAYMENT INFORMATION";
            // 
            // lblPaymentAppointment
            // 
            this.lblPaymentAppointment.AutoSize = true;
            this.lblPaymentAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAppointment.Location = new System.Drawing.Point(60, 69);
            this.lblPaymentAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentAppointment.Name = "lblPaymentAppointment";
            this.lblPaymentAppointment.Size = new System.Drawing.Size(114, 23);
            this.lblPaymentAppointment.TabIndex = 5;
            this.lblPaymentAppointment.Text = "Appointment";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(60, 135);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(75, 23);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // tabFeedback
            // 
            this.tabFeedback.BackColor = System.Drawing.Color.LightBlue;
            this.tabFeedback.Controls.Add(this.grpCustomerFeedback);
            this.tabFeedback.Location = new System.Drawing.Point(4, 25);
            this.tabFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFeedback.Name = "tabFeedback";
            this.tabFeedback.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFeedback.Size = new System.Drawing.Size(1367, 783);
            this.tabFeedback.TabIndex = 4;
            this.tabFeedback.Text = "Feedback";
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
            this.grpCustomerFeedback.Location = new System.Drawing.Point(25, 25);
            this.grpCustomerFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomerFeedback.Name = "grpCustomerFeedback";
            this.grpCustomerFeedback.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomerFeedback.Size = new System.Drawing.Size(1313, 748);
            this.grpCustomerFeedback.TabIndex = 12;
            this.grpCustomerFeedback.TabStop = false;
            this.grpCustomerFeedback.Text = "Customer Feedback";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(65, 239);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(535, 106);
            this.txtComments.TabIndex = 30;
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(65, 164);
            this.numRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numRating.Size = new System.Drawing.Size(160, 22);
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
            this.cmbFeedbackAppointment.Location = new System.Drawing.Point(65, 97);
            this.cmbFeedbackAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFeedbackAppointment.Name = "cmbFeedbackAppointment";
            this.cmbFeedbackAppointment.Size = new System.Drawing.Size(267, 22);
            this.cmbFeedbackAppointment.TabIndex = 25;
            // 
            // txtFeedbackSearch
            // 
            this.txtFeedbackSearch.Location = new System.Drawing.Point(73, 448);
            this.txtFeedbackSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFeedbackSearch.Name = "txtFeedbackSearch";
            this.txtFeedbackSearch.Size = new System.Drawing.Size(551, 22);
            this.txtFeedbackSearch.TabIndex = 24;
            this.txtFeedbackSearch.TextChanged += new System.EventHandler(this.txtFeedbackSearch_TextChanged);
            // 
            // lblFeedbackSearch
            // 
            this.lblFeedbackSearch.AutoSize = true;
            this.lblFeedbackSearch.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackSearch.Location = new System.Drawing.Point(68, 418);
            this.lblFeedbackSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedbackSearch.Name = "lblFeedbackSearch";
            this.lblFeedbackSearch.Size = new System.Drawing.Size(68, 23);
            this.lblFeedbackSearch.TabIndex = 23;
            this.lblFeedbackSearch.Text = "Search:";
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(65, 492);
            this.dgvFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.Size = new System.Drawing.Size(1175, 228);
            this.dgvFeedback.TabIndex = 22;
            // 
            // btnClearFeedback
            // 
            this.btnClearFeedback.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFeedback.Location = new System.Drawing.Point(347, 364);
            this.btnClearFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearFeedback.Name = "btnClearFeedback";
            this.btnClearFeedback.Size = new System.Drawing.Size(100, 28);
            this.btnClearFeedback.TabIndex = 21;
            this.btnClearFeedback.Text = "Clear";
            this.btnClearFeedback.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFeedback
            // 
            this.btnDeleteFeedback.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFeedback.Location = new System.Drawing.Point(200, 364);
            this.btnDeleteFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteFeedback.Name = "btnDeleteFeedback";
            this.btnDeleteFeedback.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteFeedback.TabIndex = 19;
            this.btnDeleteFeedback.Text = "Delete";
            this.btnDeleteFeedback.UseVisualStyleBackColor = true;
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitFeedback.Location = new System.Drawing.Point(65, 364);
            this.btnSubmitFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(100, 28);
            this.btnSubmitFeedback.TabIndex = 18;
            this.btnSubmitFeedback.Text = "Submit";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(60, 210);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(96, 23);
            this.lblComments.TabIndex = 10;
            this.lblComments.Text = "Comments";
            // 
            // lblCustomerFeedback
            // 
            this.lblCustomerFeedback.AutoSize = true;
            this.lblCustomerFeedback.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFeedback.Location = new System.Drawing.Point(65, 20);
            this.lblCustomerFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerFeedback.Name = "lblCustomerFeedback";
            this.lblCustomerFeedback.Size = new System.Drawing.Size(368, 34);
            this.lblCustomerFeedback.TabIndex = 9;
            this.lblCustomerFeedback.Text = "CUSTOMER FEEDBACK";
            // 
            // lblFeedbackAppointment
            // 
            this.lblFeedbackAppointment.AutoSize = true;
            this.lblFeedbackAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackAppointment.Location = new System.Drawing.Point(60, 69);
            this.lblFeedbackAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedbackAppointment.Name = "lblFeedbackAppointment";
            this.lblFeedbackAppointment.Size = new System.Drawing.Size(114, 23);
            this.lblFeedbackAppointment.TabIndex = 5;
            this.lblFeedbackAppointment.Text = "Appointment";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(60, 135);
            this.lblRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 23);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Rating";
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.LightBlue;
            this.tabProfile.Controls.Add(this.grpCustomerProfile);
            this.tabProfile.Location = new System.Drawing.Point(4, 23);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabProfile.Size = new System.Drawing.Size(1367, 785);
            this.tabProfile.TabIndex = 5;
            this.tabProfile.Text = "Profile";
            // 
            // grpCustomerProfile
            // 
            this.grpCustomerProfile.Controls.Add(this.txtCustomerProfileStatus);
            this.grpCustomerProfile.Controls.Add(this.lblProfileStatus);
            this.grpCustomerProfile.Controls.Add(this.btnCustomerRefreshProfile);
            this.grpCustomerProfile.Controls.Add(this.txtCustomerProfileName);
            this.grpCustomerProfile.Controls.Add(this.txtCustomerProfileRole);
            this.grpCustomerProfile.Controls.Add(this.txtCustomerProfileEmail);
            this.grpCustomerProfile.Controls.Add(this.btnCustomerUpdateProfile);
            this.grpCustomerProfile.Controls.Add(this.lblProfileRole);
            this.grpCustomerProfile.Controls.Add(this.lblCustomerTitle);
            this.grpCustomerProfile.Controls.Add(this.lblProfileName);
            this.grpCustomerProfile.Controls.Add(this.lblProfileEmail);
            this.grpCustomerProfile.Location = new System.Drawing.Point(25, 25);
            this.grpCustomerProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomerProfile.Name = "grpCustomerProfile";
            this.grpCustomerProfile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomerProfile.Size = new System.Drawing.Size(1313, 748);
            this.grpCustomerProfile.TabIndex = 14;
            this.grpCustomerProfile.TabStop = false;
            this.grpCustomerProfile.Text = "Customer Profile";
            // 
            // txtCustomerProfileStatus
            // 
            this.txtCustomerProfileStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerProfileStatus.Location = new System.Drawing.Point(73, 382);
            this.txtCustomerProfileStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerProfileStatus.Name = "txtCustomerProfileStatus";
            this.txtCustomerProfileStatus.ReadOnly = true;
            this.txtCustomerProfileStatus.Size = new System.Drawing.Size(535, 22);
            this.txtCustomerProfileStatus.TabIndex = 50;
            // 
            // lblProfileStatus
            // 
            this.lblProfileStatus.AutoSize = true;
            this.lblProfileStatus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileStatus.Location = new System.Drawing.Point(68, 353);
            this.lblProfileStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileStatus.Name = "lblProfileStatus";
            this.lblProfileStatus.Size = new System.Drawing.Size(56, 23);
            this.lblProfileStatus.TabIndex = 49;
            this.lblProfileStatus.Text = "Status";
            // 
            // btnCustomerRefreshProfile
            // 
            this.btnCustomerRefreshProfile.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRefreshProfile.Location = new System.Drawing.Point(73, 462);
            this.btnCustomerRefreshProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomerRefreshProfile.Name = "btnCustomerRefreshProfile";
            this.btnCustomerRefreshProfile.Size = new System.Drawing.Size(100, 28);
            this.btnCustomerRefreshProfile.TabIndex = 48;
            this.btnCustomerRefreshProfile.Text = "Refresh";
            this.btnCustomerRefreshProfile.UseVisualStyleBackColor = true;
            this.btnCustomerRefreshProfile.Click += new System.EventHandler(this.btnCustomerRefreshProfile_Click);
            // 
            // txtCustomerProfileName
            // 
            this.txtCustomerProfileName.Location = new System.Drawing.Point(73, 114);
            this.txtCustomerProfileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerProfileName.Name = "txtCustomerProfileName";
            this.txtCustomerProfileName.Size = new System.Drawing.Size(535, 22);
            this.txtCustomerProfileName.TabIndex = 46;
            // 
            // txtCustomerProfileRole
            // 
            this.txtCustomerProfileRole.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerProfileRole.Location = new System.Drawing.Point(73, 287);
            this.txtCustomerProfileRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerProfileRole.Name = "txtCustomerProfileRole";
            this.txtCustomerProfileRole.ReadOnly = true;
            this.txtCustomerProfileRole.Size = new System.Drawing.Size(535, 22);
            this.txtCustomerProfileRole.TabIndex = 36;
            // 
            // txtCustomerProfileEmail
            // 
            this.txtCustomerProfileEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerProfileEmail.Location = new System.Drawing.Point(72, 194);
            this.txtCustomerProfileEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerProfileEmail.Name = "txtCustomerProfileEmail";
            this.txtCustomerProfileEmail.ReadOnly = true;
            this.txtCustomerProfileEmail.Size = new System.Drawing.Size(535, 22);
            this.txtCustomerProfileEmail.TabIndex = 35;
            // 
            // btnCustomerUpdateProfile
            // 
            this.btnCustomerUpdateProfile.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerUpdateProfile.Location = new System.Drawing.Point(211, 462);
            this.btnCustomerUpdateProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomerUpdateProfile.Name = "btnCustomerUpdateProfile";
            this.btnCustomerUpdateProfile.Size = new System.Drawing.Size(100, 28);
            this.btnCustomerUpdateProfile.TabIndex = 19;
            this.btnCustomerUpdateProfile.Text = "Update";
            this.btnCustomerUpdateProfile.UseVisualStyleBackColor = true;
            this.btnCustomerUpdateProfile.Click += new System.EventHandler(this.btnCustomerUpdateProfile_Click);
            // 
            // lblProfileRole
            // 
            this.lblProfileRole.AutoSize = true;
            this.lblProfileRole.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileRole.Location = new System.Drawing.Point(68, 258);
            this.lblProfileRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileRole.Name = "lblProfileRole";
            this.lblProfileRole.Size = new System.Drawing.Size(47, 23);
            this.lblProfileRole.TabIndex = 10;
            this.lblProfileRole.Text = "Role";
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTitle.Location = new System.Drawing.Point(65, 20);
            this.lblCustomerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(332, 34);
            this.lblCustomerTitle.TabIndex = 9;
            this.lblCustomerTitle.Text = "CUSTOMER PROFILE";
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.Location = new System.Drawing.Point(68, 86);
            this.lblProfileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(95, 23);
            this.lblProfileName.TabIndex = 5;
            this.lblProfileName.Text = "Full Name";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileEmail.Location = new System.Drawing.Point(67, 166);
            this.lblProfileEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(57, 23);
            this.lblProfileEmail.TabIndex = 7;
            this.lblProfileEmail.Text = "Email";
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.LightBlue;
            this.tabHome.Controls.Add(this.lblCustomerCurrentTime);
            this.tabHome.Controls.Add(this.lblCustomerCurrentDate);
            this.tabHome.Controls.Add(this.lblCustomerPayments);
            this.tabHome.Controls.Add(this.lblCustomerAppointments);
            this.tabHome.Controls.Add(this.lblCustomerTotalPets);
            this.tabHome.Controls.Add(this.lblCustomerWelcome);
            this.tabHome.Location = new System.Drawing.Point(4, 23);
            this.tabHome.Margin = new System.Windows.Forms.Padding(4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(4);
            this.tabHome.Size = new System.Drawing.Size(1367, 785);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // lblCustomerCurrentTime
            // 
            this.lblCustomerCurrentTime.AutoSize = true;
            this.lblCustomerCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerCurrentTime.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCurrentTime.Location = new System.Drawing.Point(443, 599);
            this.lblCustomerCurrentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerCurrentTime.Name = "lblCustomerCurrentTime";
            this.lblCustomerCurrentTime.Size = new System.Drawing.Size(54, 23);
            this.lblCustomerCurrentTime.TabIndex = 23;
            this.lblCustomerCurrentTime.Text = "Time";
            // 
            // lblCustomerCurrentDate
            // 
            this.lblCustomerCurrentDate.AutoSize = true;
            this.lblCustomerCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerCurrentDate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCurrentDate.Location = new System.Drawing.Point(441, 455);
            this.lblCustomerCurrentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerCurrentDate.Name = "lblCustomerCurrentDate";
            this.lblCustomerCurrentDate.Size = new System.Drawing.Size(48, 23);
            this.lblCustomerCurrentDate.TabIndex = 22;
            this.lblCustomerCurrentDate.Text = "Date";
            // 
            // lblCustomerPayments
            // 
            this.lblCustomerPayments.AutoSize = true;
            this.lblCustomerPayments.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerPayments.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPayments.Location = new System.Drawing.Point(443, 319);
            this.lblCustomerPayments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerPayments.Name = "lblCustomerPayments";
            this.lblCustomerPayments.Size = new System.Drawing.Size(141, 23);
            this.lblCustomerPayments.TabIndex = 21;
            this.lblCustomerPayments.Text = "Total Services: 0";
            // 
            // lblCustomerAppointments
            // 
            this.lblCustomerAppointments.AutoSize = true;
            this.lblCustomerAppointments.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerAppointments.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAppointments.Location = new System.Drawing.Point(443, 247);
            this.lblCustomerAppointments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerAppointments.Name = "lblCustomerAppointments";
            this.lblCustomerAppointments.Size = new System.Drawing.Size(189, 23);
            this.lblCustomerAppointments.TabIndex = 20;
            this.lblCustomerAppointments.Text = "Total Appointments: 0";
            // 
            // lblCustomerTotalPets
            // 
            this.lblCustomerTotalPets.AutoSize = true;
            this.lblCustomerTotalPets.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerTotalPets.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTotalPets.Location = new System.Drawing.Point(443, 174);
            this.lblCustomerTotalPets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerTotalPets.Name = "lblCustomerTotalPets";
            this.lblCustomerTotalPets.Size = new System.Drawing.Size(111, 23);
            this.lblCustomerTotalPets.TabIndex = 19;
            this.lblCustomerTotalPets.Text = "Total Pets: 0";
            // 
            // lblCustomerWelcome
            // 
            this.lblCustomerWelcome.AutoSize = true;
            this.lblCustomerWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerWelcome.Font = new System.Drawing.Font("Baskerville Old Face", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerWelcome.Location = new System.Drawing.Point(436, 55);
            this.lblCustomerWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerWelcome.Name = "lblCustomerWelcome";
            this.lblCustomerWelcome.Size = new System.Drawing.Size(490, 57);
            this.lblCustomerWelcome.TabIndex = 17;
            this.lblCustomerWelcome.Text = "WELCOME ADMIN";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 24);
            this.toolStripButton1.Text = "New Pet";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(139, 24);
            this.toolStripButton2.Text = "Book Appointment";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(69, 24);
            this.toolStripButton3.Text = "Payment";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton4.Text = "Refresh";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // FrmCustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 937);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.tabFeedback.ResumeLayout(false);
            this.grpCustomerFeedback.ResumeLayout(false);
            this.grpCustomerFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.grpCustomerProfile.ResumeLayout(false);
            this.grpCustomerProfile.PerformLayout();
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
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
        private System.Windows.Forms.Label lblCustomerCurrentTime;
        private System.Windows.Forms.Label lblCustomerCurrentDate;
        private System.Windows.Forms.Label lblCustomerPayments;
        private System.Windows.Forms.Label lblCustomerAppointments;
        private System.Windows.Forms.Label lblCustomerTotalPets;
        private System.Windows.Forms.Label lblCustomerWelcome;
        private System.Windows.Forms.GroupBox grpCustomerProfile;
        private System.Windows.Forms.TextBox txtCustomerProfileStatus;
        private System.Windows.Forms.Label lblProfileStatus;
        private System.Windows.Forms.Button btnCustomerRefreshProfile;
        private System.Windows.Forms.TextBox txtCustomerProfileName;
        private System.Windows.Forms.TextBox txtCustomerProfileRole;
        private System.Windows.Forms.TextBox txtCustomerProfileEmail;
        private System.Windows.Forms.Button btnCustomerUpdateProfile;
        private System.Windows.Forms.Label lblProfileRole;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}