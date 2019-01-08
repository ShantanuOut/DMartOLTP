/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 06th January 2019
--Name : Shantanu Narale
--Date Modified :
--Purpose : Remove the Employee Records
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspRemoveEmployee]
	@EmployeeCode		CHAR(5),
	@AltEmployeeCode	CHAR(5) = NULL
AS
BEGIN
	DECLARE @RC INT
	DECLARE @msg VARCHAR(100)
	DECLARE @EmployeeId		INT,
			@EntityPhoneId	UNIQUEIDENTIFIER,
			@IsManager		BIT,
			@RepChange		XML (DOCUMENT [Stores].[ChangeReportingManager]),
			@AltEmpId		INT,
			@OrgPath		hierarchyid
	DECLARE @Phone AS TABLE
	(
		PhoneId	INT
	)
	BEGIN TRAN rmvEmpl
	BEGIN TRY
		IF((SELECT Designation FROM [Stores].[Employee] WHERE EmployeeCode = @EmployeeCode) = 'Owner')
		BEGIN
			SET @msg = 'Not able to delete the owner'
			;THROW 50002, 'Owner Delete not permitted', 1
		END
		EXEC @RC = [Stores].[uspTransferEmployeeAttendance] @EmployeeCode = @EmployeeCode
		IF (@RC = 1)
		BEGIN
			SET @msg = 'Unable to locate the Employee while checking attendance'
			;THROW 50002, 'Unable to Transfer attendance', 1
		END
		SELECT 
			@EmployeeId = EmployeeId,
			@EntityPhoneId = EntityPhoneId,
			@IsManager = IsManager,
			@OrgPath   = OrgPath
		FROM [Stores].[Employee] 
		WHERE EmployeeCode = @EmployeeCode
		--If Employee is a Manager
		IF(@IsManager = 1)
		BEGIN
			SET @RC = NULL
			SELECT @AltEmpId = EmployeeId
			FROM [Stores].[Employee]
			WHERE EmployeeCode = ISNULL(@AltEmployeeCode, 'SHANN')

			SET @RepChange = (
			SELECT
				ISNULL(@AltEmpId, 1) AS '@NewManagerId',				
				(SELECT
					EmployeeId 
				FROM [Stores].[Employee] AS [Employee]
				WHERE OrgPath.IsDescendantOf(@OrgPath) = 1
				AND EmployeeId <> @EmployeeId
				FOR XML RAW(''), ELEMENTS, TYPE)
			FROM [Stores].[Employee]			
			WHERE EmployeeId = @EmployeeId
			FOR XML PATH('ToBeTransferred'), TYPE
			)

			EXEC @RC = [Stores].[uspChangeReportingManager] @inputXML = @RepChange
			IF (@RC = 1)
			BEGIN
				SET @msg = 'Unable to assign employees to non manager or employee not found'
				;THROW 50002, 'Employee Assignment failed', 1
			END			
		END

		DELETE [Stores].[EmployeePhone]
		OUTPUT deleted.PhoneId INTO @Phone(PhoneId)
		WHERE EntityPhoneId = @EntityPhoneId

		DELETE [Stores].[Phone]
		WHERE PhoneId IN (SELECT PhoneId FROM @Phone)

		DELETE [Stores].[Employee]
		WHERE EmployeeId = @EmployeeId	

		COMMIT TRAN rmvEmpl
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN rmvEmpl
		IF @msg IS  NULL
			SET @msg = 'Unknown Error Occurred, Unable to delete'
		RAISERROR(50001, 19, 1, 'uspRemoveEmployee', @msg) WITH LOG
	END CATCH
END