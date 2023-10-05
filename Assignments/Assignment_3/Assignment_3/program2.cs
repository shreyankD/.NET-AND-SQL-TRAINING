using System;
using System.Text;
namespace program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string ");

            string userip = Console.ReadLine();

            string reverse = revstr(userip);
            Console.WriteLine($"reverse is {reverse}");
            Console.ReadLine();
        }

       
        static string revstr(string input)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }
    }
}
