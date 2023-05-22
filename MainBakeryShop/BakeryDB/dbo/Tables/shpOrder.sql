CREATE TABLE [dbo].[shpOrder]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Count] INT NOT NULL,
    [BreadId] BIGINT NOT NULL, 
    [UserId] BIGINT NOT NULL, 
    CONSTRAINT [FK_shpOrder_BreadId_Bread] FOREIGN KEY ([BreadId]) REFERENCES [Bread]([Id]), 
    CONSTRAINT [FK_shpOrder_UserId_usrCostumer] FOREIGN KEY ([UserId]) REFERENCES [usrCostumer]([Id])
)
