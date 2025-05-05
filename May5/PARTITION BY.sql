SELECT 
    Name,
	Department,
	Salary,
	AVG(Salary) OVER(PARTITION BY Department) AS DeptAvgSalary
FROM Employees;