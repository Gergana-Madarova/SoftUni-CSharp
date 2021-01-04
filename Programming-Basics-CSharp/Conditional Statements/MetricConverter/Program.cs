using System;
using System.Runtime.Serialization;

namespace MetricConverter
{
    class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            string enteredUnit = Console.ReadLine();
            string desiredUnit = Console.ReadLine();

            string outPut;
            double numM;

            if (enteredUnit == "cm")
            {
                numM = num / 100;
            }
            else if (enteredUnit == "mm")
            {
                numM = num / 1000;
            }
            else
            {
                numM = num;
            }

            if (desiredUnit == "cm")
            {
                outPut = $"{(numM * 100):f3}";
            }
            else if (desiredUnit == "mm")
            {
                outPut = $"{(numM * 1000):f3}";
            }
            else
            {
                outPut = $"{numM:F3}";
            }

            //изход, форматиран до 3-ти знак след десетичната запетая
            Console.WriteLine(outPut);
        }
    }
}
