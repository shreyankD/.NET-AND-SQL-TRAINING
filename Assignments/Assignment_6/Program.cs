using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_6;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)

        {

            Console.Write("Enter Name: ");

            string name = Console.ReadLine();



            Console.Write("Enter Age: ");

            int age = int.Parse(Console.ReadLine());



            Concession concession = new Concession

            {

                Name = name,

                Age = age

            };



            concession.CalculateConcession();
            Console.ReadLine();

        }


    }
}









  