using Dapper;
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
    class Storages
    {
        private static readonly string TableName = "Storage";
        internal static List<StorageModel> LoadStorages(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<StorageModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName}",
                            new DynamicParameters());
                        return output.ToList();
                    }

                    else
                    {
                        var output = cnn.Query<StorageModel>($"SELECT * FROM {TableName}", new DynamicParameters());
                        return output.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<StorageModel>();
        }

        internal async static Task SaveStorage(StorageModel Storage)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"INSERT INTO {TableName} (Name, CreationDate) VALUES " +
                        $"(@Name, '{DateTime.Now}')", Storage));
                    new Notification().ShowAlert($"تم حفظ المخزن", Notification.EnmType.Success);
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء حفظ المخزن {Storage.Name}", Notification.EnmType.Error);

                Logger.Log($"while saving storage with name = {Storage.Name} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal async static Task RemoveStorage(int StorageId)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    await Task.Run(() => cnn.Execute($"DELETE FROM {TableName} WHERE Id = {StorageId}"));
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء مسح المخزن", Notification.EnmType.Error);

                Logger.Log($"while removing a {TableName} with id = {StorageId} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static void UpdateStorage(StorageModel Storage)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE {TableName} SET Name = @Name WHERE Id = @Id", Storage);
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء تعديل المخزن {Storage.Name}", Notification.EnmType.Error);

                Logger.Log($"while updating storage with id = {Storage.Id} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static List<StorageModel> GetStorageParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<StorageModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} " +
                        $"WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a storage & parameter = {Parameter} & condition = <{Condition}> with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<StorageModel>();
        }

        internal static List<StorageModel> GetStorageParameterLike(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<StorageModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} WHERE " +
                        $"{Parameter} Like N'%{Condition}%'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a storage & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<StorageModel>();
        }
    }
}