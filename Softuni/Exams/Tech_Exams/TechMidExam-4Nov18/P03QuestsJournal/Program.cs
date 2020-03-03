using System;
using System.Collections.Generic;
using System.Linq;

namespace P03QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            while (input != "Retire!")
            {
                string[] inputParameters = input.Split(" - ");

                if (inputParameters[0] == "Start" && !quests.Contains(inputParameters[1]))
                {
                    quests.Add(inputParameters[1]);
                }
                else if (quests.Contains(inputParameters[1]))
                {
                    if (inputParameters[0] == "Complete")
                    {
                        quests.Remove(inputParameters[1]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", quests));
        }
    }
}
