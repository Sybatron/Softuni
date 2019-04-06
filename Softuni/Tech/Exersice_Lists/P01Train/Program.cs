using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] operations = input.Split().Select(x => x.ToLower()).ToArray();
                if (operations[0] == "add")
                {
                    wagons.Add(int.Parse(operations[1]));
                }
                else
                {
                    int passengers = int.Parse(operations[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacityOfWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
