using System;
using System.Linq;

namespace P05LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int index = 0;
            int count = 0;
            int LIScount = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    count++;
                    if (count > LIScount)
                    {
                        index = i;
                        LIScount = count;
                    }
                    else
                    {
                        count = -1;
                    }
                }
            }

            for (int i = index - LIScount; i <= index; i++)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
