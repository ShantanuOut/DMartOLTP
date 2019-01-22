/************************************DMart OLTP database****************************************/
--Object Type : User Defined Function
--Date Created : 22nd November 2018
--Name : Shantanu Narale
--Date Modified :
--Purpose : Generates a random 5 digit Employee Code
/**********************************************************************************************/
CREATE FUNCTION [Stores].[fnGenerateEmployeeCode] 
(
	@FirstName	VARCHAR(50),
	@LastName	VARCHAR(50)
)
RETURNS CHAR(5)
AS
BEGIN
	DECLARE @EmpCode	CHAR(5),
			@Counter	INT = 0
	SELECT TOP 1 @EmpCode = EmployeeCode
	FROM Stores.Employee	
	WHERE EmployeeId = 1

	WHILE EXISTS(SELECT TOP 1 1 FROM Stores.Employee WHERE EmployeeCode = @EmpCode)
	BEGIN
		IF ((@Counter < 10) AND (@FirstName <> '' OR @LastName <> ''))
		BEGIN
			SET @EmpCode = SUBSTRING(@FirstName+@LastName, @Counter, 6)
		END
		ELSE IF((@Counter > 10 AND @Counter < 20) AND (@FirstName <> '' OR @LastName <> ''))
		BEGIN
			SET @EmpCode = SUBSTRING(@LastName+@FirstName, @Counter, 6)
		END
		ELSE IF((@Counter > 20 AND @Counter < 30) AND (@FirstName <> '' OR @LastName <> ''))
		BEGIN
			SET @EmpCode = SUBSTRING(REVERSE(@LastName)+REVERSE(@FirstName), @Counter, 6)
		END
		ELSE
		BEGIN
			SET @EmpCode = 'XXXXX'
			BREAK;
		END		
		WHILE(LEN(@EmpCode) < 5)
		BEGIN
			SET @EmpCode = RTRIM(@EmpCode) + SUBSTRING(@FirstName+@LastName, 1, (5-(LEN(@EmpCode))))		
		END
		SET @Counter += 1
	END

	RETURN @EmpCode
END
