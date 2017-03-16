using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_time_for_exam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int studentHours = int.Parse(Console.ReadLine());
            int studentMinutes = int.Parse(Console.ReadLine());

            int examTime = examHours * 60 + examMinutes;
            int studentTime = studentHours * 60 + studentMinutes;
            int minutesDifference = studentTime - examTime;

            if (minutesDifference < -30)
                Console.WriteLine("Early");
            else if (minutesDifference <= 0)
                Console.WriteLine("On time");
            else
                Console.WriteLine("Late");

            if (minutesDifference != 0)
            {
                int hours = Math.Abs(minutesDifference / 60);
                int minutes = Math.Abs(minutesDifference % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                        Console.Write(hours + ":0" + minutes + " hours");
                    else
                        Console.Write(hours + ":" + minutes + " hours");
                }
                else
                    Console.Write(minutes + " minutes");
                if (minutesDifference < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");
            }
        }
    }
}
