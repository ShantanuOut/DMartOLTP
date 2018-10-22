CREATE TABLE [Products].[ProductCategory]
(
	[ProductCategId] INT NOT NULL, 
    [ProductCategory] VARCHAR(50) NOT NULL, 
    [StoreInWarehouse] BIT NOT NULL, 
    [ProductMasterCategId] INT NOT NULL, 
    [RequiresRefrigiration] BIT NOT NULL,
	CONSTRAINT PK_ProductCategory_ProductCategoryId PRIMARY KEY CLUSTERED ([ProductCategId]),
	CONSTRAINT FK_ProductCategory_ProductMasterCateg FOREIGN KEY ([ProductMasterCategId]) REFERENCES [Products].[ProductMasterCateg]([ProductMasterCategId])
)
