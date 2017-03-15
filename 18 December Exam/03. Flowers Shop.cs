using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers_shop
{
    class FlowersShop
    {
        static void Main(string[] args)
        {
            int chrysantem = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tullip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNOt = Console.ReadLine();
            double priceForBoucket = 0.0;
            double priceForAllFlowers = chrysantem + rose + tullip;
            if (season == "Spring" || season == "Summer" )
            {
                priceForBoucket = chrysantem * 2 + rose * 4.10 + tullip * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceForBoucket = chrysantem * 3.75 + rose * 4.50 + tullip * 4.15;
            }
            if (tullip > 7 && season == "Spring")
            {
                priceForBoucket -= priceForBoucket * 0.05;
            }
            if (rose >=10 && season == "Winter")
            {
                priceForBoucket -= priceForBoucket * 0.1;
            }
            if (priceForAllFlowers > 20)
            {
                priceForBoucket -= priceForBoucket * 0.2;
            }
            if (holidayOrNOt.Equals("Y"))
            {
                priceForBoucket += priceForBoucket * 0.15;
            }
            Console.WriteLine("{0:f2}",priceForBoucket+2);
        }
    }
}
