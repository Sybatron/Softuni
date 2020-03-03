using System;

namespace GamingStore
{
    class Program
    {
        static double balance;
        static double remain;
        static void Main(string[] args)
        {
            balance = double.Parse(Console.ReadLine());
            remain = balance;
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "Game Time")
                {
                    switch (input)
                    {
                        case "OutFall 4":
                            {
                                if (remain - 39.99 > 0)
                                {
                                    remain -= 39.99;
                                    Console.WriteLine($"Bought {input}");
                                }
                                else if (remain - 39.99 == 0)
                                {
                                    Console.WriteLine("Out of money!");
                                    result();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            }
                        case "CS: OG":
                            {
                                if (remain - 15.99 > 0)
                                {
                                    remain -= 15.99;
                                    Console.WriteLine($"Bought {input}");
                                }
                                else if (remain - 15.99 == 0)
                                {
                                    Console.WriteLine("Out of money!");
                                    result();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            }
                        case "Zplinter Zell":
                            {
                                if (remain - 19.99 > 0)
                                {
                                    remain -= 19.99;
                                    Console.WriteLine($"Bought {input}");
                                }
                                else if (remain - 19.99 == 0)
                                {
                                    Console.WriteLine("Out of money!");
                                    result();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            }
                        case "Honored 2":
                            {
                                if (remain - 59.99 > 0)
                                {
                                    remain -= 59.99;
                                    Console.WriteLine($"Bought {input}");
                                }
                                else if (remain - 59.99 == 0)
                                {
                                    Console.WriteLine("Out of money!");
                                    result();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            }
                        case "RoverWatch":
                            {
                                if (remain - 29.99 > 0)
                                {
                                    remain -= 29.99;
                                    Console.WriteLine($"Bought {input}");
                                }
                                else if (remain - 29.99 == 0)
                                {
                                    Console.WriteLine("Out of money!");
                                    result();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            }
                        case "RoverWatch Origins Edition":
                            {
                                if (remain - 39.99 > 0)
                                {
                                    remain -= 39.99;
                                    Console.WriteLine($"Bought {input}");
                                }
                                else if (remain - 39.99 == 0)
                                {
                                    Console.WriteLine("Out of money!");
                                    result();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Too Expensive");
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Not Found");
                                break;
                            }
                    }
                }
                else
                {
                    result();
                    return;
                }
            }
        }
        static void result()
        {
            Console.WriteLine($"Total spent: ${balance - remain:f2}. Remaining: ${remain:f2}");
        }
    }
}
