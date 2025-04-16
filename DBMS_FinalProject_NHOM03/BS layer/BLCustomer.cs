using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FinalProject_NHOM03.BS_layer
{
    internal class BLCustomer
    {
        private Database db;

        public BLCustomer(Database database)
        {
            db = database;
        }

        public DataSet GetFullAddress(string phoneNumber)
        {
            db.new_comm();
            string sql = "SELECT dbo.GetFullAddress(@PhoneNumber) AS FullAddress";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public DataSet AddNewCustomer(string phoneNumber, string customerName, string district, string ward, string street, string houseNumber)
        {
            db.new_comm();
            string sql = "EXEC AddNewCustomer @PhoneNumber, @CustomerName, @District, @Ward, @Street, @HouseNumber";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@CustomerName", customerName);
            cmd.Parameters.AddWithValue("@District", district);
            cmd.Parameters.AddWithValue("@Ward", ward);
            cmd.Parameters.AddWithValue("@Street", street);
            cmd.Parameters.AddWithValue("@HouseNumber", houseNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public void AddOrderWithAddress(string phoneNumber)
        {
            // Lấy địa chỉ từ hàm GetFullAddress
            string sqlGetAddress = "SELECT dbo.GetFullAddress(@PhoneNumber) AS FullAddress";
            SqlCommand cmdGet = new SqlCommand(sqlGetAddress, db.getConnection());
            cmdGet.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

            db.new_comm();
            string fullAddress = "";

            using (SqlDataReader reader = cmdGet.ExecuteReader())
            {
                if (reader.Read())
                {
                    fullAddress = reader["FullAddress"]?.ToString();
                }
            }

            db.closeConnection();

            // Nếu địa chỉ không rỗng thì thêm vào bảng Orders
            if (!string.IsNullOrWhiteSpace(fullAddress))
            {
                db.new_comm();

                string sqlInsert = "INSERT INTO Orders (PhoneNumber, Address) VALUES (@PhoneNumber, @Address)";
                SqlCommand cmdInsert = new SqlCommand(sqlInsert, db.getConnection());
                cmdInsert.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmdInsert.Parameters.AddWithValue("@Address", fullAddress);
                cmdInsert.ExecuteNonQuery();

                db.closeConnection();
            }
        }

    }
}
