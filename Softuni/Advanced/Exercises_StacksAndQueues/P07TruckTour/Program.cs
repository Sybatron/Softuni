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
            var queue = new Queue<int[]>();

            for (int i = 0; i < length; i++)
            {
                var parameters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                queue.Enqueue(parameters);
            }

            var index = 0;

            while (true)
            {
                var totalFuel = 0;

                foreach (var pump in queue)
                {
                    var currentPetrol = pump[0];
                    var currentDistance = pump[1];

                    totalFuel += currentPetrol - currentDistance;

                    if (totalFuel < 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
            }

        }
    }
}
