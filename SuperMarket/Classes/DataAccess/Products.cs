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
    class Products
    {
        public static void UpdateProduct(ProductModel Product)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Products SET BarCode = @BarCode, Name = @Name, Quantity = @Quantity, Price = @Price, " +
                    $"Description = @Description, CategoryID = @CategoryID, CategoryName = @CategoryName WHERE Id = @Id", Product);
            }
        }

        public static List<ProductModel> LoadProducts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM 'Products'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ProductModel> GetProductLikeParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>($"SELECT * FROM 'Products' WHERE {Parameter} LIKE '%{Condition}%'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ProductModel> GetProductParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>($"SELECT * FROM 'Products' WHERE {Parameter} = '{Condition}'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveProduct(ProductModel Product)
        {
            string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new System.Globalization.CultureInfo("ar-AE"));
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Products ('BarCode', 'Name', 'Quantity', 'Price', " +
                    $"'Description', 'CategoryID', 'CategoryName', 'CreationDate') VALUES " +
                    $"(@BarCode, @Name, @Quantity, @Price, @Description, @CategoryID, @CategoryName, '{DateTimeNow}')", Product);
            }
        }

        public static void RemoveProduct(int ProductID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Products WHERE Id = {ProductID}");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}