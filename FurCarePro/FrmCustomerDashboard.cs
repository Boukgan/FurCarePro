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
    public partial class FrmCustomerDashboard : Form
    {

        public FrmCustomerDashboard()
        {
            InitializeComponent();
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
        dgvAppointments.DataSource as DataTable;

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
        dgvAppointments.DataSource as DataTable;

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

        private void LoadPetComboBox()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        "SELECT PetID, PetName FROM tblPets",
                        conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    cmbPet.DataSource = dt;

                    cmbPet.DisplayMember = "PetName";

                    cmbPet.ValueMember = "PetID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadPetGrid()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        "SELECT * FROM tblPets",
                        conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvPets.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadAppointments()
        {
            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter(
                    "SELECT * FROM tblAppointments",
                    conn);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvAppointments.DataSource = dt;
            }
            ShowTodayAppointments();
        }

        private void LoadServices()
        {
            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter(
                    "SELECT * FROM tblServices",
                    conn);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                cmbService.DataSource = dt;

                cmbService.DisplayMember =
                    "ServiceName";

                cmbService.ValueMember =
                    "ServiceID";
            }
        }
        private bool IsAppointmentAvailable()
        {
            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql =
                @"SELECT COUNT(*)
          FROM tblAppointments
          WHERE AppointmentDate=@Date";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@Date",
                    dtpAppointment.Value);

                int count =
                    (int)cmd.ExecuteScalar();

                return count == 0;
            }
        }
        private void LoadAppointmentCombo()
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

                cmbPaymentAppointment.DataSource = dt;

                cmbPaymentAppointment.DisplayMember =
                    "AppointmentID";

                cmbPaymentAppointment.ValueMember =
                    "AppointmentID";
            }
        }

        private void LoadPayments()
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
                        new SqlDataAdapter(
                        sql,
                        conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvPayments.DataSource = dt;
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

        private void LoadServiceDictionary()
        {
            ServiceDictionary
                .ServiceNames
                .Clear();

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
                    ServiceDictionary
                        .ServiceNames
                        .Add(
                            Convert.ToInt32(dr["ServiceID"]), Convert.ToString(dr["ServiceName"])
                        );
                }
            }
        }
        private void LoadFeedbackAppointmentCombo()
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

                cmbFeedbackAppointment.DataSource = dt;

                cmbFeedbackAppointment.DisplayMember =
                    "AppointmentID";

                cmbFeedbackAppointment.ValueMember =
                    "AppointmentID";
            }
        }
        private void LoadFeedback()
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(
                        "SELECT * FROM tblFeedback",
                        conn);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvFeedback.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text =
        DateTime.Now.ToString(
            "dd/MM/yyyy HH:mm:ss");
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCustomerDashboard_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Customer";

            timerClock.Start();

            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Confirmed");
            cmbStatus.Items.Add("Completed");

            cmbStatus.SelectedIndex = 0;

            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Credit Card");
            cmbPaymentMethod.Items.Add("Online Banking");

            cmbPaymentMethod.SelectedIndex = 0;

            cmbPaymentStatus.Items.Add("Paid");
            cmbPaymentStatus.Items.Add("Pending");

            cmbPaymentStatus.SelectedIndex = 0;

            cmbGroomingStatus.Items.Add("Pending");
            cmbGroomingStatus.Items.Add("In Progress");
            cmbGroomingStatus.Items.Add("Completed");

            LoadPetGrid();
            LoadPetComboBox();

            LoadServices();
            LoadAppointments();

            LoadAppointmentCombo();
            LoadPayments();
            LoadStaff();

            LoadStaffAppointmentCombo();
            LoadGroomingRecords();
            LoadFeedback();

            LoadRevenueChart();
            LoadPopularServiceChart();
            LoadCustomerGrowthChart();
            LoadAppointmentStatusChart();
            LoadStaffPerformanceChart();

            LoadAnalytics();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabHome;
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabPets;
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabAppointments;
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabPayments;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabFeedback;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabProfile;
        }

        private void btnPets_MouseEnter(object sender, EventArgs e)
        {
            btnPets.Width = 129;
        }

        private void btnPets_MouseLeave(object sender, EventArgs e)
        {
            btnPets.Width = 109;
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login =
        new FrmLogin();

            login.Show();

            this.Close();
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string gender =
                        rbMale.Checked
                        ? "Male"
                        : "Female";

                    string sql =
                    @"INSERT INTO tblPets
            (
                PetName,
                Species,
                Breed,
                Gender,
                Weight
            )
            VALUES
            (
                @PetName,
                @Species,
                @Breed,
                @Gender,
                @Weight
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@PetName",
                        txtPetName.Text);

                    cmd.Parameters.AddWithValue(
                        "@Species",
                        cmbSpecies.Text);

                    cmd.Parameters.AddWithValue(
                        "@Breed",
                        txtBreed.Text);

                    cmd.Parameters.AddWithValue(
                        "@Gender",
                        gender);

                    cmd.Parameters.AddWithValue(
                        "@Weight",
                        numWeight.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Pet Added");

                    LoadPetGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPetName.Text =
        dgvPets.CurrentRow.Cells[2]
        .Value.ToString();

            cmbSpecies.Text =
                dgvPets.CurrentRow.Cells[3]
                .Value.ToString();

            txtBreed.Text =
                dgvPets.CurrentRow.Cells[4]
                .Value.ToString();
        }

        private void btnUpdatePet_Click(object sender, EventArgs e)
        {
            int petID =
        Convert.ToInt32(
        dgvPets.CurrentRow.Cells[0]
        .Value);

            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql =
                @"UPDATE tblPets
          SET PetName=@PetName,
              Species=@Species,
              Breed=@Breed
          WHERE PetID=@PetID";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@PetName",
                    txtPetName.Text);

                cmd.Parameters.AddWithValue(
                    "@Species",
                    cmbSpecies.Text);

                cmd.Parameters.AddWithValue(
                    "@Breed",
                    txtBreed.Text);

                cmd.Parameters.AddWithValue(
                    "@PetID",
                    petID);

                cmd.ExecuteNonQuery();

                LoadPetGrid();
            }
        }

        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            DialogResult result =
        MessageBox.Show(
        "Delete pet?",
        "Confirm",
        MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int petID =
                    Convert.ToInt32(
                    dgvPets.CurrentRow.Cells[0]
                    .Value);

                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd =
                        new SqlCommand(
                        "DELETE FROM tblPets WHERE PetID=@PetID",
                        conn);

                    cmd.Parameters.AddWithValue(
                        "@PetID",
                        petID);

                    cmd.ExecuteNonQuery();
                }

                LoadPetGrid();
            }
        }

        private void btnClearPet_Click(object sender, EventArgs e)
        {
            txtPetName.Clear();

            txtBreed.Clear();

            cmbSpecies.SelectedIndex = -1;

            rbMale.Checked = false;

            rbFemale.Checked = false;

            numWeight.Value = 1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt =
        (DataTable)dgvPets.DataSource;

            dt.DefaultView.RowFilter =
                $"PetName LIKE '%{txtSearch.Text}%'";
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView row =
                    (DataRowView)
                    cmbService.SelectedItem;

                txtPrice.Text =
                    row["Price"].ToString();

                txtDuration.Text =
                    row["Duration"].ToString();
            }
            catch
            {

            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpAppointment.Value.Date
            < DateTime.Today)
            {
                MessageBox.Show(
                    "Past dates not allowed");

                dtpAppointment.Value =
                    DateTime.Today;
            }
        }

        private void ShowBookingMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            if (!IsAppointmentAvailable())
            {
                MessageBox.Show("Appointment Slot Taken");
                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"INSERT INTO tblAppointments
            (
                PetID,
                ServiceID,
                AppointmentDate,
                Status
            )
            VALUES
            (
                @PetID,
                @ServiceID,
                @AppointmentDate,
                @Status
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@PetID",
                        cmbPet.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@ServiceID",
                        cmbService.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@AppointmentDate",
                        dtpAppointment.Value);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cmbStatus.Text);

                    cmd.ExecuteNonQuery();
                }

                // QUEUE<T> IMPLEMENTATION
                Appointment appointment = new Appointment();

                appointment.PetID =
                    Convert.ToInt32(cmbPet.SelectedValue);

                appointment.ServiceID =
                    Convert.ToInt32(cmbService.SelectedValue);

                appointment.AppointmentDate =
                    dtpAppointment.Value;

                appointment.Status =
                    cmbStatus.Text;

                GroomingQueueManager
                    .GroomingQueue
                    .Enqueue(appointment);

                AppointmentBookedHandler notify;

                notify = ShowBookingMessage;

                notify("Appointment Booked");

                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbPet.SelectedValue =
        dgvAppointments.CurrentRow
        .Cells["PetID"].Value;

            cmbService.SelectedValue =
                dgvAppointments.CurrentRow
                .Cells["ServiceID"].Value;

            dtpAppointment.Value =
                Convert.ToDateTime(
                    dgvAppointments.CurrentRow
                    .Cells["AppointmentDate"]
                    .Value);

            cmbStatus.Text =
                dgvAppointments.CurrentRow
                .Cells["Status"]
                .Value.ToString();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            int id =
        Convert.ToInt32(
        dgvAppointments.CurrentRow
        .Cells["AppointmentID"].Value);

            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql =
                @"UPDATE tblAppointments
          SET Status=@Status
          WHERE AppointmentID=@ID";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@Status",
                    cmbStatus.Text);

                cmd.Parameters.AddWithValue(
                    "@ID",
                    id);

                cmd.ExecuteNonQuery();
            }

            LoadAppointments();
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            int id =
       Convert.ToInt32(
       dgvAppointments.CurrentRow
       .Cells["AppointmentID"].Value);

            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                    "DELETE FROM tblAppointments WHERE AppointmentID=@ID",
                    conn);

                cmd.Parameters.AddWithValue(
                    "@ID",
                    id);

                cmd.ExecuteNonQuery();
            }

            LoadAppointments();
        }

        private void txtAppointmentSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt =
        (DataTable)dgvAppointments.DataSource;

            dt.DefaultView.RowFilter =
                $"Status LIKE '%{txtAppointmentSearch.Text}%'";
        }

        private void btnQueueCount_Click(object sender, EventArgs e)
        {
            var pendingAppointments =
        GroomingQueueManager
        .GroomingQueue
        .Where(a => a.Status == "Pending")
        .ToList();

            MessageBox.Show(
                $"Pending Queue: {pendingAppointments.Count}");
        }

        private void cmbPaymentAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT s.Price
            FROM tblAppointments a
            INNER JOIN tblServices s
            ON a.ServiceID=s.ServiceID
            WHERE a.AppointmentID=@ID";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        cmbPaymentAppointment.SelectedValue);

                    txtAmount.Text =
                        cmd.ExecuteScalar()
                        .ToString();
                }
            }
            catch
            {

            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"INSERT INTO tblPayments
            (
                AppointmentID,
                Amount,
                PaymentMethod,
                PaymentDate,
                PaymentStatus
            )
            VALUES
            (
                @AppointmentID,
                @Amount,
                @Method,
                GETDATE(),
                @Status
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@AppointmentID",
                        cmbPaymentAppointment.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Amount",
                        txtAmount.Text);

                    cmd.Parameters.AddWithValue(
                        "@Method",
                        cmbPaymentMethod.Text);

                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cmbPaymentStatus.Text);

                    cmd.ExecuteNonQuery();
                }

                PaymentHistoryManager
                    .PaymentStack
                    .Push(
                        $"RM {txtAmount.Text}");

                MessageBox.Show(
                    "Payment Successful");

                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaymentSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt =
        (DataTable)dgvPayments.DataSource;

            dt.DefaultView.RowFilter =
                $"PaymentMethod LIKE '%{txtPaymentSearch.Text}%'";
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
            int recordID =
        Convert.ToInt32(
            dgvGroomingRecords
            .CurrentRow
            .Cells["RecordID"]
            .Value);

            using (SqlConnection conn =
                DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql =
                @"UPDATE tblGroomingRecords
          SET GroomingStatus='Completed',
              CompletionDate=GETDATE()
          WHERE RecordID=@ID";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@ID",
                    recordID);

                cmd.ExecuteNonQuery();
            }

            LoadGroomingRecords();
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

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"INSERT INTO tblFeedback
            (
                AppointmentID,
                Rating,
                Comments,
                FeedbackDate
            )
            VALUES
            (
                @AppointmentID,
                @Rating,
                @Comments,
                GETDATE()
            )";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@AppointmentID",
                        cmbFeedbackAppointment.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@Rating",
                        numRating.Value);

                    cmd.Parameters.AddWithValue(
                        "@Comments",
                        txtComments.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Feedback Submitted");

                LoadFeedback();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFeedbackSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt =
        (DataTable)dgvFeedback.DataSource;

            dt.DefaultView.RowFilter =
                $"Comments LIKE '%{txtFeedbackSearch.Text}%'";
        }

        private void lblHighRatings_Click(object sender, EventArgs e)
        {

        }
    }
}
