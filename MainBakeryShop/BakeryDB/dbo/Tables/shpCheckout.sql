CREATE TABLE [dbo].[shpCheckout]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TotalPrice] NCHAR(10) NOT NULL, 
    [TransactionId] NCHAR(10) NOT NULL, 
    [IsPaidSuccessful] BIT NOT NULL DEFAULT 0, 
    [DateTime] DATETIME2 NOT NULL, 
    [UserId] BIGINT NOT NULL, 
    [UserBakeryId] BIGINT NOT NULL, 
    CONSTRAINT [FK_shpCheckout_UserId_usrCostumer] FOREIGN KEY ([UserId]) REFERENCES [usrCostumer]([Id]), 
    CONSTRAINT [FK_shpCheckout_UserBakeryId_usrBaker] FOREIGN KEY ([UserBakeryId]) REFERENCES [usrBaker]([Id])
)
