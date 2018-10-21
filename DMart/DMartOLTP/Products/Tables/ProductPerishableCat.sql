CREATE TABLE [Products].[ProductPerishableCat]
(
	[PerishableCategId]			INT,
	[PerishableCategory]		VARCHAR(20) NOT NULL,
	CONSTRAINT PK_ProductPerishableCat PRIMARY KEY CLUSTERED ([PerishableCategId]),
	CONSTRAINT UQ_ProductPerishableCat UNIQUE ([PerishableCategory])
)
