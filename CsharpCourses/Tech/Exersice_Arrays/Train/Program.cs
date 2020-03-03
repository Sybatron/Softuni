using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] numbers = new int[lenght];
            int peopleCounter = 0;

            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                peopleCounter += numbers[i];
            }
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(peopleCounter);
        }
    }
}
