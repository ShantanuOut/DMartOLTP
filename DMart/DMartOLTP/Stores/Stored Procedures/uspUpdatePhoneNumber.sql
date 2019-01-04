/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 04 January 2018
--Name : Shantanu Narale
--Date Modified :
--Purpose : Add Phone Numbers for Stores and Employees.
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspUpdatePhoneNumber]
	@EntityPhoneId	UNIQUEIDENTIFIER,
	@IsStore		BIT = 0,
	@PhoneUpdXML	XML([Stores].[UpdPhoneXMLSchema])
AS
BEGIN
	DECLARE @PhoneTableUpd AS [Stores].[PhoneTableUpdates]
	DECLARE @PhoneDelXML AS XML([Stores].[DelPhoneXMLSchema])
	DECLARE @RC		INT,
			@msg	VARCHAR(100)

	BEGIN TRAN upPhoneNum
		BEGIN TRY
			INSERT INTO @PhoneTableUpd
			EXEC @RC = [Stores].[uspValidateExistingPhoneIds] @EntityPhoneId = @EntityPhoneId, @IsStore = @IsStore, @Operation = 1, @PhoneUpdXML = @PhoneUpdXML
			IF (@RC = 1)
			BEGIN
				SET @msg = 'Validation of update XML failed in uspValidateExistingPhoneIds';
				THROW 50002, 'Validation failure', 1
			END

			UPDATE ph
			SET PhoneNumber = CASE WHEN pu.Operation IN (0, 2)
								   THEN pu.PhoneNumber
								   ELSE ph.PhoneNumber
							  END,
				IsPrimary = CASE WHEN pu.Operation IN (1, 2)
								   THEN pu.IsPrimary
								   WHEN pu.Operation = -1
								   THEN 0
								   ELSE ph.IsPrimary
							  END
			FROM [Stores].[Phone] ph
			INNER JOIN @PhoneTableUpd pu
				ON ph.PhoneId = pu.PhoneId

			IF EXISTS (SELECT TOP 1 1 FROM @PhoneTableUpd WHERE Operation = -1)
			BEGIN
				SET @PhoneDelXML = (SELECT 
										PhoneId AS '*'
									FROM @PhoneTableUpd
									WHERE Operation = -1
									FOR XML PATH('PhoneId'), ROOT('PhoneIdsToDelete'), TYPE
									)				
				--Call the Delete Stored Procedure
				EXEC [Stores].[uspRemovePhoneNumber] @EntityPhoneId = @EntityPhoneId, @IsStore = @IsStore, @PhoneDelXML = @PhoneDelXML
			END

			COMMIT TRAN upPhoneNum
		END TRY
		BEGIN CATCH			
			ROLLBACK TRAN upPhoneNum
			IF(@msg IS NULL)
				SET @msg = 'Unknown Error occurred'
			RAISERROR(50001, 19, 1, 'uspUpdatePhoneNumber', @msg) WITH LOG
		END CATCH						
END