using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SuperMarket.Classes.DataAccess
{
    class Users
    {
        public static List<UserModel> LoadUsersWithParameter(string Parameter, string Condition, string GetType)
        {
            try
            {
                if (GetType == "Admin")
                {
                    using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                    {
                        string query = $"SELECT * FROM Users WHERE {Parameter} = N'{Condition}' " +
                            $"AND ActiveState = 1 AND UserLevel = 'admin'";
                        var output = cnn.Query<UserModel>(query, new DynamicParameters());
                        return output.ToList();
                    }
                }
                else if (GetType == "NonAdmin")
                {
                    using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                    {
                        string query = $"SELECT * FROM Users WHERE {Parameter} = N'{Condition}' " +
                            $"AND ActiveState = 1 AND UserLevel != 'admin'";
                        var output = cnn.Query<UserModel>(query, new DynamicParameters());
                        return output.ToList();
                    }
                }
                else if (GetType == "All")
                {
                    using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                    {
                        string query = $"SELECT * FROM Users WHERE {Parameter} = N'{Condition}' " +
                            $"AND ActiveState = 1";
                        var output = cnn.Query<UserModel>(query, new DynamicParameters());
                        return output.ToList();
                    }
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<UserModel>($"SELECT * FROM Users", new DynamicParameters());
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT * FROM Users WHERE ActiveState = 1", new DynamicParameters());
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT * FROM Users WHERE ActiveState = 1 AND " +
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT * FROM Users WHERE ActiveState = 1 AND " +
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT * FROM Users WHERE ActiveState = 0", new DynamicParameters());
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
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO Users (Username, Password, FullName, UserLevel, Email, Phone, CreationDate, ModifyDate, ActiveState) " +
                        $"VALUES (@Username, @Password, @FullName, @UserLevel, @Email, @Phone, '{DateTime.Now}', '{DateTime.Now}', 1)", User);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ المستخدم {User.FullName}", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while saving a user with username = {User.Username} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
        }

        public static void UpdateUser(UserModel User)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE Users SET Username = @Username, Password = @Password, ModifyDate = {DateTime.Now}," +
                        $"FullName = @FullName, Phone = @Phone, UserLevel = @UserLevel WHERE Id = @Id; " +
                        $"UPDATE UserLevelAccess SET UserFullName = @FullName WHERE UserId = @Id", User);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تعديل المستخدم {User.FullName}", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while updating user with id = {User.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
        }

        public static void StopUser(long UserID)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE Users SET ActiveState = 0, ModifyDate = {DateTime.Now} WHERE Id = {UserID}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء مسح المسخدم", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while stopping user with id = {UserID} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Users", Logger.ERROR);
            }
        }

        public static List<UserModel> LoadLastAddedUser()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<UserModel>($"SELECT TOP 1 * FROM Users WHERE ActiveState = 1 ORDER BY Id DESC",
                        new DynamicParameters());
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
    }
}
