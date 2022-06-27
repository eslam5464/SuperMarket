using Dapper;
using SuperMarket.Classes.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SuperMarket.Classes.DataAccess
{
    internal class Orders
    {
        private static readonly int MaxRows = 100;
        internal static List<OrderModel> GetOrderParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<OrderModel>($"SELECT * FROM Orders WHERE {Parameter} = N'{Condition}' LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static void AddOrder(OrderModel order)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Orders (InvoiceDate, InvoiceId, CustomerId, CustomerName, " +
                    $"ContactNumber, Address, GrandTotal, CreatedByUserId) VALUES (@InvoiceDate, @InvoiceId, @CustomerId, @CustomerName, " +
                    $"@ContactNumber, @Address, @GrandTotal, @CreatedByUserId)", order);
            }
        }

        internal static List<OrderModel> GetAllOrders()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<OrderModel>($"SELECT * FROM Orders LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}