using System;
using System.Collections.Generic;

namespace P07HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(names);
            var n = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    var person = queue.Dequeue();
                    queue.Enqueue(person);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
