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

        public class ModelStrings
        {
            public class Category
            {
                public static string Id = "Id";
                public static string Name = "Name";
                public static string CreationDate = "CreationDate";
            }

            public class Customer
            {
                public static string Id = "Id";
                public static string Name = "Name";
                public static string ContactNo = "ContactNo";
                public static string Address = "Address";
                public static string CreationDate = "CreationDate";
            }

            public class Invoice
            {
                public static string Id = "Id";
                public static string InvoiceNumber = "InvoiceNumber";
                public static string CreationDate = "CreationDate";
                public static string CustomerId = "CustomerId";
                public static string CustomerName = "CustomerName";
                public static string CustomerContact = "CustomerContact";
                public static string CustomerAddress = "CustomerAddress";
                public static string ProductID = "ProductID";
                public static string ProductBarCode = "ProductBarCode";
                public static string ProductName = "ProductName";
                public static string ProductQuantity = "ProductQuantity";
                public static string ProductPrice = "ProductPrice";
                public static string PriceTotal = "PriceTotal";
            }

            public class Log
            {
                public static string Id = "Id";
                public static string Date = "Date";
                public static string MethodName = "MethodName";
                public static string ClassName = "ClassName";
                public static string LoggedUserId = "LoggedUserId";
                public static string LoggedUserName = "LoggedUserName";
                public static string LogLevel = "LogLevel";
                public static string LogMessage = "LogMessage";
            }

            public class Order
            {

            }

            public class Product
            {

            }

            public class Safe
            {

            }

            public class SafeTransaction
            {

            }

            public class Supplier
            {

            }

            public class SupplierInvoice
            {

            }

            public class SupplierInvoiceProduct
            {

            }

            public class User
            {

            }

            public class UserLevelAccess
            {

            }
        }
    }
}
