using System;


namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            double help;
            switch(a)
            {
                case "USD":
                    help = value * 1.79549;
                    break;
                case "EUR":
                    help = value * 1.95583;
                    break;
                case "GBP":
                    help = value * 2.53405;
                    break;
                default:
                    help = value;
                    break;
            }

            switch (b)
            {
                case "USD":
                    help = help / 1.79549;
                    break;
                case "EUR":
                    help = help / 1.95583;
                    break;
                case "GBP":
                    help = help / 2.53405;
                    break;
                default:
                    break;
            }

            Console.WriteLine(Math.Round(help,2)+" "+b);
        }
    }
}
