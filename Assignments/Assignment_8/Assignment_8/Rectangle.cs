using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
   
    class Rectangle : IShapes
    {
        double LENGTH;
        double BREADTH;

       public Rectangle()
        {
            Console.WriteLine("Enter the Length of Rectangle:");
            LENGTH = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Breadth of Rectangle:");
            BREADTH= Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return LENGTH*BREADTH;
        }

        public double GetCircumference()
        {
            return 2 * (LENGTH + BREADTH);
        }
    }
}
