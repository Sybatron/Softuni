using System;
using System.Linq;

namespace P05AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]++;
                        }
                        break;
                    case "multiply":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] *= 2;
                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]--;
                        }
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
