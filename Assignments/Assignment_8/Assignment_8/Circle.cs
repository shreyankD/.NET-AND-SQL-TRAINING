<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Circle : IShapes
    {
        double radius;
        public Circle()
        { 
            Console.WriteLine("Enter the Radius Of Circle");
            radius = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return 3.14 *  radius * radius;
        }

        public double GetCircumference()
        {
            return 2 * 3.14 * radius;
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
    class Circle : IShapes
    {
        double radius;
        public Circle()
        { 
            Console.WriteLine("Enter the Radius Of Circle");
            radius = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return 3.14 *  radius * radius;
        }

        public double GetCircumference()
        {
            return 2 * 3.14 * radius;
        }
    }
}
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
