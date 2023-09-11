using System;

namespace CODEBASED_1
{
    class program2
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number}*{ i}={ result} ");
                Console.ReadLine();
            }
        }
    }
}
