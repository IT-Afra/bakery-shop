CREATE TABLE [dbo].[InfBakery]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1), 
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
    [UserBakeryID] BIGINT NOT NULL, 
    CONSTRAINT [FK_InfBakery_UserBakeryID_usrBaker] FOREIGN KEY ([UserBakeryID]) REFERENCES [usrBaker]([ID])
)
