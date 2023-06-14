CREATE TABLE [dbo].[gtUser] (
    [Id]                   BIGINT         NOT NULL,
    [Title]                NVARCHAR (150) NULL,
    [Name]                 NVARCHAR (100) NULL,
    [Family]               NVARCHAR (100) NULL,
    [IsMale]               BIT            NULL,
    [BirthDate]            NVARCHAR (10)  NULL,
    [InfoConfirmed]        BIT            NOT NULL,
    [PhoneNumber]          NVARCHAR (15)  NOT NULL,
    [PhoneNumberConfirmed] BIT            NOT NULL,
    [Address]              NVARCHAR (250) NOT NULL,
    [Email]                NVARCHAR (150) NOT NULL,
    [EmailConfirmed]       BIT            NOT NULL,
    [Password]             NVARCHAR (256) NOT NULL,
    [LockoutEnabled]       BIT            NOT NULL,
    [LockoutEnd]           DATETIME2 (7)  NULL,
    [AccessFailedCount]    INT            NOT NULL,
    [NotificationCount]    INT            NOT NULL,
    [MessageCount]         INT            NOT NULL,
    [PhotoGuid]            NVARCHAR (50)  NULL,
    [IsMessageBlocked]     BIT            NOT NULL,
    [IsActive]             BIT            NOT NULL,
    [ModifierUser]         BIGINT         NULL,
    [ModifierDate]         BIGINT         NULL,
    CONSTRAINT [PK_gtUser] PRIMARY KEY CLUSTERED ([Id] ASC)
);





