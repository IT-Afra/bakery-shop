CREATE TABLE [dbo].[gtUser] (
    [Id]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (100) NOT NULL,
    [UserName]     NVARCHAR (100) NOT NULL,
    [Password]     NVARCHAR (256) NOT NULL,
    [RoleName]     NVARCHAR (50)  NOT NULL,
    [IsActive]     BIT            NOT NULL,
    [ModifierUser] BIGINT         NULL,
    [ModifierDate] BIGINT         NULL,
    CONSTRAINT [PK_gtUser] PRIMARY KEY CLUSTERED ([Id] ASC)
);









