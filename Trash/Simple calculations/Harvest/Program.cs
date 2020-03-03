using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var grapeArea = int.Parse(Console.ReadLine());
            var grapePerSquareMeter = double.Parse(Console.ReadLine());
            var litersNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var liters = (grapeArea * grapePerSquareMeter) * 0.4 / 2.5;
            if(liters-litersNeeded<0)
            {
                var difference = litersNeeded - liters;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(difference));
            }
            else
            {
                var difference = liters - litersNeeded;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(liters));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(difference),
                    Math.Ceiling(difference/workers));
            }
        }
    }
}
