/***************************DMart OLTP database************************************************/
--Object Type : Stored Procedure
--Date Created : 15 Jan 2019
--Name : Shantanu Narale
--Date Modified :
--Purpose : Gives List of Employees with there details
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspGetEmployeeDetails]
	@EmployeeCode		CHAR(5) = NULL,
	@EmployeeDetails	AS XML(DOCUMENT [Stores].[GetEmployeeDetailsXMLSchema]) OUT
AS
BEGIN
	DECLARE @RS INT = 1

	IF(@EmployeeCode IS NULL)
	BEGIN
		SET @EmployeeDetails = (
									SELECT
										e.EmployeeCode AS '@EmpCode',
										FirstName + ' ' + LastName AS 'FullName',
										Designation AS 'Designation',
										StoreId AS 'StoreId',
										ISNULL(frc.RepCount, 0) AS 'Reportees/@Count',
										fpd.PhoneXML AS '*'
									FROM [Stores].[Employee] e
									INNER JOIN [Stores].[fnGetPhoneDetails](NULL) fpd
										 ON e.EmployeeCode = fpd.EmployeeCode
									CROSS APPLY [Stores].[fnGetReportees](e.OrgPath, 1, DEFAULT) frc
									FOR XML PATH('Employee'), ROOT('EmployeeList'), TYPE			
								)
		SET @RS = 0
	END
	ELSE
	BEGIN
		SET @EmployeeDetails = (
									SELECT
										e.EmployeeCode AS '@EmpCode',
										FirstName + ' ' + LastName AS 'FullName',
										Designation AS 'Designation',
										StoreId AS 'StoreId',
										e.BloodGroup AS 'BloodGroup',
										e.Address1 AS 'Address/Address1',
										e.Address2 AS 'Address/Address2',
										e.Address3 AS 'Address/Address3',
										ISNULL(frc.RepCount, 0) AS 'Reportees/@Count',
										ISNULL(frc.ReporteeXML, '') AS 'Reportees/*',
										fpd.PhoneXML AS '*'
									FROM [Stores].[Employee] e
									CROSS APPLY [Stores].[fnGetPhoneDetails]('<PhoneEntityIds><EntityId>'+ CAST(EntityPhoneId AS varchar(100)) + '</EntityId></PhoneEntityIds>') fpd										 
									CROSS APPLY [Stores].[fnGetReportees](e.OrgPath, 0, DEFAULT) frc
									WHERE e.EmployeeCode = @EmployeeCode
									FOR XML PATH('Employee'), ROOT('EmployeeList'), TYPE			
								)
		IF(@EmployeeDetails IS NOT NULL)
			SET @RS = 0
	END

	RETURN @RS
END