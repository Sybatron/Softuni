using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P09StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            //The planet name starts after '@' and contains only letters from the Latin alphabet.
            //The planet population starts after ':' and is an Integer;
            //The attack type may be "A"(attack) or "D"(destruction) and must be surrounded by "!"(exclamation mark).
            //The soldier count starts after "->" and should be an Integer.

            var length = int.Parse(Console.ReadLine());
            var countPattern = new Regex(@"[star]", RegexOptions.IgnoreCase);
            var pattern = new Regex(@"^([^->@:!]*)@(?<name>[A-Za-z]+)([^->@:!]*):(\d+)([^->@:!]*)!(?<type>[AD])!([^->@:!]*)->(\d+)([^->@:!]*)$");

            var attackedPlanets = new List<string>();
            var attackedPlanetsCount = 0;
            var destroyedPlanets = new List<string>();
            var destroyedPlanetsCount = 0;

            for (int i = 0; i < length; i++)
            {
                //Input
                var text = Console.ReadLine();
                var tempText = new StringBuilder(text);

                //Counting s,t,a,r letters and substract ASCII value by their count
                var count = countPattern.Matches(text);
                for (int j = 0; j < tempText.Length; j++)
                {
                    tempText[j] = (char)(tempText[j] - count.Count);
                }
                text = tempText.ToString();

                //Add new planet
                var matches = pattern.Match(text);
                if (matches.Value != "")
                {
                    if (matches.Groups["type"].Value == "A")
                    {
                        attackedPlanetsCount++;
                        attackedPlanets.Add(matches.Groups["name"].Value);
                    }
                    else
                    {
                        destroyedPlanetsCount++;
                        destroyedPlanets.Add(matches.Groups["name"].Value);
                    }
                }
            }
            //Attacked planets: 1
            //->Alderaa
            //Destroyed planets: 1
            //->Cantonica

            //Output the attacked planets
            Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");
            attackedPlanets.Sort();
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            //Output the destroyed planets
            Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");
            destroyedPlanets.Sort();
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
