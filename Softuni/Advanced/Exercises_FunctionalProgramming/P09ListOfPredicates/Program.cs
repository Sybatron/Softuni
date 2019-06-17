using System;
using System.Linq;

namespace P09ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 1; i <= length; i++)
            {
                IsDividable(i, dividers);
            }
        }

        static void IsDividable(int number, int[] dividers)
        {
            foreach (var divider in dividers)
            {
                if (number % divider != 0)
                {
                    return;
                }
            }
            Console.Write($"{number} ");
        }
    }
}
