-- 作业：

--新建表TMessage(Id, FromUser, ToUser, UrgentLevel, 
--Kind, HasRead, IsDelete, Content)，使用该表：

--    证明“唯一约束依赖于唯一索引”
--    证明“主键上可以是非聚集索引”
--    证明“SQL Server不会为外键自动添加索引


--CREATE TABLE TMessage 
--(
--  [Id] INT ,
--  [FromUser] INT ,
--  [ToUser] INT,
--  [UrgentLevel] INT,
--  [Kind] INT,
--  [HasRead] BIT,
--  [IsDelete] BIT,
--  [Content] INT,
--)

--    证明“唯一约束依赖于唯一索引”
ALTER TABLE TMessage
ADD  CONSTRAINT  UCON_Kind  UNIQUE(Kind)

SELECT [name], [type],  is_unique, is_primary_key, is_unique_constraint
FROM sys.indexes 
WHERE [name] = 'UCON_Kind'


 --证明“主键上可以是非聚集索引”

 ALTER TABLE TMessage 
ALTER COLUMN Id INT Not Null

CREATE   CLUSTERED	INDEX  [Clu_HasRead]		ON TMessage(HasRead)

ALTER TABLE TMessage
ADD CONSTRAINT PK_Message_Id PRIMARY KEY  (Id)

SELECT [name], [type],  is_unique, is_primary_key, is_unique_constraint
FROM sys.indexes 
WHERE [name] = 'PK_Message_Id'


--    证明“SQL Server不会为外键自动添加索引

ALTER TABLE TMessage
ADD CONSTRAINT FK_Message_FromUser FOREIGN KEY  (FromUser)  REFERENCES  TMessage(Id)

SELECT [name], [type],  is_unique, is_primary_key, is_unique_constraint
FROM sys.indexes 
WHERE [name] = 'FK_Message_FromUser'