
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEBASED_3
{
    class Cricket

    {
        public void Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int total_points = 0;

            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter runs scored in match  {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                total_points += scores[i];
            }

            double average_points = (double)total_points / no_of_matches;

            Console.WriteLine($"Total points: {total_points}");
            Console.WriteLine($"Average points: {average_points}");
        }
    }
    class Program
    {
        static void Main()
        {
            Cricket cricket = new Cricket();

            Console.Write("Enter total number of matches: ");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());

            cricket.Pointscalculation(no_of_matches);
            Console.ReadLine();
        }
    }
}