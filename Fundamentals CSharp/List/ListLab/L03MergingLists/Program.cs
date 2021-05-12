using System;
using System.Collections.Generic;
using System.Linq;

namespace P03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            List<double> secondNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> newNumbers = new List<double>();

            int minCount = Math.Min(firstNumbers.Count, secondNumbers.Count);
            int maxCount = Math.Max(firstNumbers.Count, secondNumbers.Count);

            for (int i = 0; i < minCount; i++)
            {
                newNumbers.Add(firstNumbers[i]);
                newNumbers.Add(secondNumbers[i]);
            }

            for (int i = minCount; i < maxCount; i++)
            {
                if (firstNumbers.Count > secondNumbers.Count)
                {
                    newNumbers.Add(firstNumbers[i]);
                }
                else if (firstNumbers.Count < secondNumbers.Count)
                {
                    newNumbers.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
