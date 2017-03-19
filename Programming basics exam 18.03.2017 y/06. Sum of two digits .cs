using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_of_two_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicalValue = int.Parse(Console.ReadLine());
            int counter = 0;
            bool IsMagical = true;
            int startNumber = 0;
            int endNumber = 0;
            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int f = startInterval; f <= endInterval; f++)
                {
                    counter++;
                    if (i + f == magicalValue && IsMagical)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {f} = {magicalValue})");
                        startNumber = i;
                        endNumber = f;
                        IsMagical = false;
                    }
                }
            }
            if (startNumber+endNumber != magicalValue)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalValue}");
            }
        }           
    }
}

  
   

