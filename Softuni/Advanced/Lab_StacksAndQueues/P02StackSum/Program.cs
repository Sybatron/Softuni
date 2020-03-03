using System;
using System.Collections.Generic;
using System.Linq;
namespace P02StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var stack = new Stack<int>(nums);
            var input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                var parameters = input.Split(" ");
                if (parameters[0] == "add")
                {
                    stack.Push(int.Parse(parameters[1]));
                    stack.Push(int.Parse(parameters[2]));
                }
                else
                {
                    var length = int.Parse(parameters[1]);
                    if(length<=stack.Count)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
