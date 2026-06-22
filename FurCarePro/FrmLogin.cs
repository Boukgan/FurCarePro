using FurCarePro.DataAccess;
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
using FurCarePro.Utilities;

namespace FurCarePro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Invalid Email");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Email Required");

                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Password Required");

                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"SELECT *
              FROM tblUsers
              WHERE Email=@Email
              AND Password=@Password
              AND Role=@Role";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text);

                    cmd.Parameters.AddWithValue(
                        "@Password",
                        txtPassword.Text);

                    cmd.Parameters.AddWithValue(
                        "@Role",
                        cmbRole.Text);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        UserSession.UserID =
                        Convert.ToInt32(
                            dr["UserID"]);

                        UserSession.FullName =
                            dr["FullName"].ToString();

                        UserSession.Email =
                            dr["Email"].ToString();

                        UserSession.Role =
                            dr["Role"].ToString();

                        if (cmbRole.Text == "Customer")
                        {
                            FrmCustomerDashboard dashboard =
                                new FrmCustomerDashboard();

                            dashboard.Show();
                        }
                        else
                        {
                            FrmAdminDashboard dashboard =
                                new FrmAdminDashboard();

                            dashboard.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid Login");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister register =
        new FrmRegister();

            register.Show();

            this.Hide();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Width = 120;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.Width = 140;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
