/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 31 December 2018
--Name : Shantanu Narale
--Date Modified :
--Purpose : Add Phone Numbers for Stores and Employees.
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspUpdatePhoneNumber]
	@EntityPhoneId	UNIQUEIDENTIFIER,
	@IsStore		BIT = 0,
	@PhoneUpdXML	XML([Stores].[UpdPhoneXMLSchema]) = NULL
AS
BEGIN
	PRINT 1
END