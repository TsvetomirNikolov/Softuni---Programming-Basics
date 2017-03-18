using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLections = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double jelev = 0;
            double royal = 0;
            double roli = 0;
            double sino = 0;
            double triffon = 0;
            double guests = 0;
            double budgetForLections =budget / numberLections;
          
            for (int i = 0; i < numberLections; i++)
            {
                string nameLector = Console.ReadLine();
                if (nameLector == "Jelev")
                {
                    jelev++;

                }
                else if (nameLector == "Roli")
                {
                    roli++;
                }
                else if (nameLector == "Trofon")
                {
                    triffon++;
                }
                else if (nameLector == "Sino")
                {
                    sino++;
                }
                else if (nameLector == "RoYaL")
                {
                    royal++;
                }
                else
                {
                    guests++;
                }
            }
            Console.WriteLine("Jelev salary: {0:f2} lv",budgetForLections*jelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv",budgetForLections*royal);
            Console.WriteLine("Roli salary: {0:f2} lv",budgetForLections*roli);
            Console.WriteLine("Trofon salary: {0:f2} lv",budgetForLections*triffon);
            Console.WriteLine("Sino salary: {0:f2} lv",budgetForLections*sino);
            Console.WriteLine("Others salary: {0:f2} lv",budgetForLections*guests);
        }
    }
}
