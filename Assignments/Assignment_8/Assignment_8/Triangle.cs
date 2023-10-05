using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFactory
{
    class Triangle : IShapes
    {
        double b;
        double h;
       public Triangle()
        {
            // Constructor to get input from the user for Base and Height
            Console.WriteLine("Enter the Base of Triangle");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Height Of Triangle");
            h = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return (b * h) / 2;
        }

        public double GetCircumference()
        {
            throw new NotImplementedException();
        }
    }
}
