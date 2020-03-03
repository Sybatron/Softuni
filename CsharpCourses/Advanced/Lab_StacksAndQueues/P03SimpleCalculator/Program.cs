using System;
using System.Collections.Generic;

namespace P03SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var stack = new Stack<string>(input);
            var output = 0;
            while (stack.Count > 1)
            {
                var num = int.Parse(stack.Pop());
                var symbol = stack.Pop();
                if (symbol == "+")
                {
                    output += num;
                }
                else
                {
                    output -= num;
                }
            }
            output += int.Parse(stack.Pop());
            Console.WriteLine(output);
        }
    }
}
