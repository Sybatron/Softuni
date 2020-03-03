using System;
using System.Linq;

namespace P04FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int length = array.Length;
            int[] firstRow = new int[length / 2];
            int[] secondRow = new int[length / 2];
            int index = 0;
            for (int i = length / 4 - 1; i >= 0; i--)
            {
                firstRow[index] = array[i];
                index++;
            }
            for (int i = length - 1; i >= length / 2 + length / 4; i--)
            {
                firstRow[index] = array[i];
                index++;
            }

            index = 0;
            for (int i = length / 4; i < length - length / 4; i++)
            {
                secondRow[index] = array[i];
                index++;
            }

            length = length / 2;
            int[] sum = new int[length];
            for (int i = 0; i < length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
