using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASE_STUDY_1
{
    class Student

    {

        public int id;
        public string name;
        private DateTime dateOfBirth;
        public Student(int id, string name, DateTime dateOfBirth)

        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }

        public int Id
        {
            get {return id;}
            set {id = value;}
        }

        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        public DateTime DateOfBirth

        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

    }

    class Info
    {
        public void Display(Student student)
        {
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"DOB: {student.DateOfBirth.ToShortDateString()}");
            Console.WriteLine();
        }
    }

    class App
    {
        static void Main()
        {
            Info info = new Info();

            void Scenario1()
            {
                Student student1 = new Student(101, "shreyank", new DateTime(2001, 5, 29));
                Student student2 = new Student(2, "shreyas", new DateTime(2001, 8, 25));

                info.Display(student1);
                info.Display(student2);
            }

            void Scenario2()
            {
                Student[] students = new Student[2];

                students[0] = new Student(3, "Vivek", new DateTime(2001, 10, 5));
                students[1] = new Student(4, "Vinod", new DateTime(2000, 6, 1));

                foreach (Student student in students)
                {
                    info.Display(student);
                }
            }

            Console.WriteLine("Scenario 1:");
            Scenario1();

            Console.WriteLine("Scenario 2:");
            Scenario2();

            Console.ReadLine();
        }
    }
}
