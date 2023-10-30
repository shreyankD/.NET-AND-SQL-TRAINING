CREATE DATABASE CODEBASED_6;
<<<<<<< HEAD
=======
USE CODEBASED_6;
>>>>>>> 775706dc89fb3225aeeaedcf262edbfb46273c5a

--a. Create a table called Code_Employee(empno int primary key,
--   empname varchar(35), (is a required field)
--  empsal numeric(10,2) - (check empsal >=25000)
--  emptype char(1) ) (either 'F' for fulltime or 'P' part time) (Empty Table)


CREATE TABLE Code_Employees (
    empno int PRIMARY KEY,
    empname varchar(35),
    empsal decimal(10,2) NOT NULL CHECK (empsal > 0),
    emptype char(1) CHECK (emptype IN ('F', 'P'))
);

--b. Create a stored procedure to add new employee records. The procedure should accept all the employee details
--as input parameters, except empno. Generate the new employee no in the procedure and then insert the record

CREATE PROCEDURE AddEmployees
    @empno int,
    @empname varchar(35),
    @empsal decimal(10,2),
    @emptype char(1)
AS
BEGIN
    INSERT INTO Code_Employees(empno, empname, empsal, emptype)
    VALUES (@empno, @empname, @empsal, @emptype)
END;


EXEC AddEmployees 1001,'SHREYANK',18000.00,'F'
EXEC AddEmployees 1002,'Vivek',5001.00,'P'

--II. Write a Cursor program, that retrieves all the employees and updates salary for all employees of Department 10(Accounting) by 15%
use SQL_Assignment_2

 
DECLARE @empnum NUMERIC(5);
DECLARE @sal INT;
 

DECLARE employee_cursors CURSOR FOR
SELECT empno, sal
FROM emp
WHERE deptno = 10;


OPEN employee_cursors; 

FETCH NEXT FROM employee_cursors INTO @empnum, @sal; 

WHILE @@FETCH_STATUS = 0
BEGIN
 
UPDATE emp
SET sal = sal * 1.15
WHERE empno = @empnum; 

FETCH NEXT FROM employee_cursors INTO @empnum, @sal;
END
 

CLOSE employee_cursors;
DEALLOCATE employee_cursors; 

SELECT * FROM emp WHERE deptno = 10;

<<<<<<< HEAD
 
=======
 
>>>>>>> 775706dc89fb3225aeeaedcf262edbfb46273c5a
