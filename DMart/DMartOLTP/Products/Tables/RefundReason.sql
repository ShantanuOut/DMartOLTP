CREATE TABLE [Products].[RefundReason]
(
	[RefundReasonId] INT NOT NULL, 
    [RefundReason] VARCHAR(100) NULL,
	CONSTRAINT PK_RefundReason_RefundReasonId PRIMARY KEY CLUSTERED ([RefundReasonId])
)
