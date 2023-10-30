create database CODEBASED_5

---QUESTION 1

--Create a book table with id as primary key and provide the appropriate data type to other attributes .isbn no should be unique for each book.

CREATE TABLE books(
    id INT PRIMARY KEY,
    title VARCHAR(100),
    author VARCHAR(100),
    isbn VARCHAR(15) UNIQUE,
    published_date DATETIME
);

CREATE TABLE reviews (
    id INT PRIMARY KEY,
    book_id INT,
    reviewer_name VARCHAR(255),
    content VARCHAR(100),
    rating INT,
    published_date DATETIME
);

INSERT INTO books (id,title, author, isbn, published_date)
VALUES (1,'My First SQL book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
       (2,'My Second SQL book', 'John Mayer', '857300923713', '1972-07-03 09:22:45'),
       (3,'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');


INSERT INTO reviews (id, book_id, reviewer_name, content, rating, published_date)
VALUES (11, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11.1'),
       (22, 3, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12.6'),
       (32, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10');


--QUERY 1- Write a query to fetch the details of the books written by author whose name ends with er.
SELECT * FROM books
WHERE author LIKE '%er';

--QUERY-2 - Display the Title ,Author and ReviewerName for all the books from the above table.
SELECT books.title, books.author,reviews.reviewer_name FROM books
INNER JOIN reviews ON books.id =reviews.book_id;
---------------------------------------------------------------------------------------------------------

--QUESTION 2

--QUERY 3- Display the  reviewer name who reviewed more than one book.
SELECT reviewer_name FROM reviews
GROUP BY reviewer_name
HAVING COUNT(DISTINCT book_id) > 1;
---------------------------------------------------------------------------------------------------------

-- QUESTION 3

CREATE TABLE CUSTOMERS (
   ID INT PRIMARY KEY,
   NAME VARCHAR(50),
   AGE INT,
   ADDRESS VARCHAR(100),
   SALARY DECIMAL(7, 2)
);

INSERT INTO CUSTOMERS (ID, NAME, AGE, ADDRESS, SALARY)
VALUES (1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
 (2, 'Khilan', 25, 'Delhi', 1500.00),
 (3, 'Kaushik', 23, 'Kota', 2000.00),
 (4, 'Chaitali', 25, 'Mumbai', 6500.00),
 (5, 'Hardik', 27, 'Bhopal', 8500.00),
 (6, 'Komal', 22, 'MP', 4500.00),
 (7, 'Muffy', 24, 'Indore', 10000.00);

 --QUERY 4 -Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
 SELECT NAME FROM CUSTOMERS
 WHERE ADDRESS LIKE '%o%';
 --------------------------------------------------------------------------------------------------------------------

--QUESTION 4

CREATE TABLE CUSTOMERS (
   ID INT PRIMARY KEY,
   NAME VARCHAR(50),
   AGE INT,
   ADDRESS VARCHAR(100),
   SALARY DECIMAL(7, 2)
);

CREATE TABLE ORDERS (
 OID INT PRIMARY KEY,
 DATE DATE,
 CUSTOMER_ID INT,
 AMOUNT int
);

INSERT INTO CUSTOMERS (ID, NAME, AGE, ADDRESS, SALARY)
VALUES (1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
 (2, 'Khilan', 25, 'Delhi', 1500.00),
 (3, 'Kaushik', 23, 'Kota', 2000.00),
 (4, 'Chaitali', 25, 'Mumbai', 6500.00),
 (5, 'Hardik', 27, 'Bhopal', 8500.00),
 (6, 'Komal', 22, 'MP', 4500.00),
 (7, 'Muffy', 24, 'Indore', 10000.00);
 
INSERT INTO ORDERS (OID, DATE, CUSTOMER_ID, AMOUNT)
VALUES (102, '2009-10-08', 3, 3000.00),
       (100, '2009-10-08', 3, 1500.00),
       (101, '2009-11-20', 2, 1560.00),
       (103, '2008-05-20', 4, 2060.00);

	   
--QUERY 5 Write a query to display the Date,Total no of customer  placed order on same Date 

 SELECT DATE, COUNT(DISTINCT CUSTOMER_ID) AS total_customers FROM ORDERS
 GROUP BY DATE HAVING COUNT(DISTINCT CUSTOMER_ID)>1

------------------------------------------------------------------------------------
--QUESTION 5

   CREATE TABLE EMPLOYEES(
   ID INT PRIMARY KEY,
   NAME VARCHAR(50),
   AGE INT,
   ADDRESS VARCHAR(100),
   SALARY DECIMAL(7, 2)
);


INSERT INTO EMPLOYEES (ID, NAME, AGE, ADDRESS, SALARY)
VALUES (1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
 (2, 'Khilan', 25, 'Delhi', 1500.00),
 (3, 'Kaushik', 23, 'Kota', 2000.00),
 (4, 'Chaitali', 25, 'Mumbai', 6500.00),
 (5, 'Hardik', 27, 'Bhopal', 8500.00),
 (6, 'KOMAL', 22, 'MP', NULL),
 (7, 'MUFFY', 24, 'Indore', NULL);


 --QUERY 6 -Display the Names of the Employee in lower case, whose salary is null 
 SELECT LOWER(NAME) AS lowercase FROM EMPLOYEES
 WHERE SALARY IS NULL;



CREATE TABLE students (
RegisterNo int,
Name varchar(25),
Age int,
Qualification varchar(20),
MobileNo varchar(10),
Mail_id varchar(30),
Location varchar(50),
Gender varchar(2)
);
 

INSERT INTO students (RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location,Gender) 
VALUES (2, 'Sai', 22, 'BE', '9952836777', 'Sai@gmai.com', 'Chennai','M'),
       (3, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai','M'),
       (4, 'Selvi', 22, 'B. Tech', '8904567342', 'selvi@gnai.com', 'Salem','F'),
       (5, 'Nisha', 25, 'M.E', '7834672310', 'nisha@gmail.com', 'Theni','F'),
       (6, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmai.com', 'Madurai','M'),
       (7, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune','M');


 --QUERY 7 -Write a sql server query to display the Gender,Total no of male and female from the above  relation    .
 SELECT ISNULL(Gender,'Not Assigned') AS Gender, COUNT(RegisterNo) AS 'total' FROM students
 GROUP BY Gender;

