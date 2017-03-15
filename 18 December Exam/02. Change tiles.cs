using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_tiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double sumMoney = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLenght = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());
            double pricePerDutch = double.Parse(Console.ReadLine());
            double priceForMaster = double.Parse(Console.ReadLine());
            double floorArea = floorWidth * floorLenght;
            double dutchArea = (sideTriangle * heightTriangle)/2;
            double needDutches = Math.Ceiling(floorArea / dutchArea)+5;
            double finalSum = needDutches * pricePerDutch+priceForMaster;
            if (finalSum <= sumMoney)
            {
                Console.WriteLine("{0:f2} lv left.",sumMoney-finalSum);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",Math.Abs(finalSum-sumMoney));
            }
        }
    }
}
