using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProblemVegetableShop
{
    class VegetableShop
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits= double.Parse(Console.ReadLine());
            int sumVegetables = int.Parse(Console.ReadLine());
            int sumFruits = int.Parse(Console.ReadLine());
            double priceForVegetables = priceVegetables * sumVegetables;
            double priceForFruits = priceFruits * sumFruits;
            double resultOfAll = (priceForVegetables + priceForFruits) / 1.94;
            Console.WriteLine(resultOfAll);
        }
    }
}
