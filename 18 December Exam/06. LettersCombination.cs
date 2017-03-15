using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combination
{
    class LetersCombination
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char e = firstLetter; e <= secondLetter; e++)
                {
                    for (char g = firstLetter; g <= secondLetter; g++)
                    {
                        if (i==thirdLetter || e == thirdLetter || g == thirdLetter)
                        {
                            continue;
                        }
                        counter++;
                        Console.Write($"{i}{e}{g} ");     
                    }
                }          
            }
            Console.WriteLine(counter);
        }
    }
}
