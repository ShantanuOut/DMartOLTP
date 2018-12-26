/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 01 December 2018
--Name : Shantanu Narale
--Date Modified :
--Purpose : Add Phone Numbers for Stores and Employees.
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspRemovePhoneNumber]
	@EntityPhoneId	UNIQUEIDENTIFIER,
	@IsStore		BIT = 0,
	@PhoneDelXML	XML([Stores].[DelPhoneXMLSchema]) = NULL
AS
BEGIN	
	DECLARE @PhoneTable AS [Stores].[PhoneTable]
	DECLARE @msg	VARCHAR(100) = NULL,
			@RC		INT

	BEGIN TRAN removePhone
		BEGIN TRY
			IF (@IsStore = 1 AND @PhoneDelXML IS NULL)
			BEGIN
				SET @msg = 'Cannot Delete all phone numbers for Stores';
				THROW 50002, 'Invalid Operation', 16
			END

			INSERT @PhoneTable
			EXEC @RC = [Stores].[uspValidatePhoneNumbersToRemove] @EntityPhoneId = @EntityPhoneId, @IsStore = @IsStore, @PhoneDelXML = @PhoneDelXML

			IF(@RC = 1)
			BEGIN
				SET @msg = 'Validation falied in Validation phase';
				THROW 50002, 'Validation Failed', 16
			END

			IF EXISTS (SELECT TOP 1 1 FROM @PhoneTable WHERE Operation = 1)
			BEGIN
				UPDATE ph
				SET IsPrimary = 1
				FROM Stores.Phone ph
				INNER JOIN @PhoneTable pt
					ON ph.PhoneId = pt.NewPri
				WHERE pt.Operation = 1
			END

			IF (@IsStore = 1)
			BEGIN
				DELETE FROM Stores.StorePhone 
				WHERE PhoneId IN (SELECT ExisPhoneId FROM @PhoneTable WHERE Operation IS NOT NULL)
				AND EntityPhoneId = @EntityPhoneId
			END
			ELSE
			BEGIN
				DELETE FROM Stores.EmployeePhone 
				WHERE PhoneId IN (SELECT ExisPhoneId FROM @PhoneTable WHERE Operation IS NOT NULL)
				AND EntityPhoneId = @EntityPhoneId
			END

			DELETE FROM Stores.Phone 
			WHERE PhoneId IN (SELECT ExisPhoneId FROM @PhoneTable WHERE Operation IS NOT NULL)
			AND IsPrimary = 0

			COMMIT TRAN removePhone
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN removePhone
			
			IF (@msg IS NULL)
			BEGIN
				SET @msg = 'Problems with Update or Delete.'
			END

			RAISERROR(50001, 19, 1, 'Stores.uspRemovePhoneNumber', @msg) WITH LOG
		END CATCH			
END