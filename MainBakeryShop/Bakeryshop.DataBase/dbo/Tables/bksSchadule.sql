CREATE TABLE [dbo].[bksSchadule] (
    [Id]            BIGINT        IDENTITY (1, 1) NOT NULL,
    [SchaduleDate]  NVARCHAR (10) NOT NULL,
    [SchaduleDateL] BIGINT        NOT NULL,
    [SchaduleTime]  NVARCHAR (10) NOT NULL,
    [SchaduleTimeI] INT           NOT NULL,
    [ModifierUser]  BIGINT        NULL,
    [ModifierDate]  BIGINT        NULL,
    CONSTRAINT [PK_bksSchadule] PRIMARY KEY CLUSTERED ([Id] ASC)
);



