using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endtInterval = int.Parse(Console.ReadLine());
            int magicalValue = int.Parse(Console.ReadLine());
            int counter = 0;
            int firstNUmber = 0;
            int secondNumber = 0;
            bool isTrue = true;
            for(int i = startInterval; i >= endtInterval; i--)
            {
                for (int e = startInterval; e >= endtInterval; e--)
                {
                    counter++;
                    if (i+e == magicalValue && isTrue)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {e} = {magicalValue})");
                        firstNUmber = i;
                        secondNumber = e;
                        isTrue = false;
                    }
                   
                }
            }
            if (firstNUmber+secondNumber!=magicalValue)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalValue}");
            }
        }
    }
}