using System;
using System.Linq;

namespace P04MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
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

            var command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    if (command.IndexOf("swap") == -1)
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                        continue;
                    }
                    var coordinates = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    var helpVar = matrix[coordinates[0], coordinates[1]];
                    matrix[coordinates[0], coordinates[1]] = matrix[coordinates[2], coordinates[3]];
                    matrix[coordinates[2], coordinates[3]] = helpVar;

                    for (int i = 0; i < size[0]; i++)
                    {
                        for (int j = 0; j < size[1]; j++)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
