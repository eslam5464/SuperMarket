using System.Configuration;

namespace SuperMarket.Classes
{
    class GlobalVars
    {
        private static readonly int maxQueryRows = 500;
        private static readonly string[] userLevels = { "مدير", "مشرف", "موظف" };
        private static readonly string[] paymentMethod = { "نقدي", "آجل", "نصف آجل" };

        public static string[] PaymentMethod
        {
            get { return paymentMethod; }
        }

        public static string[] UserLevels
        {
            get { return userLevels; }
        }

        public static int MaxQueryRows
        {
            get { return maxQueryRows; }
        }

        internal static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
