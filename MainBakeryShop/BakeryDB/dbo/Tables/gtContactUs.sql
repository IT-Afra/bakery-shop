﻿CREATE TABLE [dbo].[gtContactUs]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Phone] INT NOT NULL, 
    [Description] NVARCHAR(500) NOT NULL
)
