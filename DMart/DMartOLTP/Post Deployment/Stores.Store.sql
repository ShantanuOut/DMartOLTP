/************************************DMart OLTP database****************************************/
--Object Type : Post Deployment Script
--Date Created : 24th October 2018
--Name : Shantanu Narale
--Date Modified : 24th October 2018
--Purpose : Create Initial List of Stores
/**********************************************************************************************/
IF NOT EXISTS(SELECT TOP 1 1 FROM Stores.Store WITH (NOLOCK))
BEGIN
	BEGIN TRAN insStore	
	BEGIN TRY
		INSERT Stores.Store(StoreCode, StoreName, StoreAddress1, StoreAddress2, StoreAddress3, IsWarehouse, EntityPhoneId)
		VALUES ('STRWH', 'Central Warehouse', 'Address Line 1', 'Address Line 2', NULL, 1, NEWID()),
			   ('STR01', 'Store 1 - Area 1', 'Address Line 1', 'Address Line 2', NULL, 0, NEWID()),
			   ('STR02', 'Store 2 - Area 2', 'Address Line 1', 'Address Line 2', NULL, 0, NEWID()),
			   ('STR03', 'Store 3 - Area 3', 'Address Line 1', 'Address Line 2', NULL, 0, NEWID())
		COMMIT TRAN insStore
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN insStore
		RAISERROR ('PostDeployment Script for Stores.Store Failed', 16, 1)
	END CATCH
END