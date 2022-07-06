using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SuperMarket.Classes.DataAccess
{
    class SupplierInvoice
    {
        private static readonly string TableName = "SupplierInvoice";

        internal static void SaveSupplierInvoice(SupplierInvoiceModel supplierInvoice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO Customers (SupplierId, PaymentMethod, PaidAmount, AmountLeft," +
                        $"AmountTotal, PaymentStatus, SupplierInvoiceProductId, CreationDate) VALUES " +
                        $"(@SupplierId, @PaymentMethod, @PaidAmount, @AmountLeft, @AmountTotal, @PaymentStatus," +
                        $" @SupplierInvoiceProductId, '{DateTime.Now}')", supplierInvoice);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving a supplier invoice for supplier with id = {supplierInvoice.SupplierId} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
