/************************************DMart OLTP database****************************************/
--Object Type : User Defined Table Type
--Date Created : 24 December 2018
--Name : Shantanu Narale
--Date Modified :
--Purpose : Holds the Phone Information to be deleted
/**********************************************************************************************/
CREATE TYPE [Stores].[PhoneTableDeletes] AS TABLE
(	
	ExisPhoneId		INT,
	ExisIsPri		BIT,
	Operation		BIT,
	NewPri			INT	
)
