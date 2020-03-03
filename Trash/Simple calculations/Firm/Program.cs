using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine())*0.90;
            var workers = int.Parse(Console.ReadLine());

            //var worked = (days * 0.9 * 8) /*Normal worked part*/ + (days * workers * 2) /*More worked part*/;

            var worked = days*workers*10;
            worked = Math.Floor(worked);

            if(worked>=hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.",worked-hoursNeeded);
            }
            else Console.WriteLine("Not enough time!{0} hours needed.",hoursNeeded-worked);
        }
    }
}
