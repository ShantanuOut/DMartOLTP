CREATE TABLE [Products].[RefundReason]
(
	[RefundReasonId]	INT IDENTITY(1,1) NOT NULL, 
    [RefundReason]		VARCHAR(100) NULL,
	CONSTRAINT PK_RefundReason_RefundReasonId PRIMARY KEY CLUSTERED ([RefundReasonId])
)
