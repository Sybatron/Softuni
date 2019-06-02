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
                .ToArray();
            var word = Console.ReadLine();

            var currentWord = word.Substring(0, size[1]);
            Console.WriteLine(currentWord);
            for (int i = 1; i < size[0]; i++)
            {
                //currentWord=
                for (int j = 0; j < size[1]; j++)
                {

                }
            }
        }
    }
}
