CREATE TABLE [Sales].[BillingDetails]
(
	[BillingDetailsId]	INT NOT NULL, 
    [MasterBillId]		INT NOT NULL, 
    [ProductSKUCode]	UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT PK_BillingDetails_BillingDetailsID PRIMARY KEY CLUSTERED ([BillingDetailsId] ASC),
	CONSTRAINT FK_BillingDetails_ProductSKU FOREIGN KEY ([ProductSKUCode]) REFERENCES [Products].[ProductSKU]([ProductSKUCode]),
	CONSTRAINT FK_BillingDetails_ FOREIGN KEY ([MasterBillId]) REFERENCES [Sales].[Billing]([MasterBillId])
)
