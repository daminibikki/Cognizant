USE AdvancedSQL;

CREATE TABLE Students(
    Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Marks INT
);

INSERT INTO Students VALUES
(1,'Monika',90),
(2,'Meghana',85),
(3,'Sai',95);


-- Create Index

CREATE INDEX idx_student_name
ON Students(Name);


-- Using Index Column

SELECT *
FROM Students
WHERE Name='Monika';