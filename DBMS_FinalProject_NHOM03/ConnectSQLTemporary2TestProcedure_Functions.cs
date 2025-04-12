using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DBMS_FinalProject_NHOM03
{
    public class OrderManager
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        public OrderManager(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        // Phương thức tổng quát để gọi stored procedure
        private DataTable ExecuteStoredProcedure(string procedureName, Dictionary<string, object> parameters = null)
        {
            DataTable resultTable = new DataTable();

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(procedureName, _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"SQL Error executing {procedureName}: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing {procedureName}: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return resultTable;
        }

        // Phương thức gọi function
        private T ExecuteScalarFunction<T>(string functionName, Dictionary<string, object> parameters = null)
        {
            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(functionName, _connection))
                {
                    command.CommandType = CommandType.StoredProcedure; // SQL Server treats functions similarly

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    var result = command.ExecuteScalar();
                    return (T)Convert.ChangeType(result, typeof(T));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing function {functionName}: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }

        // 1. Thêm đơn hàng mới
        public Guid AddOrder(string phoneNumber, DateTime orderDate, string status,
                           string paymentMethod, decimal totalAmount, string notes, string address)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@PhoneNumber", phoneNumber },
                { "@OrderDate", orderDate },
                { "@Status", status },
                { "@PaymentMethod", paymentMethod },
                { "@TotalAmount", totalAmount },
                { "@Notes", notes },
                { "@Address", address }
            };

            DataTable result = ExecuteStoredProcedure("AddOrder", parameters);
            return (Guid)result.Rows[0]["OrderID"];
        }

        // 2. Thêm món vào đơn hàng
        public bool AddOrderItem(Guid orderId, string menuId, string foodId, string comboId,
                               int quantity, decimal price)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@OrderID", orderId },
                    { "@MenuID", menuId },
                    { "@FoodID", foodId },
                    { "@ComboID", comboId },
                    { "@Quantity", quantity },
                    { "@Price", price }
                };

                ExecuteStoredProcedure("AddOrderItem", parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 3. Chỉnh sửa đơn hàng
        public bool EditOrder(Guid orderId, string status, string paymentMethod,
                            decimal totalAmount, string notes)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@OrderID", orderId },
                    { "@Status", status },
                    { "@PaymentMethod", paymentMethod },
                    { "@TotalAmount", totalAmount },
                    { "@Notes", notes }
                };

                ExecuteStoredProcedure("EditOrder", parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 4. Cập nhật trạng thái đơn hàng
        public bool UpdateOrderStatus(Guid orderId, string newStatus)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@OrderID", orderId },
                    { "@NewStatus", newStatus }
                };

                ExecuteStoredProcedure("UpdateOrderStatus", parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 5. Xóa đơn hàng
        public bool DeleteOrder(Guid orderId)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@OrderID", orderId }
                };

                ExecuteStoredProcedure("DeleteOrder", parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 6. Tính tổng giá trị đơn hàng
        public decimal CalculateOrderTotal(Guid orderId)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@OrderID", orderId }
            };

            return ExecuteScalarFunction<decimal>("CalculateOrderTotal", parameters);
        }

        // 7. Tìm kiếm đơn hàng
        public DataTable SearchOrders(DateTime? fromDate = null, DateTime? toDate = null,
                                    string status = null, string phoneNumber = null,
                                    decimal? minTotalAmount = null, decimal? maxTotalAmount = null)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@FromDate", fromDate },
                { "@ToDate", toDate },
                { "@Status", status },
                { "@PhoneNumber", phoneNumber },
                { "@MinTotalAmount", minTotalAmount },
                { "@MaxTotalAmount", maxTotalAmount }
            };

            return ExecuteStoredProcedure("SearchOrders", parameters);
        }
    }
}