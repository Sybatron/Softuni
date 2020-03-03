using System;

namespace P04SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sideOfSquare, sideOfSquare];
            for (int i = 0; i < sideOfSquare; i++)
            {
                var input = Console.ReadLine()
                    .ToCharArray();
                for (int j = 0; j < sideOfSquare; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < sideOfSquare; i++)
            {
                for (int j = 0; j < sideOfSquare; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
