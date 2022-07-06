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
        private static readonly int MaxRows = GlobalVars.MaxQueryRows;
        public static void UpdateProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE Products SET BarCode = @BarCode, Name = @Name, Quantity = @Quantity," +
                        $" QuantityMinimum = @QuantityMinimum, Price = @Price, Description = @Description," +
                        $" CategoryID = @CategoryID, CategoryName = @CategoryName WHERE Id = @Id", Product);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while updating product with id = {Product.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
        }

        public static List<ProductModel> LoadProducts(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<ProductModel>($"SELECT TOP {MaxRows} * FROM Products", new DynamicParameters());
                        return output.ToList();
                    }
                    else
                    {
                        var output = cnn.Query<ProductModel>($"SELECT * FROM Products", new DynamicParameters());
                        return output.ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all products & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
            return new List<ProductModel>();
        }

        public static List<ProductModel> GetProductLikeParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ProductModel>($"SELECT TOP {MaxRows} * FROM Products WHERE {Parameter} LIKE N'%{Condition}%'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a product LIKE param = {Parameter} & condition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
            return new List<ProductModel>();
        }

        public static List<ProductModel> GetProductParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    string query = $"SELECT TOP {MaxRows} * FROM Products WHERE {Parameter} = N'{Condition}'";

                    var output = cnn.Query<ProductModel>(query, new DynamicParameters());

                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting product EQUAL param = {Parameter} & condition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
            return new List<ProductModel>();
        }

        public static void SaveProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO Products (BarCode, Name, Quantity, QuantityMinimum, Price, " +
                        $"Description, CategoryID, CategoryName, CreationDate) VALUES " +
                        $"(@BarCode, @Name, @Quantity, @QuantityMinimum, @Price, @Description, @CategoryID, @CategoryName, '{DateTime.Now}')", Product);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving product with name = {Product.Name} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
        }

        public static void RemoveProduct(long ProductID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"DELETE FROM Products WHERE Id = {ProductID}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while removing prodict with id = {ProductID} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}