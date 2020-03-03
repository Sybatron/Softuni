using System;
using System.Collections.Generic;

namespace PI5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //var text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var dict = new SortedDictionary<string, char>
            {
            #region Input
                {".-", 'A' },
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G'},
                {"....", 'H'},
                {"..", 'I'},
                {".---", 'J'},
                {"-.-", 'K'},
                {".-..", 'L'},
                {"--", 'M'},
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X'},
                {"-.--", 'Y'},
                {"--..",'Z'},
                {"-----", '0'},
                {".----", '1'},
                {"..---", '2'},
                {"...--", '3'},
                {"....-", '4'},
                {".....", '5'},
                {"-....", '6'},
                {"--...", '7'},
                {"---..", '8'},
                {"----.", '9'},
            #endregion 
            };

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] != "/")
            //    {
            //        Console.Write(dict[text[i]]);
            //    }
            //    else
            //    {
            //        Console.Write(" ");
            //    }
            //}

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(dict[text[i]] + " ");
            }
            Console.WriteLine();
        }
    }
}
