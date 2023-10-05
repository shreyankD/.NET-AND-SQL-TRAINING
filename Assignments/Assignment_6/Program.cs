<<<<<<< HEAD
﻿using System;
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









=======
﻿using System;
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









>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
  