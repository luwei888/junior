-- 作业：

--为求助添加一个发布时间（TPublishTime），使用子查询：

--    删除每个作者悬赏最低的求助
--    找到从未成为邀请人的用户
--    如果一篇求助的关键字大于3个，将它的悬赏值翻倍
--    查出所有发布一篇以上（不含一篇）文章的用户信息
--    查找每个作者最近发布的一篇文章
--    查出每一篇求助的悬赏都大于5个帮帮币的作者




--USE master 
--GO
--BACKUP DATABASE _17bang TO DISK = 'E:\SQL_BackUp\17bang.bak'

--CREATE TABLE TKeyword_Problem
--(
--  [KeywordId] INT FOREIGN KEY REFERENCES Tkeyword (Id),
--  [PeoblemId] INT FOREIGN KEY REFERENCES TProblem (Id)
--)



DELETE Tproblem WHERE Reward =(SELECT MIN(Reward) FROM Tproblem r 
WHERE Author =r.Author  GROUP BY Author)


SELECT UserName FROM TUser
WHERE ID NOT IN(SELECT InviteID FROM  TUser WHERE InviteID IS Not Null )  


--SELECT * FROM Tproblem
UPDATE Tproblem SET Reward =Reward*2
WHERE Id IN
(SELECT ProblemId
FROM TKeyword_Problem
GROUP BY ProblemId
HAVING COUNT(ProblemId)>3
)

SELECT *FROM TProfile
WHERE Id IN
(
SELECT Author
FROM Tproblem
GROUP BY Author
HAVING COUNT(Author)>1
)

SELECT 
*FROM Tproblem opr
WHERE PublishDateTime IN
(
  SELECT MAX(PublishDateTime)
  FROM Tproblem ipr
  WHERE opr.Author =ipr.Author
  GROUP BY Author
)

SELECT Author
FROM Tproblem
GROUP BY Author
HAVING MIN(Reward)>5

SELECT *
FROM TProblem B
WHERE PublishDateTime = (SELECT MAX(PublishDateTime)
FROM TProblem A
WHERE A.Author=B.Author)


