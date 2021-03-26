using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecialNum = false;
            for (int number = 1; number <= n; number++)
            {
                int currentNumber = number;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNum);
                number = currentNumber;
            }
        }
    }
}
