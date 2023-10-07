<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Square : IShapes
    {
        double l; 
        public Square()
        {
            // Constructor to get input from the user for Length/Breadth
            Console.WriteLine("Enter the Length / Breadth of Sqaure");
            l =  double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return l * l;
        }

        public double GetCircumference()
        {
            return 4 * l;
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
    class Square : IShapes
    {
        double l; 
        public Square()
        {
            // Constructor to get input from the user for Length/Breadth
            Console.WriteLine("Enter the Length / Breadth of Sqaure");
            l =  double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return l * l;
        }

        public double GetCircumference()
        {
            return 4 * l;
        }
    }
}
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
