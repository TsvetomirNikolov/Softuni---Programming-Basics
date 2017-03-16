using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_password_generator
{
    class StupidPassword
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int e = 1; e <= n; e++)
                {
                    for (char s = 'a'; s < 'a'+l; s++)
                    {
                        for (char t = 'a'; t < 'a'+l; t++)
                        {
                            for (int h = 1; h <= n; h++)
                            {
                                if (h > i && h > e)
                                {
                                    Console.Write($"{i}{e}{s}{t}{h} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
