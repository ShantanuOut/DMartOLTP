CREATE TABLE [Products].[Manufacturer]
(
	[ManufacturerId] INT NOT NULL, 
    [ManufacturerName] VARCHAR(50) NOT NULL, 
    [Contact] VARCHAR(15) NOT NULL, 
    [Address] VARCHAR(100) NULL,
	CONSTRAINT PK_Manufacturer_ManufacturerId PRIMARY KEY CLUSTERED ([ManufacturerId]),
	CONSTRAINT UQ_Manufacturer_ManufactuereName UNIQUE ([ManufacturerId])
)
