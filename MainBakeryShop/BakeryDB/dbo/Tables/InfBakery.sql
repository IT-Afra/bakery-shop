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
    [UserBakeryID] BIGINT NOT NULL
)
