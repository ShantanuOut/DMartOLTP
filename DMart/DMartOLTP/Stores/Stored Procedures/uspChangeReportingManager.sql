/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 07th January 2019
--Name : Shantanu Narale
--Date Modified :
--Purpose : Transfer all the Employees to new reporting manager
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspChangeReportingManager]
	@inputXML XML (DOCUMENT [Stores].[ChangeReportingManager])
AS
BEGIN
	DECLARE @NewManagerId	INT, @IsManager BIT
	DECLARE @RS INT = 1
	DECLARE @Employees AS TABLE
	(
		EmpId		INT,
		RowNum		INT,
		RowNumNx	AS RowNum + 1
	)
	DECLARE @parenthier hierarchyid,
			@maxChild	hierarchyid

	SELECT @NewManagerId = T.c.value('@NewManagerId', 'int')
	FROM @inputXML.nodes('ToBeTransferred')T(c)

	INSERT @Employees (EmpId, RowNum)
	SELECT 
		T.c.value('.', 'int'),
		ROW_NUMBER() OVER(ORDER BY T.c.value('.', 'int'))
	FROM @inputXML.nodes('ToBeTransferred/EmployeeId')T(c)

	SELECT @parenthier = OrgPath,
			@IsManager = IsManager
	FROM [Stores].[Employee]
	WHERE EmployeeId = @NewManagerId

	SELECT @maxChild = MAX(OrgPath)
	FROM Stores.Employee
	WHERE OrgPath.IsDescendantOf(@parenthier) = 1
	AND OrgPath.GetLevel() = 1

	IF(@parenthier IS NOT NULL AND @IsManager = 1)
	BEGIN
		SET @RS = 0
		PRINT 'Processing CTE'
		;WITH CteNewHier (EmpId, OrgPath, RowNumNx)
		AS
		(
			SELECT EmpId, @parenthier.GetDescendant(NULLIF(@maxChild, @parenthier), NULL) AS OrgPath, RowNumNx
			FROM @Employees
			WHERE RowNum = 1
			UNION ALL
			SELECT e.EmpId, @parenthier.GetDescendant(c.OrgPath, NULL) AS OrgPath, e.RowNumNx
			FROM @Employees e
			INNER JOIN CteNewHier c
				ON e.RowNum = c.RowNumNx
		)
		UPDATE ep
		SET OrgPath = cn.OrgPath
		FROM [Stores].[Employee] ep
		INNER JOIN CteNewHier cn
			ON ep.EmployeeId = cn.EmpId
	END
	RETURN @RS
END