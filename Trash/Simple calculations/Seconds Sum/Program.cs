using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());

            var secs = first + second + third;
            var mins = secs / 60;
            secs %= 60;

            Console.WriteLine("{0}:{1:00}",mins,secs);
        }
    }
}
