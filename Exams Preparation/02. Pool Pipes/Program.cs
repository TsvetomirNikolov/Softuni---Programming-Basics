using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pool_Pipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            int pipesInPool = int.Parse(Console.ReadLine());
            int flowP1 = int.Parse(Console.ReadLine());
            int flowP2 = int.Parse(Console.ReadLine());
            double workerNotOnWork = double.Parse(Console.ReadLine());
            double fullyFirstPipe = flowP1 * workerNotOnWork;
            double fullySecondPipe = flowP2 * workerNotOnWork;
            double sumOfTwoPipes = fullyFirstPipe + fullySecondPipe;
            double percentageInPool = (sumOfTwoPipes / pipesInPool) * 100;
            double percentageInFirstPipe = (fullyFirstPipe / sumOfTwoPipes) * 100;
            double percentageInSecondPipe = (fullySecondPipe / sumOfTwoPipes) * 100;
       
            if (sumOfTwoPipes <= pipesInPool)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(percentageInPool)
                    , Math.Truncate(percentageInFirstPipe), Math.Truncate(percentageInSecondPipe));               
            }
            else
            {
                Console.WriteLine($"For {workerNotOnWork} hours the pool overflows with {Math.Abs(pipesInPool-sumOfTwoPipes)} liters.");
            }

        }
    }
}
