using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            //0.9 => 1
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} => {number:f0}");
            }
        }
    }
}
