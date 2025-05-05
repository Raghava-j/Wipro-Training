//Simple Transaction with Commit

BEING TRANSACTION;

UPDATE Employees
SET Salary = Salary + 2000
WHERE Department = 'IT';

COMMIT;