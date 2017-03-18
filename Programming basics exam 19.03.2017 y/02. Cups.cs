using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCups = int.Parse(Console.ReadLine());
            int numberWorkers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int workingHours = workingDays * numberWorkers * 8;
            int makedCups = workingHours / 5;        
            double change = numberCups - makedCups;
            double secondCHange = Math.Abs(makedCups - numberCups);
            if (numberCups >= makedCups)
            {
                Console.WriteLine("Losses: {0:f2}",change*4.2);
            }
            else
            {
                Console.WriteLine("{0:f2} extra money",secondCHange*4.2);

            }

        }
    }
}
