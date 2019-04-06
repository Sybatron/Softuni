using System;
using System.Collections.Generic;
using System.Linq;

namespace P04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            foreach (var number in input)
            {
                numbers.Add(number);
            }

            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
