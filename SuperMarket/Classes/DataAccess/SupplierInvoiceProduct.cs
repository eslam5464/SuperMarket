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
    class SupplierInvoiceProduct
    {
        private static readonly string TableName = "SupplierInvoiceProduct";

        internal static void SaveSupplierInvoiceProduct(SupplierInvoiceProductModel supplierInvoice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO {TableName} (ProductId, ProductName, Quantity, CreationDate) VALUES " +
                        $"(@ProductId, @ProductName, @Quantity, '{DateTime.Now}')", supplierInvoice);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving a supplier product with id = {supplierInvoice.ProductId} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static List<SupplierInvoiceProductModel> LoadSupplierInvoiceProduct()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<SupplierInvoiceProductModel>
                        ($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName}", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all SupplierInvoiceProduct & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SupplierInvoiceProductModel>();
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
