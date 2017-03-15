using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            int firstSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            double firstTimeinHours = (double)firstTime / 60;
            double secondTimeinHours = (double)secondTime / 60;
            double thirdTimeinHours = (double)thirdTime / 60;
            double distance = firstSpeed * firstTimeinHours;
            double secondDistance = firstSpeed + firstSpeed * 0.1;
            double secondDistance1 = secondDistance * secondTimeinHours;
            double thirdDistance = secondDistance - secondDistance * 0.05;
            double thirdDistance1 = thirdDistance * thirdTimeinHours;
            double result = thirdDistance1 + secondDistance1 + distance;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
