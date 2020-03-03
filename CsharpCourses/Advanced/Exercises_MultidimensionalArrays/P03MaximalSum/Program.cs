using System;
using System.Linq;

namespace P03MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var maxSum = int.MinValue;
            var maxSquare = new int[3, 3];
            for (int i = 0; i < size[0] - 2; i++)
            {
                for (int j = 0; j < size[1] - 2; j++)
                {
                    var currentSquare = new int[3, 3]
                    {
                        {matrix[i,j],matrix[i,j+1],matrix[i,j+2]},
                        {matrix[i+1,j],matrix[i+1,j+1],matrix[i+1,j+2]},
                        {matrix[i+2,j],matrix[i+2,j+1],matrix[i+2,j+2]}
                    };
                    var currentSum = currentSquare.Cast<int>().Sum();

                    if (maxSum < currentSum)
                    {
                        maxSquare = currentSquare;
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{maxSquare[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
