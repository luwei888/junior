CREATE TABLE [dbo].[TProblem] (
    [Id]              INT          NULL,
    [Title]           VARCHAR (20) NULL,
    [Content]         TEXT         NULL,
    [NeedRemoteHelp]  BIT          NULL,
    [Reward]          INT          NULL,
    [PublishDateTime] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

