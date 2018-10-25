CREATE TABLE [Products].[ProductSKU]
(
	[ProductSKUCode]		UNIQUEIDENTIFIER NOT NULL DEFAULT (NEWID()), 
    [ProductId]				INT NOT NULL, 
    [StoreId]				INT NOT NULL, 
    [IsRefunded]			BIT NOT NULL DEFAULT (0), 
    [RefundReasonId]		INT NULL,
	CONSTRAINT PK_ProductSKU_ProductSKUCode PRIMARY KEY CLUSTERED ([ProductSKUCode]),
	CONSTRAINT FK_ProductSKU_Store FOREIGN KEY ([StoreId]) REFERENCES [Stores].[Store]([StoreId]),
	CONSTRAINT FK_ProductSKU_Refund FOREIGN KEY ([RefundReasonId]) REFERENCES [Products].[RefundReason]([RefundReasonId]),
	CONSTRAINT FK_ProductSKU_Product FOREIGN KEY ([ProductId]) REFERENCES [Products].[Product]([ProductId])
)
