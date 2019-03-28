CREATE TABLE [dbo].[TProblem] (
    [Id]              INT          IDENTITY (5, 3) NOT NULL PRIMARY KEY,
    [Title]           VARCHAR (20) NULL,
    [Content]         NTEXT        NULL,
    [NeedRemoteHelp]  BIT          DEFAULT ((1)) NULL,
    [Reward]          INT          NULL,
    [PublishDateTime] DATETIME     NULL,
    [AotherName] VARCHAR(20) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Tproblem_Reward] FOREIGN KEY (Reward) REFERENCES TProblem(Id),
	CONSTRAINT [FK_Tproblem_AotherName] FOREIGN KEY (AotherName) REFERENCES TUser(UserName),
);

