using System;
using System.Text;

namespace P01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //{word} = {reversed word}".

            var input = Console.ReadLine();

            while (input != "end")
            {
                var reverseWord = new StringBuilder();
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseWord.Append(input[i]);
                }
                Console.WriteLine($"{input} = {reverseWord}");
                input = Console.ReadLine();
            }
        }
    }
}
