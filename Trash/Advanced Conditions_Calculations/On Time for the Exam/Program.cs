using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMins = int.Parse(Console.ReadLine());
            var arriveHour = int.Parse(Console.ReadLine());
            var arriveMins = int.Parse(Console.ReadLine());

            bool onTime1 = 
                examHour == arriveHour && examMins >= arriveMins && (examMins-arriveMins)<=30;
            bool onTime2 = 
                examHour < arriveHour && (60-arriveMins+examMins)<=30;

            if (onTime1||onTime2)
            {
                
            }
        }
    }
}
