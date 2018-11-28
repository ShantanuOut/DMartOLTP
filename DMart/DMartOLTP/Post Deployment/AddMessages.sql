/************************************DMart OLTP database****************************************/
--Object Type : Post Deployment Script
--Date Created : 25th November 2018
--Name : Shantanu Narale
--Date Modified : 
--Purpose : Post Deployment Script to add raiserror messages to sys.messages
/**********************************************************************************************/
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.messages WHERE message_id = 50002 AND language_id = 1033)
BEGIN
	EXEC sp_addmessage	@msgnum		= 50002, 
						@severity	= 19,
						@msgtext	= 'Userdefined procedure %s failed. This message is logged.',
						@lang		= 'us_english'
END