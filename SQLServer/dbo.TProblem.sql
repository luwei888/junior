CREATE TABLE [dbo].[TProblem] (
    [Id]              INT          IDENTITY (5, 3) NOT NULL,
    [Title]           VARCHAR (20) NULL,
    [Content]         NTEXT        NULL,
    [NeedRemoteHelp]  BIT          DEFAULT ((1)) NULL,
    [Reward]          INT          NULL,
    [PublishDateTime] DATETIME     NULL,
    [AutherName]      VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Tproblem_AotherName] FOREIGN KEY ([AutherName]) REFERENCES [dbo].[TUser] ([UserName]),
    CONSTRAINT [FK_Tproblem_Reward] FOREIGN KEY ([Reward]) REFERENCES [dbo].[TProblem] ([Id])
);

