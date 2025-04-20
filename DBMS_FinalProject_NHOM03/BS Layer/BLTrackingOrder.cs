// BLTrackingOrder.cs
using System;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_FinalProject_NHOM03.BS_layer
{
    internal class BLTrackingOrder
    {
        private readonly Database db;

        public BLTrackingOrder(Database database)
        {
            db = database;
        }

        public DataSet GetOrderTrackingInfo(String orderId)
        {
            db.new_comm();
            string sql = "SELECT * FROM dbo.GetTrackingTable(@OrderID)";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        //public DataSet GetOrderDetails(Guid orderId)
        //{
        //    db.new_comm();
        //    string sql = @"SELECT o.OrderID, o.OrderDate, o.Status, o.PaymentMethod, 
        //                 o.TotalAmount, o.Notes, o.Address,
        //                 c.CustomerName, c.PhoneNumber,
        //                 CONCAT(c.HouseNumber, ', ', c.Street, ', ', c.Ward, ', ', c.District) AS FullAddress
        //                 FROM Orders o
        //                 JOIN Customer c ON o.PhoneNumber = c.PhoneNumber
        //                 WHERE o.OrderID = @OrderID";

        //    SqlCommand cmd = new SqlCommand(sql, db.getConnection());
        //    cmd.Parameters.AddWithValue("@OrderID", orderId);

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds);

        //    db.closeConnection();
        //    return ds;
        //}

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

        public DataSet GetOrderItems(String orderId)
        {
            db.new_comm();
            string sql = @"SELECT 
                         COALESCE(oi.FoodID, oi.ComboID) AS ItemID,
                         COALESCE(i.FoodName, c.ComboName) AS ItemName,
                         oi.Quantity,
                         oi.Price,
                         (oi.Quantity * oi.Price) AS SubTotal,
                         mi.Category
                         FROM OrderItem oi
                         LEFT JOIN Inventory i ON oi.FoodID = i.FoodID
                         LEFT JOIN Combo c ON oi.ComboID = c.ComboID
                         JOIN MenuItem mi ON oi.MenuID = mi.MenuID
                         WHERE oi.OrderID = @OrderID";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@OrderID", orderId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
    }
}