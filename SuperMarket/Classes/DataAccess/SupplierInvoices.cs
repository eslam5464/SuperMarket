using Dapper;
using SuperMarket.Classes.Models;
using SuperMarket.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Classes.DataAccess
{
    class SupplierInvoices
    {
        private static readonly string TableName = "SupplierInvoices";

        internal static void SaveSupplierInvoice(SupplierInvoiceModel supplierInvoice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO {TableName} (SupplierId, SupplierName, PaymentMethod, AmountPaid, AmountLeft," +
                        $"AmountTotal, PaymentStatus, SupplierInvoiceProductId, CreationDate) VALUES " +
                        $"(@SupplierId, @SupplierName, @PaymentMethod, @AmountPaid, @AmountLeft, @AmountTotal, @PaymentStatus," +
                        $" @SupplierInvoiceProductId, '{DateTime.Now}')", supplierInvoice);
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء حفظ فاتورة المورد {supplierInvoice.SupplierInvoiceProductId}",
                    Notification.EnmType.Error);

                Logger.Log($"while saving a supplier invoice for supplier with id = {supplierInvoice.SupplierId} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal async static Task<List<SupplierInvoiceModel>> LoadSupplierInvoices(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = await Task.Run(() => cnn.Query<SupplierInvoiceModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName}",
                            new DynamicParameters()));
                        return output.ToList();
                    }

                    else
                    {
                        var output = cnn.Query<SupplierInvoiceModel>($"SELECT * FROM {TableName}", new DynamicParameters());
                        return output.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SupplierInvoiceModel>();
        }

        internal async static Task<List<SupplierInvoiceModel>> GetSupplierInvoiceParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = await Task.Run(() => cnn.Query<SupplierInvoiceModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * " +
                        $"FROM {TableName} WHERE {Parameter} = N'{Condition}'", new DynamicParameters()));
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a customer with param = {Parameter} & condition = {Condition} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SupplierInvoiceModel>();
        }

        internal async static Task<List<SupplierInvoiceModel>> GetSupplierInvoiceParameterLike(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = await Task.Run(() => cnn.Query<SupplierInvoiceModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * " +
                        $"FROM {TableName} WHERE {Parameter} Like N'%{Condition}%'", new DynamicParameters()));
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a customer like param = {Parameter} & condition = {Condition} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SupplierInvoiceModel>();
        }
    }

}