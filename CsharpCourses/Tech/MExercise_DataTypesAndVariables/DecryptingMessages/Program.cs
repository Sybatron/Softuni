using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int decryptionKey = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = 0; i < length; i++)
            {
                text += (char)(char.Parse(Console.ReadLine()) + decryptionKey);
            }
            Console.WriteLine(text);
        }
    }
}
