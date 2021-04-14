using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int curentYield = startingYield;
            int daysOfWork = 0;
            int totalAmountSpice = 0;

            while (curentYield >= 100)
            {
                daysOfWork++;
                totalAmountSpice += curentYield - 26;
                curentYield = curentYield - 10;
            }
            if (totalAmountSpice >= 26)
            {
                totalAmountSpice = totalAmountSpice - 26;
            }

            Console.WriteLine(daysOfWork);
            Console.WriteLine(totalAmountSpice);
        }
    }
}
