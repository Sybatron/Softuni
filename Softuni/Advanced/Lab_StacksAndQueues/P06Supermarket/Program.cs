using System;
using System.Collections.Generic;

namespace P06Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
