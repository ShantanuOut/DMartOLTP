CREATE TABLE [Products].[ProductPerishableCat]
(
	[PerishableCategId]			INT IDENTITY(1,1),
	[PerishableCategory]		VARCHAR(20) NOT NULL,
	CONSTRAINT PK_ProductPerishableCat PRIMARY KEY CLUSTERED ([PerishableCategId]),
	CONSTRAINT UQ_ProductPerishableCat UNIQUE ([PerishableCategory])
)
