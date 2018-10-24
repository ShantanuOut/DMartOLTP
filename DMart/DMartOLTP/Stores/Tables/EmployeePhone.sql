CREATE TABLE [Stores].[EmployeePhone]
(
	[PhoneId]		INT NOT NULL, 
    [EntityPhoneId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT FK_EmployeePhone_Employee FOREIGN KEY ([EntityPhoneId]) REFERENCES [Stores].[Employee]([EntityPhoneId]),
	CONSTRAINT FK_EmployeePhone_Phone FOREIGN KEY ([PhoneId]) REFERENCES [Stores].[Phone]([PhoneId])
)