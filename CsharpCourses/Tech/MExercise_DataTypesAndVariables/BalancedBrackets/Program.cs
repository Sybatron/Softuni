using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int bracketsCounter = 0;
            bool balanced = true;
            for (int i = 0; i < length; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    bracketsCounter++;
                }
                else if (input == ")")
                {
                    bracketsCounter--;
                }

                if (bracketsCounter < 0)
                {
                    balanced = false;
                }
            }
            if (bracketsCounter > 0)
            {
                balanced = false;
            }

            if(balanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
