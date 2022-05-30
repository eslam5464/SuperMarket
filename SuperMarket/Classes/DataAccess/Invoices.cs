using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace SuperMarket.Classes.DataAccess
{
    internal class Invoices
    {
        internal static void AddToInvoice(InvoiceModel invoice)
        {
            string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new System.Globalization.CultureInfo("ar-AE"));
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "INSERT INTO Invoices ('InvoiceNumber', 'CreationDate', 'CustomerID', 'CustomerName', 'CustomerContact', 'CustomerAddress'," +
                    " 'ProductID', 'ProductBarCode', 'ProductName', 'ProductQuantity', 'ProductPrice', 'PriceTotal') VALUES " +
                    $"(@InvoiceNumber, '{DateTimeNow}', @CustomerID, @CustomerName, @CustomerContact, @CustomerAddress, @ProductID," +
                    " @ProductBarCode, @ProductName, @ProductQuantity, @ProductPrice, @PriceTotal)";
                cnn.Execute(query, invoice);
            }
        }

        internal static List<InvoiceModel> GetInvoice(int InvoiceNumber)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InvoiceModel>($"SELECT * FROM 'Invoices' WHERE InvoiceNumber = '{InvoiceNumber}'", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static List<InvoiceModel> LoadAllInvoices()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InvoiceModel>($"SELECT * FROM 'Invoices'", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        internal static void RemoveProductFromInvoice(int ProductID, int InvoiceID, string CreationDate)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Invoices WHERE Id = {InvoiceID} AND ProductID = {ProductID} AND CreationDate = '{CreationDate}'");
            }
        }

        internal static List<InvoiceModel> LoadInvoice(int InvoiceNumber)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InvoiceModel>($"SELECT * FROM 'Invoices' WHERE InvoiceNumber = {InvoiceNumber}", new DynamicParameters());
                return output.ToList();
            }
        }
    }
}