BEGIN TRANSACTION;

DELETE FROM Students WHERE Marks < 60;

-- Realized its a mistake!
ROLLBACK;