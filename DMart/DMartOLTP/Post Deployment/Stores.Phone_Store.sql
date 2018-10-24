/************************************DMart OLTP database****************************************/
--Object Type : Post Deployment Script for Phone records for Store
--Date Created : 24th October 2018
--Name : Shantanu Narale
--Date Modified : 
--Purpose : Add INitial Phone Numbers to the Phone table for stores
/**********************************************************************************************/
IF NOT EXISTS (SELECT TOP 1 1 FROM Stores.StorePhone WITH (NOLOCK))
BEGIN
BEGIN TRAN insPhoneRecordsForStore
BEGIN TRY
	DECLARE @phint			BIGINT,
			@ph				VARCHAR(15),
			@loop			INT,
			@entityphone	UNIQUEIDENTIFIER,
			@StoreCode		VARCHAR(10),
			@pri			BIT,
			@prird			BIT
	DECLARE @phoneId AS TABLE
			(
				PhoneId	INT
			)

	DECLARE cur_Store CURSOR
	FOR SELECT StoreCode, EntityPhoneId FROM Stores.Store

	OPEN cur_Store
	FETCH NEXT FROM cur_Store
	INTO @StoreCode, @entityphone

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @loop = CASE WHEN @StoreCode <> 'STRWH'
						 THEN 3
						 ELSE 2
					END
		SET @pri = 0
		SET @prird = 0
		WHILE @loop > 0
		BEGIN
			SET @phint= (SELECT CAST((RAND()*1000000)*10000 AS BIGINT))		
			WHILE(@phint NOT BETWEEN 7000000000 AND 9999999999)
			BEGIN
				SET @phint = (SELECT CAST((RAND()*1000000)*10000 AS BIGINT))
			END
			SET @ph = '+91'+CAST(@phint AS varchar)
			SET @pri = CASE WHEN @prird = 0 AND CAST(RAND()*10 AS INT)%2 = 0
							THEN 1
							ELSE 0
						END
			IF @pri = 1
				SET @prird = 1
			INSERT Stores.Phone
			OUTPUT inserted.PhoneId INTO @phoneId
			VALUES (@ph, @pri)			
			IF @pri = 1
				SET @pri = 0
			SET @loop -= 1
		END
		INSERT Stores.StorePhone
		SELECT PhoneId, @entityphone
		FROM @phoneId
		DELETE @phoneId
		FETCH NEXT FROM cur_Store
		INTO @StoreCode, @entityphone
	END
	CLOSE cur_Store
	DEALLOCATE cur_Store
	COMMIT TRAN insPhoneRecordsForStore
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN insPhoneRecordsForStore
		RAISERROR ('PhoneNumber insert failed..', 16, 1)
	END CATCH
END