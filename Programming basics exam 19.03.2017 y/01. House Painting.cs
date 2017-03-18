using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Case
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double heightTrianglePArt = double.Parse(Console.ReadLine());
            double leftSide = height * lenght;
            double window = Math.Pow(1.5, 2);
            double twoSides = 2 * leftSide - 2 * window;
            double backSide = Math.Pow(height, 2);
            double entrance = 1.2 * 2;
            double all = 2 * backSide-entrance;
            double finalArea = twoSides + all;
            double greenPaint = finalArea / 3.4;
            double rectangle = 2 * (height * lenght);
            double triangles = 2 * (height * heightTrianglePArt / 2);
            double allAreas = triangles + rectangle;
            double redPaint = allAreas / 4.3;
            Console.WriteLine("{0:f2}",greenPaint);
            Console.WriteLine("{0:f2}",redPaint);
        }
    }
}
