using DBMS_FinalProject_NHOM03.BS_layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_FinalProject_NHOM03
{
    public partial class frmLogin : Form
    {
        private Database db = new Database();
        private BLLogin log;

        public frmLogin()
        {
            InitializeComponent();
            log = new BLLogin(db);
        }

        private bool TryLogin(string username, string password)
        {
            string connectionString = $"Data Source=.;Initial Catalog=Fast_Food_DB;User ID={username};Password={password};TrustServerCertificate=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TryLogin(username, password))
            {
                var result = log.ValidateUserAndGetRole(username, password);
                if (result.Item1)
                {
                    CurrentUser.Username = username;
                    CurrentUser.Role = result.Item2;

                    MainForm main = new MainForm();
                    main.ConfigureUIByUserRole(CurrentUser.Role);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DataSet result = log.CreateStaff(username, password);  // Trigger sẽ tạo login + user + quyền
                if (result != null)
                {
                    MessageBox.Show("Staff created successfully!\nYou can now login using this account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create staff user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pc_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static bool IsAdmin => Role == "Admin";

        public static void Clear()
        {
            Username = null;
            Role = null;
        }
    }
}