//program 1
using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter first digit:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter second digit:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine(" The two digits are equal:");
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine(" The two digits are not equal");
                Console.ReadLine();
            }
        }
    }

}

