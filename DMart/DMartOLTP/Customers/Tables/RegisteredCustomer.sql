CREATE TABLE [Customers].[RegisteredCustomer]
(
	[CustomerId]		INT IDENTITY, 
    [CustomerPhone]		VARCHAR(15) NULL, 
    [CustomerName]		VARCHAR(50) NOT NULL, 
    [PointsAvailable]	INT NOT NULL,
	CONSTRAINT PK_RegisteredCustomer_CustomerId PRIMARY KEY CLUSTERED ([CustomerId] ASC),
	CONSTRAINT UQ_RegisteredCustomer_CustomerPhone UNIQUE ([CustomerPhone])
)
