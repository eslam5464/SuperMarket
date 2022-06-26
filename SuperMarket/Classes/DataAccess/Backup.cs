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
        public static void AllWeekly(DayOfWeek Day, string strDestination = ".", string Id = "Default")
        {
            if (DateTime.Now.DayOfWeek == Day)
                All(strDestination, Id, false);
        }

        public static void AllDaily(int NumOfMaxBackup = 10, string strDestination = ".", string Id = "Default")
        {
            string Date = DateTime.Now.ToString("yyyy-MM-dd "),
                BackupLocation = Security.GetDirecotryLocation() + @"\Backup",
                FileName = $@"\{Date} LocalBackup.db";

            if (strDestination != ".")
            {
                BackupLocation = strDestination;
            }

            All(strDestination, Id, false);

            foreach (var BackupFiles in new DirectoryInfo(BackupLocation).GetFiles().OrderByDescending(x => x.LastWriteTime).Skip(NumOfMaxBackup))
                BackupFiles.Delete();
        }

        public static void All(string strDestination = ".", string Id = "Default", bool Overwrite = false)
        {
            string Date = DateTime.Now.ToString("yyyy-MM-dd "),
                BackupLocation = Security.GetDirecotryLocation() + @"\Backup",
                FileName = $@"\{Date} LocalBackup.db";

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
                using (var location = new SqlConnection(LoadConnectionString(Id)))
                //using (var destination = new SqlConnection($@"Data Source={strDestination}\{FileName}; Version=3;"))
                {
                    location.Execute($@"BACKUP DATABASE SuperMarket TO DISK = '{strDestination}\{FileName}'", new DynamicParameters());
                    /*
                     * BACKUP DATABASE testDB
                        TO DISK = 'D:\backups\testDB.bak'
                        WITH DIFFERENTIAL;
                     */
                    //location.Open();
                    //destination.Open();
                    //location.BackupDatabase(destination, "main", "main", -1, null, 0);
                }
                Logger.Log("created backup and orverwrited the file",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Backup", Logger.WARNING);
            }
            if (!Overwrite && !File.Exists(strDestination + FileName))
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
