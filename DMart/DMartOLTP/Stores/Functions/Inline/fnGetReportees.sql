/***************************DMart OLTP database****************************************/
--Object Type : Inline Function
--Date Created : 15th Jan 2019
--Name : Shantanu Narale
--Date Modified : 
--Purpose : Returns Count of Direct Reportees and Employee Code
/**********************************************************************************************/
CREATE FUNCTION [Stores].[fnGetReportees]
(
	@Parent				hierarchyid,
	@CountOnly			BIT = 1,
	@Level				INT = 1
)
RETURNS TABLE AS RETURN
(
	SELECT	(
				SELECT 
					COUNT(EmployeeId) 
				FROM [Stores].[Employee] ie 
				WHERE ie.OrgPath.GetAncestor(ISNULL(@Level, 1)) = @Parent
			) AS RepCount,
			CASE WHEN @CountOnly = 1
				 THEN ''
				 ELSE (
						 SELECT 
							FirstName + ' '  + LastName AS Reportee
						FROM [Stores].[Employee] ie 
						WHERE ie.OrgPath.GetAncestor(ISNULL(@Level, 1)) = @Parent
						FOR XML RAW(''), ELEMENTS, TYPE
					  ) 
				END AS ReporteeXML
)
