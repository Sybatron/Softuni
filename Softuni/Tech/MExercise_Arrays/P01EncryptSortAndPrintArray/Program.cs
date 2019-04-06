using System;

namespace P01EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] encryptedStringsValues = new int[length];
            for (int i = 0; i < length; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {

                    if (input[j] == 'a' ||
                        input[j] == 'e' ||
                        input[j] == 'i' ||
                        input[j] == 'o' ||
                        input[j] == 'u' ||
                        input[j] == 'A' ||
                        input[j] == 'E' ||
                        input[j] == 'I' ||
                        input[j] == 'O' ||
                        input[j] == 'U')
                    {
                        sum += ((int)input[j] * input.Length);
                    }
                    else
                    {
                        sum += ((int)input[j] / input.Length);
                    }
                }
                encryptedStringsValues[i] = sum;
            }

            Array.Sort(encryptedStringsValues);
            foreach (var number in encryptedStringsValues)
            {
                Console.WriteLine(number);
            }
        }
    }
}
