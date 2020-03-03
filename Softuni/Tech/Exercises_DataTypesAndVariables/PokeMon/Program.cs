using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPokePower = int.Parse(Console.ReadLine());
            int distanceBetPokeTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int currentPokePower = startPokePower;
            int counter = 0;
            double halfOfPokePower = currentPokePower * 0.5;

            while (distanceBetPokeTargets <= currentPokePower)
            {
                currentPokePower -= distanceBetPokeTargets;
                counter++;
                if (currentPokePower == halfOfPokePower &&
                    currentPokePower >= exhaustionFactor &&
                    exhaustionFactor > 0)
                {
                    currentPokePower /= exhaustionFactor;
                    if (currentPokePower < distanceBetPokeTargets)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(counter);
        }
    }
}