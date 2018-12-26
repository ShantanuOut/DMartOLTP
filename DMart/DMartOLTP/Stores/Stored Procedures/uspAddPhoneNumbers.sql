/************************************DMart OLTP database****************************************/
--Object Type : Stored Procedure
--Date Created : 01 December 2018
--Name : Shantanu Narale
--Date Modified :
--Purpose : Add Phone Numbers for Stores and Employees.
/**********************************************************************************************/
CREATE PROCEDURE [Stores].[uspAddPhoneNumbers]
	@Phone				XML(Stores.PhoneXMLSchema),
	@EntityPhoneId		UNIQUEIDENTIFIER,
	@IsStore			BIT
AS
BEGIN
	DECLARE @ret	INT = 1
	DECLARE @PhoneTable	AS TABLE
	(
		PhoneNumber		VARCHAR(15),
		IsPrimary		BIT,
		IsValid			BIT
	)
	DECLARE @PhoneOutput AS TABLE
	(		
		PhoneId			INT
	)

	BEGIN TRAN insPhone
		BEGIN TRY
			--Insert PhonNumbers to a work table
			INSERT @PhoneTable(PhoneNumber, IsPrimary)
			SELECT T.c.value('.', 'VARCHAR(15)'),
				   T.c.value('@IsPrimary', 'BIT')
			FROM @Phone.nodes('/PhoneNumbers/Phone') T(c)		
			
			--Check the validity of Phone Numbers
			UPDATE @PhoneTable
			SET IsValid = Stores.fnValidatePhoneNumber(PhoneNumber)		

			--Transfer the control to catch block if more than one valid phone numbers are detected
			IF (((SELECT COUNT(1) FROM @PhoneTable WHERE IsValid = 1) >= 1) OR
				((SELECT COUNT(1) FROM @PhoneTable WHERE IsPrimary = 1) <> 1))
				THROW 50002,'More than one valid flag detected', 16;

			--SET return to 0 when atleast one valid phone detected
			IF EXISTS(SELECT TOP 1 1 FROM @PhoneTable WHERE IsValid = 0)
			BEGIN
				SET @ret = 0
			END

			--Insert into the Phone table and get the PhoneIds and insert to Employee or Stores Phone
			INSERT INTO Stores.Phone (PhoneNumber, IsPrimary)
			OUTPUT inserted.PhoneId INTO @PhoneOutput
			SELECT PhoneNumber, IsPrimary
			FROM @PhoneTable
			WHERE IsValid = 0

			IF(@IsStore = 1)
			BEGIN
				INSERT Stores.StorePhone (EntityPhoneId, PhoneId)
				SELECT @EntityPhoneId, PhoneId
				FROM @PhoneOutput
			END
			ELSE
			BEGIN
				INSERT Stores.EmployeePhone (EntityPhoneId, PhoneId)
				SELECT @EntityPhoneId, PhoneId
				FROM @PhoneOutput
			END

			COMMIT TRAN insPhone			
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN insPhone
			RAISERROR(50001, 19, 1, 'Stores.uspAddPhoneNumbers', '') WITH LOG
		END CATCH
		RETURN @ret
END