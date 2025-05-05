 --1. Convert student names to uppercase

SELECT FirstName, UPPER(FirstName) AS UpperName FROM Students;

-- 2. Get age of each student

SELECT FirstName, DATEDIFF(YEAR, DOB, GETDATE()) AS Age FROM Students;

----3. Round off salary to 1000

SELECT Name, Round(Salary, -3) AS RoundedSalary FROM Employees;