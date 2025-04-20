using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBMS_FinalProject_NHOM03.BS_layer
{
    internal class BLInventory
    {
        private Database db;

        public BLInventory(Database database)
        {
            db = database;
        }

     
        public string ReduceStock(string foodID, int quantityOrdered)
        {
            db.new_comm();
            string sql = "EXEC ReduceStock @FoodID, @QuantityOrdered, @StatusMessage OUTPUT";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@FoodID", foodID);
            cmd.Parameters.AddWithValue("@QuantityOrdered", quantityOrdered);


            SqlParameter statusParam = new SqlParameter("@StatusMessage", SqlDbType.VarChar, 255);
            statusParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(statusParam);

            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();

            return statusParam.Value.ToString(); // "Updated//Empty"
        }

        public int CheckStock(string foodID)
        {
            db.new_comm();
            string sql = "SELECT dbo.CheckStock(@FoodID) AS Stock";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@FoodID", foodID);

            db.openConnection();
            object result = cmd.ExecuteScalar();
            db.closeConnection();

            if (result != null && int.TryParse(result.ToString(), out int stock))
            {
                return stock;
            }
            return -1;
        }
        public string DeleteFood(string foodID)
        {
            db.new_comm();
            string sql = "EXEC DeleteFood @FoodID, @StatusMessage OUTPUT";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@FoodID", foodID);

            SqlParameter statusParam = new SqlParameter("@StatusMessage", SqlDbType.VarChar, 255);
            statusParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(statusParam);

            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();

            return statusParam.Value.ToString(); // “Deleted//CannotDelete”
        }
        public DataSet UpdateFoodInfo(string foodID, string newFoodName, decimal newCostPrice, int newQuantityInStock, DateTime newLastRestockDate, string newStatus)
        {
            db.new_comm();
            string sql = "EXEC UpdateFoodInfo @FoodID, @NewFoodName, @NewCostPrice, @NewQuantityInStock, @NewLastRestockDate, @NewStatus";

            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.Parameters.AddWithValue("@FoodID", foodID);
            cmd.Parameters.AddWithValue("@NewFoodName", newFoodName);
            cmd.Parameters.AddWithValue("@NewCostPrice", newCostPrice);
            cmd.Parameters.AddWithValue("@NewQuantityInStock", newQuantityInStock);
            cmd.Parameters.AddWithValue("@NewLastRestockDate", newLastRestockDate);
            cmd.Parameters.AddWithValue("@NewStatus", newStatus);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            db.closeConnection();
            return ds;
        }
        public void AddNewFood(string foodID, string foodName, decimal costPrice, int quantityInStock, DateTime lastRestockDate, string status)
        {
            db.new_comm();

            using (SqlCommand cmd = new SqlCommand("AddNewFood", db.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FoodID", foodID);
                cmd.Parameters.AddWithValue("@FoodName", foodName);
                cmd.Parameters.AddWithValue("@CostPrice", costPrice);
                cmd.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                cmd.Parameters.AddWithValue("@LastRestockDate", lastRestockDate);

                cmd.ExecuteNonQuery();
            }

            db.closeConnection();
        }
        public DataSet GetInventoryDetails()
        {
            db.new_comm();
            string sql = "SELECT * FROM InventoryDetails"; // Truy vấn từ view

            SqlDataAdapter adapter = new SqlDataAdapter(sql, db.getConnection());

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            db.closeConnection();

            return ds;
        }



    }
}
