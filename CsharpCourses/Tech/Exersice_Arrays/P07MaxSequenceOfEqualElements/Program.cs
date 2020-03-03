using System;
using System.Linq;

namespace P07MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sequenceOfNumber = numbers[0];
            int count = 1;
            int[] dataBaseForNumbers = {sequenceOfNumber, count};

            for (int i = 1; i < numbers.Length; i++)
            {
                if (sequenceOfNumber == numbers[i])
                {
                    count++;
                    if (count > dataBaseForNumbers[1])
                    {
                        dataBaseForNumbers[1] = count;
                        dataBaseForNumbers[0] = sequenceOfNumber;
                    }
                }
                else
                {
                    sequenceOfNumber = numbers[i];
                    count = 1;
                }
            }

            for (int i = 0; i < dataBaseForNumbers[1]; i++)
            {
                Console.Write(dataBaseForNumbers[0] + " ");
            }
        }
    }
}

