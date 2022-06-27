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
    class Users
    {
        private static readonly int MaxRows = 100;
        public static List<UserModel> LoadUsersWithParamNonAdmin(string Parameter, string Condition)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                string query = $"SELECT * FROM Users WHERE {Parameter} = N'{Condition}' " +
                    $"AND ActiveState = 1 AND UserLevel != 'admin' LIMIT {MaxRows}";
                var output = cnn.Query<UserModel>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        internal static List<UserModel> LoadAllUsers()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM Users LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModel> LoadAtiveUsers()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM Users WHERE ActiveState = 1 LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModel> LoadAtiveUsersAdmin()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM Users WHERE ActiveState = 1 AND " +
                    "UserLevel = 'admin' LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModel> LoadAtiveUsersNonAdmin()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM Users WHERE ActiveState = 1 AND " +
                    "UserLevel != 'admin' LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModel> LoadNonAtiveUsers()
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM Users WHERE ActiveState = 0 LIMIT {MaxRows}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel User)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Users (Username, Password, FullName, UserLevel, Email, Phone, CreationDate, ModifyDate, ActiveState) " +
                    $"VALUES (@Username, @Password, @FullName, @UserLevel, @Email, @Phone, @'{DateTime.Now}', @'{DateTime.Now}', 1)", User);
            }
        }

        public static void UpdateUser(UserModel User)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Users SET Username = @Username, Password = @Password, ModifyDate = {DateTime.Now}," +
                    $"FullName = @FullName, Phone = @Phone, UserLevel = @UserLevel WHERE Id = @Id", User);
            }
        }

        public static void StopUser(long UserID)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Users SET ActiveState = 0, ModifyDate = {DateTime.Now} WHERE Id = {UserID}");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
