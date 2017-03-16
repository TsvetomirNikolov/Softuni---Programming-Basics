using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Price_for_transport
{
    class PriceForTransport
    {
        static void Main(string[] args)
        {
            int numberKM = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double transportPrice = 0.0;
            if (numberKM<=19)
            {
                if (dayOrNight.Equals("day"))
                {
                    transportPrice = 0.7 + numberKM * 0.79;
                }
                else
                {
                    transportPrice = 0.7 + 0.9 * numberKM;
                }
            }
            else if (numberKM <= 99)
            {
                transportPrice = 0.09 * numberKM;
            }
            else
            {
                transportPrice = numberKM * 0.06;
            }
            Console.WriteLine(transportPrice);
        }
    }
}
