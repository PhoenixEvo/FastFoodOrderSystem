using System;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_FinalProject_NHOM03.DB_layer
{
    class DBMain
    {
        private Database database;
        private SqlCommand comm;
        private SqlDataAdapter da;

        public DBMain()
        {
            database = new Database();
            comm = database.getConnection().CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            database.new_comm();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool success = false;
            database.new_comm();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                success = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                database.closeConnection();
            }
            return success;
        }

        public SqlDataReader ExecuteReader(string strSQL, CommandType ct)
        {
            database.new_comm();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            return comm.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
