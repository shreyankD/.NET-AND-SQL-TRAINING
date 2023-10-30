--1.Write a T-SQL Program to find the factorial of a given number.
declare @num int
set @num = 3
 declare @factorial bigint
set @factorial=1
 while @num>1
begin
 set @factorial = @factorial*@num
 set @num = @num-1
end
select @factorial as 'Answer'


--2.Create a stored procedure to generate multiplication tables up to a given number.

create procedure tables
@num int
as 
begin 
declare @multi int =1

while @multi <= 10
begin
 declare @result int = @num * @multi
 print concat(@num,'x',@multi,'=',@result)
 set @multi = @multi +1
 end
end
--to execute
exec tables @num = 9;


<<<<<<< HEAD
--3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 
create table Holidays
(holiday_date Date Primary Key, holiday_name nvarchar(max));

INSERT INTO HOLIDAYs values
=======
--3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like â€œDue to Independence day you cannot manipulate dataâ€ or "Due To Diwali", you cannot manupulate" etc Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 
create table Holidays
(holiday_date Date Primary Key, holiday_name nvarchar(max));

INSERT INTO Holidays values
>>>>>>> 775706dc89fb3225aeeaedcf262edbfb46273c5a
('2023-02-30','Deepawali'),
('2023-08-12','Independence Day'),
('2023-03-30','Ramzan'),
('2023-12-25','Christmas'),
('2023-05-29','Gandhi jayanthi');

CREATE TRIGGER RestrictDataholiday
ON Emp
FOR INSERT, UPDATE, DELETE 
AS 
BEGIN     
DECLARE @Holiday_name VARCHAR(50), @holiday_date DATE
SET @holiday_date = CONVERT(DATE, GETDATE())
SELECT @Holiday_name = Holiday_name     
FROM Holidays     
WHERE holiday_date = @holiday_date 
IF @holiday_name IS NOT NULL     
BEGIN         
ROLLBACK TRANSACTION        
RAISERROR('Due to %s, you cannot manipulate data', 16, 1, @holiday_name)     
END 
END

select * from emp;

insert into emp values(7319,'SHREYANK', 'TRAINEE', 8900,'2001-05-29',9000,null,20)

 





