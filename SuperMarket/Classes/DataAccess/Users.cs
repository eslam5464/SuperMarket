using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;

namespace SuperMarket.Classes.DataAccess
{
    class Users
    {
        public static List<UserModel> LoadUsersWithParamNonAdmin(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {//{Parameter} LIKE '%{Condition}%' OR
                string query = $"SELECT * FROM 'Users' WHERE {Parameter} = '{Condition}' " +
                    $"AND ActiveState = 1 AND UserLevel != 'admin'";
                var output = cnn.Query<UserModel>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        internal static List<UserModel> LoadAllUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM 'Users'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModel> LoadAtiveUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM 'Users' WHERE ActiveState = 1", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModel> LoadAtiveUsersAdmin()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM Users WHERE ActiveState = 1 AND " +
                    "UserLevel == 'admin'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModel> LoadAtiveUsersNonAdmin()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM Users WHERE ActiveState = 1 AND " +
                    "UserLevel != 'admin'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModel> LoadNonAtiveUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM 'Users' WHERE ActiveState = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel User)
        {
            string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new CultureInfo("ar-AE"));
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Users ('Username', 'Password', 'FullName', 'UserLevel', 'Email', 'Phone', 'CreationDate', 'ModifyDate', 'ActiveState') " +
                    $"VALUES (@Username, @Password, @FullName, @UserLevel, @Email, @Phone, '{DateTimeNow}', '{DateTimeNow}', 1)", User);
            }
        }

        public static void UpdateUser(UserModel User)
        {
            string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new CultureInfo("ar-AE"));
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Users SET Username = @Username, Password = @Password, ModifyDate = '{DateTimeNow}'," +
                    $"FullName = @FullName, 'Phone' = @Phone, 'UserLevel' = @UserLevel WHERE Id = @Id", User);
            }
        }

        public static void StopUser(int UserID)
        {
            string DateTimeNow = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy", new CultureInfo("ar-AE"));
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Users SET ActiveState = 0, ModifyDate = '{DateTimeNow}' WHERE Id = '{UserID}'");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
