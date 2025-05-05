BEGIN TRANSACTION;

UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpID = 1;

SAVE TRANSACTION IncreaseJohn;

UPDATE EmployeesSET Salary = Salary + 1000
WHERE EmpID =2;

-- Oops, rollback second increment only
RollBACK TRANSACTION IncreaseJohn;

COMMIT;