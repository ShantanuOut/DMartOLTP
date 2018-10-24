CREATE TABLE [Stores].[StorePhone]
(
	[PhoneId]		INT NOT NULL, 
    [EntityPhoneId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT FK_StorePhone_Store FOREIGN KEY ([EntityPhoneId]) REFERENCES [Stores].[Store]([EntityPhoneId]),
	CONSTRAINT FK_StorePhone_Phone FOREIGN KEY ([PhoneId]) REFERENCES [Stores].[Phone]([PhoneId])
)