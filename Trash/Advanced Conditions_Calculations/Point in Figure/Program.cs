using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            bool outRectangle1 = x > 3 * h || y > 4 * h;
            bool outRectangle2 = ((x >= 0 && x < h) || x > 2 * h) && (y > h && y <= 4 * h);

            bool inRectangle1 = (x > 0 && x < 3*h) && (y > 0 && y < h);
            bool inRectangle2 = (x > h && x < 2*h) && (y > h && y < 4*h);

            if(outRectangle1 || outRectangle2)
            {
                Console.WriteLine("outside");
            }
            else if(inRectangle1 || inRectangle2)
            {
                Console.WriteLine("inside");
            }
            else Console.WriteLine("border");
        }
    }
}
