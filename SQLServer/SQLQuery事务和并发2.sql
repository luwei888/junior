-- 作业：
--重复演示各种并发问题，解释/显示锁能否应对上述问题。 

-- 并发的问题
--丢失的更新：多个事务对同一数据进行操作，后更新会覆盖之前的更新
--脏读：读取了事务提交中的数据，但随后事务回滚，数据被删，读到的是“脏”数据。
--不可重复读：因为其中一次查询发生在事务之中，随后事务提交，两次查询结果不一致
--幻影读：类似于“不可重复读”，但两次查询不一样的是范围（事务中发生了删除/插入）
--注意：一个session（query）里的操作不是并发。 

--查看工具：
--    EXEC sp_lock
--    sys.dm_tran_locks
--锁类型：
--    S：共享锁：用于只读的SELECT。加锁之后其他用户不能修改，可避免幻影读和不可重复读。为了演示，
--		使用WITH(HOLDLOCK)让锁一直保持到事务结束
--    X：独占锁（排他）：用于INSERT/UPDATE/DELET。加锁之后其他用户不能读。
--    U：更新锁：在UPDATE/DELET之前需要查找，在这个查找的过程中使用的就是U-LOCK；
--		一旦查找到需要的数据，U-LOCK就转变成X-LOCK
--    I：意向锁：在需要加锁节点的上一级加上“意向锁”，可以提高锁查找的性能。
--		比如在需要在某一行上加X锁，就可以在KEY的上一级PAGE（甚至是TABLE级）加IX意向锁，
--		这样当另一个用户想要在这张表上加锁的时候，就不需要全表扫描直到加X锁的行……

--1.共享锁
BEGIN TRAN
SELECT Reward
FROM Tproblem
WHERE ID =6

--2.独占锁
BEGIN TRAN
UPDATE Tproblem SET Reward =Reward+15 WHERE Id =6


COMMIT 

EXEC sp_lock

SELECT  resource_database_id,request_type,
request_status,request_mode,request_session_id
FROM sys.dm_tran_locks			