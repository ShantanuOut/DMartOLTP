CREATE TABLE [Stores].[Phone]
(
	[PhoneId]		INT IDENTITY(1,1), 
    [EntityPhoneId] UNIQUEIDENTIFIER NOT NULL, 
    [PhoneNumber]	VARCHAR(15) NOT NULL, 
    [IsPrimary]		BIT NOT NULL,
	CONSTRAINT PK_Phone_PhoneId PRIMARY KEY CLUSTERED (PhoneId), 
    CONSTRAINT [FK_Phone_Store] FOREIGN KEY (EntityPhoneId) REFERENCES Stores.Store(EntityPhoneId),
	CONSTRAINT [FK_Phone_Employee] FOREIGN KEY (EntityPhoneId) REFERENCES Stores.[Employee](EntityPhoneId)
)
