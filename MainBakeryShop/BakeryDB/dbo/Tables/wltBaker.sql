CREATE TABLE [dbo].[wltBaker]
(
	[Id] BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Balance] INT NOT NULL, 
    [DateTime] DATETIME2 NOT NULL, 
    [Description] NVARCHAR(250) NOT NULL, 
    [IsDeposit] BIT NOT NULL DEFAULT 0, 
    [UserId] BIGINT NOT NULL,
    CONSTRAINT [FK_wltBaker_UserId_usrBaker] FOREIGN KEY ([UserId]) REFERENCES [usrBaker]([Id])
)
