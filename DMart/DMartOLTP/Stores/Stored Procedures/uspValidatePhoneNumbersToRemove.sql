/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 24 December 2018
--Name : Shantanu Narale
--Date Modified :
--Purpose : Validate Phone Numbers that needs to be deleted
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspValidatePhoneNumbersToRemove]
	@EntityPhoneId	UNIQUEIDENTIFIER,
	@IsStore		BIT = 0,
	@PhoneDelXML	XML([Stores].[DelPhoneXMLSchema])
AS
BEGIN
	DECLARE @ReturnStat		INT = 1,
			@RCnt			INT
	DECLARE @PhoneTable AS [Stores].[PhoneTable]	
	DECLARE @PhoneXMLTable AS TABLE
	(
		PhoneId		INT,
		IsPri		BIT	,
		Alt			INT
	)

	IF(@IsStore = 0)
	BEGIN		
		INSERT @PhoneTable (ExisPhoneId, ExisIsPri, Operation)
		SELECT *, CASE WHEN @PhoneDelXML IS NULL THEN 0 ELSE NULL END
		FROM [Stores].[fnGetEmployeePhoneData] (@EntityPhoneId)
		SET @RCnt = @@ROWCOUNT
	END
	ELSE
	BEGIN
		INSERT @PhoneTable (ExisPhoneId, ExisIsPri, Operation)
		SELECT *, CASE WHEN @PhoneDelXML IS NULL THEN 0 ELSE NULL END
		FROM [Stores].[fnGetStoresPhoneData] (@EntityPhoneId)
		SET @RCnt = @@ROWCOUNT
	END

	IF (@PhoneDelXML IS NOT NULL AND @RCnt > 1)
	BEGIN	
		INSERT @PhoneXMLTable
		SELECT 
				T.c.value('.', 'int'),
				T.c.value('@IsPrimary', 'bit'),
				T.c.value('@AlternatePrimary', 'int')
		FROM @PhoneDelXML.nodes('/PhoneIdsToDelete/PhoneId') T(c)

		IF NOT EXISTS ((SELECT 1 FROM @PhoneXMLTable WHERE PhoneId NOT IN (SELECT ExisPhoneId FROM @PhoneTable)) 
						UNION ALL 
						(SELECT 1 FROM @PhoneXMLTable WHERE IsPri = 1 AND PhoneId IN (SELECT ExisPhoneId FROM @PhoneTable WHERE ExisIsPri = 1) AND Alt IS NULL) 
						UNION ALL
						(SELECT 1 FROM @PhoneXMLTable WHERE ISNULL(IsPri,0) = 0 AND PhoneId IN (SELECT ExisPhoneId FROM @PhoneTable WHERE ExisIsPri = 1))
						UNION ALL
						(SELECT 1 FROM @PhoneXMLTable WHERE IsPri = 1 AND PhoneId IN (SELECT ExisPhoneId FROM @PhoneTable WHERE ExisIsPri = 0)))
		BEGIN
			IF (EXISTS (SELECT 1 FROM @PhoneXMLTable WHERE IsPri = 1
						AND Alt IS NOT NULL AND 
						Alt IN (SELECT ExisPhoneId FROM @PhoneTable WHERE ExisIsPri = 0))) OR
				(NOT EXISTS (SELECT 1 FROM @PhoneXMLTable  WHERE Alt IS NOT NULL))
			BEGIN				
				
				SET @ReturnStat = 0
							
				UPDATE pt
				SET Operation = CASE WHEN px.IsPri IS NULL
									 THEN 0
									 ELSE 1
								END,
					NewPri = CASE WHEN px.IsPri IS NULL
								  THEN NULL
								  ELSE Alt
							 END
				FROM @PhoneTable pt
				INNER JOIN @PhoneXMLTable px
					ON pt.ExisPhoneId = px.PhoneId
			
			END
			
		END
	END
	ELSE IF (@PhoneDelXML IS NULL)
	BEGIN
		SET @ReturnStat = 0
	END
	ELSE
	BEGIN
		SET @ReturnStat = 1
	END
	SELECT *
	FROM @PhoneTable

	RETURN @ReturnStat
END

