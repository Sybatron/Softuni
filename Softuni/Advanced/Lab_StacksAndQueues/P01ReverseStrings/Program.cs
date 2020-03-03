using System;
using System.Collections.Generic;

namespace P01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var stack = new Stack<char>(input);
            Console.WriteLine(string.Join(string.Empty, stack));
        }
    }
}
