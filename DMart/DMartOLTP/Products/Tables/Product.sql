CREATE TABLE [Products].[Product]
(
	[ProductId]				INT IDENTITY(1,1) NOT NULL, 
    [ProductCategId]		INT NOT NULL, 
    [ManufacturerId]		INT NULL, 
    [HasExpiry]				BIT NOT NULL, 
    [IsRefundable]			BIT NOT NULL DEFAULT (0), 
    [CostPrice]				MONEY NOT NULL, 
    [SellingPrice]			MONEY NOT NULL, 
    [IsFree]				BIT NOT NULL DEFAULT (0), 
    [FreeOnProdId]			INT NULL, 
    [SKUavailable]			INT NULL,
	CONSTRAINT PK_Product_ProductId PRIMARY KEY CLUSTERED (ProductId),
	CONSTRAINT FK_Product_Product_FreeOnProdId FOREIGN KEY ([FreeOnProdId]) REFERENCES [Products].[Product]([ProductId]),
	CONSTRAINT FK_Product_ProductCategory FOREIGN KEY ([ProductCategId]) REFERENCES [Products].[ProductCategory]([ProductCategId]),
	CONSTRAINT FK_Product_Manufacturer FOREIGN KEY ([ManufacturerId]) REFERENCES [Products].[Manufacturer]([ManufacturerId])
)
