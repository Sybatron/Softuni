using System.Collections.Generic;
using System.IO;

namespace P01OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(Path.Combine("files", "input.txt")))
            {
                var line = reader.ReadLine();
                var counter = 0;

                var oddLines = new List<string>();
                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        oddLines.Add(line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }

                using (var writer = new StreamWriter(Path.Combine("files", "output.txt")))
                {
                    foreach (var item in oddLines)
                    {
                        writer.WriteLine(item);
                    }
                }

            }
        }
    }
}
