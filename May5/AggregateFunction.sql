-- 4. Total number of students
SELECT COUNT(*) AS TotalStudents FROM Students;

-- 5. Average marks of all students
SELECT AVG(Marks) AS AverageMarks FROM Students;

--6. Highest salary in each department

SELECT Department, MAX(Salary) AS HighestSalary
FROM Employees GROUP BY Department;