using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class TrainingLab       
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double widthInCM = width * 100-100;
            int desksPerRow = (int)widthInCM / 70;
            double heighInCM = height * 100;
            int desksPerHeihgt = (int)heighInCM / 120;
            int numberOfSeats = desksPerRow * desksPerHeihgt - 3;
            Console.WriteLine(numberOfSeats);
        }
    }
}
