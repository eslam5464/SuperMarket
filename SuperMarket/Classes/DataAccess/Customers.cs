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
        private static readonly int MaxRows = GlobalVars.MaxQueryRows;
        public static List<CustomerModel> LoadCustomers(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<CustomerModel>($"SELECT TOP {MaxRows} * FROM Customers", new DynamicParameters());
                        return output.ToList();
                    }

                    else
                    {
                        var output = cnn.Query<CustomerModel>($"SELECT * FROM Customers", new DynamicParameters());
                        return output.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading all customers error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Customers", Logger.ERROR);
            }
            return new List<CustomerModel>();
        }

        internal static void SaveCustomer(CustomerModel customer)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO Customers (Name, ContactNo, Address, CreationDate) VALUES " +
                        $"(@Name, @ContactNo, @Address, '{DateTime.Now}')", customer);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving a customer with id = {customer.Name} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Customers", Logger.ERROR);
            }
        }

        internal static void UpdateCustomer(CustomerModel customer)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE Customers SET Name = @Name, ContactNo = @ContactNo, Address = @Address WHERE Id = @Id", customer);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while updating a customer with id = {customer.Id} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Customers", Logger.ERROR);
            }
        }

        internal static List<CustomerModel> GetCustomerParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<CustomerModel>($"SELECT TOP {MaxRows} * FROM Customers WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a customer with param = {Parameter} & condition = {Condition} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Customers", Logger.ERROR);
            }
            return new List<CustomerModel>();
        }

        internal static List<CustomerModel> GetCustomerWithID(long CustomerID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<CustomerModel>($"SELECT TOP {MaxRows} * FROM Customers WHERE Id = {CustomerID}", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a customer with id = {CustomerID} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Customers", Logger.ERROR);
            }
            return new List<CustomerModel>();
        }

        internal static void RemoveCustomer(long customerID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"DELETE FROM Customers WHERE Id= {customerID}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while removing a customer with id = {customerID} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Customers", Logger.ERROR);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}