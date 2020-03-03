using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var amount = long.Parse(Console.ReadLine());

            if(town=="sofia")
            {
                switch (name)
                {
                    case "coffee":
                        Console.WriteLine(amount*0.50);
                        break;

                    case "water":
                        Console.WriteLine(amount * 0.80);
                        break;

                    case "beer":
                        Console.WriteLine(amount * 1.20);
                        break;

                    case "sweets":
                        Console.WriteLine(amount * 1.45);
                        break;

                    case "peanuts":
                        Console.WriteLine(amount * 1.60);
                        break;
                }
            }

            else if (town == "plovdiv")
            {
                switch (name)
                {
                    case "coffee":
                        Console.WriteLine(amount * 0.40);
                        break;

                    case "water":
                        Console.WriteLine(amount * 0.70);
                        break;

                    case "beer":
                        Console.WriteLine(amount * 1.15);
                        break;

                    case "sweets":
                        Console.WriteLine(amount * 1.30);
                        break;

                    case "peanuts":
                        Console.WriteLine(amount * 1.50);
                        break;
                }
            }

            else if (town == "varna")
            {
                switch (name)
                {
                    case "coffee":
                        Console.WriteLine(amount * 0.45);
                        break;

                    case "water":
                        Console.WriteLine(amount * 0.70);
                        break;

                    case "beer":
                        Console.WriteLine(amount * 1.10);
                        break;

                    case "sweets":
                        Console.WriteLine(amount * 1.35);
                        break;

                    case "peanuts":
                        Console.WriteLine(amount * 1.55);
                        break;
                }
            }

            else Console.WriteLine(0);
        }
    }
}
