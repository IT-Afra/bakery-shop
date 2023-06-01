CREATE TABLE [dbo].[bksOrder] (
    [Id]                BIGINT        NOT NULL,
    [UserId]            BIGINT        NOT NULL,
    [SchaduleId]        BIGINT        NOT NULL,
    [RegisterDateTime]  NVARCHAR (21) NOT NULL,
    [RegisterDateTimeL] BIGINT        NOT NULL,
    [DeliveryDateTime]  NVARCHAR (21) NULL,
    [DeliveryDateTimeL] BIGINT        NULL,
    [TotalPrice]        DECIMAL (18)  NOT NULL,
    [ModifierUser]      BIGINT        NULL,
    [ModifierDate]      BIGINT        NULL,
    CONSTRAINT [PK_bksOrder] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_bksOrder_bksSchadule] FOREIGN KEY ([SchaduleId]) REFERENCES [dbo].[bksSchadule] ([Id]),
    CONSTRAINT [FK_bksOrder_gtUser] FOREIGN KEY ([UserId]) REFERENCES [dbo].[gtUser] ([Id])
);

