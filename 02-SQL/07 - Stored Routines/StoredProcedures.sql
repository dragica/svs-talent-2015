-------------------------------------------------------------
-----------Stored Procedures Demo----------------------------

DELIMITER //
CREATE PROCEDURE GetAllStudents()
BEGIN
SELECT * FROM Student;
END //
DELIMITER ; 

CALL GetAllStudents()

----------- Parametrized Stored Procedure -------------------

DELIMITER //
CREATE PROCEDURE GetCollegeByState(IN countryName VARCHAR(255))
BEGIN
SELECT *
FROM college
WHERE state = countryName;
END //
DELIMITER ; 

CALL GetCollegeByState('CA')


--------------- IN and OUT Parameters ------------------------

DELIMITER $$
CREATE PROCEDURE CountCollegeByState(
IN State1 VARCHAR(25),
OUT total INT)
BEGIN
SELECT COUNT(cName)
INTO total
FROM college
WHERE State = State1;
END$$
DELIMITER ; 

CALL CountCollegeByState('CA', @total1);
SELECT @total1 AS Total;

------------------- Clean UP ---------------------------------

DROP PROCEDURE IF EXISTS CountCollegeByState;  
DROP PROCEDURE IF EXISTS GetCollegeByState;
DROP PROCEDURE IF EXISTS GetAllStudents;