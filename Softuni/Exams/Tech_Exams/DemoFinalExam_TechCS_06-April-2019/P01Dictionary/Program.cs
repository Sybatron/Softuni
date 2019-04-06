using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = Console.ReadLine().Split(" | ");
            var dict = new Dictionary<string, List<string>>();

            foreach (var part in parts)
            {
                var word_defs = part.Split(": ");
                for (int i = 1; i < word_defs.Length; i++)
                {
                    if (!dict.ContainsKey(word_defs[0]))
                    {
                        dict[word_defs[0]] = new List<string>();
                    }
                    dict[word_defs[0]].Add(word_defs[i]);
                }
            }

            var words = Console.ReadLine().Split(" | ");
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] = dict[word].OrderByDescending(x => x.Length).ToList();
                    Console.WriteLine($"{word}");
                    foreach (var def in dict[word])
                    {
                        Console.WriteLine($" -{def}");
                    }
                }
            }

            var command = Console.ReadLine();
            if (command == "List")
            {
                dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine(string.Join(" ", dict.Keys));
            }
        }
    }
}
