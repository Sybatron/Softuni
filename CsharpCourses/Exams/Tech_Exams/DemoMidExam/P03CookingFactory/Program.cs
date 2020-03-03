using System;
using System.Linq;

namespace P03CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int HighestTotalQuality = int.MinValue;
            decimal HighestAvgQuality = decimal.MinValue;
            int ShortestLenght = int.MaxValue;

            string BestBread = "";

            string input = Console.ReadLine();
            if (input == "Bake It!")
            {
                return;
            }

            while (input != "Bake It!")
            {
                int[] currentBreadBanch = input
                    .Split('#', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int SubTotalQuality = currentBreadBanch.Sum();
                decimal SubAvgQuality = SubTotalQuality / currentBreadBanch.Length * decimal.One;
                int SubShortestLenght = currentBreadBanch.Length;

                if (SubTotalQuality > HighestTotalQuality)
                {
                    HighestTotalQuality = SubTotalQuality;
                    HighestAvgQuality = SubAvgQuality;
                    ShortestLenght = SubShortestLenght;
                    BestBread = string.Join(" ", currentBreadBanch);
                }
                else if (SubTotalQuality == HighestTotalQuality
                    && SubAvgQuality > HighestAvgQuality)
                {
                    HighestTotalQuality = SubTotalQuality;
                    HighestAvgQuality = SubAvgQuality;
                    ShortestLenght = SubShortestLenght;
                    BestBread = string.Join(" ", currentBreadBanch);
                }
                else if (SubTotalQuality == HighestTotalQuality
                    && SubAvgQuality == HighestAvgQuality
                    && SubShortestLenght < ShortestLenght)
                {
                    HighestTotalQuality = SubTotalQuality;
                    HighestAvgQuality = SubAvgQuality;
                    ShortestLenght = SubShortestLenght;
                    BestBread = string.Join(" ", currentBreadBanch);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best Batch quality: {HighestTotalQuality}");
            Console.WriteLine(BestBread);
        }
    }
}
