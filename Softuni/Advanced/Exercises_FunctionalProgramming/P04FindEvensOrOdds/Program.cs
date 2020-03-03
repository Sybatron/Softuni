using System;
using System.Linq;

namespace P04FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var find = Console.ReadLine();
            if (find == "even")
            {
                for (int i = range[0]; i <= range[1]; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            else
            {
                for (int i = range[0]; i <= range[1]; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
