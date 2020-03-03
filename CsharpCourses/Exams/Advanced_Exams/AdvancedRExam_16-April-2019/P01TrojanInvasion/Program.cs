using System;
using System.Collections.Generic;
using System.Linq;

namespace P01TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            var waves = int.Parse(Console.ReadLine());
            var plates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            for (int i = 0; i < waves; i++)
            {
                var warriors = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
                    .ToList();
                if ((i+1) % 3 == 0)
                {
                    plates.Add(int.Parse(Console.ReadLine()));
                }

                while (warriors.Count > 0)
                {
                    if (plates.Count > 0)
                    {
                        if (warriors[0] > plates[0])
                        {
                            warriors[0] -= plates[0];
                            plates.RemoveAt(0);
                        }
                        else
                        {
                            plates[0] -= warriors[0];
                            warriors.RemoveAt(0);
                            if (plates[0] == 0)
                            {
                                plates.RemoveAt(0);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                        Console.WriteLine($"Warriors left: {string.Join(", ", warriors)}");
                        return;
                    }
                }
            }

            Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
        }
    }
}
