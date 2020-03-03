using System;
using System.Linq;

namespace P02_2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new string[size[0], size[1]];


            for (int i = 0; i < size[0]; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var squareCount = 0;
            for (int i = 0; i < size[0] - 1; i++)
            {
                for (int j = 0; j < size[1] - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i + 1, j]
                        && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        squareCount++;
                    }
                }
            }
            Console.WriteLine(squareCount);

        }
    }
}
