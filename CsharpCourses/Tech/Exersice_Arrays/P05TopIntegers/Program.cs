using System;
using System.Collections.Generic;
using System.Linq;

namespace P05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> topIntegers = new List<int>();
            bool bigger = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        bigger = true;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bigger)
                {
                    topIntegers.Add(numbers[i]);
                    bigger = false;
                }
            }

            topIntegers.Add(numbers[numbers.Length - 1]);
            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}
