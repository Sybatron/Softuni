using System;
using System.Text.RegularExpressions;

namespace P08MatchAPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Regex pattern = new Regex(@"(?<!\w)\+359(?<space>[ -])2\1\d{3}\1\d{4}(?!\w)");
            var matches = pattern.Matches(text);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
