using System;
using System.Linq;

namespace L04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers.Take(3)));
        }
    }
}
