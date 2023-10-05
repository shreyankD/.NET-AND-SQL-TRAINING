﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEBASED_4
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
    }

    class Program3
    {
        static void Main(string[] args)
        {
          
            List<Employee> empList = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.Parse("16/11/1984"), DOJ = DateTime.Parse("8/6/2011"), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = DateTime.Parse("20/08/1984"), DOJ = DateTime.Parse("7/7/2012"), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.Parse("14/11/1987"), DOJ = DateTime.Parse("12/4/2015"), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("3/6/1990"), DOJ = DateTime.Parse("2/2/2016"), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("8/3/1991"), DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("7/11/1989"), DOJ = DateTime.Parse("8/8/2014"), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.Parse("2/12/1989"), DOJ = DateTime.Parse("1/6/2015"), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"), DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.Parse("12/8/1992"), DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("12/4/1991"), DOJ = DateTime.Parse("2/1/2016"), City = "Pune" }
        };

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            // QUERY 1
            Console.WriteLine("A.QUERY 1:");
            Console.WriteLine("Details of all employees:");
            foreach (var emp in empList)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            // QUERY 2
            Console.WriteLine("B.QUERY 2:");
            Console.WriteLine("\n.employees details whose location is not Mumbai:");
            var employeesNotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            foreach (var emp in employeesNotInMumbai)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");


            // QUERY 3
            Console.WriteLine("C.QUERY 3:");
            Console.WriteLine("\nc.employees details whose title is AsstManager:");
            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");


            // QUERY 4
            Console.WriteLine("D.QUERY 4:");
            Console.WriteLine("\nd.employees details whose Last Name starts with S:");
            var employeesWithLastNameStartingWithS = empList.Where(emp => emp.LastName.StartsWith("S", StringComparison.OrdinalIgnoreCase));
            foreach (var emp in employeesWithLastNameStartingWithS)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
                Console.ReadLine();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

        }
    }
}