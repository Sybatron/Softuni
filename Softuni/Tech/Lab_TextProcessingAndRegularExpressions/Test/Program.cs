using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var text = new StringBuilder(Console.ReadLine());
            //var bannedWords = Console.ReadLine().Split(" ");
            var words = string.Join(Environment.NewLine, Console.ReadLine().Split(" "));
            string longestPalindrome = string.Empty;
            Regex palindromePattern = new Regex(@"^(\w)w*\1$", RegexOptions.Multiline);
            Console.WriteLine(words);
            var matches = palindromePattern.Matches(words);
            foreach (Match match in matches)
            {
                if (match.Value.Length > longestPalindrome.Length)
                {
                    longestPalindrome = match.Value;
                }
            }

            Console.WriteLine(longestPalindrome);
        }
    }
}
