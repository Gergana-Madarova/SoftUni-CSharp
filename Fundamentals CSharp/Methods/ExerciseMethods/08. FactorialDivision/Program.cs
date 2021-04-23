using System;

namespace _08._FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong factorialFirstNum = Factorial(int.Parse(Console.ReadLine()));
            ulong factorialSecondNum = Factorial(int.Parse(Console.ReadLine()));

            Console.WriteLine($"{factorialFirstNum * 1.0 / factorialSecondNum:f2}");
        }

        private static ulong Factorial(int num)
        {
            ulong result = 1;

            for (int i = 1; i <= num; i++)
            {
                result = result * (ulong)i;
            }

            return result;
        }
    }
}
