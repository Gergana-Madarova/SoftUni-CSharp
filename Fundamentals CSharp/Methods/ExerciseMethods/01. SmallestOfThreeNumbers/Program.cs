using System;

namespace _01._SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int threeNumber = int.Parse(Console.ReadLine());

            GetSmallestNumber(firstNumber, secondNumber, threeNumber);
        }

        private static void GetSmallestNumber(int firstNumber, int secondNumber, int threeNumber)
        {
            int result = 0;

            if (firstNumber <= secondNumber && firstNumber <= threeNumber)
            {
                result = firstNumber;
            }
            else if (secondNumber <= firstNumber && secondNumber <= threeNumber)
            {
                result = secondNumber;
            }
            if (threeNumber <= secondNumber && firstNumber >= threeNumber)
            {
                result = threeNumber;
            }

            Console.WriteLine(result);
        }
    }
}
