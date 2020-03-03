using System;
using System.Collections.Generic;
using System.Linq;

namespace P02BasicQueueOperations
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
            var queue = new Queue<int>(input);
            for (int i = 0; i < parameters[1]; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(parameters[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    var smallest = queue.Dequeue();
                    foreach (var num in queue)
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
