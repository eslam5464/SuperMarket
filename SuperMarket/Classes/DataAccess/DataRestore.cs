using Dapper;
using POSWarehouse.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace POSWarehouse.Classes.DataAccess
{
    class DataRestore
    {
        private static readonly string ClassName = "DataRestore";

        public static void All(string strSource = "", string Id = "Default")
        {
            string DatabaseName = Security.GetDBName(); //Security.GetDBName();//

            //bool Continue = false;
            string query = "";
            try
            {
                using (IDbConnection cnnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    query = $@"USE MASTER "
                         //+ $@"GO; "
                         + $@"ALTER DATABASE {DatabaseName} "
                         + $@" SET SINGLE_USER WITH "
                         + $@"ROLLBACK IMMEDIATE "
                         //+ $@"GO; "

                         + $@"RESTORE DATABASE {DatabaseName} "
                         + $@"FROM DISK = '{strSource}' "
                         + $@"WITH NORECOVERY, "
                         + $@"MOVE '{DatabaseName}' TO 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\{DatabaseName}.MDF', "
                         + $@"MOVE '{DatabaseName}_LOG' TO 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\{DatabaseName}_log.LDF', REPLACE "
                         //+ $@"GO; "

                         + $@"ALTER DATABASE {DatabaseName} SET MULTI_USER ";
                    cnnn.Query(query, new DynamicParameters()).ToList();
                }
                Logger.Log($"Restored backup without recovery from destination <{strSource}>",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.INFO);

                new Notification().ShowAlert($"لقد تم استعاده البيانات من النسخه الاحتياطيه", Notification.EnmType.Success);
            }
            catch (Exception ex)
            {
                Logger.Log($"cant restore backup with recovery trying without it & error: " + ex.Message,
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.ERROR);

                try
                {
                    using (IDbConnection cnnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                    {
                        query = $@"USE MASTER "
                           //+ $@"GO; "
                           + $@"ALTER DATABASE {DatabaseName} "
                           + $@" SET SINGLE_USER WITH "
                           + $@"ROLLBACK IMMEDIATE "
                           //+ $@"GO; "

                           + $@"RESTORE DATABASE {DatabaseName} "
                           + $@"FROM DISK = '{strSource}' "
                           + $@"WITH RECOVERY, "
                           + $@"MOVE '{DatabaseName}' TO 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\{DatabaseName}.MDF', "
                           + $@"MOVE '{DatabaseName}_LOG' TO 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\{DatabaseName}_log.LDF', REPLACE "
                           //+ $@"GO; "

                           + $@"ALTER DATABASE {DatabaseName} SET MULTI_USER ";
                        cnnn.Query(query, new DynamicParameters()).ToList();
                    }
                    Logger.Log($"Restored backup without recovery from destination <{strSource}>",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.INFO);

                    new Notification().ShowAlert($"لقد تم استعاده البيانات من النسخه الاحتياطيه", Notification.EnmType.Success);
                }
                catch (Exception exx)
                {
                    Logger.Log($"while restoring backup without recovery from location: <{strSource}> & error: " + exx.Message,
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.CRITICAL);

                    new Notification().ShowAlert($"لم يتم استعاده البيانات", Notification.EnmType.Error);
                }
            }
            //}
        }
    }
}
