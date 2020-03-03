using System;

namespace P01ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var texts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(Environment.NewLine, texts));
        }
    }
}
