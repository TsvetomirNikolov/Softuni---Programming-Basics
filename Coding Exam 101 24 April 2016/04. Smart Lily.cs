using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Smart_Lili
{
    class SmartLily
    {
        static void Main(string[] args)
        {
            int yearsold = int.Parse(Console.ReadLine());
            double pricewashing = double.Parse(Console.ReadLine());
            int priceforone = int.Parse(Console.ReadLine());
            int priceForEven = 10;
            int savings = 0;
            int moneyForEven = 0;
            for (int i = 1; i <= yearsold; i++)
            {
                if (i % 2 == 0)
                {
                    savings += priceForEven;
                    savings -= 1;
                    priceForEven += 10;
                }
                else
                {
                    moneyForEven += priceforone;                 
                }
            }        
            int endResult = moneyForEven + savings;
            if (endResult >= pricewashing)
            {
                Console.WriteLine($"Yes! {endResult-pricewashing:f2}");
            }
            else
            {
                Console.WriteLine("No! {0:f2}",pricewashing-endResult);
            }
        }
    }
}
