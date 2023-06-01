CREATE TABLE [dbo].[bksTypeBread] (
    [Id]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (100) NOT NULL,
    [PhotoGuid]    NVARCHAR (50)  NOT NULL,
    [IsActive]     BIT            NOT NULL,
    [ModifierUser] BIGINT         NULL,
    [ModifierDate] BIGINT         NULL,
    CONSTRAINT [PK_bksTypeBread] PRIMARY KEY CLUSTERED ([Id] ASC)
);

