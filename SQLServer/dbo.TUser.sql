CREATE TABLE [dbo].[TUser] (
    [Id]       INT          NOT NULL,
    [UserName] VARCHAR (20) NOT NULL UNIQUE,
    [Password] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

