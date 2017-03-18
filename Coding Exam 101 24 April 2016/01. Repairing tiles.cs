using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Repairing_tiles
{
    class RepairingTiles
    {
        static void Main(string[] args)
        {
            int lenghtWidht = int.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double lenghtTile = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int lenghtSeat = int.Parse(Console.ReadLine());
            double area = Math.Pow(lenghtWidht,2);
            double areaSeat = height * lenghtSeat;
            double areaForcover = area - areaSeat;
            double tilesArea = width * lenghtTile;
            double needTiles = areaForcover /tilesArea;
            double needTime = needTiles * 0.2;
            Console.WriteLine(needTiles);        
            Console.WriteLine(needTime);
        }
    }
}
