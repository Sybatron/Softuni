using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            List<string> cards = new List<string>();

            List<string> newDeckOfCards = new List<string>();


            for (int k = 0; k < 1_000; k++)
            {
                for (int i = 2; i < 9; i++)
                {
                    cards.Add(i + "G");
                    cards.Add(i + "R");
                    cards.Add(i + "H");
                    cards.Add(i + "P");
                }
            }
            PrintAllCards(cards);

            int cardsCount = cards.Count;
            for (int i = 0; i < cardsCount; i++)
            {
                SingleRandomAdd(cards, newDeckOfCards);
            }

            Console.Write(Environment.NewLine);
            PrintAllCards(newDeckOfCards);
            time.Stop();
            Console.WriteLine(time.Elapsed);
        }

        private static void SingleRandomAdd(List<string> cards, List<string> newDeckOfCards)
        {
            int RandomPos = new Random().Next(0, cards.Count);
            newDeckOfCards.Add(cards[RandomPos]);
            cards.RemoveAt(RandomPos);
        }

        private static void PrintAllCards(List<string> cards)
        {
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
