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
        internal static List<InvoiceModel> GetInvoiceParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InvoiceModel>($"SELECT * FROM Invoices WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static void AddToInvoice(InvoiceModel invoice)
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

        internal static List<InvoiceModel> GetInvoice(long InvoiceNumber)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InvoiceModel>($"SELECT * FROM Invoices WHERE InvoiceNumber = {InvoiceNumber}", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static List<InvoiceModel> GetAllInvoices()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InvoiceModel>($"SELECT * FROM Invoices", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static List<InvoiceModel> LoadAllInvoices()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InvoiceModel>($"SELECT * FROM Invoices", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static void RemoveProductFromInvoice(long ProductID, long InvoiceID, DateTime CreationDate)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Invoices WHERE Id = {InvoiceID} AND ProductID = {ProductID} AND CreationDate = N'{CreationDate}'");
            }
        }

        internal static List<InvoiceModel> LoadInvoice(string InvoiceNumber)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InvoiceModel>($"SELECT * FROM Invoices WHERE InvoiceNumber = {InvoiceNumber}", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}