using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            List<double> listForAverage = new List<double>();
            int topStudents = 0;
            int veryGoodStudents = 0;
            int goodStudents = 0;
            int poorStudents = 0;
            for (int i = 0; i < students; i++)
            {
                double gradeFromExam = double.Parse(Console.ReadLine());
                listForAverage.Add(gradeFromExam);
                if (gradeFromExam >=2.00 && gradeFromExam <= 2.99)
                {
                    poorStudents++;
                }
                if (gradeFromExam >= 3 && gradeFromExam <= 3.99)
                {
                    goodStudents++;
                }
                if (gradeFromExam>=4 && gradeFromExam <= 4.99)
                {
                    veryGoodStudents++;
                }
                if (gradeFromExam >= 5)
                {
                    topStudents++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%",((double)topStudents/students)*100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", ((double)veryGoodStudents /students)*100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", ((double)goodStudents /students)*100);
            Console.WriteLine("Fail: {0:f2}%", ((double)poorStudents /students)*100);
            Console.WriteLine("Average: {0:f2}", listForAverage.Average());          
        }
    }
}
