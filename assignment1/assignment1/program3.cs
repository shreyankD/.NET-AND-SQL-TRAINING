using System;

class Program3
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;

        Console.WriteLine($"Sum: {sum}");
        Console.ReadLine();
        Console.WriteLine($"Difference: {difference}");
        Console.ReadLine();
        Console.WriteLine($"Product: {product}");
        Console.ReadLine();
        Console.WriteLine($"Quotient: {quotient}");
        Console.ReadLine();
    }
}





