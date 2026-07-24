CREATE DATABASE AdvancedSQL;
USE AdvancedSQL;

CREATE TABLE Employees(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT
);

INSERT INTO Employees VALUES
(1,'John','IT',50000),
(2,'David','IT',60000),
(3,'Sam','HR',45000),
(4,'Ram','HR',55000),
(5,'Mike','IT',70000);


-- ROW NUMBER
SELECT EmpName, Department, Salary,
ROW_NUMBER() OVER(
PARTITION BY Department 
ORDER BY Salary DESC
) AS RowNo
FROM Employees;


-- RANK
SELECT EmpName, Salary,
RANK() OVER(
ORDER BY Salary DESC
) AS Ranking
FROM Employees;


-- DENSE RANK
SELECT EmpName, Salary,
DENSE_RANK() OVER(
ORDER BY Salary DESC
) AS DenseRanking
FROM Employees;