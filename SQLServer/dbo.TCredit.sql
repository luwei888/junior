CREATE TABLE [dbo].[TCredit] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [CreditRecord] INT NOT NULL,
    [UserId]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TCredit_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[TUser] ([Id])
);

