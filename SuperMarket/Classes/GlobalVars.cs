using System.Configuration;
using System.Drawing;

namespace POSWarehouse.Classes
{
    class GlobalVars
    {
        private static readonly int maxQueryRows = 500, notificationTimeout = 10000;
        private static readonly string[] userLevels = { "مدير", "مشرف", "موظف" };
        private static readonly string[] paymentMethod = { "نقدي", "آجل", "نصف آجل" };
        private static readonly Color[] availableColors = { Color.Red, Color.Green, Color.Blue, Color.Purple, Color.Brown };

        public static Color[] AvailableColors
        {
            get { return availableColors; }
        }

        public static string[] PaymentMethod
        {
            get { return paymentMethod; }
        }

        public static string[] UserLevels
        {
            get { return userLevels; }
        }

        public static int NotificationTimeout
        {
            get { return notificationTimeout; }
        }

        public static int MaxQueryRows
        {
            get { return maxQueryRows; }
        }

        internal static string LoadConnectionString(string id = "Default")
        {
            string txt = ConfigurationManager.ConnectionStrings[id].ConnectionString;

            //if (id == "Default")
            //{
            //    return @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            //        $@"AttachDbFilename={System.Windows.Forms.Application.StartupPath}\Data\POSWarehouseDB.mdf;" +
            //        @"Integrated Security=True;Connect Timeout=30";
            //}
            return txt;

            //return ConfigurationManager.ConnectionStrings[id].ConnectionString;
            //return @"Server=localhost;Integrated security=SSPI;database=master";
            //return @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30";
            //return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Data\Database.mdf;Integrated Security=True";
        }

        internal static string LoadAppKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
