using Dapper;
using SuperMarket.Classes.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace SuperMarket.Classes.DataAccess
{
    internal class Orders
    {
        internal static void AddOrder(OrderModel order)
        {
            //string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new System.Globalization.CultureInfo("ar-AE"));
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Orders ('InvoiceDate', 'InvoiceId', 'CustomerId', 'CustomerName', " +
                    $"'ContactNumber','Address', 'GrandTotal') VALUES (@InvoiceDate, @InvoiceId, @CustomerId, @CustomerName, " +
                    $"@ContactNumber, @Address, @GrandTotal)", order);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        internal static List<OrderModel> GetAllOrders()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<OrderModel>($"SELECT * FROM 'Orders'", new DynamicParameters());
                return output.ToList();
            }
        }
    }
}