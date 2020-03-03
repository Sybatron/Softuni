using System;
using System.Text.RegularExpressions;

namespace P01ArrivingInKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"^(?<name>([!@#$?]{0,}[A-Za-z0-9]{1,}[!@#$?]{0,}){1,})=(?<length>\d{1,})<<(?<geohash>.{1,})$");

            while (input != "Last note")
            {
                if (pattern.IsMatch(input))
                {
                    var match = pattern.Match(input);
                    var length = int.Parse(match.Groups["length"].ToString());
                    var geohash = match.Groups["geohash"].ToString();
                    if (!(geohash.Length == length))
                    {
                        Console.WriteLine("Nothing found!");
                        input = Console.ReadLine();
                        continue;
                    }
                    var peak = match.Groups["name"].ToString()
                        .Split(new char[] { '!', '@', '#', '$', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine($"Coordinates found! {string.Join("",peak)} -> {geohash}");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
