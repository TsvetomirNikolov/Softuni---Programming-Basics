using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Special_Values
{
    class SpecialValues
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int g = 1; g <= 9; g++)
                {
                    for (int t = 1; t <= 9; t++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if (value % i == 0 && value % g == 0 && value % t ==0 && value % j == 0)
                            {
                                Console.Write($"{i}{g}{t}{j} ");
                            }
                          
                        }
                    }

                }

            }
        }
    }
}
