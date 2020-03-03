using System;
using System.Collections.Generic;
using System.Linq;

namespace P02OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("->").ToList();
            var storesDict = new Dictionary<string, List<string>>();
            while (input[0] != "END")
            {
                if (input[0] == "Add")
                {
                    if (!storesDict.ContainsKey(input[1]))
                    {
                        storesDict[input[1]] = new List<string>();
                    }
                    var items = input[2].Split(',');
                    storesDict[input[1]].AddRange(items);
                }
                else
                {
                    storesDict.Remove(input[1]);
                }
                input = Console.ReadLine().Split("->").ToList();
            }
            storesDict = storesDict.OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Stores list:");
            foreach (var store in storesDict)
            {
                Console.WriteLine(store.Key);
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
