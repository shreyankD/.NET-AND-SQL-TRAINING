//first program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class program1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array :");

        int count = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[count];
        Console.WriteLine("Enter the Elements of the Array : ");
        for (int i = 0; i < count; i++)
        {
           numbers[i]=Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];
        
        foreach(int num in numbers)
        {
            sum += num;
            if(num<min)
            {
                min = num;
            }
            if(num>max)
            {
                max = num;
            }
        }
        int average = sum / count;
        Console.WriteLine("average:" + average);
        Console.ReadLine();
        Console.WriteLine("Minimum:" + min);
        Console.ReadLine();
        Console.WriteLine("Maximum:" + max);
        Console.ReadLine();

    }
}