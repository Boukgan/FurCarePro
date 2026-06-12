using FurCarePro.DataAccess;
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

            LoadRevenueChart();

            LoadPopularServiceChart();

            LoadCustomerGrowthChart();

            LoadAppointmentStatusChart();

            LoadStaffPerformanceChart();

            LoadAnalytics();

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
    }
}

