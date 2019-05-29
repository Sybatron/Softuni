using System;
using System.Collections.Generic;

namespace P08BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    stack.Push(i);
                    continue;
                }
                else if (stack.Count == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else if (input[i] == '}' || input[i] == ']')
                {
                    if ((char)(input[stack.Pop()] + 2) != input[i])
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (input[i] == ')' && input[stack.Pop()] != '(')
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
