using System;
using System.Text;

namespace P02RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(" ");
            var text = new StringBuilder();
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    text.Append(word);
                }
            }
            Console.WriteLine(text);
        }
    }
}
