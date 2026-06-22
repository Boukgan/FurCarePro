using FurCarePro.DataAccess;
using FurCarePro.Interfaces;
using FurCarePro.Models.Appointments;
using FurCarePro.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FurCarePro
{
    public partial class FrmAdminDashboard : Form, IReport
    {

        private Queue<Appointment>
        appointmentQueue = new Queue<Appointment>();

        private List<string> petNames = new List<string>();

        private Dictionary<int, string>
        serviceDictionary = new Dictionary<int, string>();

        private Stack<string> actionHistory = new Stack<string>();

        private HashSet<string> breedSet = new HashSet<string>();

        public FrmAdminDashboard()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();

            login.Show();

            this.Close();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FrmAdminDashboard_Load(
    sender,
    e);
            MessageBox.Show(
        "Dashboard Refreshed");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"INSERT INTO tblGroomingRecords
            (
                AppointmentID,
                StaffID,
                GroomingNotes,
                GroomingStatus,
                CompletionDate
            )
            VALUES
            (
                @AppointmentID,
                NULL,
                @Notes,
                @Status,
                NULL
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@AppointmentID",
                        cmbStaffAppointment.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Notes",
                        txtNotes.Text);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cmbGroomingStatus.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Grooming Record Added");

                LoadGroomingRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"UPDATE tblGroomingRecords
              SET GroomingStatus='Completed'
              WHERE GroomingID=@GroomingID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@GroomingID",
                        dgvGroomingRecords
                        .CurrentRow
                        .Cells["GroomingID"]
                        .Value);

                    cmd.ExecuteNonQuery();
                }

                GroomingCompletedHandler notify;
                notify = (msg) => MessageBox.Show(msg, "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                notify("Grooming session marked as completed!");

                LoadGroomingRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            cmbGroomingStatus.Items.Add("Pending");
            cmbGroomingStatus.Items.Add("In Progress");
            cmbGroomingStatus.Items.Add("Completed");


            LoadCustomers();

            LoadGroomingAppointmentCombo();

            LoadGroomingRecords();

            LoadOwnerCombo();

            LoadAdminPets();

            ClearPet();

            LoadAdminAppointments();

            LoadPetList();

            LoadAdminServices();

            timerClock.Start();

            LoadProfile();

            LoadAdminPayments();

            LoadAdminFeedback();


            LoadServiceDictionary();

            LoadHomeStatistics();

            GenerateReport();
        }
        public void GenerateReport()
        {
            LoadAnalytics();
            LoadRevenueChart();
            LoadPopularServiceChart();
            LoadCustomerGrowthChart();
            LoadAppointmentStatusChart();
            LoadServicePerformanceChart();
        }
        private void LoadFeedbackSummary()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmdTotal =
                        new SqlCommand(
                        @"SELECT COUNT(*)
                  FROM tblFeedback",
                        conn);

                    lblAdminTotalFeedback.Text =
                        "Total Feedback: "
                        + cmdTotal.ExecuteScalar();

                    SqlCommand cmdAverage =
                        new SqlCommand(
                        @"SELECT ISNULL(
                        AVG(CAST(Rating AS FLOAT)),0)
                  FROM tblFeedback",
                        conn);

                    lblAdminAverageRating.Text =
                        "Average Rating: "
                        + Convert.ToDouble(
                            cmdAverage.ExecuteScalar())
                        .ToString("0.00");
                }
            }
            catch
            {
            }
        }
        private void LoadAdminFeedback()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT *
              FROM tblFeedback";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvAdminFeedback.DataSource = dt;
                }

                LoadFeedbackSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadPaymentSummary()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmdCount =
                        new SqlCommand(
                        @"SELECT COUNT(*)
                  FROM tblPayments",
                        conn);

                    lblAdminTotalPayments.Text =
                        "Total Payments: "
                        + cmdCount.ExecuteScalar();

                    SqlCommand cmdRevenue =
                        new SqlCommand(
                        @"SELECT ISNULL(
                        SUM(Amount),0)
                  FROM tblPayments
                  WHERE PaymentStatus='Paid'",
                        conn);

                    lblAdminTotalRevenue.Text =
                        "Revenue: RM "
                        + cmdRevenue.ExecuteScalar();
                }
            }
            catch
            {
            }
        }

        private void LoadAdminPayments()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT *
              FROM tblPayments";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvAdminPayments.DataSource = dt;
                }

                LoadPaymentSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProfile()
        {
            txtProfileName.Text =
                UserSession.FullName;

            txtProfileEmail.Text =
                UserSession.Email;

            txtProfileRole.Text =
                UserSession.Role;

            txtProfileStatus.Text =
                "Active";
        }

        private void LoadHomeStatistics()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Customers
                    SqlCommand cmdCustomers =
                        new SqlCommand(
                        @"SELECT COUNT(*)
                  FROM tblUsers
                  WHERE Role='Customer'",
                        conn);

                    lblHomeTotalCustomers.Text =
                        "Total Customers: " +
                        cmdCustomers.ExecuteScalar();

                    // Pets
                    SqlCommand cmdPets =
                        new SqlCommand(
                        @"SELECT COUNT(*)
                  FROM tblPets",
                        conn);

                    lblHomeTotalPets.Text =
                        "Total Pets: " +
                        cmdPets.ExecuteScalar();

                    // Appointments
                    SqlCommand cmdAppointments =
                        new SqlCommand(
                        @"SELECT COUNT(*)
                  FROM tblAppointments",
                        conn);

                    
                    lblHomeTotalAppointments.Text =
                        "Total Appointments: " +
                        cmdAppointments.ExecuteScalar();

                    // Services
                    SqlCommand cmdServices =
                        new SqlCommand(
                        @"SELECT COUNT(*)
                  FROM tblServices",
                        conn);

                    lblHomeTotalServices.Text =
                        "Total Services: " +
                        cmdServices.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadUniqueBreeds()
        {
            breedSet.Clear();

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                        "SELECT Breed FROM tblPets";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        breedSet.Add(
                            dr["Breed"]
                            .ToString());
                    }
                }

                lblUniqueBreeds.Text =
                    "Unique Breeds: " +
                    breedSet.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddActionHistory(
    string action)
        {
            actionHistory.Push(action);

            lblLastAction.Text =
                "Last Action: " +
                actionHistory.Peek();
        }

        private void LoadServiceDictionary()
        {
            serviceDictionary.Clear();

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                        "SELECT ServiceID, ServiceName FROM tblServices";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id =
                            Convert.ToInt32(
                                dr["ServiceID"]);

                        string name =
                            dr["ServiceName"]
                            .ToString();

                        serviceDictionary.Add(
                            id,
                            name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAdminServices()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                        "SELECT * FROM tblServices";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvServices.DataSource = dt;

                    LoadServiceDictionary();
                    
                    lblTotalServices.Text =
                        "Total Services: " +
                        dt.Rows.Count;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadPetList()
        {
            petNames.Clear();

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                        "SELECT PetName FROM tblPets";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        petNames.Add(
                            dr["PetName"].ToString());
                    }
                }

                lblTotalPets.Text =
                    "Total Pets: " +
                    petNames.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void ShowQueueMessage(
    string message)
        {
            MessageBox.Show(message);
        }

        private void LoadAdminAppointments()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                a.AppointmentID,
                a.PetID,
                a.ServiceID,
                p.PetName,
                s.ServiceName,
                a.AppointmentDate,
                a.Status
              FROM tblAppointments a
              INNER JOIN tblPets p
              ON a.PetID = p.PetID
              INNER JOIN tblServices s
              ON a.ServiceID = s.ServiceID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvAdminAppointments.DataSource =
                        dt;

                    LoadAppointmentStatistics();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadAppointmentStatistics()
        {
            try
            {
                DataTable dt =
                    dgvAdminAppointments.DataSource
                    as DataTable;

                if (dt == null)
                    return;

                lblTotalAppointments.Text =
                    "Total Appointments: " +
                    dt.Rows.Count;

                lblPendingAppointments.Text =
                    "Pending: " +
                    dt.AsEnumerable()
                    .Count(r =>
                        r["Status"]
                        .ToString() ==
                        "Pending");

                lblCompletedAppointments.Text =
                    "Completed: " +
                    dt.AsEnumerable()
                    .Count(r =>
                        r["Status"]
                        .ToString() ==
                        "Completed");
            }
            catch
            {
            }
        }

        private void ShowPetStatistics()
        {
            try
            {
                DataTable dt =
                    (DataTable)dgvAdminPets.DataSource;

                if (dt == null)
                    return;

                lblDogs.Text =
                    dt.AsEnumerable()
                    .Count(r =>
                        r["Species"]
                        .ToString() == "Dog")
                    .ToString();

                lblCats.Text =
                    dt.AsEnumerable()
                    .Count(r =>
                        r["Species"]
                        .ToString() == "Cat")
                    .ToString();

                lblBirds.Text =
                    dt.AsEnumerable()
                    .Count(r =>
                        r["Species"]
                        .ToString() == "Bird")
                    .ToString();
            }
            catch
            {
            }
        }
        private void ClearPet()
        {
            txtAdminPetID.Clear();

            txtAdminPetName.Clear();

            txtAdminBreed.Clear();

            txtAdminWeight.Clear();

            cmbAdminOwner.SelectedIndex = -1;

            cmbAdminSpecies.SelectedIndex = -1;

            cmbAdminGender.SelectedIndex = -1;
        }

        private void LoadAdminPets()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                p.PetID,
                p.CustomerID,
                u.FullName,
                p.PetName,
                p.Species,
                p.Breed,
                p.Gender,
                p.Weight
              FROM tblPets p
              INNER JOIN tblUsers u
              ON p.CustomerID = u.UserID";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvAdminPets.DataSource = dt;
                 
                    ShowPetStatistics();
                    ShowMostCommonSpecies();
                    LoadUniqueBreeds();

                    lblTotalPets.Text =
                        "Total Pets: " +
                        dt.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ShowMostCommonSpecies()
        {
            try
            {
                DataTable dt =
                    (DataTable)dgvAdminPets.DataSource;

                var species =
                    dt.AsEnumerable()
                    .GroupBy(r =>
                        r["Species"].ToString())
                    .OrderByDescending(g =>
                        g.Count())
                    .FirstOrDefault();

                if (species != null)
                {
                    lblMostCommonSpecies.Text =
                        species.Key;
                }
            }
            catch
            {
            }
        }
        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                UserID,
                FullName,
                Email,
                Phone,
                Status
              FROM tblUsers
              WHERE Role='Customer'";

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        sql,
                        conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvCustomers.DataSource =
                        dt;

                    LoadCustomerStatistics();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadGroomingRecords()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                RecordID,
                AppointmentID,
                GroomingNotes,
                GroomingStatus,
                CompletionDate
              FROM tblGroomingRecords";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvGroomingRecords.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadGroomingAppointmentCombo()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        "SELECT AppointmentID FROM tblAppointments",
                        conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    cmbStaffAppointment.DataSource = dt;

                    cmbStaffAppointment.DisplayMember =
                        "AppointmentID";

                    cmbStaffAppointment.ValueMember =
                        "AppointmentID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void dgvGroomingRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtNotes.Text =
                    dgvGroomingRecords
                    .CurrentRow
                    .Cells["GroomingNotes"]
                    .Value
                    .ToString();

                cmbGroomingStatus.Text =
                    dgvGroomingRecords
                    .CurrentRow
                    .Cells["GroomingStatus"]
                    .Value
                    .ToString();
            }
        }
        private void ShowCompletionMessage(
    string message)
        {
            MessageBox.Show(message);
        }

        private void LoadAnalytics()
        {
            ShowTodayAppointments();

            ShowUpcomingAppointments();

            ShowCompletedGrooming();

            ShowPendingGrooming();

            ShowHighRatings();

            ShowLowRatings();

            ShowPaidTransactions();

            ShowTotalRevenue();

            ShowAverageRating();

            ShowMostPopularService();
        }

        #region LINQ Reports
        private void ShowTodayAppointments()
        {
            using (SqlConnection conn =
        DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT COUNT(*)
              FROM tblAppointments
              WHERE CAST(AppointmentDate AS DATE)
              = CAST(GETDATE() AS DATE)",
                    conn);

                lblTodayAppointments.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }
        // LINQ methods here

        private void ShowUpcomingAppointments()
        {
            using (SqlConnection conn =
        DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT COUNT(*)
              FROM tblAppointments
              WHERE AppointmentDate > GETDATE()",
                    conn);

                lblUpcomingAppointments.Text =
                    cmd.ExecuteScalar().ToString();
            }

        }

        private void ShowCompletedGrooming()
        {
            using (SqlConnection conn =
        DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT COUNT(*)
              FROM tblGroomingRecords
              WHERE GroomingStatus='Completed'",
                    conn);

                lblCompletedGrooming.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }
        private void ShowPendingGrooming()
        {
            using (SqlConnection conn =
        DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT COUNT(*)
              FROM tblGroomingRecords
              WHERE GroomingStatus='Pending'",
                    conn);

                lblPendingGrooming.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }
        private void ShowHighRatings()
        {
            using (SqlConnection conn =
        DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT COUNT(*)
              FROM tblFeedback
              WHERE Rating >= 4",
                    conn);

                lblHighRatings.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }
        private void ShowLowRatings()
        {
            using (SqlConnection conn =
         DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT COUNT(*)
              FROM tblFeedback
              WHERE Rating <= 2",
                    conn);

                lblLowRatings.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }
        private void ShowPaidTransactions()
        {
            using (SqlConnection conn =
        DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT COUNT(*)
              FROM tblPayments
              WHERE PaymentStatus='Paid'",
                    conn);

                lblPaidTransactions.Text =
                    cmd.ExecuteScalar().ToString();
            }
        }
        private void ShowTotalRevenue()
        {
            using (SqlConnection conn =
        DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT ISNULL(
                    SUM(Amount),0)
              FROM tblPayments
              WHERE PaymentStatus='Paid'",
                    conn);

                lblRevenue.Text =
                    "RM " +
                    Convert.ToDecimal(
                        cmd.ExecuteScalar())
                    .ToString("0.00");
            }
        }
        private void ShowAverageRating()
        {
            using (SqlConnection conn =
        DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT ISNULL(
                    AVG(CAST(Rating AS FLOAT)),0)
              FROM tblFeedback",
                    conn);

                lblAverageRating.Text =
                    Convert.ToDouble(
                        cmd.ExecuteScalar())
                    .ToString("0.00");
            }
        }
        private void ShowMostPopularService()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        "SELECT ServiceID FROM tblAppointments",
                        conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        lblPopularService.Text = "N/A";
                        return;
                    }

                    var popular =
                        dt.AsEnumerable()
                          .GroupBy(r =>
                              Convert.ToInt32(
                                  r["ServiceID"]))
                          .OrderByDescending(
                              g => g.Count())
                          .FirstOrDefault();

                    if (popular == null)
                    {
                        lblPopularService.Text = "N/A";
                        return;
                    }

                    int serviceID =
                        popular.Key;    

                    if (serviceDictionary.ContainsKey(serviceID))
                    {
                        lblPopularService.Text =
                            serviceDictionary[serviceID];
                    }
                    else
                    {
                        lblPopularService.Text =
                            "Unknown Service";
                    }
                }
            }
            catch
            {
                lblPopularService.Text = "N/A";
            }
        }
        #endregion


        private void LoadCustomerGrowthChart()
        {
            chartCustomerGrowth.Series.Clear();

            Series series =
                chartCustomerGrowth.Series.Add(
                    "Customers");

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                MONTH(RegisterDate) AS MonthNo,
                COUNT(*) AS TotalCustomers
              FROM tblUsers
              GROUP BY MONTH(RegisterDate)
              ORDER BY MonthNo";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        series.Points.AddXY(
                            dr["MonthNo"],
                            dr["TotalCustomers"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAppointmentStatusChart()
        {
            chartAppointmentStatus.Series.Clear();

            Series series =
                chartAppointmentStatus.Series.Add(
                    "Appointments");

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                Status,
                COUNT(*) AS Total
              FROM tblAppointments
              GROUP BY Status";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        series.Points.AddXY(
                            dr["Status"],
                            dr["Total"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadServicePerformanceChart()
        {
            chartServicePerformance.Series.Clear();

            Series series =
                chartServicePerformance.Series.Add(
                    "Services");

            series.ChartType = SeriesChartType.Column;

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT s.ServiceName,
                    COUNT(*) TotalBookings
                    FROM tblAppointments a
                    INNER JOIN tblServices s
                    ON a.ServiceID = s.ServiceID
                    GROUP BY s.ServiceName";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        series.Points.AddXY(
                            dr["ServiceName"],
                            dr["TotalBookings"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadRevenueChart()
        {
            chartRevenue.Series.Clear();

            Series series =
                chartRevenue.Series.Add(
                    "Revenue");

            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql =
                @"SELECT
            MONTH(PaymentDate) AS MonthNo,
            SUM(Amount) AS Revenue
          FROM tblPayments
          GROUP BY MONTH(PaymentDate)";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                SqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    series.Points.AddXY(
                        dr["MonthNo"],
                        dr["Revenue"]);
                }
            }
        }

        private void LoadPopularServiceChart()
        {
            chartPopularService.Series.Clear();

            Series series =
                chartPopularService.Series.Add(
                    "Services");

            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql =
                @"SELECT
            s.ServiceName,
            COUNT(*) AS Total
          FROM tblAppointments a
          INNER JOIN tblServices s
          ON a.ServiceID=s.ServiceID
          GROUP BY s.ServiceName";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                SqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    series.Points.AddXY(
                        dr["ServiceName"],
                        dr["Total"]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCustomers.Rows[e.RowIndex];

                txtCustomerID.Text =
                    row.Cells["UserID"]
                    .Value
                    .ToString();

                txtCustomerName.Text =
                    row.Cells["FullName"]
                    .Value
                    .ToString();

                txtCustomerEmail.Text =
                    row.Cells["Email"]
                    .Value
                    .ToString();

                txtCustomerPhone.Text =
                    row.Cells["Phone"]
                    .Value
                    .ToString();

                cmbCustomerStatus.Text =
                    row.Cells["Status"]
                    .Value
                    .ToString();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Customer Name Required");

                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"UPDATE tblUsers
              SET
                FullName=@FullName,
                Email=@Email,
                Phone=@Phone,
                Status=@Status
              WHERE UserID=@UserID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        txtCustomerName.Text);

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtCustomerEmail.Text);

                    cmd.Parameters.AddWithValue(
                        "@Phone",
                        txtCustomerPhone.Text);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cmbCustomerStatus.Text);

                    cmd.Parameters.AddWithValue(
                        "@UserID",
                        txtCustomerID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Customer Updated");

                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCustomerStatistics()
        {
            try
            {
                DataTable dt =
                    (DataTable)dgvCustomers.DataSource;

                lblTotalCustomers.Text =
                    "Total Customers: " +
                    dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearCustomer()
        {
            txtCustomerID.Clear();

            txtCustomerName.Clear();

            txtCustomerEmail.Clear();

            txtCustomerPhone.Clear();

            cmbCustomerStatus.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearCustomer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show(
                    "Select Customer First");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Delete this customer?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"DELETE FROM tblUsers
              WHERE UserID=@UserID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@UserID",
                        txtCustomerID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Customer Deleted");

                LoadCustomers();

                ClearCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                UserID,
                FullName,
                Email,
                Phone,
                Status
              FROM tblUsers
              WHERE Role='Customer'
              AND FullName LIKE @Search";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Search",
                        "%" +
                        txtSearchCustomer.Text +
                        "%");

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvCustomers.DataSource =
                        dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            btnSearchCustomer.PerformClick();
            DataView dv =
        ((DataTable)dgvCustomers.DataSource)
        .DefaultView;

            dv.RowFilter =
                $"FullName LIKE '%{txtSearchCustomer.Text}%'";
        }


        private void txtSearchCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null || txt.IsDisposed) return;

            if (e.KeyCode == Keys.Enter)
            {
                btnSearchCustomer.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txt.Clear();
            }
        }

        private void tabPets_Click(object sender, EventArgs e)
        {

        }

        private void grpPetDetails_Enter(object sender, EventArgs e)
        {

        }

        private void LoadOwnerCombo()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                UserID,
                FullName
              FROM tblUsers
              WHERE Role='Customer'";

                    SqlDataAdapter da =
                        new SqlDataAdapter(sql, conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    cmbAdminOwner.DataSource = dt;

                    cmbAdminOwner.DisplayMember =
                        "FullName";

                    cmbAdminOwner.ValueMember =
                        "UserID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdminPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvAdminPets.Rows[e.RowIndex];

                txtAdminPetID.Text =
                    row.Cells["PetID"]
                    .Value.ToString();

                cmbAdminOwner.SelectedValue =
                    row.Cells["CustomerID"]
                    .Value;

                txtAdminPetName.Text =
                    row.Cells["PetName"]
                    .Value.ToString();

                cmbAdminSpecies.Text =
                    row.Cells["Species"]
                    .Value.ToString();

                txtAdminBreed.Text =
                    row.Cells["Breed"]
                    .Value.ToString();

                cmbAdminGender.Text =
                    row.Cells["Gender"]
                    .Value.ToString();

                txtAdminWeight.Text =
                    row.Cells["Weight"]
                    .Value.ToString();
            }
        }

        private void btnUpdatePet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"UPDATE tblPets
              SET
                CustomerID=@CustomerID,
                PetName=@PetName,
                Species=@Species,
                Breed=@Breed,
                Gender=@Gender,
                Weight=@Weight
              WHERE PetID=@PetID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@CustomerID",
                        cmbAdminOwner.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@PetName",
                        txtAdminPetName.Text);

                    cmd.Parameters.AddWithValue(
                        "@Species",
                        cmbAdminSpecies.Text);

                    cmd.Parameters.AddWithValue(
                        "@Breed",
                        txtAdminBreed.Text);

                    cmd.Parameters.AddWithValue(
                        "@Gender",
                        cmbAdminGender.Text);

                    cmd.Parameters.AddWithValue(
                        "@Weight",
                        Convert.ToDecimal(
                            txtAdminWeight.Text));

                    cmd.Parameters.AddWithValue(
                        "@PetID",
                        txtAdminPetID.Text);

                    MessageBox.Show("CustomerID = " + cmbAdminOwner.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Pet Updated");

                LoadAdminPets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearPet_Click(object sender, EventArgs e)
        {
            ClearPet();
        }

        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            if (txtAdminPetID.Text == "")
            {
                MessageBox.Show(
                    "Select Pet First");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Delete this pet?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"DELETE FROM tblPets
              WHERE PetID=@PetID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@PetID",
                        txtAdminPetID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Pet Deleted");

                LoadAdminPets();

                ClearPet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchPet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                p.PetID,
                p.CustomerID,
                u.FullName,
                p.PetName,
                p.Species,
                p.Breed,
                p.Gender,
                p.Weight
              FROM tblPets p
              INNER JOIN tblUsers u
              ON p.CustomerID=u.UserID
              WHERE p.PetName LIKE @Search";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Search",
                        "%" +
                        txtSearchPet.Text +
                        "%");

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvAdminPets.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchPet_TextChanged(object sender, EventArgs e)
        {
            btnSearchPet.PerformClick();
        }

        private void dgvAdminAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvAdminAppointments.Rows[e.RowIndex];

                txtAdminAppointmentID.Text =
                    row.Cells["AppointmentID"]
                    .Value
                    .ToString();

                txtPetName.Text =
                    row.Cells["PetName"]
                    .Value
                    .ToString();

                txtServiceName.Text =
                    row.Cells["ServiceName"]
                    .Value
                    .ToString();

                dtpAdminAppointment.Value =
                    Convert.ToDateTime(
                        row.Cells["AppointmentDate"]
                        .Value);

                cmbAdminAppointmentStatus.Text =
                    row.Cells["Status"]
                    .Value
                    .ToString();
            }
        }
        private void ClearAppointment()
        {
            txtAdminAppointmentID.Clear();

            txtPetName.Clear();

            txtServiceName.Clear();

            cmbAdminAppointmentStatus.SelectedIndex = -1;

            dtpAdminAppointment.Value =
                DateTime.Now;
        }

        private void btnClearAppointment_Click(object sender, EventArgs e)
        {
            ClearAppointment();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (txtAdminAppointmentID.Text == "")
            {
                MessageBox.Show(
                    "Select Appointment First");

                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"UPDATE tblAppointments
              SET
                AppointmentDate=@Date,
                Status=@Status
              WHERE AppointmentID=@ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Date",
                        dtpAdminAppointment.Value);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cmbAdminAppointmentStatus.Text);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        txtAdminAppointmentID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Appointment Updated");

                LoadAdminAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (txtAdminAppointmentID.Text == "")
            {
                MessageBox.Show(
                    "Select Appointment First");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Delete appointment?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"DELETE FROM tblAppointments
              WHERE AppointmentID=@ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        txtAdminAppointmentID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Appointment Deleted");

                LoadAdminAppointments();

                ClearAppointment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                a.AppointmentID,
                a.PetID,
                a.ServiceID,
                p.PetName,
                s.ServiceName,
                a.AppointmentDate,
                a.Status
              FROM tblAppointments a
              INNER JOIN tblPets p
              ON a.PetID = p.PetID
              INNER JOIN tblServices s
              ON a.ServiceID = s.ServiceID
              WHERE p.PetName LIKE @Search";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Search",
                        "%" +
                        txtSearchAppointment.Text +
                        "%");

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvAdminAppointments.DataSource =
                        dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchAppointment_TextChanged(object sender, EventArgs e)
        {
            btnSearchAppointment.PerformClick();
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            if (txtAdminAppointmentID.Text == "")
            {
                MessageBox.Show(
                    "Select Appointment First");

                return;
            }

            Appointment appointment =
                new Appointment();

            appointment.AppointmentID =
                Convert.ToInt32(
                    txtAdminAppointmentID.Text);

            appointment.PetName =
                txtPetName.Text;

            appointment.ServiceName =
                txtServiceName.Text;

            appointment.AppointmentDate =
                dtpAdminAppointment.Value;

            appointment.Status =
                cmbAdminAppointmentStatus.Text;

            appointmentQueue.Enqueue(
                appointment);

            lblQueueCount.Text =
                "Queue Count: " +
                appointmentQueue.Count;

            AppointmentBookedHandler notify =
        msg => MessageBox.Show(msg);

            notify(
                "Appointment Added To Queue");
        }

        private void btnProcessQueue_Click(object sender, EventArgs e)
        {
            if (appointmentQueue.Count == 0)
            {
                MessageBox.Show(
                    "Queue Empty");

                return;
            }

            Appointment appointment =
                appointmentQueue.Dequeue();

            lblQueueCount.Text =
                "Queue Count: " +
                appointmentQueue.Count;

            AppointmentBookedHandler notify =
         msg => MessageBox.Show(msg);

            notify(
                "Appointment Added To Queue");
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ClearService()
        {
            txtServiceID.Clear();

            txtServiceManagementName.Clear();

            txtServicePrice.Clear();

            txtServiceDuration.Clear();

            rtxtServiceDescription.Clear();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (txtServiceManagementName.Text == "")
            {
                MessageBox.Show(
                    "Service Name Required");

                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"INSERT INTO tblServices
            (
                ServiceName,
                Price,
                Duration,
                Description
            )
            VALUES
            (
                @ServiceName,
                @Price,
                @Duration,
                @Description
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@ServiceName",
                        txtServiceManagementName.Text);

                    cmd.Parameters.AddWithValue(
                        "@Price",
                        txtServicePrice.Text);

                    cmd.Parameters.AddWithValue(
                        "@Duration",
                        txtServiceDuration.Text);

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        rtxtServiceDescription.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Service Added");

                AddActionHistory("Added Service: " + txtServiceManagementName.Text);

                LoadAdminServices();

                ClearService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (txtServiceID.Text == "")
            {
                MessageBox.Show(
                    "Select Service First");

                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"UPDATE tblServices
              SET
                ServiceName=@ServiceName,
                Price=@Price,
                Duration=@Duration,
                Description=@Description
              WHERE ServiceID=@ServiceID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@ServiceName",
                        txtServiceManagementName.Text);

                    cmd.Parameters.AddWithValue(
                        "@Price",
                        txtServicePrice.Text);

                    cmd.Parameters.AddWithValue(
                        "@Duration",
                        txtServiceDuration.Text);

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        rtxtServiceDescription.Text);

                    cmd.Parameters.AddWithValue(
                        "@ServiceID",
                        txtServiceID.Text);

                    MessageBox.Show(
                    "Service Updated");

                    AddActionHistory(
                    "Updated Service: " +
                    txtServiceManagementName.Text);

                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Rows Updated: " +
                        rows);
                }

                MessageBox.Show(
                    "Service Updated");

                LoadAdminServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (txtServiceID.Text == "")
            {
                MessageBox.Show(
                    "Select Service First");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Delete Service?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"DELETE FROM tblServices
              WHERE ServiceID=@ServiceID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@ServiceID",
                        txtServiceID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Service Deleted");

                AddActionHistory(
                "Deleted Service ID: " +
                txtServiceID.Text);

                LoadAdminServices();

                ClearService();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearService_Click(object sender, EventArgs e)
        {
            ClearService();
        }

        private void btnSearchService_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT *
              FROM tblServices
              WHERE ServiceName
              LIKE @Search";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Search",
                        "%" +
                        txtSearchService.Text +
                        "%");

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvServices.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchService_TextChanged(object sender, EventArgs e)
        {
            btnSearchService.PerformClick();
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvServices.Rows[e.RowIndex];

                txtServiceID.Text =
                    row.Cells["ServiceID"].Value.ToString();

                txtServiceManagementName.Text =
                    row.Cells["ServiceName"].Value.ToString();

                txtServicePrice.Text =
                    row.Cells["Price"].Value.ToString();

                txtServiceDuration.Text =
                    row.Cells["Duration"].Value.ToString();

                rtxtServiceDescription.Text =
                    row.Cells["Description"].Value.ToString();
            }
        }

        private void btnShowBreeds_Click(object sender, EventArgs e)
        {
            string breeds = "";

            foreach (string breed in breedSet)
            {
                breeds += breed + "\n";
            }

            MessageBox.Show(breeds);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblHomeCurrentDate.Text =
       DateTime.Now.ToString(
           "dd/MM/yyyy");

            lblHomeCurrentTime.Text =
                DateTime.Now.ToString(
                    "hh:mm:ss tt");
        }

        private void btnRefreshProfile_Click(object sender, EventArgs e)
        {
            LoadProfile();

            MessageBox.Show(
                "Profile Refreshed");
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"UPDATE tblUsers
              SET FullName=@FullName
              WHERE UserID=@UserID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        txtProfileName.Text);

                    cmd.Parameters.AddWithValue(
                        "@UserID",
                        UserSession.UserID);

                    int rows =
                        cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        UserSession.FullName =
                            txtProfileName.Text;

                        MessageBox.Show(
                            "Profile Updated");

                        LoadProfile();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabHome;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabCustomer;
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabPets;
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabAppointments;
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabPayments;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabFeedback;
        }

        private void btnGroomingManagement_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabGroomingManagement;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabReports;
        }

        private void btnServiceManagement_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabServices;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabProfile;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminDashboard_Load(
        sender,
        e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "FurCare Pro\n" +
        "Pet Grooming Management System\n\n" +
        "Admin Dashboard");
        }

        private void tsbNewCustomer_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabCustomer;
        }

        private void tsbNewPet_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabPets;
        }

        private void tsbNewAppointment_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabAppointments;
        }

        private void dgvAdminPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvAdminPayments.Rows[e.RowIndex];

                txtAdminPaymentID.Text =
                    row.Cells["PaymentID"]
                    .Value.ToString();

                txtAdminAmount.Text =
                    row.Cells["Amount"]
                    .Value.ToString();

                cmbAdminPaymentStatus.Text =
                    row.Cells["PaymentStatus"]
                    .Value.ToString();
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"UPDATE tblPayments
              SET PaymentStatus=@Status
              WHERE PaymentID=@ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cmbAdminPaymentStatus.Text);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        txtAdminPaymentID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Payment Updated");

                LoadAdminPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdminDeletePayment_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"DELETE FROM tblPayments
              WHERE PaymentID=@ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        txtAdminPaymentID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Payment Deleted");

                LoadAdminPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdminFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvAdminFeedback.Rows[e.RowIndex];

                txtAdminFeedbackID.Text =
                    row.Cells["FeedbackID"]
                    .Value.ToString();

                txtAdminRating.Text =
                    row.Cells["Rating"]
                    .Value.ToString();

                txtAdminComments.Text =
                    row.Cells["Comments"]
                    .Value.ToString();
            }
        }

        private void btnAdminDeleteFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"DELETE FROM tblFeedback
              WHERE FeedbackID=@ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        txtAdminFeedbackID.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Feedback Deleted");

                LoadAdminFeedback();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshPayment_Click(object sender, EventArgs e)
        {
            LoadAdminPayments();

            MessageBox.Show(
                "Payments Refreshed");
        }

        private void btnRefreshFeedback_Click(object sender, EventArgs e)
        {
            LoadAdminFeedback();

            MessageBox.Show(
                "Feedback Refreshed");
        }

        private void exportReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save =
                    new SaveFileDialog();

                save.Filter =
                    "Text File|*.txt";

                save.FileName =
                    "CustomerReport.txt";

                if (save.ShowDialog()
                    == DialogResult.OK)
                {
                    using (StreamWriter sw =
                        new StreamWriter(
                            save.FileName))
                    {
                        sw.WriteLine(
                            "FURCARE PRO REPORT");

                        sw.WriteLine(
                            "====================");

                        sw.WriteLine(
                            "Generated: "
                            + DateTime.Now);

                        sw.WriteLine();

                        foreach (DataGridViewRow row
                            in dgvCustomers.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                sw.WriteLine(
                                    "Customer ID: "
                                    + row.Cells["UserID"].Value);

                                sw.WriteLine(
                                    "Name: "
                                    + row.Cells["FullName"].Value);

                                sw.WriteLine(
                                    "Email: "
                                    + row.Cells["Email"].Value);

                                sw.WriteLine(
                                    "------------------");
                            }
                        }
                    }

                    MessageBox.Show(
                        "Report Exported");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd =
                        new SqlCommand(
                        @"SELECT ISNULL(
                        SUM(Amount),0)
                  FROM tblPayments
                  WHERE PaymentStatus='Paid'",
                        conn);

                    decimal revenue =
                        Convert.ToDecimal(
                            cmd.ExecuteScalar());

                    MessageBox.Show(
                        "Total Revenue: RM " +
                        revenue.ToString("0.00"),
                        "Revenue Report");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void appointmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab =
        tabAppointments;
        }

        private void txtSearchCustomer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchCustomer.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtSearchCustomer.Clear();
            }
        }
    }
}

