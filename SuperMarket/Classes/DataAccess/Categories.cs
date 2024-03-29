﻿using Dapper;
using POSWarehouse.Classes.Models;
using POSWarehouse.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace POSWarehouse.Classes.DataAccess
{
    class Categories
    {
        private static readonly int MaxRows = GlobalVars.MaxQueryRows;
        public static List<CategoryModel> GetCategoryParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<CategoryModel>($"SELECT TOP {MaxRows} * FROM Categories WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a category parameter = {Parameter} condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
            return new List<CategoryModel>();
        }

        public static List<CategoryModel> LoadCategoryNames(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<CategoryModel>($"SELECT TOP {MaxRows} Name FROM Categories", new DynamicParameters());
                        return output.ToList();
                    }
                    else
                    {
                        var output = cnn.Query<CategoryModel>($"SELECT Name FROM Categories", new DynamicParameters());
                        return output.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all categories names error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
            return new List<CategoryModel>();
        }

        public static List<CategoryModel> LoadCategories()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<CategoryModel>($"SELECT TOP {MaxRows} * FROM Categories", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all categories error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
            return new List<CategoryModel>();
        }

        public async static Task SaveCategory(CategoryModel Category)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"INSERT INTO Categories (Name,StorageId, StorageName, CreationDate) " +
                        $"VALUES (@Name, @StorageId, @StorageName, '{DateTime.Now}')", Category));

                    new Notification().ShowAlert($"تم حفظ التصنيف", Notification.EnmType.Success);
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء حفظ التصنيف {Category.Name}", Notification.EnmType.Error);

                Logger.Log($"while saving a Category with id = {Category.Name} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
        }

        public async static Task UpdateCategory(CategoryModel Category)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"UPDATE Categories SET Name = @Name, StorageId = @StorageId, StorageName = @StorageName " +
                        $"WHERE Id = @Id", Category));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء تعديل التصنيف {Category.Name}", Notification.EnmType.Error);

                Logger.Log($"while updating a Category with id = {Category.Id} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
        }

        internal async static Task RemoveCategory(long categoryID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"DELETE FROM Categories WHERE Id = {categoryID}"));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء مسح التصنيف", Notification.EnmType.Error);

                Logger.Log($"while removing a category with id = {categoryID} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
        }
    }
}
