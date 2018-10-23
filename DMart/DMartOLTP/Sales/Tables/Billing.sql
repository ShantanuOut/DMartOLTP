CREATE TABLE [Sales].[Billing]
(
	[MasterBillId]			INT IDENTITY(1,1), 
    [BillDate]				DATE NOT NULL DEFAULT(GETDATE()), 
    [CustomerId]			INT NULL, 
    [ActualAmount]			MONEY NOT NULL, 
    [DiscountAmount]		MONEY NULL,
	[TotalAmount]  AS ([ActualAmount] - ISNULL([DiscountAmount], 0)), 
    [BillerId]				INT NOT NULL, 
	[StoreId]				INT NOT NULL,
    [HasRefundableProd]		BIT NOT NULL DEFAULT (0), 
    [IsRefund]				BIT NOT NULL DEFAULT (0), 
    [RefundMasterBillId]	INT NULL,
	CONSTRAINT PK_Billing_MasterBillId PRIMARY KEY CLUSTERED ([MasterBillId] ASC),
	CONSTRAINT FK_Billing_Store FOREIGN KEY ([StoreId]) REFERENCES [Stores].[Store]([StoreId]),
	CONSTRAINT CK_Billing_StoreId CHECK ([StoreId] <> 1),
	CONSTRAINT FK_Billing_Billing_MasterBillId FOREIGN KEY ([RefundMasterBillId]) REFERENCES [Sales].[Billing]([MasterBillId]),
	CONSTRAINT FK_Billing_Employee FOREIGN KEY ([BillerId]) REFERENCES [Stores].[Employee]([EmployeeId]),
	CONSTRAINT FK_Billing_RegisteredCustomer FOREIGN KEY ([CustomerId]) REFERENCES [Customers].[RegisteredCustomer]([CustomerId])
)
