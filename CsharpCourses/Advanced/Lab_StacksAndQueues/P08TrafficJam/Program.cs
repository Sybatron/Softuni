using System;
using System.Collections.Generic;

namespace P08TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var count = 0;
            var input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "green")
                {
                    var i = n;
                    while (queue.Count > 0 && i > 0)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                        i--;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
