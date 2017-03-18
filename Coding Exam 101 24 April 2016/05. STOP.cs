using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = n + 1;
            int middle = 2 * n + 1;
            int lenght = leftRight * 2 + middle;
            Console.WriteLine("{0}{1}{0}",new string('.',leftRight),new string ('_',middle));
            leftRight--;
            middle-=2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}", new string ('.',leftRight),new string ('_',middle));
                leftRight--;
                middle +=2;
            }
            int middleLeftRight = (lenght - 9) / 2;
            int middle2 = middleLeftRight * 2 + 5;
           Console.WriteLine(@"//{0}STOP!{0}\\",new string('_',middleLeftRight));
            Console.WriteLine(@"\\{0}//",new string('_',middle2));
            middle2-=2;
            int leftRights = 1;
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}",new string ('.',leftRights),new string ('_',middle2));
                leftRights++;
                middle2-=2;
            }
        }
    }
}
