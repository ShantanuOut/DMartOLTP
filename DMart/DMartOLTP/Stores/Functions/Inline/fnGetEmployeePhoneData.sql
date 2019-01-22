/***************************DMart OLTP database****************************************/
--Object Type : Inline Function
--Date Created : 22 December 2018
--Name : Shantanu Narale
--Date Modified : 03 Jan 2019
--Purpose : Provides the List of Phone Numbers based on the EntityId for Employees

/**Change Log**/
--03/01/2019	Shantanu Narale		Added Phone Number
/**********************************************************************************************/
CREATE FUNCTION [Stores].[fnGetEmployeePhoneData]
(
	@EntityPhoneId	UNIQUEIDENTIFIER
)
RETURNS TABLE AS RETURN
(
	SELECT p.PhoneId, p.IsPrimary, p.PhoneNumber
	FROM Stores.EmployeePhone ep
	INNER JOIN Stores.Phone p
		ON ep.PhoneId = p.PhoneId
	WHERE ep.EntityPhoneId = @EntityPhoneId
)
