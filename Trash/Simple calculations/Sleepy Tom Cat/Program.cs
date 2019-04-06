using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var leisureDays = int.Parse(Console.ReadLine());
            var wordDays = 365 - leisureDays;
            var playTime = leisureDays * 127 + wordDays * 63;
            var difference = 30000 - playTime;
            if(difference>0)
            {
                var hours = difference / 60;
                var mins = difference % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",hours,mins);
            }
            else
            {
                difference=-difference;
                var hours = difference / 60;
                var mins = difference % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, mins);
            }
        }
    }
}
