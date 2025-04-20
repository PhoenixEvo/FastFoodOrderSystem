using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FinalProject_NHOM03.BS_layer
{
    internal class BLOrder
    {
        private Database db;

        public BLOrder(Database database)
        {
            db = database;
        }
        public DataSet GetOrderSummary()
        {
            db.new_comm();
            string sql = "SELECT * FROM OrderSummary";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetOrderSummary: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
            return ds;
        }
        public DataSet GetOrderDetails(String orderId)
        {
            db.new_comm();
            string sql = "SELECT * FROM OrderDetails WHERE OrderID = @OrderID";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public DataSet GetOrderList(String orderId)
        {
            db.new_comm();
            string sql = "SELECT * FROM OrderList WHERE OrderID = @OrderID";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
                
            db.closeConnection();
            return ds;
        }
        public DataSet GetOrderItems(String orderId)
        {
            db.new_comm();
            string sql = "SELECT * FROM OrderItemDetails WHERE OrderID = @OrderID";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public DataSet GetOrderInventoryStatus(String orderId)
        {
            db.new_comm();
            string sql = "SELECT * FROM OrderInventoryCheck WHERE OrderID = @OrderID";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public DataSet AddOrder(string phoneNumber, DateTime orderDate, string status, string paymentMethod, decimal totalAmount, string notes, string address)
        {
            db.new_comm();
            string sql = "EXEC AddOrder @PhoneNumber, @OrderDate, @Status, @PaymentMethod, @TotalAmount, @Notes, @Address";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@OrderDate", orderDate);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
            cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
            cmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", address ?? (object)DBNull.Value);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }

        public DataSet AddOrderItem(String orderId, string menuId, string foodId, string comboId, int quantity, decimal price)
        {
            db.new_comm();
            string sql = "EXEC AddOrderItem @OrderID, @MenuID, @FoodID, @ComboID, @Quantity, @Price";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);
            cmd.Parameters.AddWithValue("@MenuID", menuId);
            cmd.Parameters.AddWithValue("@FoodID", foodId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ComboID", comboId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Price", price);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }

        public DataSet EditOrder(String orderId, string status, string paymentMethod, decimal totalAmount, string notes)
        {
            db.new_comm();
            string sql = "EXEC EditOrder @OrderID, @Status, @PaymentMethod, @TotalAmount, @Notes";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
            cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
            cmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public DataSet UpdateOrderItemQuantity(String orderId, int newQuantity, string foodId = null, string comboId = null)
        {
            db.new_comm();
            string sql = "EXEC UpdateOrderItemQuantity @OrderID, @FoodID, @ComboID, @NewQuantity";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);
            cmd.Parameters.AddWithValue("@FoodID", foodId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ComboID", comboId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        //public bool UpdateOrderStatus(String orderId, string newStatus)
        //{
        //    db.new_comm();
        //    string sql = "EXEC UpdateOrderStatus @OrderID, @NewStatus";

        //    SqlCommand cmd = new SqlCommand(sql, db.getConnection());
        //    cmd.Parameters.AddWithValue("@OrderID", orderId);
        //    cmd.Parameters.AddWithValue("@NewStatus", newStatus);

        //    //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    //DataSet ds = new DataSet();
        //    //adapter.Fill(ds);
        //    //if (ds != null) return true;
        //    //else return false;
        //    //db.closeConnection();
        //    //return ds;
        //    return false;
        //}
        public bool UpdateOrderStatus(string orderId, string newStatus)
        {
            try
            {
                db.new_comm();
                string sql = "EXEC UpdateOrderStatus @OrderID, @NewStatus";

                SqlCommand cmd = new SqlCommand(sql, db.getConnection());
                cmd.Parameters.AddWithValue("@OrderID", orderId); 
                cmd.Parameters.AddWithValue("@NewStatus", newStatus);

                db.openConnection(); 
                int rowsAffected = cmd.ExecuteNonQuery();
                db.closeConnection();
                return rowsAffected > 0; 
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in UpdateOrderStatus: " + ex.Message);
                db.closeConnection(); 
                return false;
            }
        }

        public DataSet DeleteOrderItem(String orderId, string foodId = null, string comboId = null)
        {
            db.new_comm();
            string sql = "EXEC DeleteOrderItem @OrderID, @FoodID, @ComboID";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);
            cmd.Parameters.AddWithValue("@FoodID", foodId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ComboID", comboId ?? (object)DBNull.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }
        public DataSet DeleteOrder(String orderId)
        {
            db.new_comm();
            string sql = "EXEC DeleteOrder @OrderID";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public DataSet CalculateOrderTotal(String orderId)
        {
            db.new_comm();
            string sql = "SELECT dbo.CalculateOrderTotal(@OrderID) AS OrderTotal";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public DataSet SearchOrders(DateTime? fromDate = null, DateTime? toDate = null,
                                   string status = null, string phoneNumber = null,
                                   decimal? minTotalAmount = null, decimal? maxTotalAmount = null, string customerName = null, string orderID = null)
        {
            db.new_comm();
            string sql = "EXEC SearchOrders @FromDate, @ToDate, @Status, @PhoneNumber, @MinTotalAmount, @MaxTotalAmount,@OrderID,@CustomerName";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@FromDate", fromDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ToDate", toDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@MinTotalAmount", minTotalAmount ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@MaxTotalAmount", maxTotalAmount ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@CustomerName", customerName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@OrderID", orderID ?? (object)DBNull.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }
    }
}