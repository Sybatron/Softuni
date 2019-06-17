using System;
using System.Linq;

namespace P06ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());
            numbers.RemoveAll(x => x % n == 0);

            numbers.Reverse();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
