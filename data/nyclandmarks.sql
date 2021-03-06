/*
TRUNCATE TABLE [dbo].[LPCReport]
TRUNCATE TABLE [dbo].[Landmark]

ALTER TABLE [dbo].[Landmark] 
DROP CONSTRAINT FK_Landmark_LPCReport

*/

SELECT Name, Street, * FROM [dbo].[LPCReport]
WHERE Borough = 'Queens'

SELECT DISTINCT [Style] FROM [dbo].[LPCReport]

SELECT [Style], Count ([Style]) FROM [dbo].[LPCReport]
GROUP BY [Style]
ORDER BY Count ([Style]) DESC



SELECT LEN( [Style]) FROM [dbo].[LPCReport]
GROUP BY [Style]
ORDER BY LEN( [Style]) DESC


SELECT * FROM [dbo].[Landmark]


SELECT * FROM [dbo].[LPCReport] r
INNER JOIN [dbo].[Landmark] l on r.LPNumber = l.LP_NUMBER
WHERE r.LPNumber = 'LP-00871'

SELECT l.LP_NUMBER, l.LM_NAME, l.STATUS,  * FROM [dbo].[LPCReport] r
RIGHT JOIN [dbo].[Landmark] l on r.LPNumber = l.LP_NUMBER
WHERE r.LPNumber IS NULL


SELECT r.LPNumber, Count(*) FROM [dbo].[LPCReport] r
INNER JOIN [dbo].[Landmark] l on r.LPNumber = l.LP_NUMBER
GROUP BY r.LPNumber
HAVING COUNT(*) = 4



SELECT * FROM [LPCReport] 
ORDER BY Id
OFFSET (0) ROWS FETCH NEXT (20) ROWS ONLY





