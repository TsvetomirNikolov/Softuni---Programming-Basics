using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hire_a_car
{
    class HireCar
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double cabrio = 0.0;
            double jeep = 0.0;
            if (budget<=100)
            {
                Console.WriteLine("Economy class");
                if (season.Equals("summer"))
                {
                    cabrio = budget * 0.35;
                    Console.WriteLine($"Cabrio - {cabrio:f2}");
                }
                else
                {
                    jeep = budget*0.65;
                    Console.WriteLine($"Jeep - {jeep:f2}");
                }
            }
            else if (budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season.Equals("Summer"))
                {
                    cabrio = budget * 0.45;
                    Console.WriteLine($"Cabrio - {cabrio:f2}");
                }
                else
                {
                    jeep = budget * 0.80;
                    Console.WriteLine($"Jeep - {jeep:f2}");
                }
            }
            else if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                    jeep = budget * 0.9;
                    Console.WriteLine($"Jeep - {jeep:f2}");
            }
        }
    }
}
