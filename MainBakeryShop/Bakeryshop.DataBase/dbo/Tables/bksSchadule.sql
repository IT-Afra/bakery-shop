CREATE TABLE [dbo].[bksSchadule] (
    [Id]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [OrderDate]    NVARCHAR (10) NOT NULL,
    [OrderDateL]   BIGINT        NOT NULL,
    [OrderTime]    NVARCHAR (10) NOT NULL,
    [OrderTimeI]   INT           NOT NULL,
    [ModifierUser] BIGINT        NULL,
    [ModifierDate] BIGINT        NULL,
    CONSTRAINT [PK_bksSchadule] PRIMARY KEY CLUSTERED ([Id] ASC)
);





