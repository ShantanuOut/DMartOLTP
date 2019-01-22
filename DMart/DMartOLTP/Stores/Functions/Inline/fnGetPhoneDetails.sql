/***************************DMart OLTP database****************************************/
--Object Type : Inline Function
--Date Created : 15 Jan 2019
--Name : Shantanu Narale
--Date Modified :
--Purpose : Provides EmployeeCodes and there Phone Numbers
/**********************************************************************************************/
CREATE FUNCTION [Stores].[fnGetPhoneDetails]
(
	@EntityPhoneIdXML	AS XML(DOCUMENT [Stores].[GetPhoneDetailsXMLSchema])
)
RETURNS TABLE AS RETURN
(	
	SELECT 
		e.EmployeeCode,
		(SELECT 
			ph.IsPrimary   AS '@IsPrimary',
			ph.PhoneNumber AS '*'			
			FROM Stores.Phone ph 
			WHERE PhoneId = p.PhoneId
			FOR XML PATH('Phone'), ROOT('PhoneNumbers'), TYPE) AS PhoneXML			
	FROM [Stores].[Employee] e
	INNER JOIN [Stores].[EmployeePhone] ep
		ON e.EntityPhoneId = ep.EntityPhoneId			
	INNER JOIN [Stores].[Phone] p
		ON ep.PhoneId = p.PhoneId
	WHERE CASE WHEN @EntityPhoneIdXML IS NULL
				THEN IsPrimary
				ELSE 1
			END = 1
	AND e.EntityPhoneId IN (CASE WHEN @EntityPhoneIdXML IS NULL
									THEN e.EntityPhoneId
									ELSE (SELECT T.c.value('.', 'UNIQUEIDENTIFIER') FROM @EntityPhoneIdXML.nodes('PhoneEntityIds/EntityId') T(c))
								END)
)
