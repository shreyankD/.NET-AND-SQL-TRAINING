create database SQL_Assignment_2
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
---------------------------------------------------------------------------
--QUERIES--

--1. List all employees whose name begins with 'A'. 
SELECT * FROM EMP
WHERE ename LIKE 'A%';

--2. Select all those employees who don't have a manager. 
SELECT * FROM EMP
WHERE mgr_id IS NULL;

--3. List employee name, number, and salary for those employees who earn in the range 1200 to 1400:
SELECT ename, empno, sal FROM EMP
WHERE sal BETWEEN 1200 AND 1400;

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise:

SELECT * FROM EMP
WHERE deptno = 20;

UPDATE EMP
SET sal = sal * 1.10
WHERE deptno = 20;

SELECT *FROM EMP
WHERE deptno = 20;

--5. Find the number of CLERKS employed. Give it a descriptive heading:

SELECT COUNT(*) AS " CLERKS PRESENT IN DATABASE " FROM EMP
WHERE job = 'CLERK';

--6. Find the average salary for each job type and the number of people employed in each job:

SELECT job, AVG(sal) AS "Avg Salary", COUNT(*) AS "Number of people employed" FROM EMP
GROUP BY job;

--7. List the employees with the lowest and highest salary:

SELECT *FROM EMP
WHERE sal IN (SELECT MIN(sal) FROM EMP)
   OR sal IN (SELECT MAX(sal) FROM EMP);

--8.List full details of departments that don't have any employees:

SELECT *FROM DEPT
WHERE deptno NOT IN (SELECT DISTINCT deptno FROM EMP);

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20.Sort the answer by ascending order of name:

SELECT ename, sal FROM EMP
WHERE job = 'ANALYST' AND sal > 1200 AND deptno = 20
ORDER BY ename ASC;

--10. For each department, list its name and number together with the total salary paid to employees in that department:

SELECT d.dname, d.deptno, SUM(e.sal) AS "Total Salary" FROM DEPT d
LEFT JOIN EMP e ON d.deptno = e.deptno
GROUP BY d.dname, d.deptno;

--11. Find out salary of both MILLER and SMITH:

SELECT ename, sal FROM EMP
WHERE ename IN ('MILLER', 'SMITH');

--12. Find out the names of the employees whose name begins with ‘A’ or ‘M’:

SELECT ename FROM EMP
WHERE ename LIKE 'A%' OR ename LIKE 'M%';

--13.Compute yearly salary of SMITH:

SELECT ename, sal * 12 AS "Yearly Salary" FROM EMP
WHERE ename = 'SMITH';

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850:

SELECT ename, sal FROM EMP
WHERE sal NOT BETWEEN 1500 AND 2850;

--15. Find all managers who have more than 2 employees reporting to them:

SELECT e.ename AS "Manager Name" FROM EMP e
JOIN (SELECT mgr_id, COUNT(*) AS emp_count
      FROM EMP
      GROUP BY mgr_id
      HAVING COUNT(*) > 2) m ON e.empno = m.mgr_id;