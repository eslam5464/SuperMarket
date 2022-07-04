using Dapper;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace SuperMarket.Classes.DataAccess
{
    class Backup
    {
        private static string Date = DateTime.Now.ToString("yyyy-MM-dd "),
                BackupLocation = Security.GetDirecotryLocation() + @"\Backup",
                FileName = $@"\{Date} LocalBackup.bak";

        public static void AllWeekly(DayOfWeek Day, string strDestination = ".", string Id = "Default")
        {
            if (DateTime.Now.DayOfWeek == Day)
                All(strDestination, Id, false);
        }

        public static void AllDaily(int NumOfMaxBackup = 10, string strDestination = ".", string Id = "Default")
        {
            if (strDestination != ".")
            {
                BackupLocation = strDestination;
            }

            All(strDestination, Id, false);

            foreach (var BackupFiles in new DirectoryInfo(BackupLocation).GetFiles().OrderByDescending(x => x.LastWriteTime).Skip(NumOfMaxBackup))
            {
                BackupFiles.Delete();
                Logger.Log($"Deleted file: '{BackupFiles.Name}' for reaching maximum backup of {NumOfMaxBackup}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO);
            }
        }

        public static void All(string strDestination = ".", string Id = "Default", bool Overwrite = false)
        {
            if (!Directory.Exists(BackupLocation))
            {
                Directory.CreateDirectory(BackupLocation);
                Logger.Log("created the directory for backup",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO);
            }

            if (strDestination == ".")
                strDestination = BackupLocation;

            if (Overwrite)
            {

                try
                {
                    using (var location = new SqlConnection(LoadConnectionString(Id)))
                    {
                        location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{FileName}' WITH DIFFERENTIAL", new DynamicParameters());
                    }
                    Logger.Log("created backup and orverwrited the file",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO);
                }
                catch (Exception ex)
                {
                    Logger.Log("Error when creating backup with diferential trying without it & error: " + ex.Message,
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.ERROR);

                    try
                    {
                        using (var location = new SqlConnection(LoadConnectionString(Id)))
                        {
                            location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{FileName}' WITH DIFFERENTIAL", new DynamicParameters());
                        }
                        Logger.Log("created backup and orverwrited the file",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.WARNING);
                    }
                    catch (Exception ex2)
                    {
                        Logger.Log("Error again when creating backup with and without diferential & error: " + ex2.Message,
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.WARNING);
                    }
                }
            }
            if (!Overwrite && !File.Exists(strDestination + FileName))
            {
                try
                {
                    using (var location = new SqlConnection(LoadConnectionString(Id)))
                    //using (var destination = new SqlConnection($@"Data Source={strDestination}\{FileName}; Version=3;"))
                    {
                        location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{FileName}'", new DynamicParameters());
                        //location.Open();
                        //destination.Open();
                        //location.BackupDatabase(destination, "main", "main", -1, null, 0);
                    }

                    Logger.Log("created backup without overwriting the file",
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO);
                }
                catch (Exception ex)
                {
                    Logger.Log("Error when creating backup: " + ex.Message,
                                System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.ERROR);
                }
            }
            else
            {
                Logger.Log("backup already done, cant make an new backup",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.INFO);
            }
        }
        private static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
