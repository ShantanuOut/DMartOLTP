/************************************DMart OLTP database****************************************/
--Object Type : Post Deployment Script
--Date Created : 25th October 2018
--Name : Shantanu Narale
--Date Modified : 14th November 2018, Adding other employees and removing ManagerId in the insert.
--Purpose : Post Deployment Script for entering information of Master Employee
/**********************************************************************************************/
IF NOT EXISTS (SELECT TOP 1 1 FROM Stores.Employee WHERE EmployeeId = 1)
BEGIN
	BEGIN TRAN insEmp
	BEGIN TRY
		INSERT INTO Stores.Employee(EmployeeCode, OrgPath, EntityPhoneId, Address1, Address2, Address3, StoreId, BloodGroup, IsManager, Designation)
		VALUES ('SHANN', '/', NEWID(), 'Address Line 1', NULL, NULL, 1, 'A+', 1, 'Owner')
		INSERT INTO Stores.Phone
		VALUES ('+919130089763', 1)
		INSERT INTO Stores.EmployeePhone
		VALUES ((SELECT MAX(PhoneId) FROM Stores.Phone), (SELECT TOP 1 EntityPhoneId FROM Stores.Employee))
		COMMIT TRAN insEmp
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN insEmp
		RAISERROR('Unable to insert Employee Data...', 16, 1)
	END CATCH
END