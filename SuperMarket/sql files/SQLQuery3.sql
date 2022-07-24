USE master;  
GO  
ALTER DATABASE "C:\USERS\ESLAM\DOCUMENTS\VISUAL STUDIO 2019\PROJECTS\SUPERMARKET\SUPERMARKET\BIN\DEBUG\DATA\POSWAREHOUSEDB.MDF" SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
ALTER DATABASE "C:\USERS\ESLAM\DOCUMENTS\VISUAL STUDIO 2019\PROJECTS\SUPERMARKET\SUPERMARKET\BIN\DEBUG\DATA\POSWAREHOUSEDB.MDF" MODIFY NAME = POSWarehouseDB;
GO  
ALTER DATABASE POSWarehouseDB SET MULTI_USER;
GO



SELECT d.name DatabaseName, f.name LogicalName,
f.physical_name AS PhysicalName,
f.type_desc TypeofFile
FROM sys.master_files f
INNER JOIN sys.databases d ON d.database_id = f.database_id
GO

update  sys.master_files set name = POSWarehouseDB where name = 'C:\USERS\ESLAM\DOCUMENTS\VISUAL STUDIO 2019\PROJECTS\SUPERMARKET\SUPERMARKET\BIN\DEBUG\DATA\POSWAREHOUSEDB.MDF'

ALTER DATABASE POSWarehouseDB MODIFY FILE (NAME=N'Database_log', NEWNAME=N'POSWarehouseDB_log')
ALTER DATABASE POSWarehouseDB MODIFY FILE (NAME=N'Database', NEWNAME=N'POSWarehouseDB')
select name from sys.master_files
select  count(name) as Count_Names from sys.master_files where name = N'Database'

USE MASTER 
GO
ALTER DATABASE POSWarehouseDB
SET SINGLE_USER 
WITH 
ROLLBACK IMMEDIATE 
GO

RESTORE DATABASE POSWarehouseDB 
FROM DISK = 'C:\POS Warehouse\Backup\LocalBackup 2022-07-24.bak' 
WITH MOVE 'POSWarehouseDB' TO 'C:\Users\Eslam\Documents\Visual Studio 2019\Projects\SuperMarket\SuperMarket\bin\Debug\Data\POSWarehouseDB.MDF', 
MOVE 'POSWarehouseDB_LOG' TO 'C:\Users\Eslam\Documents\Visual Studio 2019\Projects\SuperMarket\SuperMarket\bin\Debug\Data\POSWarehouseDB_log.LDF', REPLACE 
ALTER DATABASE POSWarehouseDB SET MULTI_USER 

