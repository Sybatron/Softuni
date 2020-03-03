using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = "files";
            List<string> words;
            using (var reader = new StreamReader(Path.Combine(dir, "words.txt")))
            {
                words = new List<string>(reader.ReadToEnd()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }
            var wordsForRegex = string.Join("|", words);

            using (var reader = new StreamReader(Path.Combine(dir, "input.txt")))
            {
                var regex = new Regex(@"\b(" + wordsForRegex + @")\b", RegexOptions.IgnoreCase);
                var matches = regex.Matches(reader.ReadToEnd())
                    .Select(x => x.ToString())
                    .Select(x => x.ToLower())
                    .ToArray();

                var dict = new Dictionary<string, int>();
                foreach (var word in matches)
                {
                    if (!dict.ContainsKey(word))
                    {
                        dict[word] = 1;
                    }
                    else
                    {
                        dict[word]++;
                    }
                }

                using (var writer = new StreamWriter(Path.Combine(dir, "output.txt")))
                {
                    dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var word in dict)
                    {
                        writer.WriteLine(string.Format($"{word.Key} - {word.Value}"));
                    }
                }
            }


        }
    }
}
