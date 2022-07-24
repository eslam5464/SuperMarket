using Dapper;
using POSWarehouse.Classes.Models;
using POSWarehouse.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWarehouse.Classes.DataAccess
{
    class Safe
    {
        private static readonly string TableName = "Safe";

        internal async static Task<List<SafeModel>> GetSafeParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = await Task.Run(() => cnn.Query<SafeModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} " +
                        $"WHERE {Parameter} = N'{Condition}'", new DynamicParameters()));
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SafeModel>();
        }

        internal static List<SafeModel> GetSafeParameterLike(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<SafeModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} WHERE {Parameter} Like N'%{Condition}%'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SafeModel>();
        }

        internal static List<SafeModel> LoadSafe()
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<SafeModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName}",
                        new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SafeModel>();
        }

        internal async static Task UpdateSafe(SafeModel safe)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"UPDATE {TableName} SET Name = @Name WHERE Id = @Id", safe));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء تعديل المورد {safe.Name}", Notification.EnmType.Error);

                Logger.Log($"while updating {TableName} with id = {safe.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal async static Task SaveSafe(SafeModel safe)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"INSERT INTO {TableName} ( Name, CreationDate) VALUES " +
                        $"(@Name, '{DateTime.Now}')", safe));
                }
                new Notification().ShowAlert($"تم الحفظ", Notification.EnmType.Success);
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء حفظ المورد {safe.Name}", Notification.EnmType.Error);

                Logger.Log($"while saving product with name = {safe.Name} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Products", Logger.ERROR);
            }
        }

        internal async static Task RemoveSafe(int SafeId)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"DELETE FROM {TableName} WHERE Id = {SafeId}"));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء مسح المورد", Notification.EnmType.Error);

                Logger.Log($"while removing a {TableName} with id = {SafeId} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }
    }
}