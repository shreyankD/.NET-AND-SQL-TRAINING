//Second program
using System;

class Program2
{
    public static void Main()
    {
        int[] marks = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter mark {0}: ", i + 1);
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

       
        int total = 0;
        foreach (int mark in marks)
        {
            total += mark;
        }
        Console.WriteLine("Total: " + total);
        Console.ReadLine();

        double average = (double)total / 10;
        Console.WriteLine("Average: " + average);
        Console.ReadLine();

     
        int min = marks[0];
        foreach (int mark in marks)
        {
            if (mark < min)
            {
                min = mark;
            }
        }
        Console.WriteLine("Minimum marks: " + min);
        Console.ReadLine();
       
        int max = marks[0];
        foreach (int mark in marks)
        {
            if (mark > max)
            {
                max = mark;
            }
        }
        Console.WriteLine("Maximum marks: " + max);
        Console.ReadLine();

        
        Array.Sort(marks);
        Console.WriteLine("Marks in ascending order:");
        Console.ReadLine();
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
            Console.ReadLine();
        }
        Console.WriteLine();

       
        Array.Reverse(marks);
        Console.WriteLine("Marks in descending order:");
        Console.ReadLine();
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
            Console.ReadLine();
        }
        Console.WriteLine();
    }
}