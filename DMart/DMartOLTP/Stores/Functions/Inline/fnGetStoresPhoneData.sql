/***************************DMart OLTP database****************************************/
--Object Type : Inline Function
--Date Created : 24 December 2018
--Name : Shantanu Narale
--Date Modified : 03/01/2019
--Purpose : Provides the List of Phone Numbers based on the EntityId for Stores

/**Change Log**/
--03/01/2019	Shantanu Narale		Added Phone Numb
/**********************************************************************************************/
CREATE FUNCTION [Stores].[fnGetStoresPhoneData]
(
	@EntityPhoneId	UNIQUEIDENTIFIER
)
RETURNS TABLE AS RETURN
(
	SELECT p.PhoneId, p.IsPrimary, p.PhoneNumber
	FROM Stores.StorePhone ep
	INNER JOIN Stores.Phone p
		ON ep.PhoneId = p.PhoneId
	WHERE ep.EntityPhoneId = @EntityPhoneId
)
