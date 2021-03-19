using System;
using System.Diagnostics.CodeAnalysis;

namespace L05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                bool special = false;
                int currentNum = i;

                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }           

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
