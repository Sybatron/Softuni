using System;
using System.Linq;

namespace P03PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sideOfSquare, sideOfSquare];
            for (int i = 0; i < sideOfSquare; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < sideOfSquare; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var sumOfPrimaryDiag = 0;
            for (int row = 0, col = 0; row < sideOfSquare; row++, col++)
            {
                sumOfPrimaryDiag += matrix[row, col];
            }
            Console.WriteLine(sumOfPrimaryDiag);
        }
    }
}
