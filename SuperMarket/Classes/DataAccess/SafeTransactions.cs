using Dapper;
using POSWarehouse.Classes.Models;
using POSWarehouse.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace POSWarehouse.Classes.DataAccess
{
    class SafeTransactions
    {
        private static readonly string TableName = "SafeTransaction";

        internal static List<SafeTransactionModel> GetSafeTransactionParameter(string Parameter, string Condition, string SortOrder)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<SafeTransactionModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} " +
                        $"WHERE {Parameter} = N'{Condition}' ORDER BY CreationDate {SortOrder}", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SafeTransactionModel>();
        }

        internal static List<SafeTransactionModel> GetSafeTransactionParameterLike(string Parameter, string Condition, string SortOrder)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<SafeTransactionModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} " +
                        $"WHERE {Parameter} Like N'%{Condition}%' ORDER BY CreationDate DESC", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting a {TableName} & parameter = {Parameter} & condition = {Condition} with error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SafeTransactionModel>();
        }

        internal static List<SafeTransactionModel> LoadSafeTransactions(bool LimitRows, string SortOrder)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<SafeTransactionModel>($"SELECT TOP {GlobalVars.MaxQueryRows} * FROM {TableName} " +
                            $"ORDER BY CreationDate DESC", new DynamicParameters());
                        return output.ToList();
                    }
                    else
                    {
                        var output = cnn.Query<SafeTransactionModel>($"SELECT * FROM {TableName} ORDER BY CreationDate DESC",
                            new DynamicParameters());
                        return output.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all {TableName} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
            return new List<SafeTransactionModel>();
        }

        internal static void UpdateSafeTransaction(SafeTransactionModel safe)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"UPDATE {TableName} SET SafeId = @SafeId, SafeName = @SafeName, AmountAdded = @AmountAdded, " +
                        $"AmountTotal = @AmountTotal, AdjustedByUserId = @AdjustedByUserId, AdjustedByUserFullName = @AdjustedByUserFullName, " +
                        $"Notes = @Notes WHERE Id = @Id", safe);
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء تعديل الخزنة {safe.SafeName}", Notification.EnmType.Error);

                Logger.Log($"while updating {TableName} with id = {safe.SafeId} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static void SaveSafeTransaction(SafeTransactionModel safe)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO {TableName} ( SafeId, SafeName, AmountAdded, AmountTotal, AdjustedByUserId, " +
                        $"AdjustedByUserFullName, Notes, CreationDate) VALUES " +
                        $"(@SafeId, @SafeName, @AmountAdded, @AmountTotal, @AdjustedByUserId, @AdjustedByUserFullName, " +
                        $"@Notes, '{DateTime.Now}')", safe);
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء حفظ الخزنة {safe.SafeName}", Notification.EnmType.Error);

                Logger.Log($"while saving product with id = {safe.SafeId} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }

        internal static void RemoveSafeTransaction(int SafeTransactionId)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"DELETE FROM {TableName} WHERE Id = {SafeTransactionId}");
                }
            }
            catch (Exception ex)
            {
                new Notification().ShowAlert($"حدث خطأ أثناء مسح الخزنة", Notification.EnmType.Error);

                Logger.Log($"while removing a {TableName} with id = {SafeTransactionId} error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, TableName, Logger.ERROR);
            }
        }
    }
}