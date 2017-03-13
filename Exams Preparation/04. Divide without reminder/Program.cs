using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Divide_without_reminder
{
    class Divide
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double divideByTwo = 0.0;
            double divideByThree = 0.0;
            double divideByFour = 0.0;
            for (int i = 0; i < input; i++)
            {
                int nextInput = int.Parse(Console.ReadLine());
                if (nextInput % 2 == 0)
                {
                    divideByTwo++;
                }
                if (nextInput % 3 == 0)
                {
                    divideByThree++;
                }
               if (nextInput % 4 ==0)
                {
                    divideByFour++;
                }
            }
            Console.WriteLine("{0:f2}%",(divideByTwo/input)*100);
            Console.WriteLine("{0:f2}%",(divideByThree/input)*100);
            Console.WriteLine("{0:f2}%",(divideByFour/input)*100);

        }
    }
}
