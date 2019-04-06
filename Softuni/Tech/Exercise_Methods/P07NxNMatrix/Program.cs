using System;

namespace P07NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] matrix = new int[number];
            Array.Fill(matrix, number);

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(string.Join(" ", matrix));
            }
        }
    }
}
