using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_FinalProject_NHOM03
{
    internal class Database
    {
        private SqlConnection conn;
        private SqlCommand comm;
        private string connectionString;

        public Database()
        {
            connectionString = "Data Source=.;" +
                               "Initial Catalog=Fast_Food_DB;" +
                               "Integrated Security=True";

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
    }
}
