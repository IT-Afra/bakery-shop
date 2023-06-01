CREATE TABLE [dbo].[bksOrderDetail] (
    [Id]             BIGINT       NOT NULL,
    [OrderId]        BIGINT       NOT NULL,
    [TypeBreadId]    BIGINT       NOT NULL,
    [Price]          DECIMAL (18) NOT NULL,
    [Amount]         INT          NOT NULL,
    [DeliveryAmount] INT          NULL,
    [ModifierUser]   BIGINT       NULL,
    [ModifierDate]   BIGINT       NULL,
    CONSTRAINT [PK_bksOrderDetail] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_bksOrderDetail_bksOrder] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[bksOrder] ([Id]),
    CONSTRAINT [FK_bksOrderDetail_bksTypeBread] FOREIGN KEY ([TypeBreadId]) REFERENCES [dbo].[bksTypeBread] ([Id])
);

