using Dapper;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Classes.DataAccess
{
    class Backup
    {
        private static string Date = DateTime.Now.ToString("yyyy-MM-dd"),
                BackupLocation = Security.GetDirecotryLocation() + @"\Backup",
                BackupType = "Daily",
                FileName = $@"\{BackupType}LocalBackup {Date}.bak";

        public async static Task AllWeekly(DayOfWeek Day, string strDestination = ".", string Id = "Default")
        {
            if (DateTime.Now.DayOfWeek == Day)
                await All(strDestination, Id, false);
        }

        public async static Task AllDaily(int NumOfMaxBackup = 10, string strDestination = ".", string Id = "Default")
        {
            if (strDestination != ".")
            {
                BackupLocation = strDestination;
            }

            await All(strDestination, Id, false);

            foreach (var BackupFiles in new DirectoryInfo(BackupLocation).GetFiles()
                .OrderByDescending(x => x.LastWriteTime).Skip(NumOfMaxBackup))
            {
                await Task.Run(() => BackupFiles.Delete());
                await Task.Run(() => Logger.Log($"Deleted file: '{BackupFiles.Name}' for reaching maximum backup of {NumOfMaxBackup}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO));
            }
        }

        public async static Task All(string strDestination = ".", string Id = "Default", bool Overwrite = false)
        {
            if (!Directory.Exists(BackupLocation))
            {
                await Task.Run(() => Directory.CreateDirectory(BackupLocation));
                await Task.Run(() => Logger.Log("Created the directory for backup", System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    "Backup", Logger.INFO));
            }

            if (strDestination == ".")
                strDestination = BackupLocation;

            if (Overwrite)
            {
                try
                {
                    using (var location = new SqlConnection(GlobalVars.LoadConnectionString(Id)))
                    {
                        await Task.Run(() => location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{FileName}' 
                            WITH DIFFERENTIAL", new DynamicParameters()));
                    }
                    await Task.Run(() => Logger.Log("created backup and orverwrited the file",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO));
                }
                catch (Exception ex)
                {
                    await Task.Run(() => Logger.Log("Error when creating backup with diferential trying without it & error: "
                        + ex.Message, System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.ERROR));

                    try
                    {
                        using (var location = new SqlConnection(GlobalVars.LoadConnectionString(Id)))
                        {
                            await Task.Run(() => location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{FileName}' "
                                + "WITH DIFFERENTIAL", new DynamicParameters()));
                        }
                        await Task.Run(() => Logger.Log("created backup and orverwrited the file", System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.WARNING));
                    }
                    catch (Exception ex2)
                    {
                        await Task.Run(() => Logger.Log("Error again when creating backup with and without diferential & error: "
                            + ex2.Message, System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.WARNING));
                    }
                }
            }

            if (!Overwrite && !File.Exists(strDestination + FileName))
            {
                try
                {
                    using (var location = new SqlConnection(GlobalVars.LoadConnectionString(Id)))
                    //using (var destination = new SqlConnection($@"Data Source={strDestination}\{FileName}; Version=3;"))
                    {
                        await Task.Run(() => location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{FileName}'",
                            new DynamicParameters()));
                        //location.Open();
                        //destination.Open();
                        //location.BackupDatabase(destination, "main", "main", -1, null, 0);
                    }

                    await Task.Run(() => Logger.Log("created backup without overwriting the file",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO));
                }
                catch (Exception ex)
                {
                    await Task.Run(() => Logger.Log("Error when creating backup: " + ex.Message,
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.ERROR));
                }
            }
            else
            {
                await Task.Run(() => Logger.Log("backup already done, cant make an new backup",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO));
            }
        }
    }
}
