using Dapper;
using SuperMarket.Forms;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Classes.DataAccess
{
    class DataRestore
    {
        private static readonly string ClassName = "DataRestore";

        public async static void All(string strDestination = "", string Id = "Default")
        {
            try
            {
                string DatabaseName = Security.GetDBName();

                using (var location = new SqlConnection(GlobalVars.LoadConnectionString(Id)))
                {
                    string query = $@"USE MASTER "
                        //+ $@"GO; "
                        + $@"ALTER DATABASE {DatabaseName} "
                        + $@" SET SINGLE_USER WITH "
                        + $@"ROLLBACK IMMEDIATE "
                        //+ $@"GO; "

                        + $@"RESTORE DATABASE {DatabaseName} "
                        + $@"FROM DISK = '{strDestination}' "
                        + $@"WITH "
                        + $@"MOVE '{DatabaseName}' TO 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\{DatabaseName}.MDF', "
                        + $@"MOVE '{DatabaseName}_LOG' TO 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\{DatabaseName}_log.LDF', REPLACE "
                        //+ $@"GO; "

                        + $@"ALTER DATABASE {DatabaseName} SET MULTI_USER ";
                    //+ $@"GO; ",";

                    await Task.Run(() => location.Execute(query, new DynamicParameters()));
                }
                await Task.Run(() => Logger.Log($"restored backup from destination {strDestination}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.INFO));

                new Notification().ShowAlert($"لقد تم استعاده البيانات من النسخه الاحتياطيه", Notification.EnmType.Success);
            }
            catch (Exception ex)
            {
                await Task.Run(() => Logger.Log($"while restoring backup from location: <{strDestination}> & error: "
                    + ex.Message, System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.ERROR));

                new Notification().ShowAlert($"لم يتم استعاده البيانات", Notification.EnmType.Error);
            }
        }
    }
}
