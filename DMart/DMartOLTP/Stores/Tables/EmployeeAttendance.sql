CREATE TABLE [Stores].[EmployeeAttendance]
(
	[AttendanceDate]	DATE DEFAULT DF_EmployeeAttendance_AttendanceDate (GETDATE()), 
    [EmployeeId]		INT NOT NULL,
	CONSTRAINT PK_EmployeeAttendance_AttDt_EmpId PRIMARY KEY CLUSTERED ([AttendanceDate], [EmployeeId]),
	CONSTRAINT FK_EmployeeAttendance_EmployeeId  FOREIGN KEY ([EmployeeId]) REFERENCES [Stores].[Employee]([EmployeeId])
)
