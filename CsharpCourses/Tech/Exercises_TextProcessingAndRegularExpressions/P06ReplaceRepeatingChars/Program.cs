using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P06ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    var pattern = new Regex($"[{text[i]}]"+"{2,}");
                    Match match = pattern.Match(text.ToString());
                    text = text.Replace(match.Value, text[i].ToString());
                    i = -1;
                }
            }
            Console.WriteLine(text);
        }
    }
}
