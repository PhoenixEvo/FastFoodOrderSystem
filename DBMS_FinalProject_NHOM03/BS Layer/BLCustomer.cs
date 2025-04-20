using System;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_FinalProject_NHOM03.BS_layer
{
    internal class BLCustomer
    {
        private Database db;

        public BLCustomer(Database database)
        {
            db = database;
        }

        public void AddNewCustomer(string phoneNumber, string customerName, string district, string ward, string street, string houseNumber)
        {
            db.new_comm();

            SqlCommand cmd = new SqlCommand("AddNewCustomer", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@CustomerName", customerName);
            cmd.Parameters.AddWithValue("@District", district);
            cmd.Parameters.AddWithValue("@Ward", ward);
            cmd.Parameters.AddWithValue("@Street", street);
            cmd.Parameters.AddWithValue("@HouseNumber", houseNumber);

            cmd.ExecuteNonQuery();
            db.closeConnection();
        }

        public void AddCustomerAndUpdateOrder(string phoneNumber, string customerName, string district, string ward, string street, string houseNumber)
        {
            db.new_comm();

            SqlCommand cmd = new SqlCommand("AddCustomerAndUpdateOrder", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@CustomerName", customerName);
            cmd.Parameters.AddWithValue("@District", district);
            cmd.Parameters.AddWithValue("@Ward", ward);
            cmd.Parameters.AddWithValue("@Street", street);
            cmd.Parameters.AddWithValue("@HouseNumber", houseNumber);

            cmd.ExecuteNonQuery();
            db.closeConnection();
        }


        public bool ConfirmCart(
            string sessionId,
            string phoneNumber,
            string customerName,
            string district,
            string ward,
            string street,
            string houseNumber,
            string paymentMethod,
            out string orderId,
            out string errorMessage)
        {
            orderId = "";
            errorMessage = "";

            try
            {
                db.new_comm();

                SqlCommand cmd = new SqlCommand("ProcessCart", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", "CONFIRM");
                cmd.Parameters.AddWithValue("@SessionID", sessionId);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@District", district);
                cmd.Parameters.AddWithValue("@Ward", ward);
                cmd.Parameters.AddWithValue("@Street", street);
                cmd.Parameters.AddWithValue("@HouseNumber", houseNumber);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                SqlParameter orderIdParam = new SqlParameter("@OrderID", SqlDbType.NVarChar, 50)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(orderIdParam);

                cmd.ExecuteNonQuery();

                orderId = orderIdParam.Value.ToString();

                db.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                db.closeConnection();
                return false;
            }

        }
        public DataSet ProcessCart(
    string action, string sessionID, string foodID, string comboID, int quantity, decimal price,
    out string orderID,
    string phoneNumber = null, string customerName = null, string district = null,
    string ward = null, string street = null, string houseNumber = null, string paymentMethod = null
)
        {
            db.new_comm();
            SqlCommand cmd = new SqlCommand("ProcessCart", db.getConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Action", action);
            cmd.Parameters.AddWithValue("@SessionID", (object)sessionID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@FoodID", (object)foodID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ComboID", (object)comboID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.Add("@OrderID", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("@PhoneNumber", (object)phoneNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CustomerName", (object)customerName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@District", (object)district ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Ward", (object)ward ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Street", (object)street ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HouseNumber", (object)houseNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@PaymentMethod", (object)paymentMethod ?? DBNull.Value);

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                orderID = cmd.Parameters["@OrderID"].Value?.ToString();
            }
            catch (Exception ex)
            {
                orderID = null;
                throw new Exception("Error processing cart: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return ds;
        }

    }
}
