using System;
using System.Linq;

namespace P10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] ladyBugsIndexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] field = new int[length];
            Array.Fill(field, 0);
            foreach (var index in ladyBugsIndexes)
            {
                try
                {
                    field[index] = 1;
                }
                catch (Exception)
                {
                }
            }
            //index direction movePower
            string[] input = Console.ReadLine().Split(" ");
            while (input[0] != "end")
            {
                int index = int.Parse(input[0]);
                string direction = input[1];
                int movePower = int.Parse(input[2]);

                if (index >= 0 && index < length && field[index] == 1)
                {
                    field[index] = 0;
                    if (direction == "right")
                    {
                        for (int i = index + movePower; i < length; i += movePower)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = index - movePower; i >= 0; i -= movePower)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
