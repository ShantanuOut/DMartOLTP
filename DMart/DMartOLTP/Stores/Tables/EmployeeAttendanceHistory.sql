CREATE TABLE [Stores].[EmployeeAttendanceHistory]
(
	[EmployeeAttendanceHistoryId]				INT		IDENTITY(1,1),
	[AttemdamceDate]							DATE NOT NULL,
	[EmployeeId]								INT NOT NULL,
	[LoadDate]									DATE NOT NULL DEFAULT(GETDATE()),
	CONSTRAINT PK_EmployeeAttendanceHistory_EmployeeAttendanceHistoryId PRIMARY KEY CLUSTERED ([EmployeeAttendanceHistoryId] ASC)
)
