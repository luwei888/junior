CREATE TABLE [dbo].[TProfile] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (1) NULL,
    [Age]        INT          NULL,
    [Sex]        NVARCHAR (1) NULL,
    [UserNameId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TProfile_UserNameId] FOREIGN KEY ([UserNameId]) REFERENCES [dbo].[TUser] ([Id])
);

