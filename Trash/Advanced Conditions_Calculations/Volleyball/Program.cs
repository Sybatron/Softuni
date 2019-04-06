using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var homeDays = int.Parse(Console.ReadLine());

            var weekends = 48.0;
            weekends = (weekends - homeDays) * 3 / 4.0;

            var playedTime = (2.0 * holidays / 3) + weekends;
            playedTime += homeDays;

            if(yearType=="normal")
            {
                Console.WriteLine(Math.Floor(playedTime));
            }
            else Console.WriteLine(Math.Floor(playedTime*1.15));
        }
    }
}
