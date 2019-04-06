using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            var a = 0.0;
            var b = 0.0;

            switch(figure)
            {
                case "square":
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine(a*a);
                    break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * b);
                    break;
                case "circle":
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * a * Math.PI);
                    break;
                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * b / 2);
                    break;
            }
        }
    }
}
