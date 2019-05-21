using System;
using System.Collections.Generic;
using System.Linq;

namespace P07TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var index = new List<int>();
            var queue = new Queue<int[]>();

            for (int i = 0; i < length; i++)
            {
                var parameters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                queue.Enqueue(parameters);
                if (parameters[0] - parameters[1] >= 0)
                {
                    index.Add(i);
                }
            }

            for (int i = 0; i < index.Count; i++)
            {
                if (TryIfItsRight(queue, index[i]))
                {
                    Console.WriteLine(index[i]);
                    return;
                }
            }
        }

        static bool TryIfItsRight(Queue<int[]> queue, int index)
        {
            var sum = 0;
            for (int i = 0; i < index; i++)
            {
                var helpVar = queue.Dequeue();
                queue.Enqueue(helpVar);
            }
            foreach (var pump in queue)
            {
                sum += pump[0];
                if (sum - pump[1] < 0)
                {
                    return false;
                }
                sum -= pump[1];
            }
            return true;
        }
    }
}
