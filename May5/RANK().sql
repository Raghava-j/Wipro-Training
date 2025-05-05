SELECT 
    Name,
	Salary,
	RANK() OVER(ORDER BY Salary DESC) AS RankBYSalary
FROM Employees;
