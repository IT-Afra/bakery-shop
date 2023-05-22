CREATE TABLE [dbo].[shpPreparing]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [IsPreparing] BIT NOT NULL DEFAULT 0, 
    [IsSending] BIT NOT NULL DEFAULT 0, 
    [IsFinished] BIT NOT NULL DEFAULT 0, 
    [DateTime] DATETIME2 NOT NULL,
    [UserId] BIGINT NOT NULL, 
    [UserBakeryId] BIGINT NOT NULL, 
    CONSTRAINT [FK_Id_shpPreparing_UserId_usrCostumer] FOREIGN KEY ([UserId]) REFERENCES [usrCostumer]([Id]), 
    CONSTRAINT [FK_shpPreparing_UserBakeryId_usrCostumer] FOREIGN KEY ([UserBakeryId]) REFERENCES[usrCostumer]([Id])
)
