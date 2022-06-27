using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SuperMarket.Classes.DataAccess
{
    class Customers
    {
        private static readonly int MaxRows = 100;
        public static List<CustomerModel> LoadCustomers()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>($"SELECT * FROM Customers LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static void SaveCustomer(CustomerModel customer)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Customers (Name, ContactNo, Address, CreationDate) VALUES " +
                    $"(@Name, @ContactNo, @Address, '{DateTime.Now}')", customer);
            }
        }

        internal static void UpdateCustomer(CustomerModel customer)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Customers SET Name = @Name, ContactNo = @ContactNo, Address = @Address WHERE Id = @Id", customer);
            }
        }

        internal static List<CustomerModel> GetCustomerParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>($"SELECT * FROM Customers WHERE {Parameter} = N'{Condition}' LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static List<CustomerModel> GetCustomerWithID(long CustomerID)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>($"SELECT * FROM Customers WHERE Id = {CustomerID} LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static void RemoveCustomer(long customerID)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Customers WHERE Id= {customerID}");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}