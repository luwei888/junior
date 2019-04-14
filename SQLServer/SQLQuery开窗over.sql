

--尽可能多的写出“查找每个用户关键字最多的求助” 的SQL语句，
--利用执行计划，找出效率最高的一个。

CREATE TABLE #Temp
(
    Problem INT,
    KeyTime INT,
    Author INT
)

insert into #Temp 
SELECT  ProblemId,Keytime,Author
FROM 
(SELECT 	ProblemId, COUNT (KeywordId)  KeyTime
FROM TKeyword_Problem  tkp
GROUP BY ProblemId) TimeInner  JOIN Tproblem  tpr
ON  TimeInner.ProblemId = tpr.ID
ORDER BY KeyTime DESC

SELECT *
FROM #Temp

SELECT 
* FROM Tproblem
WHERE ID IN(
select btem.Problem from
(select #Temp.*,row_number() over (partition by Author order by KeyTime desc) rn 
from #Temp) btem
where rn=1)