using System;
using System.Linq;

namespace P05SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            var word = Console.ReadLine();
            var index = 0;

            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++, index++)
                {
                    if (index >= word.Length)
                    {
                        index = 0;
                    }
                    Console.Write(word[index]); ;
                }
                Console.WriteLine();
            }
        }
    }
}