using System;
using System.Text.RegularExpressions;

namespace P06MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            var matches = pattern.Matches(text);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
