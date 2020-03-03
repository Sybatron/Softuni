using System;
using System.Collections.Generic;
using System.IO;

namespace P02LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(Path.Combine("files", "input.txt")))
            {
                var lines = new List<string>(reader.ReadToEnd()
                    .Split(Environment.NewLine,StringSplitOptions.RemoveEmptyEntries));

                for (int i = 0; i < lines.Count; i++)
                {
                    lines[i] = string.Format($"{i + 1}. {lines[i]}");
                }

                using (var writer = new StreamWriter(Path.Combine("files", "output.txt")))
                {
                    foreach (var line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
