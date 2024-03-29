﻿using Dapper;
using POSWarehouse.Classes.Models;
using POSWarehouse.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace POSWarehouse.Classes.DataAccess
{
    class SupplierInvoiceProduct
    {
        private static readonly string TableName = "SupplierInvoiceProduct";

        internal static void SaveSupplierInvoiceProduct(SupplierInvoiceProductModel supplierInvoice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO {TableName} (ProductId, ProductName, ProductPriceWholesale, ProductPriceSell, Quantity, CreationDate)" +
                        $" VALUES (@ProductId, @ProductName, @ProductPriceWholesale, @ProductPriceSell, @Quantity, '{DateTime.Now}')", supplierInvoice);
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء حفظ منتج لفاتورة المورد {supplierInvoice.ProductName}", Notification.EnmType.Error);

                Logger.Log($"while saving a supplier product with id = {supplierInvoice.ProductId} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static List<SupplierInvoiceProductModel> LoadSupplierInvoiceProduct()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
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
    }
}
