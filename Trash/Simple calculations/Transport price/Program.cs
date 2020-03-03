using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_price
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometers = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            if(kilometers>=100)
            {
                Console.WriteLine(kilometers*0.06);
            }
            else if(kilometers>=20)
            {
                Console.WriteLine(kilometers*0.09);
            }

            else if(time=="day")
            {
                Console.WriteLine(kilometers * 0.79 + 0.70);
            }
            else Console.WriteLine(kilometers*0.90+0.70);
        }
    }
}
