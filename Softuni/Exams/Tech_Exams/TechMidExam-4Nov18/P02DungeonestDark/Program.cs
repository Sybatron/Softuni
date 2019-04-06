using System;

namespace P02DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;
            string[] rooms = Console.ReadLine().Split("|");

            int roomNumber = 1;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] eventParameters = rooms[i].Split();
                string operation = eventParameters[0];
                int number = int.Parse(eventParameters[1]);

                if (operation == "potion")
                {
                    if (health + number <= 100)
                    {
                        health += number;
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {

                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (operation == "chest")
                {
                    coins += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                else if (health - number > 0)
                {
                    health -= number;
                    Console.WriteLine($"You slayed {operation}.");
                }
                else
                {
                    Console.WriteLine($"You died! Killed by {operation}.");
                    Console.WriteLine($"Best room: {roomNumber}");
                    return;
                }

                roomNumber++;
            }
            //You've made it!", "Coins: {coins}", "Health: {health}
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
