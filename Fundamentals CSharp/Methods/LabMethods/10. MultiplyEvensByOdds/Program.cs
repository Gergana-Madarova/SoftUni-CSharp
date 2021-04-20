using System;

namespace _10._MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                number = Math.Abs(number);
            }

            int sumEven = GetSumOfEvenDigits(number);
            int sumOdd = GetSumOfOddDigits(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumEven, sumOdd));
        }

        private static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            return sumEven * sumOdd;
        }

        private static int GetSumOfOddDigits(int number)
        {
            string numToString = number.ToString();
            int sumOdd = 0;

            for (int i = 0; i < numToString.Length; i++)
            {
                if ((number) % 2 != 0)
                {
                    sumOdd += number % 10;
                }

                number = number / 10;
            }

            return sumOdd;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            string numToString = number.ToString();
            int sumEvens = 0;

            for (int i = 0; i < numToString.Length; i++)
            {
                if ((number) % 2 == 0)
                {
                    sumEvens += number % 10;
                }

                number = number / 10;
            }

            return sumEvens;
        }
    }
}
