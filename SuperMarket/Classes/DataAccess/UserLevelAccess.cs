using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Classes.DataAccess
{
    class UserLevelAccess
    {
        private static readonly string TableName = "UserLevelAccess";

        internal static List<UserLevelAccessModel> GetUserLevelAccessParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<UserLevelAccessModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} " +
                        $"WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<UserLevelAccessModel>();
        }

        internal static List<UserLevelAccessModel> GetUserLevelAccessParameterLike(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<UserLevelAccessModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} " +
                        $"WHERE {Parameter} Like N'%{Condition}%'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<UserLevelAccessModel>();
        }

        internal static List<UserLevelAccessModel> LoadUserLevelAccess(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<UserLevelAccessModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName}",
                            new DynamicParameters());
                        return output.ToList();
                    }


                    else
                    {
                        var output = cnn.Query<UserLevelAccessModel>($"SELECT * FROM {TableName}", new DynamicParameters());
                        return output.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<UserLevelAccessModel>();
        }

        internal async static Task UpdateUserLevelAccess(UserLevelAccessModel user)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"UPDATE {TableName} SET UserLevel= @UserLevel, Billing = @Billing, " +
                        $"BillsEdit = @BillsEdit, Categories = @Categories, Customers = @Customers, Dashboard = @Dashboard, " +
                        $"Products = @Products, Reports = @Reports, Users = @Users, Settings = @Settings, Orders = @Orders, " +
                        $"Safe = @Safe, SupplierInvoices = @SupplierInvoices, SuppliersEdit = @SuppliersEdit WHERE UserId = @UserId", user));
                }

                MessageBox.Show("تم التعديل", "عملية ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تعديل الصلاحيات {user.Id}", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while updating {TableName} with id = {user.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static void SaveUserLevelAccess(UserLevelAccessModel user)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO {TableName} (UserId, UserFullName, UserLevel, Billing, BillsEdit, Categories, Customers, " +
                        $"Dashboard, Products, Reports, Users, Settings, Orders, Safe, SupplierInvoices, SuppliersEdit) " +
                        $"VALUES  (@UserId, @UserFullName, @UserLevel, @Billing, @BillsEdit, @Categories, @Customers, @Dashboard, " +
                        $"@Products, @Reports, @Users, @Settings, @Orders, @Safe, @SupplierInvoices, @SuppliersEdit)", user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ الصلاحيات {user.Id}", "خطأ",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while saving {TableName} with id = {user.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static void RemoveUserLevelAccess(int UserId)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"DELETE FROM {TableName} WHERE UserId = {UserId}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء مسح صلاحيات المستخدم", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Log($"while removing a {TableName} with id = {UserId} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }
    }
}
