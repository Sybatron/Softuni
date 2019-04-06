using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCounter = 0;
            int mouseCounter = 0;
            int keyboardCounter = 0;
            int displayCounter = 0;

            headsetCounter = lostGames / 2;
            mouseCounter = lostGames / 3;
            keyboardCounter = lostGames / 6;
            displayCounter = keyboardCounter / 2;

            double money =  headsetCounter * headsetPrice +
                            mouseCounter * mousePrice +
                            keyboardCounter * keyboardPrice +
                            displayCounter * displayPrice;
            Console.WriteLine($"Rage expenses: {money:f2} lv.");
        }
    }
}
