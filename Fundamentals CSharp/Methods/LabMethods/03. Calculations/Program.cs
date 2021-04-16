using System;
using System.ComponentModel;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    {
                        Add(number1, number2);
                        break;
                    }
                case "multiply":
                    {
                        multiply(number1, number2);
                        break;
                    }
                case "subtract":
                    {
                        subtract(number1, number2);
                        break;
                    }
                case "divide":
                    {
                        Divide(number1, number2);
                        break;
                    }
                default:
                    break;
            }

        }

        private static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }

        private static void subtract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        private static void multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        private static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
