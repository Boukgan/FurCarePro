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

namespace FurCarePro
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Customer");
            cmbRole.Items.Add("Staff");
            cmbRole.Items.Add("Admin");

            cmbRole.SelectedIndex = 0;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
        &&
        !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            progressPassword.Value =
        Math.Min(
            txtPassword.Text.Length * 10,
            100);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show(
                    "Name Required");
                return;
            }

            if (txtPassword.Text
               !=
               txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "Password mismatch");
                return;
            }

            try
            {
                using (SqlConnection conn =
                    DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql =
                    @"INSERT INTO tblUsers
            (
                FullName,
                Email,
                Password,
                Phone,
                Role,
                Status
            )
            VALUES
            (
                @FullName,
                @Email,
                @Password,
                @Phone,
                @Role,
                'Active'
            )";

                    SqlCommand cmd =
                        new SqlCommand(
                            sql,
                            conn);

                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        txtFullName.Text);

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text);

                    cmd.Parameters.AddWithValue(
                        "@Password",
                        txtPassword.Text);

                    cmd.Parameters.AddWithValue(
                        "@Phone",
                        txtPhone.Text);

                    cmd.Parameters.AddWithValue(
                        "@Role",
                        cmbRole.Text);

                    int rows =
                        cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show(
                            "Registration Successful");

                        FrmLogin login =
                            new FrmLogin();

                        login.Show();

                        this.Hide();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Email Already Exists");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtPhone.Clear();

            cmbRole.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmLogin login =
        new FrmLogin();

            login.Show();

            this.Hide();
        }
    }
}
