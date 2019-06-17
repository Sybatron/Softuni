using System;
using System.Linq;

namespace P001SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var evenNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x);
            Console.WriteLine(string.Join("...",evenNumbers));
               


        }
    }
}
