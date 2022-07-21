using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Data;
using System.Threading.Tasks;

namespace SuperMarket.Classes.DataAccess
{
    class DataInit
    {
        public static async Task<bool> CheckDatabaseExists(string databaseName)
        {
            //string sqlCreateDBQuery;
            bool result = false;

            try
            {
                //sqlCreateDBQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{databaseName}'";

                //using (SqlConnection tmpConn = await Task.Run(() => new SqlConnection("server=(local)\\SQLEXPRESS;Trusted_Connection=yes")))
                //{
                //    using (SqlCommand sqlCmd = await Task.Run(() => new SqlCommand(sqlCreateDBQuery, tmpConn)))
                //    {
                //        await Task.Run(() => tmpConn.Open());

                //        object resultObj = await Task.Run(() => sqlCmd.ExecuteScalar());

                //        int databaseID = 0;

                //        if (resultObj != null)
                //        {
                //            int.TryParse(resultObj.ToString(), out databaseID);
                //        }

                //        tmpConn.Close();

                //        result = (databaseID > 0);

                //        Logger.Log($"Successfully found databse <{databaseName}> while checking its existance",
                //            System.Reflection.MethodInfo.GetCurrentMethod().Name, "DataInit", Logger.INFO);
                //    }
                //}



                //string conStr = "server=(local)\\SQLEXPRESS;Trusted_Connection=yes";
                //string cmdText = "SELECT * FROM master.dbo.sysdatabases WHERE name ='" + databaseName + "'";

                //using (SqlConnection con = await Task.Run(() => new SqlConnection(conStr)))
                //{
                //    await Task.Run(() => con.Open());
                //    using (SqlCommand cmd = await Task.Run(() => new SqlCommand(cmdText, con)))
                //    {
                //        using (SqlDataReader reader = await Task.Run(() => cmd.ExecuteReader()))
                //        {
                //            result = reader.HasRows;
                //        }
                //    }
                //    con.Close();
                //}
                //return result;


                //using (var connection = new SqlConnection("server=(local)\\SQLEXPRESS;Trusted_Connection=yes"))
                using (var connection = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    using (var command = new SqlCommand($"SELECT db_id('{databaseName}')", connection))
                    {
                        await Task.Run(() => connection.Open());
                        Logger.Log($"->: {(command.ExecuteScalar() != DBNull.Value)}",
                                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "DataInit", Logger.ERROR);
                        return (command.ExecuteScalar() != DBNull.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"While checking connection to the database & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "DataInit", Logger.ERROR);

                return result;
            }
        }


        public static async Task<bool> CreateDatabase(string DatabaseName)
        {
            try
            {
                //string sqlconn = "server=(local)\\SQLEXPRESS;Trusted_Connection=yes";
                string sqlconn = GlobalVars.LoadConnectionString();

                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    //string script = File.ReadAllText(@"C:\Users\Eslam\Documents\Visual Studio 2019" +
                    //    @"\Projects\SuperMarket\SuperMarket\Classes\DataAccess\FullDatabase.sql");

                    string script = @"USE [master]
									GO
									/****** Object:  Database [SuperMarket]    Script Date: 21-Jul-22 09:00:10 AM ******/
									CREATE DATABASE [SuperMarket]
									 CONTAINMENT = NONE
									 ON  PRIMARY 
									( NAME = N'SuperMarket', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SuperMarket.MDF' , SIZE = 8192KB , MAXSIZE = 52428800KB , FILEGROWTH = 65536KB )
									 LOG ON 
									( NAME = N'SuperMarket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SuperMarket_log.LDF' , SIZE = 73728KB , MAXSIZE = 10485760KB , FILEGROWTH = 65536KB )
									 WITH CATALOG_COLLATION = DATABASE_DEFAULT
									GO
									ALTER DATABASE [SuperMarket] SET COMPATIBILITY_LEVEL = 150
									GO
									IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
									begin
									EXEC [SuperMarket].[dbo].[sp_fulltext_database] @action = 'enable'
									end
									GO
									ALTER DATABASE [SuperMarket] SET ANSI_NULL_DEFAULT OFF 
									GO
									ALTER DATABASE [SuperMarket] SET ANSI_NULLS OFF 
									GO
									ALTER DATABASE [SuperMarket] SET ANSI_PADDING OFF 
									GO
									ALTER DATABASE [SuperMarket] SET ANSI_WARNINGS OFF 
									GO
									ALTER DATABASE [SuperMarket] SET ARITHABORT OFF 
									GO
									ALTER DATABASE [SuperMarket] SET AUTO_CLOSE OFF 
									GO
									ALTER DATABASE [SuperMarket] SET AUTO_SHRINK OFF 
									GO
									ALTER DATABASE [SuperMarket] SET AUTO_UPDATE_STATISTICS ON 
									GO
									ALTER DATABASE [SuperMarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
									GO
									ALTER DATABASE [SuperMarket] SET CURSOR_DEFAULT  GLOBAL 
									GO
									ALTER DATABASE [SuperMarket] SET CONCAT_NULL_YIELDS_NULL OFF 
									GO
									ALTER DATABASE [SuperMarket] SET NUMERIC_ROUNDABORT OFF 
									GO
									ALTER DATABASE [SuperMarket] SET QUOTED_IDENTIFIER OFF 
									GO
									ALTER DATABASE [SuperMarket] SET RECURSIVE_TRIGGERS OFF 
									GO
									ALTER DATABASE [SuperMarket] SET  DISABLE_BROKER 
									GO
									ALTER DATABASE [SuperMarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
									GO
									ALTER DATABASE [SuperMarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
									GO
									ALTER DATABASE [SuperMarket] SET TRUSTWORTHY OFF 
									GO
									ALTER DATABASE [SuperMarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
									GO
									ALTER DATABASE [SuperMarket] SET PARAMETERIZATION SIMPLE 
									GO
									ALTER DATABASE [SuperMarket] SET READ_COMMITTED_SNAPSHOT OFF 
									GO
									ALTER DATABASE [SuperMarket] SET HONOR_BROKER_PRIORITY OFF 
									GO
									ALTER DATABASE [SuperMarket] SET RECOVERY FULL 
									GO
									ALTER DATABASE [SuperMarket] SET  MULTI_USER 
									GO
									ALTER DATABASE [SuperMarket] SET PAGE_VERIFY CHECKSUM  
									GO
									ALTER DATABASE [SuperMarket] SET DB_CHAINING OFF 
									GO
									ALTER DATABASE [SuperMarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
									GO
									ALTER DATABASE [SuperMarket] SET TARGET_RECOVERY_TIME = 60 SECONDS 
									GO
									ALTER DATABASE [SuperMarket] SET DELAYED_DURABILITY = DISABLED 
									GO
									EXEC sys.sp_db_vardecimal_storage_format N'SuperMarket', N'ON'
									GO
									ALTER DATABASE [SuperMarket] SET QUERY_STORE = OFF
									GO
									USE [SuperMarket]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Categories]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Categories](
										[Id] [bigint] IDENTITY(1,1) NOT NULL,
										[Name] [nvarchar](50) NOT NULL,
										[StorageId] [int] NULL,
										[StorageName] [nvarchar](50) NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC,
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
									 CONSTRAINT [UQ_Dbo_Category_Name] UNIQUE NONCLUSTERED 
									(
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Customers]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Customers](
										[Id] [bigint] IDENTITY(1,1) NOT NULL,
										[Name] [nvarchar](50) NULL,
										[ContactNo] [nvarchar](50) NULL,
										[Address] [nvarchar](max) NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Invoices]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Invoices](
										[Id] [bigint] IDENTITY(1,1) NOT NULL,
										[InvoiceNumber] [bigint] NOT NULL,
										[CreationDate] [datetime] NOT NULL,
										[CustomerID] [bigint] NULL,
										[CustomerName] [nvarchar](50) NULL,
										[CustomerContact] [nvarchar](50) NULL,
										[CustomerAddress] [nvarchar](100) NULL,
										[ProductID] [bigint] NULL,
										[ProductBarCode] [bigint] NOT NULL,
										[ProductName] [nvarchar](50) NULL,
										[ProductQuantity] [float] NOT NULL,
										[ProductPrice] [decimal](10, 2) NOT NULL,
										[PriceTotal] [decimal](20, 2) NOT NULL,
									 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Orders]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Orders](
										[Id] [bigint] IDENTITY(1,1) NOT NULL,
										[InvoiceDate] [datetime] NOT NULL,
										[InvoiceId] [bigint] NULL,
										[CustomerId] [bigint] NULL,
										[CustomerName] [nvarchar](50) NULL,
										[ContactNumber] [nvarchar](50) NULL,
										[Address] [nvarchar](max) NULL,
										[GrandTotal] [decimal](25, 2) NOT NULL,
										[CreatedByUserId] [bigint] NULL,
										[CreatedByUserFullName] [nvarchar](200) NULL,
									 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[ProductPrice]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[ProductPrice](
										[Id] [int] IDENTITY(1,1) NOT NULL,
										[ProductId] [bigint] NULL,
										[ProductName] [nvarchar](50) NULL,
										[PriceWholesale] [decimal](10, 2) NOT NULL,
										[PriceSell] [decimal](10, 2) NOT NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_ProductPrice] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Products]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Products](
										[Id] [bigint] IDENTITY(1,1) NOT NULL,
										[BarCode] [varchar](50) NOT NULL,
										[Name] [nvarchar](50) NOT NULL,
										[Quantity] [float] NOT NULL,
										[QuantityMinimum] [float] NOT NULL,
										[Description] [nvarchar](100) NULL,
										[CategoryID] [bigint] NULL,
										[CategoryName] [nvarchar](50) NULL,
										[CreationDate] [datetime] NOT NULL,
										[PriceModificationDate] [datetime] NULL,
									 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC,
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
									 CONSTRAINT [UQ_Dbo_Product_Name] UNIQUE NONCLUSTERED 
									(
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Safe]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Safe](
										[Id] [int] IDENTITY(1,1) NOT NULL,
										[Name] [nvarchar](50) NOT NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_Safe_1] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC,
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
									 CONSTRAINT [UQ_Dbo_Safe_Name] UNIQUE NONCLUSTERED 
									(
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[SafeTransaction]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[SafeTransaction](
										[Id] [int] IDENTITY(1,1) NOT NULL,
										[SafeId] [int] NULL,
										[SafeName] [nvarchar](50) NULL,
										[AmountAdded] [decimal](25, 2) NOT NULL,
										[AmountTotal] [decimal](25, 2) NOT NULL,
										[AdjustedByUserId] [bigint] NULL,
										[AdjustedByUserFullName] [nvarchar](200) NULL,
										[Notes] [nvarchar](500) NOT NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_SafeTransaction] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Storage]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Storage](
										[Id] [int] IDENTITY(1,1) NOT NULL,
										[Name] [nvarchar](50) NOT NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_Storage] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC,
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[SupplierInvoiceProduct]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[SupplierInvoiceProduct](
										[Id] [bigint] IDENTITY(1,1) NOT NULL,
										[ProductId] [bigint] NULL,
										[ProductName] [nvarchar](50) NULL,
										[ProductPriceWholesale] [decimal](10, 2) NOT NULL,
										[ProductPriceSell] [decimal](10, 2) NOT NULL,
										[Quantity] [float] NOT NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_SupplierInvoiceProduct] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[SupplierInvoices]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[SupplierInvoices](
										[Id] [bigint] IDENTITY(1,1) NOT NULL,
										[SupplierId] [int] NULL,
										[SupplierName] [nvarchar](200) NULL,
										[PaymentMethod] [int] NOT NULL,
										[AmountPaid] [decimal](25, 2) NOT NULL,
										[AmountLeft] [decimal](25, 2) NOT NULL,
										[AmountTotal] [decimal](25, 2) NOT NULL,
										[PaymentStatus] [bit] NOT NULL,
										[SupplierInvoiceProductId] [bigint] NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_SupplierInvoices] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Suppliers]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Suppliers](
										[Id] [int] IDENTITY(1,1) NOT NULL,
										[Name] [nvarchar](200) NOT NULL,
										[Contact] [nvarchar](200) NOT NULL,
										[Address] [nvarchar](200) NOT NULL,
										[CreationDate] [datetime] NOT NULL,
									 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC,
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
									 CONSTRAINT [UQ_Dbo_Supplier_Name] UNIQUE NONCLUSTERED 
									(
										[Name] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[UserLevelAccess]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[UserLevelAccess](
										[Id] [int] IDENTITY(1,1) NOT NULL,
										[UserId] [bigint] NOT NULL,
										[UserFullName] [nvarchar](200) NOT NULL,
										[UserLevel] [nvarchar](20) NOT NULL,
										[Billing] [bit] NOT NULL,
										[BillsEdit] [bit] NOT NULL,
										[Categories] [bit] NOT NULL,
										[Customers] [bit] NOT NULL,
										[Dashboard] [bit] NOT NULL,
										[Products] [bit] NOT NULL,
										[Reports] [bit] NOT NULL,
										[Users] [bit] NOT NULL,
										[Settings] [bit] NOT NULL,
										[Orders] [bit] NOT NULL,
										[Safe] [bit] NOT NULL,
										[SupplierInvoices] [bit] NOT NULL,
										[SuppliersEdit] [bit] NOT NULL,
									 CONSTRAINT [PK_UserLevelAccess] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									/****** Object:  Table [SuperMarket].[dbo].[Users]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE TABLE [SuperMarket].[dbo].[Users](
										[Id] [bigint] IDENTITY(1,1) NOT NULL,
										[Username] [nvarchar](200) NOT NULL,
										[Password] [nvarchar](200) NOT NULL,
										[FullName] [nvarchar](200) NOT NULL,
										[UserLevel] [nvarchar](20) NOT NULL,
										[Email] [nvarchar](200) NULL,
										[Phone] [nvarchar](200) NULL,
										[CreationDate] [datetime] NOT NULL,
										[ModifyDate] [datetime] NOT NULL,
										[ActiveState] [bit] NOT NULL,
									 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
									(
										[Id] ASC,
										[FullName] ASC
									)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
									) ON [PRIMARY]
									GO
									ALTER TABLE [SuperMarket].[dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Storage] FOREIGN KEY([StorageId], [StorageName])
									REFERENCES [SuperMarket].[dbo].[Storage] ([Id], [Name])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Storage]
									GO
									ALTER TABLE [SuperMarket].[dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Customers] FOREIGN KEY([CustomerID])
									REFERENCES [SuperMarket].[dbo].[Customers] ([Id])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Customers]
									GO
									ALTER TABLE [SuperMarket].[dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Products] FOREIGN KEY([ProductID], [ProductName])
									REFERENCES [SuperMarket].[dbo].[Products] ([Id], [Name])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Products]
									GO
									ALTER TABLE [SuperMarket].[dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
									REFERENCES [SuperMarket].[dbo].[Customers] ([Id])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
									GO
									ALTER TABLE [SuperMarket].[dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([CreatedByUserId], [CreatedByUserFullName])
									REFERENCES [SuperMarket].[dbo].[Users] ([Id], [FullName])
									ON UPDATE CASCADE
									ON DELETE CASCADE
									GO
									ALTER TABLE [SuperMarket].[dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
									GO
									ALTER TABLE [SuperMarket].[dbo].[ProductPrice]  WITH CHECK ADD  CONSTRAINT [FK_ProductPrice_Products] FOREIGN KEY([ProductId], [ProductName])
									REFERENCES [SuperMarket].[dbo].[Products] ([Id], [Name])
									ON UPDATE CASCADE
									ON DELETE CASCADE
									GO
									ALTER TABLE [SuperMarket].[dbo].[ProductPrice] CHECK CONSTRAINT [FK_ProductPrice_Products]
									GO
									ALTER TABLE [SuperMarket].[dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID], [CategoryName])
									REFERENCES [SuperMarket].[dbo].[Categories] ([Id], [Name])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
									GO
									ALTER TABLE [SuperMarket].[dbo].[SafeTransaction]  WITH CHECK ADD  CONSTRAINT [FK_SafeTransaction_Safe] FOREIGN KEY([SafeId], [SafeName])
									REFERENCES [SuperMarket].[dbo].[Safe] ([Id], [Name])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[SafeTransaction] CHECK CONSTRAINT [FK_SafeTransaction_Safe]
									GO
									ALTER TABLE [SuperMarket].[dbo].[SafeTransaction]  WITH CHECK ADD  CONSTRAINT [FK_SafeTransaction_Users] FOREIGN KEY([AdjustedByUserId], [AdjustedByUserFullName])
									REFERENCES [SuperMarket].[dbo].[Users] ([Id], [FullName])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[SafeTransaction] CHECK CONSTRAINT [FK_SafeTransaction_Users]
									GO
									ALTER TABLE [SuperMarket].[dbo].[SupplierInvoiceProduct]  WITH CHECK ADD  CONSTRAINT [FK_SupplierInvoiceProduct_Products] FOREIGN KEY([ProductId], [ProductName])
									REFERENCES [SuperMarket].[dbo].[Products] ([Id], [Name])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[SupplierInvoiceProduct] CHECK CONSTRAINT [FK_SupplierInvoiceProduct_Products]
									GO
									ALTER TABLE [SuperMarket].[dbo].[SupplierInvoices]  WITH CHECK ADD  CONSTRAINT [FK_SupplierInvoices_SupplierInvoiceProduct] FOREIGN KEY([SupplierInvoiceProductId])
									REFERENCES [SuperMarket].[dbo].[SupplierInvoiceProduct] ([Id])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[SupplierInvoices] CHECK CONSTRAINT [FK_SupplierInvoices_SupplierInvoiceProduct]
									GO
									ALTER TABLE [SuperMarket].[dbo].[SupplierInvoices]  WITH CHECK ADD  CONSTRAINT [FK_SupplierInvoices_Suppliers] FOREIGN KEY([SupplierId], [SupplierName])
									REFERENCES [SuperMarket].[dbo].[Suppliers] ([Id], [Name])
									ON UPDATE CASCADE
									ON DELETE SET NULL
									GO
									ALTER TABLE [SuperMarket].[dbo].[SupplierInvoices] CHECK CONSTRAINT [FK_SupplierInvoices_Suppliers]
									GO
									ALTER TABLE [SuperMarket].[dbo].[UserLevelAccess]  WITH CHECK ADD  CONSTRAINT [FK_UserLevelAccess_Users] FOREIGN KEY([UserId], [UserFullName])
									REFERENCES [SuperMarket].[dbo].[Users] ([Id], [FullName])
									ON UPDATE CASCADE
									ON DELETE CASCADE
									GO
									ALTER TABLE [SuperMarket].[dbo].[UserLevelAccess] CHECK CONSTRAINT [FK_UserLevelAccess_Users]
									GO
									/****** Object:  StoredProcedure [SuperMarket].[dbo].[spProducts_GetFullDetails]    Script Date: 21-Jul-22 09:00:10 AM ******/
									SET ANSI_NULLS ON
									GO
									SET QUOTED_IDENTIFIER ON
									GO
									CREATE procedure [dbo].[spProducts_GetFullDetails]
										@rowscount int
									as
									begin
										SET ROWCOUNT @rowscount;

										SELECT [Id],[BarCode],[Name],[Quantity],[QuantityMinimum], productPrice.[PriceWholesale],productPrice.[PriceSell],
									[Description],[CategoryID],[CategoryName], products.[CreationDate], [PriceModificationDate]
									FROM [SuperMarket].[dbo].[Products] AS products
									 join (
										SELECT [ProductId],[PriceWholesale], [PriceSell], [CreationDate]
										FROM [SuperMarket].[dbo].[ProductPrice]
									) AS productPrice
									ON products .[Id] = productPrice.[ProductId]
									AND products.[PriceModificationDate] = productPrice.[CreationDate]
									ORDER BY [Id]

									end
									GO
									USE [master]
									GO
									ALTER DATABASE [SuperMarket] SET  READ_WRITE 
									GO";

                    script = script.Replace("SuperMarket", DatabaseName);

                    SqlConnection conn = new SqlConnection(sqlconn);

                    Server server = new Server(new ServerConnection(conn));

                    await Task.Run(() => server.ConnectionContext.ExecuteNonQuery(script));

                    Logger.Log($"Created teh database successfully",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "DataInit", Logger.INFO);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"While creating the database & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "DataInit", Logger.ERROR);
                return false;
            }
        }
    }
}
