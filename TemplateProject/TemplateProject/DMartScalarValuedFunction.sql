/************************************DMart OLTP database****************************************/
--Object Type : Scalar Valued Function
--Date Created : 
--Name : 
--Date Modified :
--Purpose : 
/**********************************************************************************************/
CREATE FUNCTION [dbo].[DMartScalarValuedFunction]
(
	@param1 int,
	@param2 int
)
RETURNS INT
AS
BEGIN
	RETURN @param1 + @param2
END
