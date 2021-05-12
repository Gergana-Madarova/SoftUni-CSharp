using System;
using System.Collections.Generic;
using System.Linq;

namespace L02GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            //double sum = 0.0;
            int numbersCount = numbers.Count;

            List<double> newNumbers = new List<double>((numbersCount + 1) / 2);

            for (int i = 0; i < (numbersCount + 1) / 2; i++)
            {
                if (numbersCount % 2 != 0 && i == numbersCount / 2)
                {
                    newNumbers.Add(numbers[0 + i]);
                    break;
                }

                double sum = numbers[0 + i] + numbers[numbersCount - 1 - i];
                newNumbers.Add(sum);
            }

            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
