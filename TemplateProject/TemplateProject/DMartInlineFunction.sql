/************************************DMart OLTP database****************************************/
--Object Type : Inline Function
--Date Created : 
--Name : 
--Date Modified :
--Purpose : 
/**********************************************************************************************/
CREATE FUNCTION [dbo].[DMartInlineFunction]
(
	@param1 int,
	@param2 char(5)
)
RETURNS TABLE AS RETURN
(
	SELECT @param1 AS c1,
		   @param2 AS c2
)