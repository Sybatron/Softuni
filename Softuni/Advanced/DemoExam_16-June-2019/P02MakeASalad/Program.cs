using System;
using System.Collections.Generic;
using System.Linq;

namespace P02MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            var veggies = new Queue<string>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));
            var salads = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var doneSalads = new Queue<int>();

            while (salads.Count > 0)
            {
                var currentSalad = salads.Peek();
                while (currentSalad > 0)
                {
                    if (veggies.Count > 0)
                    {
                        switch (veggies.Dequeue())
                        {

                            case "tomato":
                                currentSalad -= 80;
                                break;
                            case "carrot":
                                currentSalad -= 136;
                                break;
                            case "lettuce":
                                currentSalad -= 109;
                                break;
                            case "potato":
                                currentSalad -= 215;
                                break;
                        }
                    }
                    else
                    {
                        doneSalads.Enqueue(salads.Pop());
                        Console.WriteLine(string.Join(" ", doneSalads));
                        Console.WriteLine(string.Join(" ", salads));
                        return;
                    }
                }
                doneSalads.Enqueue(salads.Pop());
            }

            Console.WriteLine(string.Join(" ", doneSalads));
            Console.WriteLine(string.Join(" ", veggies));


        }
    }
}
