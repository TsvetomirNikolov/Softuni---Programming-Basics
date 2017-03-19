using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Softuni_label
{
    class SoftuniLabel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 4 * n-2;
            int widht = 12 * n - 5;
            int leftRight = (widht - 1) / 2;
            int middle = 1;
            for (int i = 0; i <= height/2-1; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string ('.',leftRight), new string ('#',middle));
                middle += 6;
                leftRight -= 3;
            }
            Console.WriteLine(new string ('#',widht));
            int left = 2;
            int middle1 = widht - 6;
            int right = 3;
            int cycle = height / 2 - 1 - n;

            for (int i = 0; i < cycle; i++)
            {
                Console.WriteLine(@"|{0}{1}{2}", new string('.', left), new string('#', middle1), new string('.', right));
                middle1 -= 6;
                left += 3;
                right += 3;
            }
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("|{0}{1}{2}",new string ('.',left), new string ('#',middle1),new string('.',right));
            }
            Console.WriteLine("@{0}{1}{2}", new string('.',left), new string ('#',middle1),new string('.',right));

        }
    }
}
