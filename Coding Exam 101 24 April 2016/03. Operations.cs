using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            double endResult = 0;
            if (operators == "+")
            {
                endResult = N1 + N2;
                if (endResult % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {endResult} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {endResult} - odd");

                }
            }
            else if (operators == "-")
            {
                endResult = N1 - N2;
                if (endResult % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {endResult} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {endResult} - odd");

                }
            }
            else if (operators == "*")
            {
                endResult = N1 * N2;
                if (endResult % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {endResult} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {endResult} - odd");

                }

            }
            else if (operators == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    endResult =(double) N1 / N2;
                    Console.WriteLine($"{N1} / {N2} = {endResult:f2}");
                }

            }
            else if (operators == "%")
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                  else
                {
                    endResult = (double)N1 % N2;

                    Console.WriteLine($"{N1} % {N2} = {endResult}");
                }
        }
        }
    }

