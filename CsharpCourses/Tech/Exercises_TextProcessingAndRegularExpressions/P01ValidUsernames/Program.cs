using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^[\w-]{3,16}$");
            var usernames = Console.ReadLine().Split(", ").Where(x => pattern.IsMatch(x)).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, usernames));
        }
    }
}
