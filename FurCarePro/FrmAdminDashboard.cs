using FurCarePro.DataAccess;
using FurCarePro.Models.Appointments;
using FurCarePro.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FurCarePro
{
    public partial class FrmAdminDashboard : Form
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

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
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
            @StaffID,
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
                    "@StaffID",
                    cmbStaff.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@Notes",
                    txtNotes.Text);

                cmd.Parameters.AddWithValue(
                    "@Status",
                    cmbGroomingStatus.Text);

                cmd.ExecuteNonQuery();
            }

            LoadGroomingRecords();
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

                notify = ShowCompletionMessage;

                notify("Grooming Completed Successfully");

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

            LoadStaff();

            LoadStaffAppointmentCombo();

            LoadGroomingRecords();

            LoadOwnerCombo();

            LoadAdminPets();

            ClearPet();

            LoadAdminAppointments();

            LoadPetList();

            LoadAdminServices();

            LoadRevenueChart();

            LoadPopularServiceChart();

            LoadCustomerGrowthChart();

            LoadAppointmentStatusChart();

            LoadStaffPerformanceChart();

            LoadAnalytics();

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
                gr.RecordID,
                gr.AppointmentID,
                s.StaffName,
                gr.GroomingNotes,
                gr.GroomingStatus,
                gr.CompletionDate
              FROM tblGroomingRecords gr
              INNER JOIN tblStaff s
              ON gr.StaffID = s.StaffID";

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
        private void LoadStaffAppointmentCombo()
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
        private void LoadStaff()
        {
            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter(
                    "SELECT * FROM tblStaff",
                    conn);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                cmbStaff.DataSource = dt;

                cmbStaff.DisplayMember =
                    "StaffName";

                cmbStaff.ValueMember =
                    "StaffID";
            }
        }

        private void dgvGroomingRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbStaff.Text =
                    dgvGroomingRecords
                    .CurrentRow
                    .Cells["StaffName"]
                    .Value
                    .ToString();

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
            DataTable dt =
        dgvAdminAppointments.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblTodayAppointments.Text = "0";
                return;
            }

            int count =
                dt.AsEnumerable()
                  .Count(r =>
                      Convert.ToDateTime(
                          r["AppointmentDate"]).Date
                      ==
                      DateTime.Today);

            lblTodayAppointments.Text =
                count.ToString();
        }
        // LINQ methods here

        private void ShowUpcomingAppointments()
        {
            DataTable dt =
        dgvAdminAppointments.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblUpcomingAppointments.Text = "0";
                return;
            }

            int count =
                dt.AsEnumerable()
                  .Count(r =>
                      Convert.ToDateTime(
                          r["AppointmentDate"])
                      >
                      DateTime.Now);

            lblUpcomingAppointments.Text =
                count.ToString();

        }

        private void ShowCompletedGrooming()
        {
            DataTable dt =
        dgvGroomingRecords.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblCompletedGrooming.Text = "0";
                return;
            }

            int count =
                dt.AsEnumerable()
                  .Count(r =>
                      r["GroomingStatus"]
                      .ToString()
                      ==
                      "Completed");

            lblCompletedGrooming.Text =
                count.ToString();

        }
        private void ShowPendingGrooming()
        {
            DataTable dt =
        dgvGroomingRecords.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblPendingGrooming.Text = "0";
                return;
            }

            int count =
                dt.AsEnumerable()
                  .Count(r =>
                      r["GroomingStatus"]
                      .ToString()
                      ==
                      "Pending");

            lblPendingGrooming.Text =
                count.ToString();
        }
        private void ShowHighRatings()
        {
            DataTable dt =
        dgvFeedback.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblHighRatings.Text = "0";
                return;
            }

            int count =
                dt.AsEnumerable()
                  .Count(r =>
                      Convert.ToInt32(
                          r["Rating"]) >= 4);

            lblHighRatings.Text =
                count.ToString();
        }
        private void ShowLowRatings()
        {
            DataTable dt =
        dgvFeedback.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblLowRatings.Text = "0";
                return;
            }

            int count =
                dt.AsEnumerable()
                  .Count(r =>
                      Convert.ToInt32(
                          r["Rating"]) <= 2);

            lblLowRatings.Text =
                count.ToString();
        }
        private void ShowPaidTransactions()
        {
            DataTable dt =
       dgvPayments.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblPaidTransactions.Text = "0";
                return;
            }

            int count =
                dt.AsEnumerable()
                  .Count(r =>
                      r["PaymentStatus"]
                      .ToString()
                      ==
                      "Paid");

            lblPaidTransactions.Text =
                count.ToString();
        }
        private void ShowTotalRevenue()
        {
            DataTable dt =
        dgvPayments.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblRevenue.Text = "RM 0.00";
                return;
            }

            decimal total =
                dt.AsEnumerable()
                  .Sum(r =>
                      Convert.ToDecimal(
                          r["Amount"]));

            lblRevenue.Text =
                "RM " + total.ToString("N2");
        }
        private void ShowAverageRating()
        {
            DataTable dt =
        dgvFeedback.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblAverageRating.Text = "0";
                return;
            }

            double average =
                dt.AsEnumerable()
                  .Average(r =>
                      Convert.ToDouble(
                          r["Rating"]));

            lblAverageRating.Text =
                average.ToString("0.00");
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

                    if (ServiceDictionary
                        .ServiceNames
                        .ContainsKey(serviceID))
                    {
                        lblPopularService.Text =
                            ServiceDictionary
                            .ServiceNames[serviceID];
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

        private void LoadStaffPerformanceChart()
        {
            chartStaffPerformance.Series.Clear();

            Series series =
                chartStaffPerformance.Series.Add(
                    "Performance");

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT
                s.StaffName,
                COUNT(*) AS TotalJobs
              FROM tblGroomingRecords gr
              INNER JOIN tblStaff s
              ON gr.StaffID = s.StaffID
              WHERE gr.GroomingStatus = 'Completed'
              GROUP BY s.StaffName";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        series.Points.AddXY(
                            dr["StaffName"],
                            dr["TotalJobs"]);
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
                lblTotalCustomers.Text =
                    "Total Customers: " +
                    dgvCustomers.Rows.Count;
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
    }
}

