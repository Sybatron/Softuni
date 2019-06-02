using System;
using System.Linq;

namespace P06Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfMatrix = int.Parse(Console.ReadLine());
            var matrix = new int[sizeOfMatrix][];

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                matrix[i] = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            }

            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "END")
            {
                var x = int.Parse(input[1]);
                var y = int.Parse(input[2]);
                var changeValue = int.Parse(input.Last());

                if (input[0] == "Add")
                {
                    try
                    {
                        matrix[x][y] += changeValue;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else
                {
                    try
                    {
                        matrix[x][y] -= changeValue;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
