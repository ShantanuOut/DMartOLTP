/************************************DMart OLTP database****************************************/
--Object Type : Post Deployment Script
--Date Created : 25th November 2018
--Name : Shantanu Narale
--Date Modified : 
--Purpose : Post Deployment Script to add raiserror messages to sys.messages
/**********************************************************************************************/
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.messages WHERE message_id = 50001 AND language_id = 1033)
BEGIN
	EXEC sp_addmessage	@msgnum		= 50001, 
						@severity	= 19,
						@msgtext	= 'Userdefined procedure %s failed. This message is logged. The Custom Error is %s',
						@lang		= 'us_english'
END