using System;
using System.Linq;

namespace P05SquareWithMaximumSum
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
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var maxSum = int.MinValue;
            int[,] square = new int[2, 2];
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    var currentSquare = new int[,]
                    {
                        {matrix[row, col],     matrix[row, col + 1]},
                        {matrix[row + 1, col], matrix[row + 1, col + 1]}
                    };
                    var currentSum = currentSquare[0, 0]
                        + currentSquare[0, 1]
                        + currentSquare[1, 0]
                        + currentSquare[1, 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        square = currentSquare;
                    }
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{square[row, col]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
