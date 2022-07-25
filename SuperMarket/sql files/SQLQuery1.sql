-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [StorageId] int  NULL,
    [StorageName] nvarchar(50)  NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [ContactNo] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'Invoices'
CREATE TABLE [dbo].[Invoices] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [InvoiceNumber] bigint  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [CustomerID] bigint  NULL,
    [CustomerName] nvarchar(50)  NULL,
    [CustomerContact] nvarchar(50)  NULL,
    [CustomerAddress] nvarchar(100)  NULL,
    [ProductID] bigint  NULL,
    [ProductBarCode] bigint  NOT NULL,
    [ProductName] nvarchar(50)  NULL,
    [ProductQuantity] float  NOT NULL,
    [ProductPrice] decimal(10,2)  NOT NULL,
    [PriceTotal] decimal(20,2)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [InvoiceDate] datetime  NOT NULL,
    [InvoiceId] bigint  NULL,
    [CustomerId] bigint  NULL,
    [CustomerName] nvarchar(50)  NULL,
    [ContactNumber] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL,
    [GrandTotal] decimal(25,2)  NOT NULL,
    [CreatedByUserId] bigint  NULL,
    [CreatedByUserFullName] nvarchar(200)  NULL
);
GO

-- Creating table 'ProductPrices'
CREATE TABLE [dbo].[ProductPrices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProductId] bigint  NULL,
    [ProductName] nvarchar(50)  NULL,
    [PriceWholesale] decimal(10,2)  NOT NULL,
    [PriceSell] decimal(10,2)  NOT NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [BarCode] varchar(50)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Quantity] float  NOT NULL,
    [QuantityMinimum] float  NOT NULL,
    [Description] nvarchar(100)  NULL,
    [CategoryID] bigint  NULL,
    [CategoryName] nvarchar(50)  NULL,
    [CreationDate] datetime  NOT NULL,
    [PriceModificationDate] datetime  NULL
);
GO

-- Creating table 'Safes'
CREATE TABLE [dbo].[Safes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'SafeTransactions'
CREATE TABLE [dbo].[SafeTransactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SafeId] int  NULL,
    [SafeName] nvarchar(50)  NULL,
    [AmountAdded] decimal(25,2)  NOT NULL,
    [AmountTotal] decimal(25,2)  NOT NULL,
    [AdjustedByUserId] bigint  NULL,
    [AdjustedByUserFullName] nvarchar(200)  NULL,
    [Notes] nvarchar(500)  NOT NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'Storages'
CREATE TABLE [dbo].[Storages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'SupplierInvoiceProducts'
CREATE TABLE [dbo].[SupplierInvoiceProducts] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ProductId] bigint  NULL,
    [ProductName] nvarchar(50)  NULL,
    [ProductPriceWholesale] decimal(10,2)  NOT NULL,
    [ProductPriceSell] decimal(10,2)  NOT NULL,
    [Quantity] float  NOT NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'SupplierInvoices'
CREATE TABLE [dbo].[SupplierInvoices] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [SupplierId] int  NULL,
    [SupplierName] nvarchar(200)  NULL,
    [PaymentMethod] int  NOT NULL,
    [AmountPaid] decimal(25,2)  NOT NULL,
    [AmountLeft] decimal(25,2)  NOT NULL,
    [AmountTotal] decimal(25,2)  NOT NULL,
    [PaymentStatus] bit  NOT NULL,
    [SupplierInvoiceProductId] bigint  NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Contact] nvarchar(200)  NOT NULL,
    [Address] nvarchar(200)  NOT NULL,
    [CreationDate] datetime  NOT NULL
);
GO

-- Creating table 'UserLevelAccesses'
CREATE TABLE [dbo].[UserLevelAccesses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] bigint  NOT NULL,
    [UserFullName] nvarchar(200)  NOT NULL,
    [UserLevel] nvarchar(20)  NOT NULL,
    [Billing] bit  NOT NULL,
    [BillsEdit] bit  NOT NULL,
    [Categories] bit  NOT NULL,
    [Customers] bit  NOT NULL,
    [Dashboard] bit  NOT NULL,
    [Products] bit  NOT NULL,
    [Reports] bit  NOT NULL,
    [Users] bit  NOT NULL,
    [Settings] bit  NOT NULL,
    [Orders] bit  NOT NULL,
    [Safe] bit  NOT NULL,
    [SupplierInvoices] bit  NOT NULL,
    [SuppliersEdit] bit  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(200)  NOT NULL,
    [Password] nvarchar(200)  NOT NULL,
    [FullName] nvarchar(200)  NOT NULL,
    [UserLevel] nvarchar(20)  NOT NULL,
    [Email] nvarchar(200)  NULL,
    [Phone] nvarchar(200)  NULL,
    [CreationDate] datetime  NOT NULL,
    [ModifyDate] datetime  NOT NULL,
    [ActiveState] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id], [Name] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id], [Name] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [PK_Invoices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductPrices'
ALTER TABLE [dbo].[ProductPrices]
ADD CONSTRAINT [PK_ProductPrices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [Name] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id], [Name] ASC);
GO

-- Creating primary key on [Id], [Name] in table 'Safes'
ALTER TABLE [dbo].[Safes]
ADD CONSTRAINT [PK_Safes]
    PRIMARY KEY CLUSTERED ([Id], [Name] ASC);
GO

-- Creating primary key on [Id] in table 'SafeTransactions'
ALTER TABLE [dbo].[SafeTransactions]
ADD CONSTRAINT [PK_SafeTransactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [Name] in table 'Storages'
ALTER TABLE [dbo].[Storages]
ADD CONSTRAINT [PK_Storages]
    PRIMARY KEY CLUSTERED ([Id], [Name] ASC);
GO

-- Creating primary key on [Id] in table 'SupplierInvoiceProducts'
ALTER TABLE [dbo].[SupplierInvoiceProducts]
ADD CONSTRAINT [PK_SupplierInvoiceProducts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SupplierInvoices'
ALTER TABLE [dbo].[SupplierInvoices]
ADD CONSTRAINT [PK_SupplierInvoices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [Name] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([Id], [Name] ASC);
GO

-- Creating primary key on [Id] in table 'UserLevelAccesses'
ALTER TABLE [dbo].[UserLevelAccesses]
ADD CONSTRAINT [PK_UserLevelAccesses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [FullName] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id], [FullName] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StorageId], [StorageName] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_Categories_Storage]
    FOREIGN KEY ([StorageId], [StorageName])
    REFERENCES [dbo].[Storages]
        ([Id], [Name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Categories_Storage'
CREATE INDEX [IX_FK_Categories_Storage]
ON [dbo].[Categories]
    ([StorageId], [StorageName]);
GO

-- Creating foreign key on [CategoryID], [CategoryName] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_Categories]
    FOREIGN KEY ([CategoryID], [CategoryName])
    REFERENCES [dbo].[Categories]
        ([Id], [Name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_Categories'
CREATE INDEX [IX_FK_Products_Categories]
ON [dbo].[Products]
    ([CategoryID], [CategoryName]);
GO

-- Creating foreign key on [CustomerID] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [FK_Invoices_Customers]
    FOREIGN KEY ([CustomerID])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Invoices_Customers'
CREATE INDEX [IX_FK_Invoices_Customers]
ON [dbo].[Invoices]
    ([CustomerID]);
GO

-- Creating foreign key on [CustomerId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Orders_Customers]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Orders_Customers'
CREATE INDEX [IX_FK_Orders_Customers]
ON [dbo].[Orders]
    ([CustomerId]);
GO

-- Creating foreign key on [ProductID], [ProductName] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [FK_Invoices_Products]
    FOREIGN KEY ([ProductID], [ProductName])
    REFERENCES [dbo].[Products]
        ([Id], [Name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Invoices_Products'
CREATE INDEX [IX_FK_Invoices_Products]
ON [dbo].[Invoices]
    ([ProductID], [ProductName]);
GO

-- Creating foreign key on [CreatedByUserId], [CreatedByUserFullName] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_Orders_Users]
    FOREIGN KEY ([CreatedByUserId], [CreatedByUserFullName])
    REFERENCES [dbo].[Users]
        ([Id], [FullName])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Orders_Users'
CREATE INDEX [IX_FK_Orders_Users]
ON [dbo].[Orders]
    ([CreatedByUserId], [CreatedByUserFullName]);
GO

-- Creating foreign key on [ProductId], [ProductName] in table 'ProductPrices'
ALTER TABLE [dbo].[ProductPrices]
ADD CONSTRAINT [FK_ProductPrice_Products]
    FOREIGN KEY ([ProductId], [ProductName])
    REFERENCES [dbo].[Products]
        ([Id], [Name])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductPrice_Products'
CREATE INDEX [IX_FK_ProductPrice_Products]
ON [dbo].[ProductPrices]
    ([ProductId], [ProductName]);
GO

-- Creating foreign key on [ProductId], [ProductName] in table 'SupplierInvoiceProducts'
ALTER TABLE [dbo].[SupplierInvoiceProducts]
ADD CONSTRAINT [FK_SupplierInvoiceProduct_Products]
    FOREIGN KEY ([ProductId], [ProductName])
    REFERENCES [dbo].[Products]
        ([Id], [Name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierInvoiceProduct_Products'
CREATE INDEX [IX_FK_SupplierInvoiceProduct_Products]
ON [dbo].[SupplierInvoiceProducts]
    ([ProductId], [ProductName]);
GO

-- Creating foreign key on [SafeId], [SafeName] in table 'SafeTransactions'
ALTER TABLE [dbo].[SafeTransactions]
ADD CONSTRAINT [FK_SafeTransaction_Safe]
    FOREIGN KEY ([SafeId], [SafeName])
    REFERENCES [dbo].[Safes]
        ([Id], [Name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SafeTransaction_Safe'
CREATE INDEX [IX_FK_SafeTransaction_Safe]
ON [dbo].[SafeTransactions]
    ([SafeId], [SafeName]);
GO

-- Creating foreign key on [AdjustedByUserId], [AdjustedByUserFullName] in table 'SafeTransactions'
ALTER TABLE [dbo].[SafeTransactions]
ADD CONSTRAINT [FK_SafeTransaction_Users]
    FOREIGN KEY ([AdjustedByUserId], [AdjustedByUserFullName])
    REFERENCES [dbo].[Users]
        ([Id], [FullName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SafeTransaction_Users'
CREATE INDEX [IX_FK_SafeTransaction_Users]
ON [dbo].[SafeTransactions]
    ([AdjustedByUserId], [AdjustedByUserFullName]);
GO

-- Creating foreign key on [SupplierInvoiceProductId] in table 'SupplierInvoices'
ALTER TABLE [dbo].[SupplierInvoices]
ADD CONSTRAINT [FK_SupplierInvoices_SupplierInvoiceProduct]
    FOREIGN KEY ([SupplierInvoiceProductId])
    REFERENCES [dbo].[SupplierInvoiceProducts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierInvoices_SupplierInvoiceProduct'
CREATE INDEX [IX_FK_SupplierInvoices_SupplierInvoiceProduct]
ON [dbo].[SupplierInvoices]
    ([SupplierInvoiceProductId]);
GO

-- Creating foreign key on [SupplierId], [SupplierName] in table 'SupplierInvoices'
ALTER TABLE [dbo].[SupplierInvoices]
ADD CONSTRAINT [FK_SupplierInvoices_Suppliers]
    FOREIGN KEY ([SupplierId], [SupplierName])
    REFERENCES [dbo].[Suppliers]
        ([Id], [Name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierInvoices_Suppliers'
CREATE INDEX [IX_FK_SupplierInvoices_Suppliers]
ON [dbo].[SupplierInvoices]
    ([SupplierId], [SupplierName]);
GO

-- Creating foreign key on [UserId], [UserFullName] in table 'UserLevelAccesses'
ALTER TABLE [dbo].[UserLevelAccesses]
ADD CONSTRAINT [FK_UserLevelAccess_Users]
    FOREIGN KEY ([UserId], [UserFullName])
    REFERENCES [dbo].[Users]
        ([Id], [FullName])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLevelAccess_Users'
CREATE INDEX [IX_FK_UserLevelAccess_Users]
ON [dbo].[UserLevelAccesses]
    ([UserId], [UserFullName]);
GO