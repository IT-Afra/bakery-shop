CREATE TABLE [dbo].[bksSchaduleDetail] (
    [Id]           BIGINT       NOT NULL,
    [SchaduleId]   BIGINT       NOT NULL,
    [TypeBreadId]  BIGINT       NOT NULL,
    [Price]        DECIMAL (18) NOT NULL,
    [Amount]       INT          NOT NULL,
    [IsActive]     BIT          NOT NULL,
    [ModifierUser] BIGINT       NULL,
    [ModifierDate] BIGINT       NULL,
    CONSTRAINT [PK_bksSchaduleDetail] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_bksSchaduleDetail_bksSchadule] FOREIGN KEY ([SchaduleId]) REFERENCES [dbo].[bksSchadule] ([Id]),
    CONSTRAINT [FK_bksSchaduleDetail_bksTypeBread] FOREIGN KEY ([TypeBreadId]) REFERENCES [dbo].[bksTypeBread] ([Id])
);

