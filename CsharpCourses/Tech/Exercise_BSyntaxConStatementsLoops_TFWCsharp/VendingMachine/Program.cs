using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            List<string> orders = new List<string>();
            List<double> wrongCoins = new List<double>();

            for (; ; )
            {
                string input = Console.ReadLine();
                try
                {
                    double coin = double.Parse(input);
                    switch (coin)
                    {
                        case 0.1:
                        case 0.2:
                        case 0.5:
                        case 1:
                        case 2:
                            {
                                sum += coin;
                                break;
                            }
                        default:
                            {
                                wrongCoins.Add(coin);
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    if (input == "Start")
                    {
                        for (; ; )
                        {
                            string product = Console.ReadLine().ToLower();
                            if (product != "end")
                            {
                                switch (product)
                                {
                                    case "nuts":
                                        {
                                            if (sum - 2.0 >= 0)
                                            {
                                                orders.Add("Purchased " + product);
                                                sum -= 2.0;
                                            }
                                            else
                                            {
                                                orders.Add("Sorry, not enough money");
                                            }
                                            break;
                                        }
                                    case "water":
                                        {
                                            if (sum - 0.7 >= 0)
                                            {
                                                orders.Add("Purchased " + product);
                                                sum -= 0.7;
                                            }
                                            else
                                            {
                                                orders.Add("Sorry, not enough money");
                                            }
                                            break;
                                        }
                                    case "crisps":
                                        {
                                            if (sum - 1.5 >= 0)
                                            {
                                                orders.Add("Purchased " + product);
                                                sum -= 1.5;
                                            }
                                            else
                                            {
                                                orders.Add("Sorry, not enough money");
                                            }
                                            break;
                                        }
                                    case "soda":
                                        {
                                            if (sum - 0.8 >= 0)
                                            {
                                                orders.Add("Purchased " + product);
                                                sum -= 0.8;
                                            }
                                            else
                                            {
                                                orders.Add("Sorry, not enough money");
                                            }
                                            break;
                                        }
                                    case "coke":
                                        {
                                            if (sum - 1.0 >= 0)
                                            {
                                                orders.Add("Purchased " + product);
                                                sum -= 1.0;
                                            }
                                            else
                                            {
                                                orders.Add("Sorry, not enough money");
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            orders.Add("Invalid product");
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                foreach (var notCoin in wrongCoins)
                                {
                                    Console.WriteLine($"Cannot accept {notCoin}");
                                }
                                foreach (var order in orders)
                                {
                                    Console.WriteLine(order);
                                }
                                Console.WriteLine($"Change: {sum:f2}");
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
