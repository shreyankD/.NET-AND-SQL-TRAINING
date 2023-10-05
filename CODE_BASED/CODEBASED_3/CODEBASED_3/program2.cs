
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEBASED_3
{
    class Box
    {
        public double Length;
        public double Breadth;

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public Box Sum(Box box)
        {
            double newLength = this.Length + box.Length;
            double newBreadth = this.Breadth + box.Breadth;

            return new Box(newLength, newBreadth);
        }

        public void Display()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }

    class Test
    {
        static void Main()
        {
            Box box1 = new Box(35.78, 90.5);
            Box box2 = new Box(87.334, 50.6);

            Box box3 = box1.Sum(box2);

            Console.WriteLine("1st Box:");
            box1.Display();

            Console.WriteLine("2nd Box:");
            box2.Display();

            Console.WriteLine("3rd Box:");
            box3.Display();

            Console.ReadLine();
        }
    }
}
