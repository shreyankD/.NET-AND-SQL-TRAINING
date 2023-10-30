<<<<<<< HEAD
create database SQL_Assignment_3

--a) creation of employment table 
CREATE TABLE EMP (
    empno INT PRIMARY KEY,
    ename VARCHAR(20),job VARCHAR(20),
    mgr_id INT,
    hiredate DATE,
    sal int,comm int,deptno int
	);

--b) creation of  table Department table
CREATE TABLE DEPT (
    deptno INT PRIMARY KEY,
    dname VARCHAR(30),loc VARCHAR(30)
);

------------------------------------------------------------------------------------
--a)Insert statements for employee table
INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES 
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);

--a)Insert statements for Department table

INSERT INTO DEPT (deptno, dname, loc)
VALUES 
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

-------------------------------------------------------------------------------
--Queries
--1. Retrieve a list of MANAGERS.
SELECT * FROM emp WHERE job = 'MANAGER';

--2.Find out the names and salaries of all employees earning more than 1000 per month.
SELECT ename, sal FROM emp WHERE sal > 1000;

--3.Display the names and salaries of all employees except JAMES.
SELECT ename, sal FROM emp WHERE ename != 'JAMES';

--4.Find out the details of employees whose names begin with ‘S’.
SELECT * FROM emp WHERE ename LIKE 'S%';

--5.Find out the names of all employees that have ‘A’ anywhere in their name. 
SELECT ename FROM emp WHERE ename LIKE '%A%';

--6.Find out the names of all employees that have ‘L’ as their third character in their name. 
SELECT * FROM emp WHERE ename LIKE '__L%';

--7.Compute daily salary of JONES.
SELECT ename, sal/31 AS daily_sal FROM emp WHERE ename = 'JONES';

--8.Calculate the total monthly salary of all employees.
SELECT SUM(sal) AS total_monthly_salary FROM emp;

--9.Print the average annual salary.
SELECT AVG(sal*12) AS average_annual_salary FROM emp;

--10.Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
SELECT ename, job, sal, deptno FROM emp 
WHERE NOT deptno = 30  AND job != 'SALESMAN';

--11.List unique departments of the EMP table.
SELECT DISTINCT dname FROM emp e,dept d where d.deptno = e.deptno ;

--12.List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
SELECT ename , sal FROM emp
WHERE sal > 1500 AND (deptno = 10 OR deptno = 30);

--13.Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
SELECT ename, job, sal FROM emp
WHERE (job = 'MANAGER' OR job = 'ANALYST') AND sal NOT IN (1000, 3000, 5000);

--14.Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
SELECT ename, sal, comm FROM emp
WHERE comm > sal * 0.1;

--15.Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
SELECT ename FROM emp
WHERE (ename LIKE '%L%L%' AND deptno = 30) OR mgr_id = 7782;

--16.Display the names of employees with experience of over 30 years and under 40 years. Count the total number of employees.
select ename from emp where datediff(year,hiredate,getdate())> 30 and datediff(year,hiredate,getdate())< 40


-------------16. Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 

select count(*) as "total no of emp", ename from emp where (2023-YEAR(hiredate))>30 and (2023-YEAR(hiredate))<40 group by ename


--17.Retrieve the names of departments in ascending order and their employees in descending order.
SELECT dname, ename FROM DEPT
JOIN emp ON dept.deptno = emp.deptno
ORDER BY dname ASC, ename DESC;

--18.Find out experience of MILLER.
select DATEDIFF(year, hiredate,getdate()) AS EXPERIENCE from emp 
where ename='miller';
=======
create database SQL_Assignment_3

--a) creation of employment table 
CREATE TABLE EMP (
    empno INT PRIMARY KEY,
    ename VARCHAR(20),job VARCHAR(20),
    mgr_id INT,
    hiredate DATE,
    sal int,comm int,deptno int
	);

--b) creation of  table Department table
CREATE TABLE DEPT (
    deptno INT PRIMARY KEY,
    dname VARCHAR(30),loc VARCHAR(30)
);

------------------------------------------------------------------------------------
--a)Insert statements for employee table
INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES 
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);

--a)Insert statements for Department table

INSERT INTO DEPT (deptno, dname, loc)
VALUES 
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

-------------------------------------------------------------------------------
--Queries
--1. Retrieve a list of MANAGERS.
SELECT * FROM emp WHERE job = 'MANAGER';

--2.Find out the names and salaries of all employees earning more than 1000 per month.
SELECT ename, sal FROM emp WHERE sal > 1000;

--3.Display the names and salaries of all employees except JAMES.
SELECT ename, sal FROM emp WHERE ename != 'JAMES';

--4.Find out the details of employees whose names begin with â€˜Sâ€™.
SELECT * FROM emp WHERE ename LIKE 'S%';

--5.Find out the names of all employees that have â€˜Aâ€™ anywhere in their name. 
SELECT ename FROM emp WHERE ename LIKE '%A%';

--6.Find out the names of all employees that have â€˜Lâ€™ as their third character in their name. 
SELECT * FROM emp WHERE ename LIKE '__L%';

--7.Compute daily salary of JONES.
SELECT ename, sal/31 AS daily_sal FROM emp WHERE ename = 'JONES';

--8.Calculate the total monthly salary of all employees.
SELECT SUM(sal) AS total_monthly_salary FROM emp;

--9.Print the average annual salary.
SELECT AVG(sal*12) AS average_annual_salary FROM emp;

--10.Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
SELECT ename, job, sal, deptno FROM emp 
WHERE NOT deptno = 30  AND job != 'SALESMAN';

--11.List unique departments of the EMP table.
SELECT DISTINCT dname FROM emp e,dept d where d.deptno = e.deptno ;

--12.List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
SELECT ename , sal FROM emp
WHERE sal > 1500 AND (deptno = 10 OR deptno = 30);

--13.Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
SELECT ename, job, sal FROM emp
WHERE (job = 'MANAGER' OR job = 'ANALYST') AND sal NOT IN (1000, 3000, 5000);

--14.Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
SELECT ename, sal, comm FROM emp
WHERE comm > sal * 0.1;

--15.Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
SELECT ename FROM emp
WHERE (ename LIKE '%L%L%' AND deptno = 30) OR mgr_id = 7782;

--16.Display the names of employees with experience of over 30 years and under 40 years. Count the total number of employees.
select ename from emp where datediff(year,hiredate,getdate())> 30 and datediff(year,hiredate,getdate())< 40
	
--17.Retrieve the names of departments in ascending order and their employees in descending order.
SELECT dname, ename FROM DEPT
JOIN emp ON dept.deptno = emp.deptno
ORDER BY dname ASC, ename DESC;

--18.Find out experience of MILLER.
select DATEDIFF(year, hiredate,getdate()) AS EXPERIENCE from emp 
where ename='miller';
>>>>>>> 775706dc89fb3225aeeaedcf262edbfb46273c5a
