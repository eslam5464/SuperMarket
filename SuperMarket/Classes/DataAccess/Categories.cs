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
    class Categories
    {
        public static List<CategoryModel> GetCategoryParameter(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>($"SELECT * FROM 'Categories' WHERE {Parameter} = '{Condition}'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CategoryModel> LoadCategoryNames()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("SELECT Name FROM 'Categories'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CategoryModel> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>("SELECT * FROM 'Categories'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveCategory(CategoryModel Category)
        {
            string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new System.Globalization.CultureInfo("ar-AE"));
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO Categories ('Name', 'CreationDate') VALUES (@Name, '{DateTimeNow}')", Category);
            }
        }

        public static void UpdateCategory(CategoryModel Category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Categories SET Name = @Name WHERE Id = @Id", Category);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        internal static void RemoveCategory(int categoryID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Categories WHERE Id= {categoryID}");
            }
        }
    }
}
