CREATE TABLE [Customers].[PointsConsumed]
(
	[OnDate]		DATE NOT NULL DEFAULT(GETDATE()),
	[CustomerId]	INT NOT NULL,
	[Points]		INT NOT NULL,
	[BillId]		INT NOT NULL,
	CONSTRAINT FK_PointsConsumed_RegisteredCustomer FOREIGN KEY ([CustomerId]) REFERENCES [Customers].[RegisteredCustomer]([CustomerId]),
	CONSTRAINT FK_PointsConsumed_Billing FOREIGN KEY ([BillId]) REFERENCES [Sales].[Billing]([MasterBillId])
)
