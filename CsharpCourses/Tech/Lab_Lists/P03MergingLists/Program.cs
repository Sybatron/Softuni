using System;
using System.Collections.Generic;
using System.Linq;

namespace P03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();
            List<int> numbers2 = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

            int length = Math.Max(numbers1.Count, numbers2.Count);
            List<int> resultNumbers = new List<int>(length);
            resultNumbers.AddRange(numbers1);

            for (int i = 1, index = 0; index < numbers2.Count; i += 2, index++)
            {
                if (i >= resultNumbers.Count)
                {
                    resultNumbers.Add(numbers2[index]);
                }
                else
                {
                    resultNumbers.Insert(i, numbers2[index]);
                }
            }
            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
