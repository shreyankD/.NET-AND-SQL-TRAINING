using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEBASED_2
{

    abstract class Student

    {
        public string Name;
        public int StudentId;
        public double Grade;
        public abstract bool IsPassed(double grade);

    }

    class Undergraduate : Student

    {
        public override bool IsPassed(double grade)

        {
            return grade > 70.0;
        }
    }


    class Graduate : Student

    {
        public override bool IsPassed(double grade)

        {
            return grade > 80.0;
        }
    }


    class Program1

    {
        static void Main()
        {
            Console.WriteLine("Enter details for Undergraduate student:");

            Undergraduate undergradStudent = new Undergraduate

            {

                Name = GetInput("Name"),

                StudentId = int.Parse(GetInput("Student ID")),

                Grade = double.Parse(GetInput("Grade"))

            };



            Console.WriteLine($"Name: {undergradStudent.Name}");

            Console.WriteLine($"Student ID: {undergradStudent.StudentId}");

            Console.WriteLine($"Grade: {undergradStudent.Grade}");

            Console.WriteLine($"Passed: {undergradStudent.IsPassed(undergradStudent.Grade)}");

            Console.WriteLine();

            Console.WriteLine("Enter details for Graduate student:");

            Graduate gradStudent = new Graduate

            {

                Name = GetInput("Name"),

                StudentId = int.Parse(GetInput("Student ID")),

                Grade = double.Parse(GetInput("Grade"))
            };

            Console.WriteLine($"Name: {gradStudent.Name}");
            Console.WriteLine($"Student ID: {gradStudent.StudentId}");
            Console.WriteLine($"Grade: {gradStudent.Grade}");
            Console.WriteLine($"Passed: {gradStudent.IsPassed(gradStudent.Grade)}");
            Console.ReadLine();

        }

        static string GetInput(string prompt)

        {
            Console.Write($"Enter {prompt}: ");
            return Console.ReadLine();
        }

    }
}