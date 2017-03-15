using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int width = 4 * input + 1;
            int height = 2 * input + 5;
            Console.WriteLine(@"{0}/|\{0}",new string ('.',width/2-1));
            Console.WriteLine(@"{0}\|/{0}",new string ('.',width/2-1));
            int leftRight = width / 2 - 1;
            int middle = 0;
            for (int i = 0; i < 2*input; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',leftRight), new string('-',middle));
                leftRight--;
                middle++;
            }
            Console.WriteLine(new string('*',width));
            Console.Write('*');
            for (int i = 0; i < width/2; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', width));

        }
    }
}
