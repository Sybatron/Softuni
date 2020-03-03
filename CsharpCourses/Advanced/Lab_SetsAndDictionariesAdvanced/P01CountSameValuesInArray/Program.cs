using System;
using System.Collections.Generic;

namespace P01CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var numbers = new Dictionary<string, int>();
            foreach (var num in inputNums)
            {
                if (!numbers.ContainsKey(num))
                {
                    numbers[num] = 0;
                }
                numbers[num]++;
            }

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
