using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(input);
            int sum = 0;
            for (int index = 0; index < input.Length; index++)
            {
                int multiplication = 1;
                int n = int.Parse((input[index]).ToString());
                for (int start = 2; start <= n; start++)
                {
                    multiplication *= start;
                }
                sum += multiplication;
            }
            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
