using System;
using System.Text.RegularExpressions;

namespace P07MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Regex pattern = new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            var matches = pattern.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}" +
                    $", Year: { match.Groups["year"].Value}");
            }
        }
    }
}
