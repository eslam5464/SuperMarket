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
    class Suppliers
    {
        private static readonly string TableName = "Suppliers";

        internal static List<SupplierModel> GetSupplierParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SupplierModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a supplier & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SupplierModel>();
        }

        internal static List<SupplierModel> LoadSuppliers(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<SupplierModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName}",
                            new DynamicParameters());
                        return output.ToList();
                    }


                    else
                    {
                        var output = cnn.Query<SupplierModel>($"SELECT * FROM {TableName}", new DynamicParameters());
                        return output.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SupplierModel>();
        }

        internal static void UpdateSupplier(SupplierModel supplier)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE {TableName} SET Name = @Name, Contact = @Contact, Address = @Address" +
                        $" WHERE Id = @Id", supplier);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while updating supplier with id = {supplier.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static void SaveSupplier(SupplierModel supplier)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO {TableName} ( Name, Contact, Address, CreationDate) VALUES " +
                        $"(@Name, @Contact, @Address, '{DateTime.Now}')", supplier);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving product with name = {supplier.Name} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
        }

        internal static void RemoveSupplier(int SupplierId)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"DELETE FROM {TableName} WHERE Id = {SupplierId}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while removing a {TableName} with id = {SupplierId} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
