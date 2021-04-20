using System;

namespace _11._MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = MathOerator(firstNumber, secondNumber, operators);

            Console.WriteLine(result);
        }

        private static double MathOerator(double firstNumber, double secondNumber, char operators)
        {
            double result = 0;

            switch (operators)
            {
                case '/':
                    {
                        result = firstNumber / secondNumber;
                        break;
                    }
                case '*':
                    {
                        result = firstNumber * secondNumber;
                        break;
                    }
                case '+':
                    {
                        result = firstNumber + secondNumber;
                        break;
                    }
                case '-':
                    {
                        result = firstNumber - secondNumber;
                        break;
                    }
            }

            return result;
        }
    }
}
