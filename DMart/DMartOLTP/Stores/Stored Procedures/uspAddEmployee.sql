﻿/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 01 December 2018
--Name : Shantanu Narale
--Date Modified : 09 January 2019
--Purpose : Add Employee to the Employee table

--Change Log
--09 Jan 2019		Shantanu Narale		Added Transfer Employee flag which when set can assign employees 
--									to newly allocated managers
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspAddEmployee]
	@Employee XML (DOCUMENT Stores.EmployeeXMLSchema),
	@TransferEmp BIT = 0
AS
BEGIN
	DECLARE @ManagerId		INT,
			@ManagerOrgPath	hierarchyid,
			@currentChild	hierarchyid,
			@newChild		hierarchyid,
			@idoc			INT,
			@EntityPhoneId	UNIQUEIDENTIFIER,
			@PhoneXML		XML(DOCUMENT Stores.PhoneXMLSchema),
			@inp			VARCHAR(MAX),
			@inpXML			XML(DOCUMENT [Stores].[ChangeReportingManager]),
			@RC				INT = NULL

	DECLARE @insertedData AS TABLE
	(		
		FirstName		VARCHAR(50),
		LastName		VARCHAR(50),
		StoreId			INT,
		IsManager		BIT,
		EmployeeId		INT
	)
	
	BEGIN TRAN insEmployee
		BEGIN TRY
			--Loads the XML document in memory and creates a DOM
			SET @inp = CAST(@Employee AS VARCHAR(MAX))
			EXEC sp_xml_preparedocument @idoc OUTPUT, @inp

			SELECT @ManagerId = ManagerId
			FROM OPENXML(@idoc, 'Employee')
			WITH (ManagerId		INT './ReportingManager')

			SELECT @ManagerOrgPath = OrgPath
			FROM Stores.Employee
			WHERE EmployeeId = @ManagerId
			AND IsManager = 1

			IF(@ManagerOrgPath IS NULL)
				THROW 500002, 'Invalid Manager', 16;
	
			SELECT @currentChild = NULLIF(MAX(OrgPath), @ManagerOrgPath)
			FROM Stores.Employee
			WHERE OrgPath.IsDescendantOf(@ManagerOrgPath) = 1

			SET @newChild = @ManagerOrgPath.GetDescendant(@currentChild, NULL)

			SET @EntityPhoneId = NEWID()
	
			INSERT INTO Stores.Employee(EmployeeCode, FirstName, LastName, OrgPath, EntityPhoneId, Address1, Address2, Address3, StoreId, BloodGroup, IsManager, Designation)	
			OUTPUT inserted.FirstName, inserted.LastName, inserted.StoreId, inserted.IsManager, inserted.EmployeeId INTO @insertedData
			SELECT
				Stores.fnGenerateEmployeeCode(ISNULL(FirstName, ''), ISNULL(LastName, '')),
				FirstName,
				LastName,
				@newChild AS OrgPath,
				@EntityPhoneId,
				Address1,
				Address2,
				Address3,
				StoreId,
				BloodGroup,
				IsManager,
				Designation
			FROM OPENXML(@idoc, 'Employee')
			WITH (
					FirstName			VARCHAR(50)		'./FirstName',
					LastName			VARCHAR(50)		'./LastName',
					Address1			VARCHAR(100)	'./Address/AddressLine1',
					Address2			VARCHAR(100)	'./Address/AddressLine2',
					Address3			VARCHAR(100)	'./Address/AddressLine3',
					StoreId				INT				'@StoreId',
					BloodGroup			VARCHAR(3)		'@BloodGroup',
					IsManager			BIT				'@IsManager',
					Designation			VARCHAR(10)		'@Designation'
				)

			--Remove the XML from Memory
			EXEC sp_xml_removedocument @idoc

			IF EXISTS (SELECT TOP 1 1 FROM @insertedData WHERE ISNULL(FirstName, '') = '' OR ISNULL(LastName, '') = '')
				THROW 500002, 'Invalid First or Last Name', 16;

			SELECT @PhoneXML = T.c.query('.')
			FROM @Employee.nodes('Employee/PhoneNumbers') T(c)

			EXEC Stores.uspAddPhoneNumbers	@Phone = @PhoneXML, 
											@EntityPhoneId = @EntityPhoneId,
											@IsStore = 0

			IF(EXISTS (SELECT TOP 1 1 FROM @insertedData WHERE IsManager = 1) AND @TransferEmp = 1)
			BEGIN			
				BEGIN TRY
					SET @inpXML = (	SELECT
										ins.EmployeeId AS '@NewManagerId',				
										(SELECT
											[EmployeeId]
										FROM [Stores].[Employee] AS [Employee]
										WHERE [Employee].[StoreId] = ins.[StoreId]
										AND [Employee].IsManager = 0
										FOR XML RAW(''), ELEMENTS, TYPE)
									FROM @insertedData	ins
									FOR XML PATH('ToBeTransferred'), TYPE)

					EXEC @RC = [Stores].[uspChangeReportingManager] @inputXML = @inpXML

					IF (@RC = 1)
					BEGIN						
						;THROW 50002, 'Employee Assignment failed', 1
					END			
				END TRY
				BEGIN CATCH					
					IF (@RC = 1)
					BEGIN
						;THROW
					END
				END CATCH
			END
			
			COMMIT TRAN insEmployee
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN insEmployee
			RAISERROR(50001, 19, 1, 'Stores.uspAddEmployee', '') WITH LOG
		END CATCH
END