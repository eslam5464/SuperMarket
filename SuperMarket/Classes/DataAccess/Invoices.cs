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
    internal class Invoices
    {
        private static readonly int MaxRows = 100;
        internal static List<InvoiceModel> GetInvoiceParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InvoiceModel>($"SELECT TOP {MaxRows} * FROM Invoices WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting an invoicewith param = {Parameter} & codition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Invoices", Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }

        internal static void AddToInvoice(InvoiceModel invoice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    string query = "INSERT INTO Invoices (InvoiceNumber, CreationDate, CustomerID, CustomerName, CustomerContact, CustomerAddress," +
                        " ProductID, ProductBarCode, ProductName, ProductQuantity, ProductPrice, PriceTotal) VALUES " +
                        $"(@InvoiceNumber, '{DateTime.Now}', @CustomerID, @CustomerName, @CustomerContact, @CustomerAddress, @ProductID," +
                        " @ProductBarCode, @ProductName, @ProductQuantity, @ProductPrice, @PriceTotal)";
                    cnn.Execute(query, invoice);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while adding an invoice with id = {invoice.Id} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Invoices", Logger.ERROR);
            }
        }

        internal static List<InvoiceModel> GetInvoice(long InvoiceNumber)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InvoiceModel>($"SELECT TOP {MaxRows} * FROM Invoices WHERE InvoiceNumber = {InvoiceNumber}", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while removing an invoice with id = {InvoiceNumber} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Invoices", Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }

        internal static List<InvoiceModel> GetAllInvoices(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
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
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Invoices", Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }

        internal static void RemoveProductFromInvoice(long ProductID, long InvoiceNumber)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"DELETE FROM Invoices WHERE Id = {InvoiceNumber} AND ProductID = {ProductID}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while removing product from invoice with Pid = {ProductID} & Iid = {InvoiceNumber} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Invoices", Logger.ERROR);
            }
        }

        internal static List<InvoiceModel> LoadInvoice(string InvoiceNumber)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<InvoiceModel>($"SELECT TOP {MaxRows} * FROM Invoices WHERE InvoiceNumber = {InvoiceNumber}", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading invoice with number = {InvoiceNumber} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Invoices", Logger.ERROR);
            }
            return new List<InvoiceModel>();
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}