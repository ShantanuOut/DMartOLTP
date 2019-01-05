/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 05 January 2019
--Name : Shantanu Narale
--Date Modified : 
--Purpose : Marks the Entry into Employee Attendance table
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspMarkEmployeeAttendance]
	@EmployeeCode	CHAR(5)
AS
BEGIN
	DECLARE @RC	INT,
			@RS	INT = 1
	BEGIN TRAN insEmpAtt
	BEGIN TRY
		--Insert in Employee Attendance table
		INSERT INTO Stores.EmployeeAttendance(AttendanceDate, EmployeeId)
		SELECT CAST(GETDATE() AS DATE), EmployeeId
		FROM Stores.Employee
		WHERE EmployeeCode = @EmployeeCode

		SELECT @RC = @@ROWCOUNT

		COMMIT TRAN insEmpAtt
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN insEmpAtt
		RAISERROR(50001, 19, 1, 'uspMarkEmployeeAttendance', 'Unable to Mark Attendance, either already marked or due to unknown issue') WITH LOG
	END CATCH
	IF (@RC > 0)
		SET @RS = 0
	RETURN @RS
END