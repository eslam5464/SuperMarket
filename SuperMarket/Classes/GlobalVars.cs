namespace SuperMarket.Classes
{
    class GlobalVars
    {
        private static readonly int maxQueryRows = 500;
        private static readonly string[] userLevels = { "مدير", "مشرف", "موظف" };

        public static string[] UserLevels
        {
            get { return userLevels; }
        }

        public static int MaxQueryRows
        {
            get { return maxQueryRows; }
        }
    }
}
