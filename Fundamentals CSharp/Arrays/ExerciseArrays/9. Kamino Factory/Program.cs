using System;
using System.Linq;
using System.Threading;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            uint lengthOfSequence = uint.Parse(Console.ReadLine());
            string sequences = Console.ReadLine();
            int[] DNA1 = new int[lengthOfSequence - 1];
            int[] DNA2 = new int[lengthOfSequence - 1];
            int countSeq = 0;
            int count1DNA1 = 0;
            int count1DNA2 = 0;
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;

            while (sequences != "Clone them!")
            {
                if (countSeq == 0)
                {
                    DNA1 = sequences
                        .Split('!', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    countSeq++;
                    bestSequenceIndex = countSeq;

                    for (int i = 0; i < DNA1.Length; i++)
                    {
                        if (DNA1[i] == 1)
                        {
                            count1DNA1++;
                        }
                        bestSequenceSum = count1DNA1;
                    }
                }
                else if (countSeq == 1)
                {
                    DNA2 = sequences
                        .Split('!', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    countSeq++;
                    count1DNA1 = 0;

                    for (int i = 0; i < DNA1.Length; i++)
                    {
                        if (DNA1[i] == 1)
                        {
                            count1DNA1++;
                        }
                        if (DNA2[i] == 1)
                        {
                            count1DNA2++;
                        }
                        if (count1DNA1 > count1DNA2)
                        {
                            DNA2 = DNA1;
                            bestSequenceIndex = countSeq;   //DNA1
                            bestSequenceSum = count1DNA1;
                        }
                        else
                        {
                            bestSequenceIndex = countSeq + 1;    //DNA2
                            bestSequenceSum = count1DNA2;
                        }
                    }
                }
                else if (countSeq >= 2)
                {
                    DNA1 = sequences
                        .Split('!', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    countSeq++;

                    for (int i = 0; i < DNA1.Length; i++)
                    {
                        if (DNA1[i] == 1)
                        {
                            count1DNA1++;
                        }
                        if (DNA2[i] == 1)
                        {
                            count1DNA2++;
                        }
                        if (count1DNA1 > count1DNA2)
                        {
                            DNA2 = DNA1;
                        }
                    }

                    count1DNA1 = 0;
                    count1DNA2 = 0;
                }

                    sequences = Console.ReadLine();
                }

                Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: { bestSequenceSum}.");
            }
        }
    }
