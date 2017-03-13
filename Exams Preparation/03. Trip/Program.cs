using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double camp = 0.0;
            double hotel = 0.0;
            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    camp = budget * 0.3;
                    Console.WriteLine("Camp - {0:f2}",camp);
                }
                else
                {
                    hotel = budget * 0.7;
                    Console.WriteLine("Hotel - {0:f2}", hotel);
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    camp = budget * 0.4;
                    Console.WriteLine("Camp - {0:f2}", camp);
                }
                else
                {
                    hotel = budget * 0.8;
                    Console.WriteLine("Hotel - {0:f2}", hotel);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                hotel = budget * 0.9;
                Console.WriteLine("Hotel - {0:f2}", hotel);
            }
        }
    }
}