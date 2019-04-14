


--CREATE TABLE  Texperiment
--(
--  [Id] INT Not Null IDENTITY (1,1),
--  [Author] NVARCHAR(20) Not Null,
--  [Content] NVARCHAR(50) Not Null,
--  [Reward] INT Not Null
--)

--INSERT INTO Texperiment  (Author,Content,Reward) VALUES 
--( N'路炜',N'一曲肝肠断，天涯何处觅知音',N'666' )


--insert into Texperiment(Author,Content,Reward) 
--select Author,Content,Reward from Texperiment

CREATE  CLUSTERED INDEX Non_CLU_Id  ON  Texperiment (Id)


CHECKPOINT              -- 将所有内存（memory）中的数据写到磁盘（disk）
GO
DBCC DROPCLEANBUFFERS   -- 清除所有缓存
GO
SET STATISTICS IO ON
SELECT *FROM Texperiment
WHERE Id =2
SET STATISTICS IO OFF

DBCC TRACEON(2588)
DBCC HELP ('IND')
DBCC IND (_17bang,Texperiment,-1)

DBCC TRACEON(3604)
--（pageFID:pagePID）=(1:392)
DBCC PAGE(_17bang,1,3986,1)

ALTER TABLE Texperiment
ADD CONSTRAINT  PK_Id PRIMARY KEY (Id)

ALTER DATABASE _17bang SET AUTO_UPDATE_STATISTICS OFF
