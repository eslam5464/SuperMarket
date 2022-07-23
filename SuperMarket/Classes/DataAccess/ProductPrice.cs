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
    class ProductPrice
    {
        private static readonly string TableName = "ProductPrice";

        internal static List<ProductPriceModel> GetProductPriceParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<ProductPriceModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} WHERE " +
                        $"{Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<ProductPriceModel>();
        }

        internal static List<ProductPriceModel> GetProductPriceParameterLike(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<ProductPriceModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} " +
                        $"WHERE {Parameter} Like N'%{Condition}%'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<ProductPriceModel>();
        }

        internal static List<ProductPriceModel> LoadProductPrices(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<ProductPriceModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName}",
                            new DynamicParameters());
                        return output.ToList();
                    }

                    else
                    {
                        var output = cnn.Query<ProductPriceModel>($"SELECT * FROM {TableName}", new DynamicParameters());
                        return output.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<ProductPriceModel>();
        }

        internal async static Task UpdateProductPrice(ProductPriceModel ProductPrice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"UPDATE {TableName} SET ProductName = @ProductName, PriceWholesale = @PriceWholesale, " +
                        $"PriceSell = @PriceSell WHERE Id = @Id", ProductPrice));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء تعديل سعر المنتج {ProductPrice.ProductName}",
                    Notification.EnmType.Error);

                Logger.Log($"while updating {TableName} with id = {ProductPrice.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal async static Task SaveProductPrice(ProductPriceModel ProductPrice)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"INSERT INTO {TableName} (ProductId, ProductName, PriceWholesale, PriceSell" +
                        $", CreationDate) VALUES " +
                        $"(@ProductId, @ProductName, @PriceWholesale, @PriceSell, @CreationDate)", ProductPrice));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء حفظ السعر على المنتج {ProductPrice.ProductName}",
                    Notification.EnmType.Error);

                Logger.Log($"while saving {TableName} with id = {ProductPrice.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
        }

        internal async static Task RemoveProductPrice(int ProductPriceId)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"DELETE FROM {TableName} WHERE Id = {ProductPriceId}"));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء مسح السعر", Notification.EnmType.Error);

                Logger.Log($"while removing a {TableName} with id = {ProductPriceId} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }
    }
}
