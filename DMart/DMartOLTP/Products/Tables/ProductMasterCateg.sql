CREATE TABLE [Products].[ProductMasterCateg]
(
	[ProductMasterCategId]		INT IDENTITY(1,1),
    [ProductMasterCateg]		VARCHAR(50) NOT NULL, 
    [ProductPerishableCategId]	INT NOT NULL,
	CONSTRAINT PK_ProductMasterCateg_ProductMasterCategId PRIMARY KEY CLUSTERED ([ProductMasterCategId]),
	CONSTRAINT FK_ProductMasterCateg_ProductPerishableCat FOREIGN KEY ([ProductPerishableCategId]) REFERENCES [Products].[ProductPerishableCat]([PerishableCategId])
)
