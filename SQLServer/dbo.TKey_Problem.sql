CREATE TABLE [dbo].[TKey_Problem] (
    [KeywordId]  INT NOT NULL,
    [TproblemId] INT NOT NULL,
    CONSTRAINT [FK_TKey_Problem_KeywordId] FOREIGN KEY ([KeywordId]) REFERENCES [dbo].[TKeyword] ([Id]),
    CONSTRAINT [FK_TKey_Problem_TproblemId] FOREIGN KEY ([TproblemId]) REFERENCES [dbo].[TProblem] ([Id])
);

