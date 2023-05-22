CREATE TABLE [dbo].[InfBakery]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BakeryName] NVARCHAR(50) NOT NULL, 
    [BakeryRate] NVARCHAR(50) NULL, 
    [ThumbnailePic] NVARCHAR(50) NOT NULL, 
    [ProfileBannerPic] NVARCHAR(50) NOT NULL, 
    [ProfileLogoPic] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [PhoneNimber] NCHAR(10) NOT NULL, 
    [OpenTime] DATETIME2 NOT NULL, 
    [Discount] BIGINT NULL, 
    [Discriptioin] NVARCHAR(200) NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [BreadId] BIGINT NOT NULL, 
    [BkCTId] BIGINT NOT NULL, 
    [UserBakeryID] BIGINT NOT NULL, 
    CONSTRAINT [FK_InfBakery_BreadId_Bread] FOREIGN KEY ([BreadId]) REFERENCES [Bread]([ID]), 
    CONSTRAINT [FK_InfBakery_BkCTId_InfBakeryBrdCategory] FOREIGN KEY ([BkCTId]) REFERENCES [InfBakeryBrdCategory]([ID]), 
    CONSTRAINT [FK_InfBakery_UserBakeryID_usrBaker] FOREIGN KEY ([UserBakeryID]) REFERENCES [usrBaker]([ID])
)
