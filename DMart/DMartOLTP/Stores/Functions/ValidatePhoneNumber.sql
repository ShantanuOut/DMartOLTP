/************************************DMart OLTP database****************************************/
--Object Type : View
--Date Created : 
--Name : 
--Date Modified :
--Purpose : 
/**********************************************************************************************/
CREATE FUNCTION [Stores].[ValidatePhoneNumber]
(
	@phone	VARCHAR(15)
)
RETURNS BIT
AS
BEGIN
	DECLARE @ret BIT = 1
	IF (LEN(@phone) = 10)
	BEGIN
		IF ((SELECT PATINDEX('%[^0-9]%',@phone)) = 0)
			SET @ret = 0
	END
	IF (LEN(@phone) = 13)
	BEGIN
		IF (((SELECT PATINDEX('%[^+0-9]%',@phone)) = 0) AND ((SELECT PATINDEX('+%',@phone)) = 0) AND (SELECT PATINDEX('%+%', SUBSTRING(@phone, 2, LEN(@phone) + 1))) = 0)
			SET @ret = 0
	END
	RETURN @ret
END
