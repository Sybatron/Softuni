using System;
using System.Text;

namespace P07StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var index = 0;
            var power = 0;
            //abv>1>1>2>2asdasd
            //abv>>>>dasd
            index = text.IndexOf('>', index);
            while (index != -1)
            {
                if (index + 1 < text.Length && char.IsDigit(text[index + 1]))
                {
                    power = text[index + 1] - '0';
                }
                var count = power;
                var i = index + 1;
                var tempText = new StringBuilder(text);
                while (count > 0 && i < tempText.Length)
                {
                    if (tempText[i] != '>')
                    {
                        tempText.Remove(i, 1);
                        count--;
                    }
                    else
                    {
                        index = i;
                        i++;
                        count += tempText[i] - '0';
                    }
                }
                text = tempText.ToString();
                index++;
                index = text.IndexOf('>', index);
            }
            Console.WriteLine(text);
        }
    }
}
