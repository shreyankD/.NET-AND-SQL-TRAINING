using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Concession

    {

        public const int TotalFare = 500;



        public string Name;

        public int Age;



        public void CalculateConcession()

        {

            if (Age <= 5)

            {

                Console.WriteLine($"Little Champs - Free Ticket\nName: {Name}, Age: {Age}");

            }

            else if (Age > 60)

            {

                double discountedFare = 0.7 * TotalFare;

                Console.WriteLine($"Senior Citizen\nName: {Name}, Age: {Age}\nCalculated Fare: {discountedFare}");

            }

            else

            {

                Console.WriteLine($"Ticket Booked\nName: {Name}, Age: {Age}\nFare: {TotalFare}");

            }

        }

    }
}