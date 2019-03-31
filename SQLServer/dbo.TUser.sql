CREATE TABLE [dbo].[TUser] (
    [Id]       INT          NOT NULL,
    [UserName] VARCHAR (20) NOT NULL,
    [Password] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([UserName] ASC)
);

