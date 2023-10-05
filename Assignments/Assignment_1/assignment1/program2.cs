//program2
using System;

class Program2
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());



        if (number > 0)
        {
            Console.WriteLine(number + " is a positive number");
            Console.ReadLine();
        }
        else if (number < 0)
        {
            Console.WriteLine(number + " is a negative number");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(number + " is neither positive nor negative");
            Console.ReadLine();
        }

    }
}

