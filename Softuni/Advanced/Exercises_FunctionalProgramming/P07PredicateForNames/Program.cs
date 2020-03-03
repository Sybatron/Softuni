using System;

namespace P07PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            PrintValideNames(length, names);
        }

        static void PrintValideNames(int length, string[] names)
        {
            foreach (var name in names)
            {
                if (name.Length <= length)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
