using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace SuperMarket.Classes.DataAccess
{
    class Customers
    {
        public static List<CustomerModel> LoadCustomers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>($"SELECT * FROM 'Customers'", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        internal static void SaveCustomer(CustomerModel customer)
        {
            string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new System.Globalization.CultureInfo("ar-AE"));
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Customers ('Name', 'ContactNo', 'Address', 'CreationDate') VALUES " +
                    $"(@Name, @ContactNo, @Address,'{DateTimeNow}')", customer);
            }
        }

        internal static void UpdateCustomer(CustomerModel customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Customers SET Name = @Name, ContactNo = @ContactNo, Address = @Address WHERE Id = @Id", customer);
            }
        }

        internal static List<CustomerModel> GetCustomerParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>($"SELECT * FROM 'Customers' WHERE {Parameter} = '{Condition}'", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static List<CustomerModel> GetCustomerWithID(string CustomerID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>($"SELECT * FROM 'Customers' WHERE Id = {CustomerID}", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static void RemoveCustomer(int customerID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Customers WHERE Id= {customerID}");
            }
        }
    }
}