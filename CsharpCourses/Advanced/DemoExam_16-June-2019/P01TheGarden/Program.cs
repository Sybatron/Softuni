using System;
using System.Collections.Generic;
using System.Linq;

namespace P01TheGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var garden = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                garden[i] = Console.ReadLine()
                    .Split(" ");
            }

            var harvest = new Dictionary<string, int>
            {
                {"C", 0},
                {"P", 0},
                {"L", 0},
                {"HV", 0}
            };

            var input = Console.ReadLine();
            while (input != "End of Harvest")
            {
                var command = input.Substring(0, input.IndexOf(" "));
                var cord =
                    input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .Take(2)
                    .Select(int.Parse)
                    .ToArray();
                if (cord[0] >= 0 && cord[0] < garden.Length
                   && cord[1] >= 0 && cord[1] < garden[cord[0]].Length)
                {
                    if (command == "Harvest")
                    {
                        if (garden[cord[0]][cord[1]] != " ")
                        {
                            harvest[
                                garden[
                                    cord[0]][cord[1]]]++;
                            garden[cord[0]][cord[1]] = " ";
                        }
                    }
                    else
                    {
                        var dir = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Last()
                            .ToLower();
                        switch (dir)
                        {
                            case "up":
                                Up(ref garden, ref harvest, cord);
                                break;
                            case "down":
                                Down(ref garden, ref harvest, cord);
                                break;
                            case "right":
                                Right(ref garden, ref harvest, cord);
                                break;
                            case "left":
                                Left(ref garden, ref harvest, cord);
                                break;
                        }
                    }
                }


                input = Console.ReadLine();
            }
            for (int i = 0; i < garden.Length; i++)
            {
                Console.WriteLine(string.Join(" ", garden[i]));
            }
            Console.WriteLine($"Carrots: {harvest["C"]}");
            Console.WriteLine($"Potatoes: {harvest["P"]}");
            Console.WriteLine($"Lettuce: {harvest["L"]}");
            Console.WriteLine($"Harmed vegetables: {harvest["HV"]}");
        }

        public static void Up(ref string[][] garden, ref Dictionary<string, int> harvest, int[] cord)
        {
            for (int i = cord[0]; i >= 0; i -= 2)
            {
                if (garden[i][cord[1]] != " ")
                {
                    harvest["HV"]++;
                    garden[i][cord[1]] = " ";
                }
            }
        }
        public static void Down(ref string[][] garden, ref Dictionary<string, int> harvest, int[] cord)
        {
            for (int i = cord[0]; i <= garden.Length; i += 2)
            {
                if (garden[i][cord[1]] != " ")
                {
                    harvest["HV"]++;
                    garden[i][cord[1]] = " ";
                }
            }
        }
        public static void Right(ref string[][] garden, ref Dictionary<string, int> harvest, int[] cord)
        {
            for (int i = cord[1]; i <= garden[cord[0]].Length; i += 2)
            {
                if (garden[cord[0]][i] != " ")
                {
                    harvest["HV"]++;
                    garden[cord[0]][i] = " ";
                }
            }
        }
        public static void Left(ref string[][] garden, ref Dictionary<string, int> harvest, int[] cord)
        {
            for (int i = cord[1]; i >= 0; i -= 2)
            {
                if (garden[cord[0]][i] != " ")
                {
                    harvest["HV"]++;
                    garden[cord[0]][i] = " ";
                }
            }
        }
    }
}
