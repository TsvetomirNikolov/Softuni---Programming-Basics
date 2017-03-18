using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Case
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double hotel = 0.0;
            double camp =0.0;
            double hut = 0.0;
            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    camp = budget * 0.65;
                    Console.WriteLine("Alaska - Camp - {0:f2}",camp);
                }
                else
                {
                    camp = budget * 0.45;
                    Console.WriteLine("Morocco - Camp - {0:f2}",camp);
                }              
            }
            else if (budget <= 3000)
            {

                if (season == "Summer")
                {
                    hut = budget * 0.8;
                    Console.WriteLine("Alaska - Hut - {0:f2}", hut);
                }
                else
                {
                    hut = budget * 0.6;
                    Console.WriteLine("Morocco - Hut - {0:f2}", hut);
                }
            }
            else if (budget > 3000)
            {
                if (season == "Summer")
                {
                        hotel = budget * 0.9;
                        Console.WriteLine("Alaska - Hotel - {0:f2}", hotel);
                    }
                    else
                    {
                        hotel = budget * 0.9;
                        Console.WriteLine("Morocco - Hotel - {0:f2}", hotel);
                    }
                }
            }
        }
     }
    

