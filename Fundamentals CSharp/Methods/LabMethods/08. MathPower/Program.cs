using System;

namespace _08._MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = MathPower(number, power);

            Console.WriteLine(result);
        }

        private static double MathPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
