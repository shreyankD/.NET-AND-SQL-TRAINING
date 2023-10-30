using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEBASED_4
{
    public delegate int CalculatorDelegate(int num1, int num2);

    class Program2

    {
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static void Main()
        {
            CalculatorDelegate AdditionDelegate = Addition;
            CalculatorDelegate SubtractionDelegate = Subtraction;
            CalculatorDelegate MultiplicationDelegate = Multiplication;

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = AdditionDelegate(num1, num2);

            int difference = SubtractionDelegate(num1, num2);

            int product = MultiplicationDelegate(num1, num2);

            Console.WriteLine($"Additionition Result: {sum}");
            Console.WriteLine($"Subtractionion Result: {difference}");
            Console.WriteLine($"Multiplication Result: {product}");
            Console.ReadLine();
        }
    }
}