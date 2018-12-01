/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 01 December 2018
--Name : Shantanu Narale
--Date Modified :
--Purpose : Add Employee to the Employee table
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspAddEmployee]
	@Employee XML (Stores.EmployeeXMLSchema)
AS
BEGIN
	DECLARE @ManagerId		INT,
			@ManagerOrgPath	hierarchyid,
			@currentChild	hierarchyid,
			@newChild		hierarchyid,
			@idoc			INT,
			@EntityPhoneId	UNIQUEIDENTIFIER,
			@PhoneXML		XML(Stores.PhoneXMLSchema)
	
	BEGIN TRAN insEmployee
		BEGIN TRY
			--Loads the XML document in memory and creates a DOM
			EXEC sp_xml_preparedocument @idoc OUTPUT, @Employee

			SELECT @ManagerId = ManagerId
			FROM OPENXML(@idoc, 'Employee')
			WITH (ManagerId		INT './ReportingManager')

			SELECT @ManagerOrgPath = OrgPath
			FROM Stores.Employee
			WHERE EmployeeId = @ManagerId
	
			SELECT @currentChild = NULLIF(MAX(OrgPath), @ManagerOrgPath)
			FROM Stores.Employee
			WHERE OrgPath.IsDescendantOf(@ManagerOrgPath) = 1

			SET @newChild = @currentChild.GetDescendant(@currentChild, NULL)

			SET @EntityPhoneId = NEWID()
	
			INSERT INTO Stores.Employee(EmployeeCode, FirstName, LastName, OrgPath, EntityPhoneId, Address1, Address2, Address3, StoreId, BloodGroup, IsManager, Designation)	
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
					BloodGroup			CHAR(3)			'@BloodGroup',
					IsManager			BIT				'@IsManager',
					Designation			VARCHAR(10)		'@Designation'
				)

			--Remove the XML from Memory
			EXEC sp_xml_removedocument @idoc

			SELECT @PhoneXML = T.c.query('.')
			FROM @Employee.nodes('Employee/PhoneNumbers') T(c)

			EXEC Stores.uspAddPhoneNumbers	@Phone = @PhoneXML, 
											@EntityPhoneId = @EntityPhoneId,
											@IsStore = 0
			
			COMMIT TRAN insEmployee
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN insEmployee
			RAISERROR(50001, 19, 1, 'Stores.uspAddEmployee') WITH LOG
		END CATCH
END