using System;

namespace P02PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            if (length == 1)
            {
                Console.WriteLine(1);
            }
            else if (length == 0)
            {

            }
            else
            {
                int[,] PascalTriangle = new int[2, length];
                PascalTriangle[0, 0] = 1;
                PascalTriangle[0, 1] = 1;
                PascalTriangle[1, 0] = 1;
                PascalTriangle[1, 1] = 1;
                Console.WriteLine(1);
                for (int i = 2; i <= length; i++)
                {
                    int[] output = new int[i];
                    output[0] = 1;

                    for (int column = 1; column < i - 1; column++)
                    {
                        PascalTriangle[1, column] = PascalTriangle[0, column] + PascalTriangle[0, column - 1];
                        output[column] = PascalTriangle[1, column];
                    }
                    for (int column = 1; column < i - 1; column++)
                    {
                        PascalTriangle[0, column] = PascalTriangle[1, column];
                    }

                    output[output.Length - 1] = 1;
                    Console.WriteLine(string.Join(" ", output));

                    if (i == length)
                    {
                        return;
                    }
                    PascalTriangle[0, i] = 1;
                }
            }

        }
    }
}
