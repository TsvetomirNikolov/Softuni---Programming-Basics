using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;
            int leftRight = width / 2 - 1;
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(@"{0}\ /{0}", new string(i % 2==0 ? '*' : '-',leftRight));
            }
            Console.WriteLine("{0}@{0}",new string (' ', leftRight+1));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(@"{0}/ \{0}", new string(i % 2 == 0 ? '*' : '-', leftRight));
            }
        }
    }
}
