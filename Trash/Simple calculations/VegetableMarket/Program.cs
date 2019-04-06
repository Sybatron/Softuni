using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegiePrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegieKG = int.Parse(Console.ReadLine());
            var fruitKG = int.Parse(Console.ReadLine());
            var incomeValue = (vegieKG * vegiePrice + fruitKG * fruitPrice) / 1.94;
            Console.WriteLine(incomeValue);
        }
    }
}
