<<<<<<< HEAD
Create Database SQL_Assignment_5
use SQL_Assignment_2

-- Creating procedure
create procedure Payslips
@EmployeeID int
as
begin
    declare @EmployeeName varchar(255)
    declare @Sal int
    declare @HRA int
    declare @DA int
    declare @PF int
    declare @IT int
    declare @Deductions int
    declare @GrossSalary int
    declare @NetSalary int

-- fetching employee details
select @EmployeeName = Ename, @Sal = Sal
from emp
where EmpNo = @EmployeeID

-- Calculate HRA, DA, PF, IT
set @HRA = @Sal * 0.10
set @DA = @Sal * 0.20
set @PF = @Sal * 0.08
set @IT = @Sal * 0.05

-- Calculate Deductions
set @Deductions = @PF + @IT

-- Calculate Gross Salary
set @GrossSalary = @Sal + @HRA + @DA

-- Calculate Net Salary
set @NetSalary = @GrossSalary - @Deductions

-- Print the payslip
print 'Employee Name: ' + @EmployeeName
print 'Salary: ' + cast (@Sal as varchar (80))
print 'HRA: ' + cast (@HRA as varchar (30))
print 'DA: ' + cast (@DA as varchar (100))
print 'PF: ' + cast (@PF as varchar (100))
print 'IT: ' + cast (@IT as varchar (100))
print 'Deductions: ' + cast (@Deductions as varchar (100))
print 'Gross Sal: ' + cast (@GrossSalary as varchar (100))
print 'Net Sal: ' + cast (@NetSalary as varchar (100))
end
-- Execute the procedure to generate a payslip for employee with EmpNo 7902
exec Payslips @EmployeeID = 7521
=======
Create Database SQL_Assignment_5
use SQL_Assignment_2

-- Creating procedure
create procedure Payslips
@EmployeeID int
as
begin
    declare @EmployeeName varchar(255)
    declare @Sal int
    declare @HRA int
    declare @DA int
    declare @PF int
    declare @IT int
    declare @Deductions int
    declare @GrossSalary int
    declare @NetSalary int

-- fetching employee details
select @EmployeeName = Ename, @Sal = Sal
from emp
where EmpNo = @EmployeeID

-- Calculate HRA, DA, PF, IT
set @HRA = @Sal * 0.10
set @DA = @Sal * 0.20
set @PF = @Sal * 0.08
set @IT = @Sal * 0.05

-- Calculate Deductions
set @Deductions = @PF + @IT

-- Calculate Gross Salary
set @GrossSalary = @Sal + @HRA + @DA

-- Calculate Net Salary
set @NetSalary = @GrossSalary - @Deductions

-- Print the payslip
print 'Employee Name: ' + @EmployeeName
print 'Salary: ' + cast (@Sal as varchar (80))
print 'HRA: ' + cast (@HRA as varchar (30))
print 'DA: ' + cast (@DA as varchar (100))
print 'PF: ' + cast (@PF as varchar (100))
print 'IT: ' + cast (@IT as varchar (100))
print 'Deductions: ' + cast (@Deductions as varchar (100))
print 'Gross Sal: ' + cast (@GrossSalary as varchar (100))
print 'Net Sal: ' + cast (@NetSalary as varchar (100))
end
-- Execute the procedure to generate a payslip for employee with EmpNo 7902
exec Payslips @EmployeeID = 7521
>>>>>>> 775706dc89fb3225aeeaedcf262edbfb46273c5a
