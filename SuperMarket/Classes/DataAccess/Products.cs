using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Classes.DataAccess
{
    class Products
    {
        private static readonly int MaxRows = GlobalVars.MaxQueryRows;
        public async static Task UpdateProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"UPDATE Products SET BarCode = @BarCode, Name = @Name, Quantity = @Quantity,"
                        + $" QuantityMinimum = @QuantityMinimum, PriceWholesale = @PriceWholesale, PriceSell = @PriceSell,"
                        + $" Description = @Description, CategoryID = @CategoryID, CategoryName = @CategoryName WHERE Id = @Id", Product));
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
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

        public async static Task SaveProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"INSERT INTO Products (BarCode, Name, Quantity, QuantityMinimum, PriceWholesale," +
                        $" PriceSell, Description, CategoryID, CategoryName, CreationDate) VALUES " +
                        $"(@BarCode, @Name, @Quantity, @QuantityMinimum, @PriceWholesale, @PriceSell, @Description, @CategoryID," +
                        $" @CategoryName, '{DateTime.Now}')", Product));
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving product with name = {Product.Name} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
        }

        public async static Task RemoveProduct(long ProductID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"DELETE FROM Products WHERE Id = {ProductID}"));
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while removing prodict with id = {ProductID} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
        }
    }
}