using System;
using System.Collections.Generic;

namespace P03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //-"{name} is going!"
            //- "{name} is not going!"
            //: "{name} is already in the list!".
            //"{name} is not in the list!".

            List<string> listOfGuests = new List<string>();
            int operationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < operationsCount; i++)
            {
                string[] inputParameters = Console.ReadLine().Split();
                string name = inputParameters[0];
                string operation = inputParameters[2];

                if (operation == "not")
                {
                    if (listOfGuests.Contains(name))
                    {
                        listOfGuests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (listOfGuests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        listOfGuests.Add(name);
                    }
                }


            }

            foreach (var guest in listOfGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
