using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int width = 2 * input;
            int height = input/2;
            int middle = width - 2 * height - 4;
            Console.WriteLine(@"/{0}\{1}/{0}\",new string ('^',input/2), new string('_',middle));
            for (int i = 1; i < input-2; i++)
            {
                Console.WriteLine(@"|{0}|", new string(' ', width - 2));
            }
            Console.WriteLine("|{0}{1}{0}|",new string (' ',input/2+1),new string ('_',middle));
            Console.WriteLine(@"\{0}/{1}\{0}/",new string ('_',height),new string(' ',middle));
        }
    }
}
