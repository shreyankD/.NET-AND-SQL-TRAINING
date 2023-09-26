using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program1
    {
        public static void Display()
        {
            Console.WriteLine("enter your first name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string Lastname = Console.ReadLine();
            Console.WriteLine(firstname.ToUpper() + "\n" + Lastname.ToUpper());
        }
         static void Main(string[] args)
        {

                Display();
                Console.ReadLine();
        }
    }
}
