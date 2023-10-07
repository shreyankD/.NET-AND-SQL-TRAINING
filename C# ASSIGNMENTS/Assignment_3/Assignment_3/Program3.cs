<<<<<<< HEAD
﻿using System;

namespace program3
{
    class Program3
    {
        static void Main(string[] args)
        {
             twoString();
        }

        static void twoString()
        {
            Console.WriteLine("enter the first word");
            string word1 = Console.ReadLine();
            Console.WriteLine("enter the second word");
            string word2 = Console.ReadLine();

            bool equal = string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase);

            if (equal)
            {
                Console.WriteLine("the entered words are equal");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("the entered words are not equal");
                Console.ReadLine();
            }
            Console.
        }
    }
}



=======
﻿using System;

namespace program3
{
    class Program3
    {
        static void Main(string[] args)
        {
             twoString();
        }

        static void twoString()
        {
            Console.WriteLine("enter the first word");
            string word1 = Console.ReadLine();
            Console.WriteLine("enter the second word");
            string word2 = Console.ReadLine();

            bool equal = string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase);

            if (equal)
            {
                Console.WriteLine("the entered words are equal");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("the entered words are not equal");
                Console.ReadLine();
            }
            Console.
        }
    }
}



>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
