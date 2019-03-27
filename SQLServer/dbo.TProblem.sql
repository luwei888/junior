CREATE TABLE [dbo].[TProblem] (
    [Id]              INT            IDENTITY (5, 3) NOT NULL,
    [Title]           VARCHAR (20)   NULL,
    [Content]         NTEXT NULL,
    [NeedRemoteHelp]  BIT            DEFAULT ((1)) NULL,
    [Reward]          INT            NULL,
    [PublishDateTime] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_TProblem_Column] CHECK ((1) = (1))
);

