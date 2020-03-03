using System;
using System.Collections.Generic;
using System.Linq;

namespace P05PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var queue = new Queue<int>(numbers);
            var length = queue.Count;
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    var number = queue.Dequeue();
                    queue.Enqueue(number);
                }
            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
