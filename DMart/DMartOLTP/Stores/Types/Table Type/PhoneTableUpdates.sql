/************************************DMart OLTP database****************************************/
--Object Type : User Defined Table Type
--Date Created : 03 Jan 2019
--Name : Shantanu Narale
--Date Modified :
--Purpose : Holds the Phone Information to be updated
/**********************************************************************************************/
CREATE TYPE [Stores].[PhoneTableUpdates] AS TABLE
(	
	PhoneId			INT,
	IsPrimary		BIT,
	PhoneNumber		VARCHAR(15),
	Operation		SMALLINT
)
