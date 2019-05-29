using System;
using System.Linq;

namespace P01SumMatrixElements
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

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            var sum = 0;
            foreach (var num in matrix)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
