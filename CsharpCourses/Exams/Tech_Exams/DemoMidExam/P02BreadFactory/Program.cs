using System;

namespace P02BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;
            string[] events = Console.ReadLine().Split("|");

            //operations: 
            //rest(gain energy no more than 100)
            //order(gain coins -30EN)
            //ingridient(lose money or bankrupt)
            for (int i = 0; i < events.Length; i++)
            {
                string[] eventParameters = events[i].Split("-");
                string operation = eventParameters[0];
                int number = int.Parse(eventParameters[1]);

                if (operation == "rest")
                {
                    if (energy + number <= 100)
                    {
                        energy += number;
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                    else
                    {
                        Console.WriteLine($"You gained {100 - energy} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                else if (operation == "order")
                {
                    if (energy - 30 >= 0)
                    {
                        energy -= 30;
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else if (coins - number > 0)
                {
                    coins -= number;
                    Console.WriteLine($"You bought {operation}.");
                }
                else
                {
                    Console.WriteLine($"Closed! Cannot afford {operation}.");
                    return;
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
