using Dapper;
using SuperMarket.Classes.Models;
using SuperMarket.Classes.Models.Joins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Classes.DataAccess
{
    class Products
    {
        private static readonly int MaxRows = GlobalVars.MaxQueryRows;
        private static readonly string TableName = "Products";
        internal async static Task UpdateProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"UPDATE {TableName} SET BarCode = @BarCode, Name = @Name, Quantity = @Quantity,"
                        + $" QuantityMinimum = @QuantityMinimum, Description = @Description, CategoryID = @CategoryID, " +
                        $"CategoryName = @CategoryName, PriceModificationDate = @PriceModificationDate WHERE Id = @Id", Product));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تعديل المنتج {Product.Name}", "خطأ",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while updating {TableName} with id = {Product.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static List<ProductModel> LoadProductsWithoutPrices(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<ProductModel>($"SELECT TOP {MaxRows} * FROM {TableName}", new DynamicParameters());
                        return output.ToList();
                    }
                    else
                    {
                        var output = cnn.Query<ProductModel>($"SELECT * FROM {TableName}", new DynamicParameters());
                        return output.ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<ProductModel>();
        }

        internal static List<Product_ProductPriceModel> LoadProductsWithPrices(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        string query = $"exec dbo.spProducts_GetFullDetails {MaxRows}";
                        var output = cnn.Query<Product_ProductPriceModel>(query, new DynamicParameters());
                        return output.ToList();
                    }
                    else
                    {
                        var output = cnn.Query<Product_ProductPriceModel>($"exec dbo.spProducts_GetFullDetails 0", new DynamicParameters());
                        return output.ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<Product_ProductPriceModel>();
        }

        internal static List<ProductModel> GetProductLikeParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<ProductModel>($"SELECT TOP {MaxRows} * FROM {TableName} WHERE {Parameter} LIKE N'%{Condition}%'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} LIKE param = {Parameter} & condition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<ProductModel>();
        }

        internal static List<ProductModel> GetProductParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    string query = $"SELECT TOP {MaxRows} * FROM {TableName} WHERE {Parameter} = N'{Condition}'";

                    var output = cnn.Query<ProductModel>(query, new DynamicParameters());

                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting product EQUAL param = {Parameter} & condition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<ProductModel>();
        }

        internal static List<Product_ProductPriceModel> GetProductParameterWithPricee(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    string query = $"SELECT TOP {MaxRows} * FROM (SELECT [Id],[BarCode],[Name],[Quantity],[QuantityMinimum], " +
                        $"productPrice.[PriceWholesale], productPrice.[PriceSell], [Description], [CategoryID], " +
                        $"[CategoryName], products.[CreationDate], [PriceModificationDate] FROM [dbo].[Products] AS products " +
                        $"join (SELECT[ProductId], [PriceWholesale], [PriceSell], [CreationDate] FROM[dbo].[ProductPrice]) " +
                        $"AS productPrice ON products .[Id] = productPrice.[ProductId] " +
                        $"AND products.[PriceModificationDate] = productPrice.[CreationDate]) AS TempTable " +
                        $"WHERE {Parameter} = N'{Condition}'";

                    var output = cnn.Query<Product_ProductPriceModel>(query, new DynamicParameters());

                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting product EQUAL param = {Parameter} & condition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<Product_ProductPriceModel>();
        }

        internal async static Task SaveProduct(ProductModel Product)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    DateTime DateTimeNow = DateTime.Now;
                    await Task.Run(() => cnn.Execute($"INSERT INTO Products (BarCode, Name, Quantity, QuantityMinimum, Description," +
                        $" CategoryID, CategoryName, CreationDate, PriceModificationDate) VALUES " +
                        $"(@BarCode, @Name, @Quantity, @QuantityMinimum, @Description, @CategoryID, @CategoryName, " +
                        $"'{DateTimeNow}', '{DateTimeNow}')", Product));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ المنتج {Product.Name}", "خطأ",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while saving {TableName} with name = {Product.Name} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal async static Task RemoveProduct(long ProductID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"DELETE FROM {TableName} WHERE Id = {ProductID}"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء مسح المنتج", "خطأ",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while removing {TableName} with id = {ProductID} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static ProductModel GetLastAddedProduct()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    string query = $"SELECT TOP 1 * FROM {TableName} ORDER BY Id DESC";

                    var output = cnn.Query<ProductModel>(query, new DynamicParameters());

                    return output.ToList()[0];
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting last added row from {TableName} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new ProductModel();
        }
    }
}