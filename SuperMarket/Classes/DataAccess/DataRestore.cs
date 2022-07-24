using Dapper;
using POSWarehouse.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace POSWarehouse.Classes.DataAccess
{
    class DataRestore
    {
        private static readonly string ClassName = "DataRestore";

        public async static Task All(string strSource = "", string Id = "Default")
        {
            string DatabaseName = "POSWarehouseDB";//  Security.GetDBName();//, DatabaseLogName = "";
            string query = "";

            bool Continue = false;
            try
            {
                // await Task.Run(() =>

                query = $@"
                            select count(name) from sys.master_files where name = N'Database'
                            ";

                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = await Task.Run(() => cnn.Query<int>(query, new DynamicParameters()).ToList());
                    if (output.Count > 0)
                    {
                        query = $@"
                            ALTER DATABASE {DatabaseName} MODIFY FILE (NAME=N'Database_log', NEWNAME=N'{DatabaseName}_log')
                            ALTER DATABASE {DatabaseName} MODIFY FILE (NAME=N'Database', NEWNAME=N'{DatabaseName}')
                            ";
                        using (IDbConnection cnnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                        {
                            await Task.Run(() => cnnn.Query(query, new DynamicParameters()).ToList());
                        }
                    }
                }
                await Task.Run(() => Logger.Log($"Changed logical name of DB from <Database> to <{DatabaseName}>",
                   System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.INFO));

                Continue = true;
            }
            catch (Exception ex)
            {
                await Task.Run(() => Logger.Log($"While Changing logical name of DB <Database> & error: " + ex.Message, System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.ERROR));

                Continue = false;
            }
            //---------------------------------------------------------------------------------------------------
            if (Continue)
            {
                try
                {
                    using (IDbConnection cnnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                    {
                        query = $@"
                                USE MASTER 
                                ALTER DATABASE {DatabaseName}  
                                SET SINGLE_USER WITH ROLLBACK IMMEDIATE 

                                RESTORE DATABASE {DatabaseName} 
                                FROM DISK = '{strSource}' 

                                WITH MOVE '{DatabaseName}' TO '{System.Windows.Forms.Application.StartupPath}\Data\{DatabaseName}.MDF', 
                                MOVE '{DatabaseName}_LOG' TO '{System.Windows.Forms.Application.StartupPath}\Data\{DatabaseName}_log.LDF', REPLACE 
                                ALTER DATABASE {DatabaseName} SET MULTI_USER
                                ";
                        await Task.Run(() => cnnn.Query(query, new DynamicParameters()).ToList());
                    }
                    await Task.Run(() => Logger.Log($"Restored backup from destination {strSource}", System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.INFO));

                    new Notification().ShowAlert($"لقد تم استعاده البيانات من النسخه الاحتياطيه", Notification.EnmType.Success);
                }
                catch (Exception exx)
                {
                    await Task.Run(() => Logger.Log($"while restoring backup from location: <{strSource}> & error: " + exx.Message, System.Reflection.MethodInfo.GetCurrentMethod().Name, ClassName, Logger.CRITICAL));

                    new Notification().ShowAlert($"لم يتم استعاده البيانات", Notification.EnmType.Error);
                }
            }
        }
    }
}
