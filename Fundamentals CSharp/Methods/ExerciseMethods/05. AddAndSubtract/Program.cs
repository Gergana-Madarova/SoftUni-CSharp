using System;

namespace _05._AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = Sum(firstNumber, secondNumber);
            Substract(result, thirdNumber);
        }

        private static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static void Substract(int result, int thirdNumber)
        {
            Console.WriteLine(result - thirdNumber);
        }
    }
}
