using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_FinalProject_NHOM03.DB_layer;

namespace DBMS_FinalProject_NHOM03.BS_layer
{
    public class SessionManager
    {
        private static string _sessionID = Guid.NewGuid().ToString("N").Substring(0, 10);
        public static string SessionID
        {
            get { return _sessionID; }
        }
    }
    internal class BLMenu
    {
        private Database db;
        private string _sessionID;

        public BLMenu(Database dab)
        {
            db = dab;
        }

        public DataSet AddSingleDish(string menuID, string foodID, string comboID, decimal price,
            string category, int availableQuantity, string status)
        {
            db.new_comm();
            string sql = "EXEC AddSingleDish @MenuID, @FoodID, @ComboID, @Price, @Category, @AvailableQuantity, @Status";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@MenuID", menuID);
            cmd.Parameters.AddWithValue("@FoodID", foodID);
            cmd.Parameters.AddWithValue("@ComboID", string.IsNullOrEmpty(comboID) ? DBNull.Value : (object)comboID);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@AvailableQuantity", availableQuantity);
            cmd.Parameters.AddWithValue("@Status", status);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public DataSet UpdateMenuItem(string mid, decimal? price, string cate, int? quantity, string stt)
        {
            db.new_comm();
            string sql = "EXEC UpdateMenuItem @MenuID, @Price, @Category, @Quantity, @Status";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@MenuID", mid);
            cmd.Parameters.AddWithValue("@Price", price ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Category", string.IsNullOrEmpty(cate) ? DBNull.Value : (object)cate);
            cmd.Parameters.AddWithValue("@Quantity", quantity ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", string.IsNullOrEmpty(stt) ? DBNull.Value : (object)stt);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }


        public DataSet RemoveFoodInMenu(string id)
        {
            db.new_comm();
            string sql = "EXEC RemoveFoodInMenu @FoodID";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@FoodID", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }
        public DataSet AddCombo(string comboID, string comboName, decimal price)
        {
            db.new_comm();
            string sql = "EXEC AddCombo @ComboID, @ComboName, @Price";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@ComboID", comboID);
            cmd.Parameters.AddWithValue("@ComboName", comboName);
            cmd.Parameters.AddWithValue("@Price", price);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }
        public DataSet RemoveCombo(string comboID)
        {
            db.new_comm();
            string sql = "EXEC RemoveCombo @ComboID";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@ComboID", comboID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }
        public DataSet AddComboItem(string comboID, string foodIDs, string qan)
        {
            db.new_comm();
            string sql = "EXEC AddComboItems @ComboID, @FoodIDs, @Quantity";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@ComboID", comboID);
            cmd.Parameters.AddWithValue("@FoodIDs", foodIDs);
            cmd.Parameters.AddWithValue("@Quantity", qan);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }
        public DataSet DeleteComboItem(string comboID, string foodID)
        {
            db.new_comm();
            string sql = "EXEC DeleteComboItem @ComboID, @FoodID";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@ComboID", comboID);
            cmd.Parameters.AddWithValue("@FoodID", foodID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }
        public DataSet UpdateComboItem(string comboID, string foodID, int? quantity)
        {
            db.new_comm();
            string sql = "EXEC UpdateComboItem @ComboID, @FoodID, @Quantity";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@ComboID", comboID);
            cmd.Parameters.AddWithValue("@FoodID", foodID ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Quantity", quantity.HasValue ? (object)quantity.Value : DBNull.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error executing stored procedure: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
            return ds;
        }


        public DataSet UpdateCombo(string cid, string newn, decimal? np)
        {
            db.new_comm();
            string sql = "EXEC UpdateCombo @ComboID, @NewName, @NewPrice";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@ComboID", cid);
            cmd.Parameters.AddWithValue("@NewName", string.IsNullOrEmpty(newn) ? DBNull.Value : (object)newn);
            cmd.Parameters.AddWithValue("@NewPrice", np.HasValue ? (object)np.Value : DBNull.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public DataSet AddFoodToCart(string sessionID, string foodID, string comboID, int quantity)
        {
            db.new_comm();
            string sql = "EXEC AddItemToCart @SessionID, @FoodID, @ComboID, @Quantity";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@SessionID", sessionID);
            cmd.Parameters.AddWithValue("@FoodID", string.IsNullOrEmpty(foodID) ? DBNull.Value : (object)foodID);
            cmd.Parameters.AddWithValue("@ComboID", string.IsNullOrEmpty(comboID) ? DBNull.Value : (object)comboID);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public DataSet RemoveFoodFromCart(string sessionID, string proid)
        {
            db.new_comm();
            string sql = "EXEC RemoveItemFromCart @SessionID, @ProductID";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@SessionID", sessionID);
            cmd.Parameters.AddWithValue("@ProductID", proid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public DataSet ClearCart(string ss)
        {
            db.new_comm();
            string sql = "EXEC ClearCart @SessionID";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@SessionID", ss);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public DataSet ProcessCart(string action, string sessionID, string foodID, string comboID, int quantity,
            decimal price, out Guid? orderID, string phoneNumber, string customerName, string district, string ward,
            string street, string houseNumber)
        {
            orderID = null;
            db.new_comm();
            SqlCommand cmd = new SqlCommand("ProcessCart", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", action);
            cmd.Parameters.AddWithValue("@SessionID", string.IsNullOrEmpty(sessionID) ? DBNull.Value : (object)sessionID);
            cmd.Parameters.AddWithValue("@FoodID", string.IsNullOrEmpty(foodID) ? DBNull.Value : (object)foodID);
            cmd.Parameters.AddWithValue("@ComboID", string.IsNullOrEmpty(comboID) ? DBNull.Value : (object)comboID);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Price", price);
            SqlParameter orderIdParam = new SqlParameter("@OrderID", SqlDbType.UniqueIdentifier);
            orderIdParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(orderIdParam);

            if (!string.IsNullOrEmpty(phoneNumber))
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            else
                cmd.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);

            if (!string.IsNullOrEmpty(customerName))
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
            else
                cmd.Parameters.AddWithValue("@CustomerName", DBNull.Value);

            if (!string.IsNullOrEmpty(district))
                cmd.Parameters.AddWithValue("@District", district);
            else
                cmd.Parameters.AddWithValue("@District", DBNull.Value);

            if (!string.IsNullOrEmpty(ward))
                cmd.Parameters.AddWithValue("@Ward", ward);
            else
                cmd.Parameters.AddWithValue("@Ward", DBNull.Value);

            if (!string.IsNullOrEmpty(street))
                cmd.Parameters.AddWithValue("@Street", street);
            else
                cmd.Parameters.AddWithValue("@Street", DBNull.Value);

            if (!string.IsNullOrEmpty(houseNumber))
                cmd.Parameters.AddWithValue("@HouseNumber", houseNumber);
            else
                cmd.Parameters.AddWithValue("@HouseNumber", DBNull.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (orderIdParam.Value != DBNull.Value)
            {
                orderID = (Guid)orderIdParam.Value;
            }
            db.closeConnection();
            return ds;
        }
        public DataSet LoadMenu()
        {
            db.new_comm();
            string sql = "SELECT FoodID, FoodName, Price, Category FROM Menu ORDER BY CAST(FoodID AS INT) ASC";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public DataSet GetComboForManage()
        {
            db.new_comm();
            string sql = "SELECT * FROM Combo";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public DataSet GetComboitem()
        {
            db.new_comm();
            string sql = "SELECT * FROM ComboItem";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }


        public DataTable GetCombo()
        {
            db.new_comm();
            string sql = "SELECT ComboID, ComboName, Includes, Price FROM ComboView";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            db.closeConnection();
            return dt;
        }

        public DataSet GetMenuForManagement()
        {
            db.new_comm();
            string sql = "SELECT * FROM MenuItem ORDER BY CAST(MenuID AS INT) ASC";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public DataSet ViewCart(string ssid)
        {
            db.new_comm();
            string sql = "SELECT ProductID, FoodID, ComboID, ProductName, Quantity, Price, TotalPrice FROM Cart WHERE SessionID = @SessionID";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@SessionID", ssid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();
            return ds;
        }

        public decimal CalCulaTotalPrice(string sessionID, int productID, int newQ)
        {
            string sql = "SELECT dbo.CalculateCartItemTotalPrice(@SessionID, @ProductID, @NewQuantity)";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@SessionID", sessionID);
            cmd.Parameters.AddWithValue("@ProductID", productID);
            cmd.Parameters.AddWithValue("@NewQuantity", newQ);
            object result = cmd.ExecuteScalar();
            db.closeConnection();
            return result != null ? Convert.ToDecimal(result) : 0;
        }

        public void UpdateCartItemTotalPrice(string sessionID, int productID, int newQuantity, decimal newTotalPrice)
        {
            string sql = "UPDATE Cart SET Quantity = @Quantity, TotalPrice = @TotalPrice WHERE SessionID = @SessionID AND ProductID = @ProductID";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@Quantity", newQuantity);
            cmd.Parameters.AddWithValue("@TotalPrice", newTotalPrice);
            cmd.Parameters.AddWithValue("@SessionID", sessionID);
            cmd.Parameters.AddWithValue("@ProductID", productID);
            cmd.ExecuteNonQuery();
            db.closeConnection();
        }

    }
}
