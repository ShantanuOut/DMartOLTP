CREATE TABLE [Stores].[Phone]
(
	[PhoneId]		INT IDENTITY(1,1),     
    [PhoneNumber]	VARCHAR(15) NOT NULL, 
    [IsPrimary]		BIT NOT NULL,
	CONSTRAINT PK_Phone_PhoneId PRIMARY KEY CLUSTERED (PhoneId)
)
