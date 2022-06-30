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
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    string query = $"SELECT TOP {MaxRows} * FROM Users WHERE {Parameter} = N'{Condition}' " +
                        $"AND ActiveState = 1 AND UserLevel != 'admin'";
                    var output = cnn.Query<UserModel>(query, new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading users with param = {Parameter} & condition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
            return new List<UserModel>();
        }

        internal static List<UserModel> LoadAllUsers(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<UserModel>($"SELECT TOP {MaxRows} * FROM Users", new DynamicParameters());
                        return output.ToList();
                    }
                    else
                    {
                        var output = cnn.Query<UserModel>($"SELECT * FROM Users", new DynamicParameters());
                        return output.ToList();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading all users & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
            return new List<UserModel>();
        }

        public static List<UserModel> LoadAtiveUsers()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT TOP {MaxRows} * FROM Users WHERE ActiveState = 1", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading all active users & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
            return new List<UserModel>();
        }

        public static List<UserModel> LoadAtiveUsersAdmin()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT TOP {MaxRows} * FROM Users WHERE ActiveState = 1 AND " +
                        "UserLevel = 'admin'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading all active users that are ADMIN & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
            return new List<UserModel>();
        }

        public static List<UserModel> LoadAtiveUsersNonAdmin()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT TOP {MaxRows} * FROM Users WHERE ActiveState = 1 AND " +
                        "UserLevel != 'admin'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading all active users that are NOT ADMIN & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
            return new List<UserModel>();
        }

        public static List<UserModel> LoadNonAtiveUsers()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT TOP {MaxRows} * FROM Users WHERE ActiveState = 0", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while loading all notn-active users & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
            return new List<UserModel>();
        }

        public static void SaveUser(UserModel User)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO Users (Username, Password, FullName, UserLevel, Email, Phone, CreationDate, ModifyDate, ActiveState) " +
                        $"VALUES (@Username, @Password, @FullName, @UserLevel, @Email, @Phone, @'{DateTime.Now}', @'{DateTime.Now}', 1)", User);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while saving a user with username = {User.Username} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
        }

        public static void UpdateUser(UserModel User)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE Users SET Username = @Username, Password = @Password, ModifyDate = {DateTime.Now}," +
                        $"FullName = @FullName, Phone = @Phone, UserLevel = @UserLevel WHERE Id = @Id", User);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while updating user with id = {User.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
        }

        public static void StopUser(long UserID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE Users SET ActiveState = 0, ModifyDate = {DateTime.Now} WHERE Id = {UserID}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while stopping user with id = {UserID} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
