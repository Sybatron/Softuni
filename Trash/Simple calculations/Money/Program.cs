using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var yuani = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine())/100;

            var value = (bitcoin * 1168 + yuani * 0.15 * 1.76) * commision / 1.95;
            Console.WriteLine(value);
        }
    }
}
