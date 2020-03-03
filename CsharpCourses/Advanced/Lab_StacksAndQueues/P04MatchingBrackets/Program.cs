using System;
using System.Collections.Generic;

namespace P04MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var expr = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expr[i] == ')')
                {
                    var index = stack.Pop();
                    Console.WriteLine(expr.Substring(index, i - index + 1));
                }
            }
        }
    }
}
