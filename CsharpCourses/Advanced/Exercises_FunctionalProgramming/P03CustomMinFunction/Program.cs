using System;
using System.Linq;

namespace P03CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Min();
            Console.WriteLine(min);
        }
    }
}
