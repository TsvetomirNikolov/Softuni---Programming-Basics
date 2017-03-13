using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', n - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', n));
        }
    }
}