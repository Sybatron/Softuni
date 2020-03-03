using System;
using System.Text;

namespace P04CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = (char)(text[i] + 3);
            }
            Console.WriteLine(text);
        }
    }
}
