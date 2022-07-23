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
    internal class Invoices
    {
        private static readonly int MaxRows = GlobalVars.MaxQueryRows;
        private static readonly string TableName = "Invoices";
        internal static List<InvoiceModel> GetInvoiceParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<InvoiceModel>($"SELECT TOP {MaxRows} * FROM Invoices WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting an {TableName} with param = {Parameter} & codition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }
        internal static List<InvoiceModel> GetInvoiceTwoParameter(string Parameter1, string Condition1, string Parameter2, string Condition2)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<InvoiceModel>($"SELECT TOP {MaxRows} * FROM Invoices WHERE {Parameter1} = N'{Condition1}' " +
                        $"AND {Parameter2} = N'{Condition2}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting an {TableName} with param1 = {Parameter1} & codition1 = {Condition1} " +
                    $"& param1 = {Parameter2} & codition1 = {Condition2}  & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }

        internal async static Task AddToInvoice(InvoiceModel invoice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    string query = "INSERT INTO Invoices (InvoiceNumber, CreationDate, CustomerID, CustomerName, CustomerContact, CustomerAddress," +
                        " ProductID, ProductBarCode, ProductName, ProductQuantity, ProductPrice, PriceTotal) VALUES " +
                        $"(@InvoiceNumber, '{DateTime.Now}', @CustomerID, @CustomerName, @CustomerContact, @CustomerAddress, @ProductID," +
                        " @ProductBarCode, @ProductName, @ProductQuantity, @ProductPrice, @PriceTotal)";
                    await Task.Run(() => cnn.Execute(query, invoice));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء اضافه المنتج  للفاتورة {invoice.InvoiceNumber}",
                    Notification.EnmType.Error);

                Logger.Log($"while adding an invoice with id = {invoice.Id} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static List<InvoiceModel> GetInvoice(long InvoiceNumber)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<InvoiceModel>($"SELECT TOP {MaxRows} * FROM Invoices WHERE InvoiceNumber = {InvoiceNumber}", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while removing an invoice with id = {InvoiceNumber} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }

        internal static List<InvoiceModel> GetAllInvoices(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<InvoiceModel>($"SELECT TOP {MaxRows} * FROM Invoices", new DynamicParameters());
                        return output.ToList();
                    }
                    else
                    {
                        var output = cnn.Query<InvoiceModel>($"SELECT * FROM Invoices", new DynamicParameters());
                        return output.ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all invoices error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }

        internal async static Task RemoveProductFromInvoice(long ProductID, long InvoiceNumber)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"DELETE FROM Invoices WHERE InvoiceNumber = {InvoiceNumber} AND ProductID = {ProductID}"));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء مسح المنتج من الفاتورة {InvoiceNumber}",
                    Notification.EnmType.Error);

                Logger.Log($"while removing product from invoice with Pid = {ProductID} & Iid = {InvoiceNumber} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static List<InvoiceModel> LoadInvoice(string InvoiceNumber)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<InvoiceModel>($"SELECT TOP {MaxRows} * FROM Invoices WHERE InvoiceNumber = {InvoiceNumber}", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading invoice with number = {InvoiceNumber} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }
    }
}