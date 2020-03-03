using System;

namespace P07PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            if (rows != 0)
            {
                var matrix = new long[rows][];
                for (int row = 0; row < rows; row++)
                {
                    matrix[row] = new long[row + 1];
                    matrix[row][0] = 1;
                    for (int col = 1; col < matrix[row].Length - 1; col++)
                    {
                        matrix[row][col] = matrix[row - 1][col] + matrix[row - 1][col - 1];
                    }
                    matrix[row][row] = 1;
                    Console.WriteLine(string.Join(" ", matrix[row]));
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
