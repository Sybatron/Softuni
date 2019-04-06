using System;

namespace PrintNumberInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
