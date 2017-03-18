using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n + 1;
            int lenght = 2 * n + 1;
            Console.WriteLine(new string ('*',lenght));
            Console.WriteLine(".*{0}*.",new string (' ',lenght-4));
            int leftRight = 2;
            int middle = lenght - 6;
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string ('.',leftRight),new string ('@',middle));
                leftRight++;
                middle-=2;
            }
            Console.WriteLine("{0}*{0}",new string ('.',lenght/2));
            int midlle2 = 0;
            leftRight--;
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', leftRight), new string(' ', midlle2));
                leftRight--;
                midlle2++;
            }
            Console.WriteLine(".*{0}*.", new string('@', lenght - 4));
            Console.WriteLine(new string ('*',lenght));

        }
    }
}
