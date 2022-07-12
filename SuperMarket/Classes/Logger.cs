using Dapper;
using SuperMarket.Classes.Models;
using SuperMarket.Forms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;

namespace SuperMarket.Classes
{
    class Logger
    {
        private static long LoggedUserId = -1;
        private static string LoggedUsername = "";
        private static readonly string AppLogFileFolder = "Logs",
            AppLogFileName = "app",
            AppLogFileExtention = ".log",
            AppLogFile = $@"{AppLogFileFolder}\{AppLogFileName}{AppLogFileExtention}";

        public static string INFO = "INFO", DEBUG = "DEBUG", ERROR = "ERROR",
            WARNING = "WARNING", CRITICAL = "CRITICAL";

        public static void Log(string Message, string MethodName, string LogLevel, string Location)
        {
            if (!Directory.Exists(AppLogFileFolder))
                Task.Run(() => Directory.CreateDirectory(AppLogFileFolder));

            using (StreamWriter w = File.AppendText(AppLogFile))
            {
                Task.Run(() => LogString(Message, MethodName, LogLevel, Location, w));
            }
        }

        private async static Task LogString(string logMessage, string MethodName, string Location, string LogLevel, TextWriter Writer)
        {
            if (Main.LoggedUser != null)
            {
                LoggedUsername = Main.LoggedUser.Username;
                LoggedUserId = Main.LoggedUser.Id;
            }

            string DateTimeNow = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt");
            //Writer.Write("Log Entry : ");
            //Writer.WriteLine($"{DateTimeNow} - Method: {MethodName} - Location: {Location} - User: {LoggedUsername} - Log level: {LogLevel}");
            //Writer.WriteLine($"  #{logMessage}");
            //Writer.WriteLine("--------------------------------------------------------------");

            LogModel logModel = new LogModel()
            {
                ClassName = Location,
                Date = DateTime.Now,
                LoggedUserId = LoggedUserId,
                LoggedUserName = LoggedUsername,
                LogLevel = LogLevel,
                LogMessage = logMessage,
                MethodName = MethodName
            };

            try
            {
                logModel.LogMessage.Replace("'", "*");
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    string query = $"INSERT INTO Log ('Date', 'MethodName', 'ClassName', 'LoggedUserId'," +
                        $" 'LoggedUserName', 'LogLevel', 'LogMessage') " +
                        $"VALUES('{logModel.Date}', '{logModel.MethodName}', '{logModel.ClassName}', {logModel.LoggedUserId}, " +
                        $"'{logModel.LoggedUserName}', '{logModel.LogLevel}', '{logModel.LogMessage}'); ";

                    var output = await Task.Run(() => cnn.Query<LogModel>(query, new DynamicParameters()));
                }
            }
            catch (Exception ex)
            {
                await Task.Run(() => Writer.Write("Log Entry : "));
                await Task.Run(() => Writer.WriteLine($"Cannot make log into database & error: {ex.Message}"));
                await Task.Run(() => Writer.WriteLine($"{DateTimeNow} - Method: {MethodName} - Location: {Location} - User: {LoggedUsername} - Log level: {LogLevel}"));
                await Task.Run(() => Writer.WriteLine($"  #{logMessage}"));
                await Task.Run(() => Writer.WriteLine("--------------------------------------------------------------"));
            }
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        private static string LoadConnectionString(string id = "DefaultLog")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
