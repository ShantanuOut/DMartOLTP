CREATE TABLE [Customers].[PointsAdded]
(
	[OnDate]		DATE NOT NULL DEFAULT(GETDATE()),
	[CustomerId]	INT NOT NULL,
	[Points]		INT NOT NULL,
	[BillId]		INT NOT NULL,
	CONSTRAINT FK_PointsAdded_RegisteredCustomer FOREIGN KEY ([CustomerId]) REFERENCES [Customers].[RegisteredCustomer]([CustomerId]),
	CONSTRAINT FK_PointsAdded_Billing FOREIGN KEY ([BillId]) REFERENCES [Sales].[Billing]([MasterBillId])
)
