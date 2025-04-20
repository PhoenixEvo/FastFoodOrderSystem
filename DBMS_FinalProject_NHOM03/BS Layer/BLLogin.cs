using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FinalProject_NHOM03.BS_layer
{
    internal class BLLogin
    {
        private Database db;

        public BLLogin(Database database)
        {
            db = database;
        }

        public string GetUserRole(string username)
        {
            db.new_comm();
            string sql = "SELECT Role FROM StaffLogin WHERE Username = @Username";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@Username", username);

            try
            {
                db.openConnection();
                object result = cmd.ExecuteScalar();
                db.closeConnection();

                return result != null ? result.ToString() : "Staff";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetUserRole: " + ex.Message);
                db.closeConnection();
                return "Staff";
            }
        }
        public Tuple<bool, string> ValidateUserAndGetRole(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return new Tuple<bool, string>(true, "Admin");
            }

            db.new_comm();
            string sql = "SELECT COUNT(*) FROM StaffLogin WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                db.openConnection();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                db.closeConnection();

                if (result > 0)
                    return new Tuple<bool, string>(true, "Staff");
                else
                    return new Tuple<bool, string>(false, string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in ValidateUser: " + ex.Message);
                db.closeConnection();
                return new Tuple<bool, string>(false, string.Empty);
            }
        }

        public DataSet CreateStaff(string user, string pass)
        {
            db.new_comm();
            string sql = "INSERT INTO StaffLogin (Username, Password) VALUES (@Username, @Password)";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@Username", user);
            cmd.Parameters.AddWithValue("@Password", pass);
            DataSet ds = new DataSet();
            db.openConnection(); 
            int rowsAffected = cmd.ExecuteNonQuery();
            db.closeConnection();
            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("RowsAffected", typeof(int));
            resultTable.Rows.Add(rowsAffected);
            ds.Tables.Add(resultTable);
            return ds;
        }

        public bool GrantAdminPermissions(string username)
        {
            db.new_comm();
            string sql = "EXEC sp_addrolemember 'db_owner', @Username";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@Username", username);
            try
            {
                db.openConnection();
                int rowsAffected = cmd.ExecuteNonQuery();
                db.closeConnection();
                return rowsAffected >= 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GrantAdminPermissions: " + ex.Message);
                db.closeConnection();
                return false;
            }
        }
        public void CreateLoginAndGrantAccess(string username, string password)
        {
            db.new_comm();
            SqlCommand cmd = new SqlCommand("usp_CreateLoginAndGrantAccess", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CreateLoginAndGrantAccess: " + ex.Message);
                db.closeConnection();
            }
        }
    }
}