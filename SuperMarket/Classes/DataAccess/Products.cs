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
    class Products
    {
        private static readonly int MaxRows = 100;
        public static void UpdateProduct(ProductModel Product)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Products SET BarCode = @BarCode, Name = @Name, Quantity = @Quantity, Price = @Price, " +
                    $"Description = @Description, CategoryID = @CategoryID, CategoryName = @CategoryName WHERE Id = @Id", Product);
            }
        }

        public static List<ProductModel> LoadProducts()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>("SELECT * FROM Products LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ProductModel> GetProductLikeParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>($"SELECT * FROM Products WHERE {Parameter} LIKE N'%{Condition}%' LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ProductModel> GetProductParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                string query = $"SELECT * FROM Products WHERE {Parameter} = N'{Condition}' LIMIT {MaxRows}";

                List<ProductModel> output = new List<ProductModel>();

                try
                {
                    output = cnn.Query<ProductModel>(query, new DynamicParameters()).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("message: " + ex.Message);
                    Console.WriteLine("output: " + output);
                    Console.WriteLine("query: " + query);
                }

                return output;
            }
        }

        public static void SaveProduct(ProductModel Product)
        {
            string DateTimeNow = DateTime.Now.ToString();
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Products (BarCode, Name, Quantity, Price, " +
                    $"Description, CategoryID, CategoryName, CreationDate) VALUES " +
                    $"(@BarCode, @Name, @Quantity, @Price, @Description, @CategoryID, @CategoryName, '{DateTimeNow}')", Product);
            }
        }

        public static void RemoveProduct(long ProductID)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
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