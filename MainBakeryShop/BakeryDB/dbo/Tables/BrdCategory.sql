CREATE TABLE [dbo].[BrdCategory]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Thumbnaile] NVARCHAR(50) NOT NULL, 
    [BkCTId] BIGINT NOT NULL
    CONSTRAINT [FK_BrdCategory_BkCTId_InfBakeryBrdCategory] FOREIGN KEY ([BkCTId]) REFERENCES [InfBakeryBrdCategory]([Id])
)
