using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            foreach (var number in numbers)
            {
                if(number%2==0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
