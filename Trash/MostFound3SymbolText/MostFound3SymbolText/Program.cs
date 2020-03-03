using System;

namespace MostFound3SymbolText
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input text
            string text = Console.ReadLine();

            string mostFound = "";
            int mostFoundCount = -1;

            for (int i = 0; i <= text.Length - 3; i++)
            {
                string currentText = text.Substring(i, 3);
                int index = text.IndexOf(currentText);
                int currentCount = 0;
                //Finding count of the current text
                while (index != -1)
                {
                    currentCount++;
                    index = text.IndexOf(currentText, index + 1);
                }

                //Compare current and current most found text and changing values if necessary
                if (currentCount > mostFoundCount)
                {
                    mostFoundCount = currentCount;
                    mostFound = currentText;
                }
            }

            Console.WriteLine("Най-срещания 3 символен низ е: " + mostFound);
            Console.WriteLine("Среща се: " + mostFoundCount);
        }
    }
}
