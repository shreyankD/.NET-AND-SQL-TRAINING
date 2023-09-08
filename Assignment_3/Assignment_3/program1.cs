using System;
namespace program1
{
    class Program1
    {
        static void Main(string[] args)
        {
            length();
        }

        static void length()
        {
            Console.WriteLine("enter the string ");

            string userip = Console.ReadLine();

            double iplength = userip.Length;
            Console.WriteLine($"the length is {iplength}");
            Console.ReadLine();
        }
    }
}