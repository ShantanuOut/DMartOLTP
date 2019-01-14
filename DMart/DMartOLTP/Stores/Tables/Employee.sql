CREATE TABLE [Stores].[Employee]
(
	[EmployeeId]		INT IDENTITY(1,1), 
    [EmployeeCode]		CHAR(5) NOT NULL,    
	[FirstName]			VARCHAR(50) NULL,
	[LastName]			VARCHAR(50) NULL,
    [OrgPath]			hierarchyid NOT NULL, 
	[OrgLev]			AS [OrgPath].GetLevel(),
    [EntityPhoneId]		UNIQUEIDENTIFIER NOT NULL DEFAULT (NEWID()), 
    [Address1]			VARCHAR(100) NULL, 
    [Address2]			VARCHAR(100) NULL, 
    [Address3]			VARCHAR(100) NULL, 
    [StoreId]			INT NOT NULL, 
    [BloodGroup]		VARCHAR(3) NULL, 
    [IsManager]			BIT NOT NULL DEFAULT (0), 
    [Designation]		VARCHAR(10) NULL, 
    CONSTRAINT [PK_Employee_EmployeeId] PRIMARY KEY ([EmployeeId]), 
    CONSTRAINT [UQ_Employee_EmployeeCode] UNIQUE ([EmployeeCode]),     
    CONSTRAINT [UQ_Employee_Phone] UNIQUE ([EntityPhoneId]), 
    CONSTRAINT [FK_Employee_Store] FOREIGN KEY ([StoreId]) REFERENCES [Stores].[Store]([StoreId]), 
    CONSTRAINT [CK_Employee_BloodGroup] CHECK ([BloodGroup] IN ('A+', 'A-', 'B+', 'B-', 'O+', 'O-', 'AB+', 'AB-')), 
    CONSTRAINT [CK_Employee_Designation] CHECK ([Designation] IN ('Owner', 'Manager', 'Senior', 'Junior'))
)

GO

CREATE INDEX [IX_Employee_OrgPath_DF] 
ON [Stores].[Employee] 
(
	[OrgPath]
)

GO

CREATE INDEX [IX_Employee_OrgLevOrgPath_BF] 
ON [Stores].[Employee] 
(
	[OrgLev],
	[OrgPath]
)
