using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15mins
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var mins = int.Parse(Console.ReadLine());

            mins += 15;
            if(mins>59)
            {
                mins -= 60;
                hours++;
                if(hours==24)
                {
                    hours = 0;
                }
            }

            Console.WriteLine("{0}:{1:00}",hours,mins);
        }
    }
}
