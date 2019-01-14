/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 09 January 2019
--Name : Shantanu Narale
--Date Modified : 
--Purpose : Update the Employee details
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspUpdateEmployeeDetails]
	@EmployeeCode	AS CHAR(5),
	@EmpUpdXML		AS XML (DOCUMENT [Stores].[UpdEmployeeSchema]) = NULL,
	@PhnUpdXML		AS XML (DOCUMENT [Stores].[UpdPhoneXMLSchema]) = NULL,
	@TransferAllEmp	AS BIT = 0
AS
BEGIN
	DECLARE @RS				INT = 1,
			@RC				INT,
			@Designation	VARCHAR(10),
			@StoreId		INT,
			@EmpId			INT,
			@EntPhId		UNIQUEIDENTIFIER,
			@OrgPath		hierarchyid,
			@msg			VARCHAR(100),
			@tranEmpXML		AS XML (DOCUMENT [Stores].[ChangeReportingManager]),
			@NewManId		INT = 1

	DECLARE @EmpTable AS TABLE
	(
		EmployeeId			INT PRIMARY KEY CLUSTERED,
		FirstName			VARCHAR(50),
		LastName			VARCHAR(50),
		Address1			VARCHAR(100),
		Address2			VARCHAR(100),
		Address3			VARCHAR(100),
		StoreId				INT,
		BloodGroup			VARCHAR(3),
		Designation			VARCHAR(10)
	)

	BEGIN TRAN uspUpdEmp
		BEGIN TRY

			SELECT
				@EmpId			= EmployeeId,
				@OrgPath		= OrgPath,
				@Designation	= Designation,
				@EntPhId		= EntityPhoneId,
				@StoreId		= StoreId
			FROM [Stores].[Employee] 
			WHERE EmployeeCode = @EmployeeCode

			IF (@EmpId IS NULL)
			BEGIN
				SET @msg = 'Employee Code not found';
				THROW 50002, 'Unknown Employee', 16
			END

			IF(@EmpUpdXML IS NOT NULL)
			BEGIN
				INSERT @EmpTable
				SELECT
					@EmpId,
					T.c.value('FirstName','VARCHAR(50)'),
					T.c.value('LastName','VARCHAR(50)'),
					T.c.value('Address/AddLine1','VARCHAR(100)'),
					T.c.value('Address/AddLine2','VARCHAR(100)'),
					T.c.value('Address/AddLine3','VARCHAR(100)'),
					T.c.value('StoreId','INT'),
					T.c.value('BloodGroup','VARCHAR(3)'),
					T.c.value('Designation','VARCHAR(10)')
				FROM @EmpUpdXML.nodes('EmployeeUpdate') T(c)

				--Check if target designation is Employee
				IF((SELECT ISNULL(Designation, '') FROM @EmpTable) <> 'Manager') 
				BEGIN										
					UPDATE eph
					SET 
						FirstName		= ISNULL(et.FirstName, eph.FirstName),
						LastName		= ISNULL(et.LastName, eph.LastName),
						Address1		= ISNULL(et.Address1, eph.Address1),
						Address2		= ISNULL(et.Address2, eph.Address2),
						Address3		= ISNULL(et.Address3, eph.Address3),
						BloodGroup		= ISNULL(et.BloodGroup, eph.BloodGroup),
						Designation		= ISNULL(et.Designation, eph.Designation),
						StoreId			= ISNULL(et.StoreId, eph.StoreId),
						IsManager		= 0
					FROM [Stores].[Employee] eph
					INNER JOIN @EmpTable et
						ON eph.EmployeeId = et.EmployeeId

					--If already manager and has reporting employees transfer them
					IF((@Designation = 'Manager') AND EXISTS(SELECT * FROM [Stores].[Employee] WHERE OrgPath.IsDescendantOf(@OrgPath) = 1 AND EmployeeId <> @EmpId))
					BEGIN
						SELECT TOP 1 @NewManId = EmployeeId
						FROM [Stores].[Employee]
						WHERE StoreId = @StoreId
						AND EmployeeId <> @EmpId
						AND IsManager = 1

						SET @tranEmpXML = '<ToBeTransferred NewManagerId="' + CAST(@NewManId AS VARCHAR(5)) + '"><EmployeeId>' + 
													(SELECT 
														EmployeeId
													FROM [Stores].[Employee] 
													WHERE OrgPath.IsDescendantOf(@OrgPath) = 1 
													AND EmployeeId <> @EmpId
													FOR XML RAW(''), ELEMENTS) + '</ToBeTransferred>'

						EXEC @RC = [Stores].uspChangeReportingManager @inputXML = @tranEmpXML
						IF(@RC = 1)
						BEGIN
							SET @msg = 'Unable to transfer employees of current manager';
							THROW 50002, 'Unable to transfer the Employee', 16
						END
					END

					--Transfer existing employee to new manager
					IF((SELECT ISNULL(StoreId, @StoreId) FROM @EmpTable) <> @StoreId)
					BEGIN
						SET @NewManId = 1
						SELECT TOP 1 @NewManId = EmployeeId
						FROM [Stores].[Employee]
						WHERE StoreId = (SELECT StoreId FROM @EmpTable)
						AND IsManager = 1
						AND Designation <> 'Owner'

						SET @tranEmpXML = '<ToBeTransferred NewManagerId="' + CAST(@NewManId AS VARCHAR(5)) + '"><EmployeeId>'+CAST(@EmpId AS VARCHAR(5))
											+'</EmployeeId>'+'</ToBeTransferred>'

						EXEC @RC = [Stores].uspChangeReportingManager @inputXML = @tranEmpXML
						IF(@RC = 1)
						BEGIN
							SET @msg = 'Unable to change the Reporting';
							THROW 50002, 'Unable to transfer the Employee', 16
						END
					END					
				END
				
				--Target Designation is Manager			
				ELSE
				BEGIN
					UPDATE eph
					SET 
						FirstName		= ISNULL(et.FirstName, eph.FirstName),
						LastName		= ISNULL(et.LastName, eph.LastName),
						Address1		= ISNULL(et.Address1, eph.Address1),
						Address2		= ISNULL(et.Address2, eph.Address2),
						Address3		= ISNULL(et.Address3, eph.Address3),
						BloodGroup		= ISNULL(et.BloodGroup, eph.BloodGroup),
						Designation		= ISNULL(et.Designation, eph.Designation),
						StoreId			= ISNULL(et.StoreId, eph.StoreId),
						IsManager		= 1
					FROM [Stores].[Employee] eph
					INNER JOIN @EmpTable et
						ON eph.EmployeeId = et.EmployeeId

					--Changing Store of existing manager, transfer the employees to other manager
					IF((@Designation = 'Manager') AND ((SELECT ISNULL(StoreId, @StoreId) FROM @EmpTable) <> @StoreId))
					BEGIN
						SET @NewManId = 1
						SELECT TOP 1 @NewManId = EmployeeId
						FROM [Stores].[Employee]
						WHERE StoreId = @StoreId
						AND EmployeeId <> @EmpId
						AND IsManager = 1

						SET @tranEmpXML = '<ToBeTransferred NewManagerId="' + CAST(@NewManId AS VARCHAR(5)) + '"><EmployeeId>' + 
													(SELECT 
														EmployeeId
													FROM [Stores].[Employee] 
													WHERE OrgPath.IsDescendantOf(@OrgPath) = 1 
													AND EmployeeId <> @EmpId
													FOR XML RAW(''), ELEMENTS) + '</ToBeTransferred>'

						EXEC @RC = [Stores].uspChangeReportingManager @inputXML = @tranEmpXML
						IF(@RC = 1)
						BEGIN
							SET @msg = 'Unable to transfer employees of current manager';
							THROW 50002, 'Unable to transfer the Employee', 16
						END
					END
					
					--Transfer reporting to owner for a non manager employee
					IF(@Designation <> 'Manager')
					BEGIN
						SET @tranEmpXML = '<ToBeTransferred NewManagerId="' + CAST(1 AS VARCHAR(5)) + '"><EmployeeId>'+CAST(@EmpId AS VARCHAR(5))
											+'</EmployeeId>'+'</ToBeTransferred>'

						EXEC @RC = [Stores].uspChangeReportingManager @inputXML = @tranEmpXML
						IF(@RC = 1)
						BEGIN
							SET @msg = 'Unable to change the Reporting';
							THROW 50002, 'Unable to transfer the Employee', 16
						END
					END

					--Transfer all employees if intimated
					IF(@TransferAllEmp = 1)
					BEGIN
						SET @tranEmpXML = '<ToBeTransferred NewManagerId="' + CAST(@EmpId AS VARCHAR(5)) + '">' + 
											(SELECT 
												EmployeeId
											FROM [Stores].[Employee] 
											WHERE EmployeeId <> @EmpId
											AND StoreId = (SELECT ISNULL(StoreId, @StoreId) FROM @EmpTable)
											AND IsManager = 0
											FOR XML RAW(''), ELEMENTS) + '</ToBeTransferred>'

						EXEC @RC = [Stores].uspChangeReportingManager @inputXML = @tranEmpXML
						IF(@RC = 1)
						BEGIN
							SET @msg = 'Unable to change the Reporting';
							THROW 50002, 'Unable to transfer the Employee', 16
						END
					END
				END
			END

			--Update Phone Numbers
			IF(@PhnUpdXML IS NOT NULL)
			BEGIN
				EXEC [Stores].[uspUpdatePhoneNumber] @EntityPhoneId = @EntPhId, @Isstore = 0, @PhoneUpdXML = @PhnUpdXML
			END
			
			SET @RS = 0
			COMMIT TRAN uspUpdEmp
		END TRY
		BEGIN CATCH
		
			ROLLBACK TRAN uspUpdEmp
			IF(@msg IS NULL)
				SET @msg = 'Failure due to some unknown error'
			RAISERROR(50001, 19, 1, 'uspUpdateEmployeeDetails', @msg) WITH LOG
		
		END CATCH
	
	RETURN @RS
END