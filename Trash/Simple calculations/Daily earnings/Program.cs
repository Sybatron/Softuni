using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var income = double.Parse(Console.ReadLine());
            var UsdToBgn = double.Parse(Console.ReadLine());
            var yearIncome = days * income * (12+2.5);
            yearIncome *= (3 / 4.0);
            yearIncome *= UsdToBgn;
            Console.WriteLine(Math.Round(yearIncome/365,2)); 
        }
    }
}