using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = n / 2 - 1;
            int emptyPLaces = 1;
            for (int i = 1; i <= n / 2; i++)
            {
                string print = new string('.', leftRight) + new string('+', emptyPLaces).Replace("+", "/ ") + new string('+', emptyPLaces).Replace("+", " \\") +
                new string('.', leftRight);
                Console.WriteLine(print.Substring(0, n / 2) + print.Substring(print.Length - n / 2));
                leftRight--;
                emptyPLaces++;
            }
            leftRight = 0;
            emptyPLaces = n / 2;
            for (int i = 1; i <= n / 2; i++)
            {
                string print = new string('.', leftRight) + new string('+', emptyPLaces).Replace("+", "\\ ") + new string('+', emptyPLaces).Replace("+", " /") +
                new string('.', leftRight);
                Console.WriteLine(print.Substring(0, n / 2) + print.Substring(print.Length - n / 2));
                leftRight++;
                emptyPLaces--;
            }
            Console.WriteLine();
        }
    }
}