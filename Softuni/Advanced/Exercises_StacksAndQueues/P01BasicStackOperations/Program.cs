using System;
using System.Collections.Generic;
using System.Linq;

namespace P01BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(input);
            for (int i = 0; i < parameters[1]; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(parameters[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    var smallest = stack.Pop();
                    foreach (var num in stack)
                    {
                        if (num < smallest)
                        {
                            smallest = num;
                        }
                    }
                    Console.WriteLine(smallest);
                }
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
