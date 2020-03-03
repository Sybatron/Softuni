using System;
using System.Linq;

namespace P01DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new int[size, size];

            var sumPrimaryDiag = 0;
            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        sumPrimaryDiag += input[j];
                    }
                    matrix[i, j] = input[j];
                }
            }

            var secondDiag = 0;
            for (int i = 0; i < size; i++)
            {
                secondDiag += matrix[i, size - 1 - i];
            }

            Console.WriteLine(Math.Abs(sumPrimaryDiag - secondDiag));
        }
    }
}
