using System;
using System.Reflection;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 USD = 1.79549 BGN
            var usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;

            // Форматиране до 2-ри знак след десетичната запетая
            Console.WriteLine("{0:F2}", bgn);
        }
    }
}
