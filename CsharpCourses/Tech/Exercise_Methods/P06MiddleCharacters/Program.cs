using System;

namespace P06MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacters(text);
        }

        private static void PrintMiddleCharacters(string text)
        {
            string middle = "";
            if (text.Length % 2 == 0)
            {
                middle += text[text.Length / 2 - 1].ToString()+text[text.Length / 2].ToString();
                Console.WriteLine(middle);
            }
            else
            {
                middle += text[text.Length / 2].ToString();
                Console.WriteLine(middle);
            }
        }
    }
}
