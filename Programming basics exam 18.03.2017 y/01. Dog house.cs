using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dog_house
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            double lenghtA = double.Parse(Console.ReadLine());
            double heightB = double.Parse(Console.ReadLine());
            double twoSides = lenghtA * (lenghtA / 2) * 2;
            double square = (lenghtA / 2) * (lenghtA / 2);
            double triangle = (lenghtA / 2) * (heightB - lenghtA / 2) / 2;
            double backSide = square + triangle;
            double entrance = (lenghtA / 5) * (lenghtA / 5);
            double frontMoan = backSide - entrance;
            double allSides = backSide + twoSides + frontMoan;
            Console.WriteLine("{0:f2}",allSides/3);
            double stage = lenghtA * (lenghtA / 2) * 2;
            Console.WriteLine("{0:f2}",stage/5);
        }
    }
}
