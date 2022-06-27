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
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>($"SELECT * FROM Categories WHERE {Parameter} = N'{Condition}' LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CategoryModel> LoadCategoryNames()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("SELECT Name FROM Categories LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CategoryModel> LoadCategories()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("SELECT * FROM Categories LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Categories (Name, CreationDate) VALUES (@Name, '{DateTime.Now}')", Category);
            }
        }

        public static void UpdateCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Categories SET Name = @Name WHERE Id = @Id", Category);
            }
        }

        internal static void RemoveCategory(long categoryID)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Categories WHERE Id = {categoryID}");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
