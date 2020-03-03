using System;
using System.Collections.Generic;

namespace P06AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var carsToBeServed = new Queue<string>(input);
            var servedCars = new Stack<string>();

            var command = Console.ReadLine()
                .Split("-", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    //Service, CarInfo -{ modelName} and History
                    case "Service":
                        if (carsToBeServed.Count > 0)
                        {
                            Console.WriteLine($"Vehicle {carsToBeServed.Peek()} got served.");
                            servedCars.Push(carsToBeServed.Dequeue());
                        }

                        break;
                    case "CarInfo":
                        if (carsToBeServed.Contains(command[1]))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                    case "History":
                        Console.WriteLine(string.Join(", ", servedCars));
                        break;
                }
                command = Console.ReadLine()
                .Split("-", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carsToBeServed.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsToBeServed)}");
            }
            if (servedCars.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
            }
        }
    }
}
