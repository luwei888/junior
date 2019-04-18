
 --作业：
 --   创建求助的应答表 TResponse(Id, Content, AuthorId, ProblemId, CreateTime)
 --   然后生成一个视图VResponse(ResponseId, Content, AuthorId, AuthorName, ProblemId, ProblemTitle, CreateTime)，要求该视图：
 --       能展示应答作者的用户名、应答对应求助的标题和作者用户名
 --       只显示求助悬赏值大于5的数据
 --       已被加密
 --       保证其使用的基表结构无法更改
 --   演示：在VResponse中插入一条数据，却不能在视图中显示
 --   修改VResponse，让其能避免上述情形
 --   创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，要求该视图：
 --       能反映求助的标题、使用关键字数量和悬赏
 --       在ProblemId上有一个唯一聚集索引
 --       在ProblemReward上有一个非聚集索引
 --   在基表中插入/删除数据，观察VProblemKeyword是否相应的发生变化

CREATE TABLE TResponse
(
	[Id] INT PRIMARY KEY IDENTITY (1,1),
	[Content]  NVARCHAR(500),
	[AuthorId] INT FOREIGN KEY REFERENCES TUser(Id),
	[ProblemId] INT FOREIGN KEY REFERENCES TProblem(ID),
	[Create Time] DATETIME
)



INSERT TResponse (Content,AuthorId,ProblemId,[Create Time])
VALUES (N'牛批',16,6,2019-6-5)

ALTER VIEW VResponse WITH SCHEMABINDING,ENCRYPTION   AS
SELECT tre.Id rid,tre.Content rcon,AuthorId,tpr.Author,tpr.ID ProblemId,tpr.Title,tpr.PublishDateTime,u.UserName
FROM dbo.TResponse tre 
JOIN dbo.Tproblem tpr ON tre.ProblemId =tpr.ID
JOIN TUser u ON tpr.Author =u.ID
WHERE tpr.Reward >5

SELECT *FROM VResponse

INSERT VResponse  (rcon,AuthorId,Author,ProblemId,Title,PublishDateTime)
VALUES (N'主外键关系',16,16,7,N'数据库',2019-3-2)

CREATE VIEW VResponse   AS
SELECT tre.Id rid,tre.Content rcon,AuthorName,tpr.Author,tpr.ID ProblemId,tpr.Title,tpr.PublishDateTime
FROM dbo.TResponse tre JOIN dbo.Tproblem tpr
ON tre.ProblemId =tpr.ID
WHERE tpr.Reward >5



 --创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，要求该视图：
 ----       能反映求助的标题、使用关键字数量和悬赏

ALTER VIEW VProblemKeyword WITH SCHEMABINDING AS
SELECT tpr.ID pid ,tpr.Title ptitle ,tpr.Reward preward,TimeInner.KeyTime KeyTime
FROM  (SELECT 	ProblemId, COUNT_BIG (KeywordId)  KeyTime
FROM dbo.TKeyword_Problem  tkp
GROUP BY ProblemId) TimeInner JOIN dbo.Tproblem  tpr
ON  TimeInner.ProblemId = tpr.ID


SELECT
* FROM
VProblemKeyword

CREATE UNIQUE CLUSTERED  INDEX Uni_Clu_PId  ON VProblemKeyword(pid)


ALTER VIEW VProblemKeyword WITH SCHEMABINDING AS
SELECT p.Author ,COUNT_BIG (*) CountKey,kp.ProblemId ,p.Title,p.Reward
FROM dbo.Tproblem p JOIN dbo.TKeyword_Problem kp 
ON p.ID =kp.ProblemId
GROUP BY p.Author,kp.ProblemId,p.Title,p.Reward

CREATE UNIQUE CLUSTERED  INDEX Uni_Clu_PId  ON VProblemKeyword(ProblemId)

CREATE  NONCLUSTERED  INDEX NoClu_Rew  ON VProblemKeyword(Reward)

INSERT Tproblem (Author,NeedRemoteHelp,Reward,ID) VALUES (16,1,23,13)
