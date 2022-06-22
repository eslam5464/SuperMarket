using SuperMarket.Forms;
using System;
using System.IO;

namespace SuperMarket.Classes
{
    class Logger
    {
        private static string LoggedUser = "";
        private static readonly string AppLogFileFolder = "Logs",
            AppLogFileName = "app",
            AppLogFileExtention = ".log",
            AppLogFile = $@"{AppLogFileFolder}\{AppLogFileName}{AppLogFileExtention}";

        public static string INFO = "INFO", DEBUG = "DEBUG", ERROR = "ERROR",
            WARNING = "WARNING", CRITICAL = "CRITICAL";

        public static void Log(string Message, string MethodName, string LogLevel, string Location)
        {
            if (!Directory.Exists(AppLogFileFolder))
                Directory.CreateDirectory(AppLogFileFolder);

            using (StreamWriter w = File.AppendText(AppLogFile))
            {
                LogString(Message, MethodName, LogLevel, Location, w);
            }
        }

        private static void LogString(string logMessage, string MethodName, string Location, string LogLevel, TextWriter Writer)
        {
            LoggedUser = Main.LoggedUser.Username;
            string DateTimeNow = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt");
            Writer.Write("Log Entry : ");
            Writer.WriteLine($"{DateTimeNow} - Method: {MethodName} - Location: {Location} - User: {LoggedUser} - Log level: {LogLevel}");
            Writer.WriteLine($"  #{logMessage}");
            Writer.WriteLine("--------------------------------------------------------------");
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
