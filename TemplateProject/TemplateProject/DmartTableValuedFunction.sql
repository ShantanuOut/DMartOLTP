/************************************DMart OLTP database****************************************/
--Object Type : Table Valued Function
--Date Created : 
--Name : 
--Date Modified :
--Purpose : 
/**********************************************************************************************/
CREATE FUNCTION [dbo].[DmartTableValuedFunction]
(
	@param1 int,
	@param2 char(5)
)
RETURNS @returntable TABLE
(
	c1 int,
	c2 char(5)
)
AS
BEGIN
	INSERT @returntable
	SELECT @param1, @param2
	RETURN
END
