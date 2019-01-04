/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 24 December 2018
--Name : Shantanu Narale
--Date Modified : 03/01/2019
--Purpose : Validate Phone Numbers that needs to be deleted

/**Change Log**/
--03/01/2019	Shantanu Narale		Renamed to uspValidateExistingPhoneIds and made changes to validate update changes
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspValidateExistingPhoneIds]
	@EntityPhoneId	UNIQUEIDENTIFIER,
	@IsStore		BIT = 0,
	@Operation		BIT = 0,
	@PhoneDelXML	XML([Stores].[DelPhoneXMLSchema]) = NULL,
	@PhoneUpdXML	XML([Stores].[UpdPhoneXMLSchema]) = NULL
AS
BEGIN
	DECLARE @ReturnStat		INT = 1,
			@RCnt			INT

	--Delete Validation Part
	IF(@Operation = 0)
	BEGIN
		DECLARE @PhoneTableDel AS [Stores].[PhoneTableDeletes]	
		DECLARE @PhoneXMLDeleteTable AS TABLE
		(
			PhoneId		INT,
			IsPri		BIT	,
			Alt			INT
		)

		IF(@IsStore = 0)
		BEGIN		
			INSERT @PhoneTableDel (ExisPhoneId, ExisIsPri, Operation)
			SELECT PhoneId, IsPrimary, CASE WHEN @PhoneDelXML IS NULL THEN 0 ELSE NULL END
			FROM [Stores].[fnGetEmployeePhoneData] (@EntityPhoneId)
			SET @RCnt = @@ROWCOUNT
		END
		ELSE
		BEGIN
			INSERT @PhoneTableDel (ExisPhoneId, ExisIsPri, Operation)
			SELECT PhoneId, IsPrimary, CASE WHEN @PhoneDelXML IS NULL THEN 0 ELSE NULL END
			FROM [Stores].[fnGetStoresPhoneData] (@EntityPhoneId)
			SET @RCnt = @@ROWCOUNT
		END

		IF (@PhoneDelXML IS NOT NULL AND @RCnt > 1)
		BEGIN	
			INSERT @PhoneXMLDeleteTable
			SELECT 
					T.c.value('.', 'int'),
					T.c.value('@IsPrimary', 'bit'),
					T.c.value('@AlternatePrimary', 'int')
			FROM @PhoneDelXML.nodes('/PhoneIdsToDelete/PhoneId') T(c)

			IF NOT EXISTS ((SELECT 1 FROM @PhoneXMLDeleteTable WHERE PhoneId NOT IN (SELECT ExisPhoneId FROM @PhoneTableDel)) 
							UNION ALL 
							(SELECT 1 FROM @PhoneXMLDeleteTable WHERE IsPri = 1 AND PhoneId IN (SELECT ExisPhoneId FROM @PhoneTableDel WHERE ExisIsPri = 1) AND Alt IS NULL) 
							UNION ALL
							(SELECT 1 FROM @PhoneXMLDeleteTable WHERE ISNULL(IsPri,0) = 0 AND PhoneId IN (SELECT ExisPhoneId FROM @PhoneTableDel WHERE ExisIsPri = 1))
							UNION ALL
							(SELECT 1 FROM @PhoneXMLDeleteTable WHERE IsPri = 1 AND PhoneId IN (SELECT ExisPhoneId FROM @PhoneTableDel WHERE ExisIsPri = 0)))
			BEGIN
				IF (EXISTS (SELECT 1 FROM @PhoneXMLDeleteTable WHERE IsPri = 1
							AND Alt IS NOT NULL AND 
							Alt IN (SELECT ExisPhoneId FROM @PhoneTableDel WHERE ExisIsPri = 0))) OR
					(NOT EXISTS (SELECT 1 FROM @PhoneXMLDeleteTable  WHERE Alt IS NOT NULL))
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
					FROM @PhoneTableDel pt
					INNER JOIN @PhoneXMLDeleteTable px
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
		FROM @PhoneTableDel
	END

	--Update Validation Part
	ELSE IF (@Operation = 1)
	BEGIN
		DECLARE @PhoneTableUpd AS [Stores].[PhoneTableUpdates]
		DECLARE @PhoneXMLUpdateTable AS TABLE
		(
			PhoneId			INT,
			PhoneNumber		VARCHAR(15),
			IsPrimary		BIT
		)
		
		IF(@IsStore = 0)
		BEGIN
			INSERT @PhoneTableUpd(PhoneId, PhoneNumber, IsPrimary)
			SELECT PhoneId, PhoneNumber, IsPrimary
			FROM [Stores].[fnGetEmployeePhoneData](@EntityPhoneId)
			SET @RCnt = @@ROWCOUNT
		END
		ELSE
		BEGIN
			INSERT @PhoneTableUpd(PhoneId, PhoneNumber, IsPrimary)
			SELECT PhoneId, PhoneNumber, IsPrimary
			FROM [Stores].[fnGetStoresPhoneData](@EntityPhoneId)
			SET @RCnt = @@ROWCOUNT
		END

		INSERT @PhoneXMLUpdateTable(PhoneId, IsPrimary, PhoneNumber)
		SELECT 
			T.c.value('@PhoneId', 'int') AS PhoneId,
			T.c.value('@IsPrimary', 'bit') AS IsPrimary,
			T.c.value('.', 'varchar(15)') AS PhoneNumber
		FROM @PhoneUpdXML.nodes('/PhoneUpdateXML/Phone') T(c)			

		IF NOT EXISTS (SELECT TOP 1 1 FROM @PhoneXMLUpdateTable WHERE PhoneId NOT IN (SELECT PhoneId FROM @PhoneTableUpd))
		BEGIN
			UPDATE ph
			SET Operation = -1
			FROM @PhoneTableUpd ph
			LEFT JOIN @PhoneXMLUpdateTable pt
				ON ph.PhoneId = pt.PhoneId
				AND pt.PhoneId IS NULL

			UPDATE ph
			SET Operation = CASE WHEN (ph.IsPrimary <> pt.IsPrimary AND ph.PhoneNumber <> pt.PhoneNumber)
								 THEN 2
								 WHEN (ph.IsPrimary <> pt.IsPrimary AND ph.PhoneNumber = pt.PhoneNumber)
								 THEN 1
								 WHEN (ph.IsPrimary = pt.IsPrimary AND ph.PhoneNumber <> pt.PhoneNumber)
								 THEN 0
								 ELSE NULL
							END,
				IsPrimary = CASE WHEN (ph.IsPrimary <> pt.IsPrimary)
								 THEN pt.IsPrimary
								 ELSE ph.IsPrimary
							END,
				PhoneNumber = CASE WHEN (ph.PhoneNumber <> pt.PhoneNumber)
								   THEN pt.PhoneNumber
								   ELSE ph.PhoneNumber
								END
			FROM @PhoneTableUpd ph
			INNER JOIN @PhoneXMLUpdateTable pt
				ON ph.PhoneId = pt.PhoneId	
				
			IF NOT EXISTS(SELECT TOP 1 1 FROM @PhoneTableUpd pu WHERE Operation >= 0 AND Stores.fnValidatePhoneNumber(PhoneNumber) = 1)
			BEGIN
				SET @ReturnStat = 0
				SELECT *
				FROM @PhoneTableUpd
			END
		END
	END

	ELSE
		SET @ReturnStat = 1

	RETURN @ReturnStat
END

