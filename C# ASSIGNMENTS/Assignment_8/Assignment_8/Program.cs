<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Shape Type :");
            string typesofshape = Console.ReadLine().ToLower();

            IShapes cc = ShapeFactory.GetShapes(typesofshape);


            if (cc != null)
            {
                Console.WriteLine("Area is : {0}", cc.GetArea());
                Console.WriteLine("Circumference is : {0}", cc.GetCircumference());
             
            }
            else
            {
                Console.WriteLine("Invalid shapes.. please give correct type");
            }
            Console.Read();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Shape Type :");
            string typesofshape = Console.ReadLine().ToLower();

            IShapes cc = ShapeFactory.GetShapes(typesofshape);


            if (cc != null)
            {
                Console.WriteLine("Area is : {0}", cc.GetArea());
                Console.WriteLine("Circumference is : {0}", cc.GetCircumference());
             
            }
            else
            {
                Console.WriteLine("Invalid shapes.. please give correct type");
            }
            Console.Read();
        }
    }
}
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
