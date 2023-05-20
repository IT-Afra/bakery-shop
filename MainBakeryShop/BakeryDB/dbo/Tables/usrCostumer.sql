CREATE TABLE [dbo].[usrCostumer]
(
	[Id] BIGINT NOT NULL IDENTITY(1,1)  PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL
)
