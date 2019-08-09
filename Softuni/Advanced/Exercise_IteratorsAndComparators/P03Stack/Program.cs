using System;
using System.Linq;

namespace P03Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var customStack = new CustomStack<int>();

            var command = Console.ReadLine();

            while (command != "END")
            {
                if (command.Contains("Push"))
                {
                    var tokens = command.Split(new char[] { ' ', ',' }
                                        , StringSplitOptions.RemoveEmptyEntries)
                                        .Skip(1)
                                        .Select(int.Parse)
                                        .ToArray();
                    customStack.Push(tokens);
                }
                else if (command == "Pop")
                {
                    customStack.Pop();
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in customStack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
