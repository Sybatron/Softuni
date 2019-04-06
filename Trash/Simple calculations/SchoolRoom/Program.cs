using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine())-1;
            var result = Math.Floor(lenght / 1.2) * Math.Floor(width / 0.7) - 3;
            Console.WriteLine(result);
        }
    }
}
