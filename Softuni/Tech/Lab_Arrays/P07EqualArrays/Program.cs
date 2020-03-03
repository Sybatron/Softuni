using System;
using System.Linq;

namespace P07EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum: { sum}
            //Found difference at { index} index".
            int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if (firstArray.SequenceEqual(secondArray))
            {
                int sum = 0;
                foreach (var number in firstArray)
                {
                    sum += number;
                }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                int maxLength = Math.Max(firstArray.Length, secondArray.Length);
                for (int i = 0; i < maxLength; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
                }
            }
        }
    }
}
