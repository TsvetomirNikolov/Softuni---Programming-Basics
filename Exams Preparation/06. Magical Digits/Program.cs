using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Magical_Digits
{
    class MagicalDigits
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                for (int e = 0; e <=9; e++)
                {
                    for (int t = 0; t <= 9; t++)
                    {
                        for (int f = 0; f <= 9; f++)
                        {
                            for (int a = 0; a <= 9; a++)
                            {
                                for (int y = 0; y <= 9; y++)
                                {
                                    if (i*e*t*f*a*y == input)
                                    {
                                        Console.Write($"{i}{e}{t}{f}{a}{y} ");
                                    }
                                }

                            }
                        }
                    }
                }

            }
        }
    }
}
