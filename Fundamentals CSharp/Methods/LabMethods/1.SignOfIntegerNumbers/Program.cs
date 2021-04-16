using System;

namespace _1.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            SignOfNumbers(number);
        }

        private static void SignOfNumbers(int number)
        {
            string output = string.Empty;
            if (number > 0)
            {
                output = $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                output = $"The number {number} is negative.";
            }
            else if (number == 0)
            {
                output = $"The number {number} is zero.";
            }
            Console.WriteLine(output);
        }
    }
}
