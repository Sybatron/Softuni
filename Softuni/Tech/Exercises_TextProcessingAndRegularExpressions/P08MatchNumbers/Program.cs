using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P08MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)*($|(?=\s))");
            var matches = Console.ReadLine().Split(" ").Where(x => pattern.IsMatch(x)).ToArray();
            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
