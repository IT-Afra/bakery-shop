﻿CREATE TABLE [dbo].[shpPreparing]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [IsPreparing] BIT NOT NULL DEFAULT 0, 
    [IsSending] BIT NOT NULL DEFAULT 0, 
    [IsFinished] BIT NOT NULL DEFAULT 0, 
    [UserId] BIGINT NOT NULL, 
    [UserBakeryId] BIGINT NOT NULL
)
