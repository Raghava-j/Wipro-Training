--7. Grade students based on marks
SELECT FirstName, Marks,
   CASE
       WHEN Marks >= 90 THEN 'A'
	   WHEN Marks >= 75 THEN 'B'
	   WHEN Marks >= 60 THEN 'C'
	   ELSE 'D'
	END AS Grade
FROM Students;

-- 8. Categorize employees by salary
SELECT Name, Salary,
   CASE 
       WHEN Salary >= 70000 THEN 'High'
	   WHEN Salary >= 50000 THEN 'Medium'
	   ELSE 'Low'
	END AS SalaryBand
FROM Employees;