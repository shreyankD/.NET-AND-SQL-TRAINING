using System;

namespace CODEBASED_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string inputString = Console.ReadLine();

            Console.WriteLine("enter the position");
            int position = Convert.ToInt32(Console.ReadLine());

            if (position >= 0 && position < inputString.Length)
            {
                string resultString = RemoveCharacter(inputString, position);
                Console.WriteLine("Result string: " + resultString);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("invalid position");
            }


        }

         static string RemoveCharacter(string input, int position)
        {
            return input.Remove(position, 1);
        }
    }
}

