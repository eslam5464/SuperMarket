
/****** Object:  Table [dbo].[Categories]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[StorageId] [int] NULL,
	[StorageName] [nvarchar](50) NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Dbo_Category_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductPrice]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductPrice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NULL,
	[ProductName] [nvarchar](50) NULL,
	[PriceWholesale] [decimal](10, 2) NOT NULL,
	[PriceSell] [decimal](10, 2) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProductPrice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Dbo_Product_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Safe]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Safe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Safe_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Dbo_Safe_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SafeTransaction]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SafeTransaction](
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Storage]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Storage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierInvoiceProduct]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierInvoiceProduct](
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierInvoices]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierInvoices](
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Contact] [nvarchar](200) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Dbo_Supplier_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLevelAccess]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLevelAccess](
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24-Jul-22 03:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Storage] FOREIGN KEY([StorageId], [StorageName])
REFERENCES [dbo].[Storage] ([Id], [Name])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Storage]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Customers]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Products] FOREIGN KEY([ProductID], [ProductName])
REFERENCES [dbo].[Products] ([Id], [Name])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([CreatedByUserId], [CreatedByUserFullName])
REFERENCES [dbo].[Users] ([Id], [FullName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[ProductPrice]  WITH CHECK ADD  CONSTRAINT [FK_ProductPrice_Products] FOREIGN KEY([ProductId], [ProductName])
REFERENCES [dbo].[Products] ([Id], [Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductPrice] CHECK CONSTRAINT [FK_ProductPrice_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID], [CategoryName])
REFERENCES [dbo].[Categories] ([Id], [Name])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[SafeTransaction]  WITH CHECK ADD  CONSTRAINT [FK_SafeTransaction_Safe] FOREIGN KEY([SafeId], [SafeName])
REFERENCES [dbo].[Safe] ([Id], [Name])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SafeTransaction] CHECK CONSTRAINT [FK_SafeTransaction_Safe]
GO
ALTER TABLE [dbo].[SafeTransaction]  WITH CHECK ADD  CONSTRAINT [FK_SafeTransaction_Users] FOREIGN KEY([AdjustedByUserId], [AdjustedByUserFullName])
REFERENCES [dbo].[Users] ([Id], [FullName])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SafeTransaction] CHECK CONSTRAINT [FK_SafeTransaction_Users]
GO
ALTER TABLE [dbo].[SupplierInvoiceProduct]  WITH CHECK ADD  CONSTRAINT [FK_SupplierInvoiceProduct_Products] FOREIGN KEY([ProductId], [ProductName])
REFERENCES [dbo].[Products] ([Id], [Name])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SupplierInvoiceProduct] CHECK CONSTRAINT [FK_SupplierInvoiceProduct_Products]
GO
ALTER TABLE [dbo].[SupplierInvoices]  WITH CHECK ADD  CONSTRAINT [FK_SupplierInvoices_SupplierInvoiceProduct] FOREIGN KEY([SupplierInvoiceProductId])
REFERENCES [dbo].[SupplierInvoiceProduct] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SupplierInvoices] CHECK CONSTRAINT [FK_SupplierInvoices_SupplierInvoiceProduct]
GO
ALTER TABLE [dbo].[SupplierInvoices]  WITH CHECK ADD  CONSTRAINT [FK_SupplierInvoices_Suppliers] FOREIGN KEY([SupplierId], [SupplierName])
REFERENCES [dbo].[Suppliers] ([Id], [Name])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SupplierInvoices] CHECK CONSTRAINT [FK_SupplierInvoices_Suppliers]
GO
ALTER TABLE [dbo].[UserLevelAccess]  WITH CHECK ADD  CONSTRAINT [FK_UserLevelAccess_Users] FOREIGN KEY([UserId], [UserFullName])
REFERENCES [dbo].[Users] ([Id], [FullName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserLevelAccess] CHECK CONSTRAINT [FK_UserLevelAccess_Users]
GO
/****** Object:  StoredProcedure [dbo].[spProducts_GetFullDetails]    Script Date: 24-Jul-22 03:23:13 PM ******/
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
FROM [dbo].[Products] AS products
 join (
	SELECT [ProductId],[PriceWholesale], [PriceSell], [CreationDate]
	FROM [dbo].[ProductPrice]
) AS productPrice
ON products .[Id] = productPrice.[ProductId]
AND products.[PriceModificationDate] = productPrice.[CreationDate]
ORDER BY [Id]

end
GO
