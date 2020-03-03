using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            for (int i = 0; i < 3; i++)
            {
                text += Console.ReadLine() + " ";
            }

            char[] characters = text.ToCharArray();
            Array.Reverse(characters);
            string reversedText = new string(characters);
            reversedText.Remove(0, 1);
            Console.WriteLine(reversedText);
        }
    }
}
