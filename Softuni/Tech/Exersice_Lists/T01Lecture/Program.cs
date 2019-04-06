using System;
using System.Linq;

namespace T01Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Where(x => x % 2 == 0)
                .ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
