CREATE TABLE [Stores].[Employee]
(
	[EmployeeId]		INT IDENTITY(1,1), 
    [EmployeeCode]		CHAR(5) NOT NULL, 
    [ManagerId]			INT NOT NULL, 
    [OrgPath]			hierarchyid NOT NULL, 
    [EntityPhoneId]		UNIQUEIDENTIFIER NOT NULL, 
    [Address1]			VARCHAR(100) NULL, 
    [Address2]			VARCHAR(100) NULL, 
    [Address3]			VARCHAR(100) NULL, 
    [StoreId]			INT NOT NULL, 
    [BloodGroup]		CHAR(3) NULL, 
    [IsManager]			BIT NOT NULL DEFAULT DF_Employee_IsManager (0), 
    [Designation]		VARCHAR(10) NULL, 
    CONSTRAINT [PK_Employee_EmployeeId] PRIMARY KEY ([EmployeeId]), 
    CONSTRAINT [UQ_Employee_EmployeeCode] UNIQUE ([EmployeeCode]), 
    CONSTRAINT [FK_Employee_Employee] FOREIGN KEY ([ManagerId]) REFERENCES [Stores].[Employee]([EmployeeId]), 
    CONSTRAINT [FK_Employee_Phone] FOREIGN KEY ([EntityPhoneId]) REFERENCES [Stores].[Phone]([EntityPhoneId]), 
    CONSTRAINT [FK_Employee_Store] FOREIGN KEY ([StoreId]) REFERENCES [Stores].[Store]([StoreId]), 
    CONSTRAINT [CK_Employee_BloodGroup] CHECK ([BloodGroup] IN ('A+', 'A-', 'B+', 'B-', 'O+', 'O-', 'AB+', 'AB-')), 
    CONSTRAINT [CK_Employee_Designation] CHECK ([Designation] IN ('Owner', 'Manager', 'Senior', 'Junior'))
)
