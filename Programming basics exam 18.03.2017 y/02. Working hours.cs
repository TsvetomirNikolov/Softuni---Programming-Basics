using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Working_hours
{
    class WorkingHours
    {
        static void Main(string[] args)
        {
            int needHours = int.Parse(Console.ReadLine());
            int numberWorkers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int workersHours = workingDays * 8*numberWorkers;
            int paymentTaxes = (needHours - workersHours) * workingDays;

            if (workersHours >= needHours)
            {
                Console.WriteLine("{0} hours left",workersHours-needHours);
            }
            else
            {
                Console.WriteLine("{0} overtime",Math.Abs(needHours-workersHours));
                Console.WriteLine("Penalties: {0}",paymentTaxes);
            }
        }
    }
}
