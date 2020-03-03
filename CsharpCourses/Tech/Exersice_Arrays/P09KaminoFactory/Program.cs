using System;
using System.Linq;

namespace P09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            //count, starting index, SubSequenceSum, dnaIndex
            int LongestSequenceCount = -1;
            int LongestSequenceStartIndex = -1;
            int LongestSequenceSum = -1;
            int LongestSequenceSample = -1;

            string DNA = "";
            int sampleCount = 1;

            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int[] currentDNA = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int SubSequence = -1;
                int SubSequenceIndex = -1;
                int SubSequenceSum = 0;

                int count = 0;
                for (int i = 0; i < length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        count++;
                        SubSequenceSum++;
                        if (count > SubSequence)
                        {
                            SubSequenceIndex = i - count;
                            SubSequence = count;
                        }
                    }
                    else
                    {

                        count = 0;
                    }
                }

                if (SubSequence > LongestSequenceCount)
                {
                    LongestSequenceCount = SubSequence;
                    LongestSequenceStartIndex = SubSequenceIndex;
                    LongestSequenceSum = SubSequenceSum;
                    LongestSequenceSample = sampleCount;
                    DNA = string.Join(" ", currentDNA);
                }
                else if (SubSequence == LongestSequenceCount
                    && SubSequenceIndex < LongestSequenceStartIndex)
                {
                    LongestSequenceCount = SubSequence;
                    LongestSequenceStartIndex = SubSequenceIndex;
                    LongestSequenceSum = SubSequenceSum;
                    LongestSequenceSample = sampleCount;
                    DNA = string.Join(" ", currentDNA);
                }
                else if (SubSequence == LongestSequenceCount
                    && SubSequenceIndex == LongestSequenceStartIndex
                    && SubSequenceSum > LongestSequenceSum)
                {
                    LongestSequenceCount = SubSequence;
                    LongestSequenceStartIndex = SubSequenceIndex;
                    LongestSequenceSum = SubSequenceSum;
                    LongestSequenceSample = sampleCount;
                    DNA = string.Join(" ", currentDNA);
                }

                input = Console.ReadLine();
                sampleCount++;
            }

            Console.WriteLine($"Best DNA sample {LongestSequenceSample} with sum: {LongestSequenceSum}.");
            Console.WriteLine(DNA);
        }
    }
}
