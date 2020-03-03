using System;
using System.Linq;

namespace P00RetakeMidExam_SantasList
{
    class Program
    {
        static void Main(string[] args)
        {
            var noisyKids = Console.ReadLine()
                .Split("&")
                .ToList();

            var input = Console.ReadLine();
            while (input != "Finished!")
            {
                var inputParameters = input.Split();
                var operation = inputParameters[0].ToLower();
                var name = inputParameters[1];

                if (operation == "bad" && !noisyKids.Contains(name))
                {
                    noisyKids.Insert(0, name);
                }
                else if (operation == "good" && noisyKids.Contains(name))
                {
                    noisyKids.Remove(name);
                }
                else if (operation == "rename" && noisyKids.Contains(name))
                {
                    string newName = inputParameters[2];
                    noisyKids[noisyKids.IndexOf(name)] = newName;
                }
                else if (operation == "rearrange" && noisyKids.Contains(name))
                {
                    noisyKids.Add(name);
                    noisyKids.Remove(name);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", noisyKids));
        }
    }
}