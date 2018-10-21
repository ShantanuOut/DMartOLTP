CREATE TABLE [Stores].[Store]
(
	[StoreId]			INT IDENTITY(1,1),
	[StoreCode]			VARCHAR(10) NOT NULL,
	[StoreName]			VARCHAR(50) NOT NULL,
	[StoreAddress1]		VARCHAR(100) NOT NULL,
	[StoreAddress2]		VARCHAR(100),
	[StoreAddress3]		VARCHAR(100),
	IsWarehouse			BIT,
	EntityPhoneId		UNIQUEIDENTIFIER DEFAULT Df_Store_EntityPhoneId (NEWID()),
	CONSTRAINT PK_Store_StoreId PRIMARY KEY CLUSTERED (StoreId),
	CONSTRAINT UQ_Store_StoreCode UNIQUE (StoreCode)	
)
