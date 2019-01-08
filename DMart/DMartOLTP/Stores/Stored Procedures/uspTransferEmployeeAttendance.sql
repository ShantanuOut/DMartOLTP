/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 06th January 2019
--Name : Shantanu Narale
--Date Modified :
--Purpose : Transfer Employee Attendance Data to EmployeeAttendanceHistory table
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspTransferEmployeeAttendance]
	@EmployeeCode	CHAR(5)
AS
BEGIN
	DECLARE @EmployeeId	INT,
			@RC			INT,
			@RS			INT = 1

	SELECT @EmployeeId = EmployeeId
	FROM Stores.Employee
	WHERE EmployeeCode = @EmployeeCode

	IF (@EmployeeId IS NOT NULL)
	BEGIN
		SET @RS = 0

		INSERT INTO [Stores].[EmployeeAttendanceHistory](AttemdamceDate, EmployeeId)
		SELECT AttendanceDate, EmployeeId
		FROM [Stores].[EmployeeAttendance]
		WHERE EmployeeId = @EmployeeId

		SELECT @RC = @@ROWCOUNT

		IF(@RC > 0)		
			DELETE [Stores].[EmployeeAttendanceHistory] 
			WHERE EmployeeId = @EmployeeId
	END
END