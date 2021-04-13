using System;
using System.Linq;

namespace _8._MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputInt = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputInt.Length; i++)
            {
                for (int j = i+1; j < inputInt.Length; j++)
                {
                    if (inputInt[i] + inputInt[j] == givenNumber)
                    {
                        Console.WriteLine($"{inputInt[i]} {inputInt[j]}");
                    }
                }
            }
        }
    }
}
