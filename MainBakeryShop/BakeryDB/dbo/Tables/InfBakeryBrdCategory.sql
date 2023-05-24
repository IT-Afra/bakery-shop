CREATE TABLE [dbo].[InfBakeryBrdCategory]
(
	[Id] BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [CategoryId] BIGINT NOT NULL, 
    [BreadId] BIGINT NOT NULL, 
    [BakeryId] BIGINT NOT NULL, 
    CONSTRAINT [FK_InfBakeryBrdCategory_BreadId_Bread] FOREIGN KEY ([BreadId]) REFERENCES [Bread]([Id]), 
    CONSTRAINT [FK_InfBakeryBrdCategory_CategoryId_brdCategory] FOREIGN KEY ([CategoryId]) REFERENCES [brdCategory]([Id]), 
    CONSTRAINT [FK_InfBakeryBrdCategory_BakeryId_InfBakery] FOREIGN KEY ([BakeryId]) REFERENCES [InfBakery]([Id])
)
