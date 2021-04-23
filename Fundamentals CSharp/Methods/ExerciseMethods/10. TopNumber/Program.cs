using System;

namespace _10._TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 17; i <= number; i++)
            {
                GetTopNum(i);
            }
        }

        private static void GetTopNum(int number)
        {
            int currNum = number;
            bool haveOddDigit = false;

            while (currNum != 0)
            {
                int currChifre = currNum % 10;

                if (currChifre % 2 != 0)
                {
                    haveOddDigit = true;
                    break;
                }

                currNum /= 10;
            }

            currNum = number;
            int sumOfDigits = 0;
            bool isDivisibleByEight = false;

            while (currNum != 0)
            {
                sumOfDigits += currNum % 10;
                currNum /= 10;
            }

            if (sumOfDigits % 8 == 0)
            {
                isDivisibleByEight = true;
            }

            if (isDivisibleByEight && haveOddDigit)
            {
                Console.WriteLine(number);
            }
        }
    }
}
