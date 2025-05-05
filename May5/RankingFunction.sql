SELECT
    Name,
	Department,
	Salary,
	ROW_NUMBER() OVER(PARTITION BY Department ORDER BY Salary DESC) AS RowNum
FROM Employees;