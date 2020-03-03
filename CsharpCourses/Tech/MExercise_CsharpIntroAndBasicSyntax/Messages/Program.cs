using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    text += " ";
                }
                else
                {
                    int mainDigit = input % 10;
                    int letter = (mainDigit - 2) * 3;
                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        letter++;
                    }
                    letter = letter + input.ToString().Length - 1;
                    text += ((char)(letter + 'a')).ToString();
                }
            }
            Console.WriteLine(text);
        }
    }
}
