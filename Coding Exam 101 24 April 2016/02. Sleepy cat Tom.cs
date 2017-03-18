using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sleepy_cat_Tom
{
    class SleepyCatTom
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());
            int daysRestMin = numberDays * 127;
            int daysWorkMin = (365-numberDays) * 63;          
            int endMinutes = daysRestMin + daysWorkMin;
            int ednResultInMin = Math.Abs(30000 - endMinutes);

            if (endMinutes <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{ednResultInMin/60} hours and {ednResultInMin%60} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{ednResultInMin/60} hours and {ednResultInMin%60} minutes more for play");
            }
        }
    }
}
