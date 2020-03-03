using System;
using System.Linq;

namespace P03Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] firstArray = new int[length];
            int[] secondArray = new int[length];

            int index1 = 0;
            int index2 = 1;
            for (int i = 0; i < length; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                firstArray[i] = numbers[index1];
                secondArray[i] = numbers[index2];
                index1++;
                index2++;
                if (index1 > 1)
                {
                    index1 = 0;
                }
                else
                {
                    index2 = 0;
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
