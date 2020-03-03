using System;
using System.Linq;

namespace P02SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = parameters[0];
            var cols = parameters[1];

            int[,] matrix = new int[rows, cols];
            int[] sumPerCol = new int[cols];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                    sumPerCol[j] += input[j];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, sumPerCol));
        }
    }
}
