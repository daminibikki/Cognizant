USE AdvancedSQL;


DELIMITER //

CREATE PROCEDURE GetEmployeeByDept(
IN dept VARCHAR(50)
)

BEGIN

SELECT EmpName, Salary
FROM Employees
WHERE Department = dept;

END //

DELIMITER ;