
using System;

class Student
{
    private int rollno;
    private string name;
    private string Class;
    private int semester;
    private string branch;
    private int[] marks = new int[5];

    public Student(int rollno, string name, string Class, int semester, string branch)
    {
        this.rollno = rollno;
        this.name = name;
        this.Class = Class;
        this.semester = semester;
        this.branch = branch;
    }

    public void GetMarks()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter marks {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void DisplayResult()
    {
        double average = (marks[0] + marks[1] + marks[2] + marks[3] + marks[4]) / 5.0;

        bool failedSubject = false;
        foreach (int mark in marks)
        {
            if (mark < 35)
            {
                failedSubject = true;
                break;
            }
        }

        if (failedSubject || average < 50)
        {
            Console.WriteLine("Results-FAIL");
        }
        else
        {
            Console.WriteLine("Results-PASS");
        }

        Console.WriteLine($"Roll No: {rollno}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Class: {Class}");
        Console.WriteLine($"Semester: {semester}");
        Console.WriteLine($"Branch: {branch}");
        Console.WriteLine($"Marks: {string.Join(", ", marks)}");
        Console.WriteLine($"Average Marks: {average}");
        Console.ReadLine();
    }
}

class Program2
{
    static void Main()
    {
        Student student1 = new Student(1033404, "SHREYANK", "ISE=8B", 8, "CITECH");
        student1.GetMarks();
        student1.DisplayResult();
    }
}