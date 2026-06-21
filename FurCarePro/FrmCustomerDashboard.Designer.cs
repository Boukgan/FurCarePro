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
            this.lblCustomerCurrentTime = new System.Windows.Forms.Label();
            this.lblCustomerCurrentDate = new System.Windows.Forms.Label();
            this.lblCustomerPayments = new System.Windows.Forms.Label();
            this.lblCustomerAppointments = new System.Windows.Forms.Label();
            this.lblCustomerTotalPets = new System.Windows.Forms.Label();
            this.lblCustomerWelcome = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabHome.SuspendLayout();
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
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
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
            this.registerPetToolStripMenuItem.Click += new System.EventHandler(this.registerPetToolStripMenuItem_Click);
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
            this.bookAppointmentToolStripMenuItem.Click += new System.EventHandler(this.bookAppointmentToolStripMenuItem_Click);
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
            this.makePaymentToolStripMenuItem.Click += new System.EventHandler(this.makePaymentToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton3.Text = "Payment";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton4.Text = "Refresh";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            this.splitContainer1.Panel2.BackgroundImage = global::FurCarePro.Properties.Resources._8;
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1384, 690);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProfile.Location = new System.Drawing.Point(48, 511);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(109, 45);
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
            this.btnFeedback.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFeedback.Location = new System.Drawing.Point(48, 433);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(109, 45);
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
            this.btnPayments.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPayments.Location = new System.Drawing.Point(48, 354);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(109, 45);
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
            this.btnAppointments.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAppointments.Location = new System.Drawing.Point(48, 283);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(109, 45);
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
            this.btnPets.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPets.Location = new System.Drawing.Point(48, 208);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(109, 45);
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
            this.btnHome.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHome.Location = new System.Drawing.Point(48, 132);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 45);
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
            this.tabMain.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(71, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1031, 660);
            this.tabMain.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.LightBlue;
            this.tabHome.Controls.Add(this.lblCustomerCurrentTime);
            this.tabHome.Controls.Add(this.lblCustomerCurrentDate);
            this.tabHome.Controls.Add(this.lblCustomerPayments);
            this.tabHome.Controls.Add(this.lblCustomerAppointments);
            this.tabHome.Controls.Add(this.lblCustomerTotalPets);
            this.tabHome.Controls.Add(this.groupBox1);
            this.tabHome.Controls.Add(this.lblCustomerWelcome);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1023, 634);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // lblCustomerCurrentTime
            // 
            this.lblCustomerCurrentTime.AutoSize = true;
            this.lblCustomerCurrentTime.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCustomerCurrentTime.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCurrentTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCustomerCurrentTime.Location = new System.Drawing.Point(332, 487);
            this.lblCustomerCurrentTime.Name = "lblCustomerCurrentTime";
            this.lblCustomerCurrentTime.Size = new System.Drawing.Size(43, 18);
            this.lblCustomerCurrentTime.TabIndex = 23;
            this.lblCustomerCurrentTime.Text = "Time";
            // 
            // lblCustomerCurrentDate
            // 
            this.lblCustomerCurrentDate.AutoSize = true;
            this.lblCustomerCurrentDate.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCustomerCurrentDate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCurrentDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCustomerCurrentDate.Location = new System.Drawing.Point(331, 370);
            this.lblCustomerCurrentDate.Name = "lblCustomerCurrentDate";
            this.lblCustomerCurrentDate.Size = new System.Drawing.Size(38, 18);
            this.lblCustomerCurrentDate.TabIndex = 22;
            this.lblCustomerCurrentDate.Text = "Date";
            // 
            // lblCustomerPayments
            // 
            this.lblCustomerPayments.AutoSize = true;
            this.lblCustomerPayments.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCustomerPayments.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPayments.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCustomerPayments.Location = new System.Drawing.Point(332, 259);
            this.lblCustomerPayments.Name = "lblCustomerPayments";
            this.lblCustomerPayments.Size = new System.Drawing.Size(114, 18);
            this.lblCustomerPayments.TabIndex = 21;
            this.lblCustomerPayments.Text = "Total Services: 0";
            // 
            // lblCustomerAppointments
            // 
            this.lblCustomerAppointments.AutoSize = true;
            this.lblCustomerAppointments.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCustomerAppointments.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAppointments.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCustomerAppointments.Location = new System.Drawing.Point(332, 201);
            this.lblCustomerAppointments.Name = "lblCustomerAppointments";
            this.lblCustomerAppointments.Size = new System.Drawing.Size(151, 18);
            this.lblCustomerAppointments.TabIndex = 20;
            this.lblCustomerAppointments.Text = "Total Appointments: 0";
            // 
            // lblCustomerTotalPets
            // 
            this.lblCustomerTotalPets.AutoSize = true;
            this.lblCustomerTotalPets.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCustomerTotalPets.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTotalPets.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCustomerTotalPets.Location = new System.Drawing.Point(332, 141);
            this.lblCustomerTotalPets.Name = "lblCustomerTotalPets";
            this.lblCustomerTotalPets.Size = new System.Drawing.Size(88, 18);
            this.lblCustomerTotalPets.TabIndex = 19;
            this.lblCustomerTotalPets.Text = "Total Pets: 0";
            // 
            // lblCustomerWelcome
            // 
            this.lblCustomerWelcome.AutoSize = true;
            this.lblCustomerWelcome.Font = new System.Drawing.Font("Baskerville Old Face", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerWelcome.ForeColor = System.Drawing.Color.Peru;
            this.lblCustomerWelcome.Location = new System.Drawing.Point(327, 45);
            this.lblCustomerWelcome.Name = "lblCustomerWelcome";
            this.lblCustomerWelcome.Size = new System.Drawing.Size(393, 45);
            this.lblCustomerWelcome.TabIndex = 17;
            this.lblCustomerWelcome.Text = "WELCOME ADMIN";
            // 
            // tabPets
            // 
            this.tabPets.BackColor = System.Drawing.Color.LightBlue;
            this.tabPets.Controls.Add(this.grpPetInfo);
            this.tabPets.Location = new System.Drawing.Point(4, 22);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPets.Size = new System.Drawing.Size(1023, 634);
            this.tabPets.TabIndex = 1;
            this.tabPets.Text = "Pets";
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
            this.grpPetInfo.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblSearch.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(45, 401);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 18);
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
            this.btnClearPet.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDeletePet.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnUpdatePet.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAddPet.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblWeight.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(45, 285);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(55, 18);
            this.lblWeight.TabIndex = 16;
            this.lblWeight.Text = "Weight";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.SystemColors.Window;
            this.rbFemale.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(156, 256);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(58, 17);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.SystemColors.Window;
            this.rbMale.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(49, 256);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(45, 231);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 18);
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
            this.lblBreed.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.Location = new System.Drawing.Point(45, 171);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(47, 18);
            this.lblBreed.TabIndex = 10;
            this.lblBreed.Text = "Breed";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Peru;
            this.lblTitle.Location = new System.Drawing.Point(49, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 27);
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
            this.lblPetName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(48, 56);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(71, 18);
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
            this.lblSpecies.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(45, 110);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(55, 18);
            this.lblSpecies.TabIndex = 7;
            this.lblSpecies.Text = "Species";
            // 
            // tabAppointments
            // 
            this.tabAppointments.BackColor = System.Drawing.Color.LightBlue;
            this.tabAppointments.Controls.Add(this.grpAppointmentBooking);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointments.Size = new System.Drawing.Size(1023, 634);
            this.tabAppointments.TabIndex = 2;
            this.tabAppointments.Text = "Appointments";
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
            this.grpAppointmentBooking.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblSearchAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAppointment.Location = new System.Drawing.Point(45, 417);
            this.lblSearchAppointment.Name = "lblSearchAppointment";
            this.lblSearchAppointment.Size = new System.Drawing.Size(142, 18);
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
            this.lblStatus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(46, 320);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 18);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnQueueCount.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnUpdateAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnBookAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblDate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(45, 264);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 18);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(45, 208);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(65, 18);
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
            this.lblPrice.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(45, 154);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 18);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblPetInformation
            // 
            this.lblPetInformation.AutoSize = true;
            this.lblPetInformation.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetInformation.ForeColor = System.Drawing.Color.Peru;
            this.lblPetInformation.Location = new System.Drawing.Point(49, 16);
            this.lblPetInformation.Name = "lblPetInformation";
            this.lblPetInformation.Size = new System.Drawing.Size(330, 27);
            this.lblPetInformation.TabIndex = 9;
            this.lblPetInformation.Text = "APPOINTMENT BOOKING";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.Location = new System.Drawing.Point(45, 54);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(28, 18);
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
            this.lblService.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(45, 104);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(54, 18);
            this.lblService.TabIndex = 7;
            this.lblService.Text = "Service";
            // 
            // tabPayments
            // 
            this.tabPayments.BackColor = System.Drawing.Color.LightBlue;
            this.tabPayments.Controls.Add(this.grpPaymentInfo);
            this.tabPayments.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPayments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPayments.Location = new System.Drawing.Point(4, 22);
            this.tabPayments.Name = "tabPayments";
            this.tabPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayments.Size = new System.Drawing.Size(1023, 634);
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
            this.cmbPaymentAppointment.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentAppointment_SelectedIndexChanged);
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
            this.lblPaymentSearch.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentSearch.Location = new System.Drawing.Point(51, 340);
            this.lblPaymentSearch.Name = "lblPaymentSearch";
            this.lblPaymentSearch.Size = new System.Drawing.Size(55, 18);
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
            this.lblPaymentStatus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(45, 231);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(45, 18);
            this.lblPaymentStatus.TabIndex = 12;
            this.lblPaymentStatus.Text = "Status";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(45, 171);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(57, 18);
            this.lblMethod.TabIndex = 10;
            this.lblMethod.Text = "Method";
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentInfo.ForeColor = System.Drawing.Color.Peru;
            this.lblPaymentInfo.Location = new System.Drawing.Point(49, 16);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(329, 27);
            this.lblPaymentInfo.TabIndex = 9;
            this.lblPaymentInfo.Text = "PAYMENT INFORMATION";
            // 
            // lblPaymentAppointment
            // 
            this.lblPaymentAppointment.AutoSize = true;
            this.lblPaymentAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAppointment.Location = new System.Drawing.Point(45, 56);
            this.lblPaymentAppointment.Name = "lblPaymentAppointment";
            this.lblPaymentAppointment.Size = new System.Drawing.Size(91, 18);
            this.lblPaymentAppointment.TabIndex = 5;
            this.lblPaymentAppointment.Text = "Appointment";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(45, 110);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 18);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // tabFeedback
            // 
            this.tabFeedback.BackColor = System.Drawing.Color.LightBlue;
            this.tabFeedback.Controls.Add(this.grpCustomerFeedback);
            this.tabFeedback.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFeedback.Location = new System.Drawing.Point(4, 22);
            this.tabFeedback.Name = "tabFeedback";
            this.tabFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeedback.Size = new System.Drawing.Size(1023, 634);
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
            this.txtFeedbackSearch.TextChanged += new System.EventHandler(this.txtFeedbackSearch_TextChanged);
            // 
            // lblFeedbackSearch
            // 
            this.lblFeedbackSearch.AutoSize = true;
            this.lblFeedbackSearch.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackSearch.Location = new System.Drawing.Point(51, 340);
            this.lblFeedbackSearch.Name = "lblFeedbackSearch";
            this.lblFeedbackSearch.Size = new System.Drawing.Size(55, 18);
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
            this.lblComments.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(45, 171);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(78, 18);
            this.lblComments.TabIndex = 10;
            this.lblComments.Text = "Comments";
            // 
            // lblCustomerFeedback
            // 
            this.lblCustomerFeedback.AutoSize = true;
            this.lblCustomerFeedback.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFeedback.ForeColor = System.Drawing.Color.Peru;
            this.lblCustomerFeedback.Location = new System.Drawing.Point(49, 16);
            this.lblCustomerFeedback.Name = "lblCustomerFeedback";
            this.lblCustomerFeedback.Size = new System.Drawing.Size(296, 27);
            this.lblCustomerFeedback.TabIndex = 9;
            this.lblCustomerFeedback.Text = "CUSTOMER FEEDBACK";
            // 
            // lblFeedbackAppointment
            // 
            this.lblFeedbackAppointment.AutoSize = true;
            this.lblFeedbackAppointment.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackAppointment.Location = new System.Drawing.Point(45, 56);
            this.lblFeedbackAppointment.Name = "lblFeedbackAppointment";
            this.lblFeedbackAppointment.Size = new System.Drawing.Size(91, 18);
            this.lblFeedbackAppointment.TabIndex = 5;
            this.lblFeedbackAppointment.Text = "Appointment";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(45, 110);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(48, 18);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Rating";
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.LightBlue;
            this.tabProfile.Controls.Add(this.grpCustomerProfile);
            this.tabProfile.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(1023, 634);
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
            this.grpCustomerProfile.Location = new System.Drawing.Point(19, 20);
            this.grpCustomerProfile.Name = "grpCustomerProfile";
            this.grpCustomerProfile.Size = new System.Drawing.Size(985, 608);
            this.grpCustomerProfile.TabIndex = 14;
            this.grpCustomerProfile.TabStop = false;
            this.grpCustomerProfile.Text = "Customer Profile";
            // 
            // txtCustomerProfileStatus
            // 
            this.txtCustomerProfileStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerProfileStatus.Location = new System.Drawing.Point(55, 310);
            this.txtCustomerProfileStatus.Name = "txtCustomerProfileStatus";
            this.txtCustomerProfileStatus.ReadOnly = true;
            this.txtCustomerProfileStatus.Size = new System.Drawing.Size(402, 20);
            this.txtCustomerProfileStatus.TabIndex = 50;
            // 
            // lblProfileStatus
            // 
            this.lblProfileStatus.AutoSize = true;
            this.lblProfileStatus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileStatus.Location = new System.Drawing.Point(51, 287);
            this.lblProfileStatus.Name = "lblProfileStatus";
            this.lblProfileStatus.Size = new System.Drawing.Size(45, 18);
            this.lblProfileStatus.TabIndex = 49;
            this.lblProfileStatus.Text = "Status";
            // 
            // btnCustomerRefreshProfile
            // 
            this.btnCustomerRefreshProfile.Location = new System.Drawing.Point(55, 375);
            this.btnCustomerRefreshProfile.Name = "btnCustomerRefreshProfile";
            this.btnCustomerRefreshProfile.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerRefreshProfile.TabIndex = 48;
            this.btnCustomerRefreshProfile.Text = "Refresh";
            this.btnCustomerRefreshProfile.UseVisualStyleBackColor = true;
            this.btnCustomerRefreshProfile.Click += new System.EventHandler(this.btnCustomerRefreshProfile_Click);
            // 
            // txtCustomerProfileName
            // 
            this.txtCustomerProfileName.Location = new System.Drawing.Point(55, 93);
            this.txtCustomerProfileName.Name = "txtCustomerProfileName";
            this.txtCustomerProfileName.Size = new System.Drawing.Size(402, 20);
            this.txtCustomerProfileName.TabIndex = 46;
            // 
            // txtCustomerProfileRole
            // 
            this.txtCustomerProfileRole.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerProfileRole.Location = new System.Drawing.Point(55, 233);
            this.txtCustomerProfileRole.Name = "txtCustomerProfileRole";
            this.txtCustomerProfileRole.ReadOnly = true;
            this.txtCustomerProfileRole.Size = new System.Drawing.Size(402, 20);
            this.txtCustomerProfileRole.TabIndex = 36;
            // 
            // txtCustomerProfileEmail
            // 
            this.txtCustomerProfileEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerProfileEmail.Location = new System.Drawing.Point(54, 158);
            this.txtCustomerProfileEmail.Name = "txtCustomerProfileEmail";
            this.txtCustomerProfileEmail.ReadOnly = true;
            this.txtCustomerProfileEmail.Size = new System.Drawing.Size(402, 20);
            this.txtCustomerProfileEmail.TabIndex = 35;
            // 
            // btnCustomerUpdateProfile
            // 
            this.btnCustomerUpdateProfile.Location = new System.Drawing.Point(158, 375);
            this.btnCustomerUpdateProfile.Name = "btnCustomerUpdateProfile";
            this.btnCustomerUpdateProfile.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerUpdateProfile.TabIndex = 19;
            this.btnCustomerUpdateProfile.Text = "Update";
            this.btnCustomerUpdateProfile.UseVisualStyleBackColor = true;
            this.btnCustomerUpdateProfile.Click += new System.EventHandler(this.btnCustomerUpdateProfile_Click);
            // 
            // lblProfileRole
            // 
            this.lblProfileRole.AutoSize = true;
            this.lblProfileRole.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileRole.Location = new System.Drawing.Point(51, 210);
            this.lblProfileRole.Name = "lblProfileRole";
            this.lblProfileRole.Size = new System.Drawing.Size(37, 18);
            this.lblProfileRole.TabIndex = 10;
            this.lblProfileRole.Text = "Role";
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTitle.ForeColor = System.Drawing.Color.Peru;
            this.lblCustomerTitle.Location = new System.Drawing.Point(49, 16);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(268, 27);
            this.lblCustomerTitle.TabIndex = 9;
            this.lblCustomerTitle.Text = "CUSTOMER PROFILE";
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.Location = new System.Drawing.Point(51, 70);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(76, 18);
            this.lblProfileName.TabIndex = 5;
            this.lblProfileName.Text = "Full Name";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileEmail.Location = new System.Drawing.Point(50, 135);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(46, 18);
            this.lblProfileEmail.TabIndex = 7;
            this.lblProfileEmail.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(316, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 485);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
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
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}