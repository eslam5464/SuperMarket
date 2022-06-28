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
    class Categories
    {
        private static readonly int MaxRows = 100;
        public static List<CategoryModel> GetCategoryParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
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

        public static List<CategoryModel> LoadCategoryNames()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<CategoryModel>($"SELECT TOP {MaxRows} Name FROM Categories", new DynamicParameters());
                    return output.ToList();
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
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
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

        public static void SaveCategory(CategoryModel Category)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO Categories (Name, CreationDate) VALUES (@Name, '{DateTime.Now}')", Category);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving a Category with id = {Category.Name} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
        }

        public static void UpdateCategory(CategoryModel Category)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE Categories SET Name = @Name WHERE Id = @Id", Category);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while updating a Category with id = {Category.Id} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
        }

        internal static void RemoveCategory(long categoryID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"DELETE FROM Categories WHERE Id = {categoryID}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while removing a category with id = {categoryID} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Categories", Logger.ERROR);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
