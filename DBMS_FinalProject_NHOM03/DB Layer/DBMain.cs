using System.Data.SqlClient;
using System;
using System.Data;
using System.Security.AccessControl;
using System.Windows.Forms;


namespace DBMS_FinalProject_NHOM03.DB_Layer
{
    internal class DBMain
    {

        private SqlConnection conn;
        private SqlCommand comm;
        private string connectionString;

        public DBMain()
        {
            connectionString = "Data Source=Pa;" +
                               "Initial Catalog=Fast_Food_DB;" +
                               "Integrated Security=True;" +
                                "TrustServerCertificate=True";

            conn = new SqlConnection(connectionString);
            comm = conn.CreateCommand();
        }
        public SqlConnection getConnection()
        {
            return conn;
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void new_comm()
        {
            closeConnection();
            openConnection();
        }

        public DataSet ExecuteQueryDataSet(string sql, CommandType commandType, params string[] parameters)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = commandType;
            for (int i = 0; i < parameters.Length; i += 2)
            {
                var paramName = parameters[i];
                var paramValue = parameters[i + 1];
                da.SelectCommand.Parameters.AddWithValue(paramName, paramValue);
            }
            try
            {
                openConnection();
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return ds;
        }
        public DataTable ExecuteReader(string sql, CommandType commandType = CommandType.Text)
        {
            new_comm();
            SqlCommand command = new SqlCommand(sql, conn);
            command.CommandType = commandType;
            DataTable dataTable = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dataTable.Load(reader);
            }
            closeConnection();
            return dataTable;
        }
        public object ExecuteScalarQuery(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(sql, getConnection()))
            {
                cmd.CommandType = commandType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                try
                {
                    openConnection();
                    return cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing query: " + ex.Message);
                    return null;
                }
                finally
                {
                    closeConnection();
                }
            }
        }

    }
}
