using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Classes.DataAccess
{
    class Suppliers
    {
        private static readonly string TableName = "Suppliers";

        public static List<SupplierModel> GetSupplierParameter(string Parameter, string Condition)
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

        public static List<SupplierModel> LoadSuppliers()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SupplierModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName}", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
            return new List<SupplierModel>();
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
