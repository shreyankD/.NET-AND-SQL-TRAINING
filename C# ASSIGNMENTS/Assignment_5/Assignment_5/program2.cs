<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class program2
    {
        static int countsofletter(string inputString, char letter)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string: ");
            string inputstring = Console.ReadLine();

            Console.WriteLine("enter the letter to find its occurrence: ");
            char letter = Console.ReadLine()[0];

            int result = countsofletter(inputstring, letter);
            Console.WriteLine("the no. of occurrence of the given letter in the string is: "+ result);
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

namespace Assignment_5
{
    class program2
    {
        static int countsofletter(string inputString, char letter)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string: ");
            string inputstring = Console.ReadLine();

            Console.WriteLine("enter the letter to find its occurrence: ");
            char letter = Console.ReadLine()[0];

            int result = countsofletter(inputstring, letter);
            Console.WriteLine("the no. of occurrence of the given letter in the string is: "+ result);
            Console.ReadLine();

        }
    }
}
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
