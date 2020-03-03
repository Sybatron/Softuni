using System;
using System.Text.RegularExpressions;

namespace P05DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex digitsPat = new Regex(@"[\d]+");
            Regex lettersPat = new Regex(@"[A-Za-z]+");
            Regex otherPat = new Regex(@"[^A-Za-z0-9]");

            var text = Console.ReadLine();
            var digits = digitsPat.Matches(text);
            var letters = lettersPat.Matches(text);
            var other = otherPat.Matches(text);

            foreach (Match match in digits)
            {
                Console.Write(match.Value);
            }
            Console.WriteLine();
            foreach (Match match in letters)
            {
                Console.Write(match.Value);
            }
            Console.WriteLine();
            foreach (Match match in other)
            {
                Console.Write(match.Value);
            }
        }
    }
}
