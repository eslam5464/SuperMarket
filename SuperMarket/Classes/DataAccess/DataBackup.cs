using Dapper;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Classes.DataAccess
{
    class DataBackup
    {
        private static string Date = DateTime.Now.ToString("yyyy-MM-dd"),
                BackupLocation = Properties.Settings.Default.BackupLocation,
                BackupType = "Daily",
                FileName = $@"\{BackupType}LocalBackup {Date}.bak";

        public async static Task<bool> AllOnce(string strDestination, string BackupFileName, bool Overwrite, string Id = "Default")
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd ");

            bool output = await All(strDestination, Id, Overwrite, BackupFileName);

            return output;
        }

        public async static Task AllWeekly(DayOfWeek Day, string strDestination = ".", string Id = "Default")
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd");
            BackupType = "Weekly";
            FileName = $@"\{BackupType}LocalBackup {Date}.bak";

            if (BackupLocation != "")
                BackupLocation = Security.GetDirecotryLocation() + @"\Backup";

            if (DateTime.Now.DayOfWeek == Day)
                await All(strDestination, Id, false, FileName);
        }

        public async static Task AllDaily(int NumOfMaxBackup = 10, string strDestination = ".", string Id = "Default")
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd");
            BackupType = "Daily";
            FileName = $@"\{BackupType}LocalBackup {Date}.bak";

            if (strDestination != ".")
            {
                BackupLocation = strDestination;
            }

            if (BackupLocation == "")
                BackupLocation = Security.GetDirecotryLocation() + @"\Backup";

            await All(strDestination, Id, false);

            foreach (var BackupFiles in new DirectoryInfo(BackupLocation).GetFiles()
                .OrderByDescending(x => x.LastWriteTime).Skip(NumOfMaxBackup))
            {
                await Task.Run(() => BackupFiles.Delete());
                await Task.Run(() => Logger.Log($"Deleted file: '{BackupFiles.Name}' for reaching maximum backup of {NumOfMaxBackup}",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO));
            }
        }

        private async static Task<bool> All(string strDestination = ".", string Id = "Default", bool Overwrite = false,
            string BackupFileName = "")
        {
            bool output = false;
            if (!Directory.Exists(BackupLocation))
            {
                await Task.Run(() => Directory.CreateDirectory(BackupLocation));
                await Task.Run(() => Logger.Log("Created the directory for backup", System.Reflection.MethodInfo.GetCurrentMethod().Name,
                    "Backup", Logger.INFO));
            }

            if (strDestination == ".")
                strDestination = BackupLocation;

            if (BackupFileName == "")
                BackupFileName = FileName;


            if (Overwrite)
            {
                try
                {
                    using (var location = new SqlConnection(GlobalVars.LoadConnectionString(Id)))
                    {
                        await Task.Run(() => location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{BackupFileName}' 
                            WITH DIFFERENTIAL", new DynamicParameters()));
                    }
                    await Task.Run(() => Logger.Log($@"created backup and orverwrited the file at location " +
                        $@"<{strDestination}\{BackupFileName}>", System.Reflection.MethodInfo.GetCurrentMethod().Name,
                        "Backup", Logger.INFO));

                    output = true;
                }
                catch (Exception ex)
                {
                    await Task.Run(() => Logger.Log("Error when creating backup with diferential trying without it & error: "
                        + ex.Message, System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.ERROR));

                    try
                    {
                        using (var location = new SqlConnection(GlobalVars.LoadConnectionString(Id)))
                        {
                            await Task.Run(() => location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{BackupFileName}' "
                                + "WITH DIFFERENTIAL", new DynamicParameters()));
                        }
                        await Task.Run(() => Logger.Log($@"created backup and orverwrited the file at location " +
                            $@"<{strDestination}\{BackupFileName}>", System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup",
                            Logger.WARNING));

                        output = true;
                    }
                    catch (Exception ex2)
                    {
                        await Task.Run(() => Logger.Log("Error again when creating backup with and without diferential & error: "
                            + ex2.Message, System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.WARNING));

                        output = false;
                    }
                }
            }

            if (!Overwrite && !File.Exists(strDestination + BackupFileName))
            {
                try
                {
                    using (var location = new SqlConnection(GlobalVars.LoadConnectionString(Id)))
                    //using (var destination = new SqlConnection($@"Data Source={strDestination}\{BackupFileName}; Version=3;"))
                    {
                        await Task.Run(() => location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{BackupFileName}'",
                            new DynamicParameters()));
                        //location.Open();
                        //destination.Open();
                        //location.BackupDatabase(destination, "main", "main", -1, null, 0);
                    }

                    await Task.Run(() => Logger.Log($@"created backup without overwriting the file at location <{strDestination}\{BackupFileName}>",
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO));

                    output = true;
                }
                catch (Exception ex)
                {
                    await Task.Run(() => Logger.Log("Error when creating backup: " + ex.Message,
                        System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.ERROR));
                    output = false;
                }
            }
            if (!Overwrite && File.Exists(strDestination + BackupFileName))
            {
                await Task.Run(() => Logger.Log($@"backup already done at <{strDestination}\{BackupFileName}>, cant make an new backup",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO));

                output = true;
            }

            return output;
        }
    }
}
