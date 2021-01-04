using System;
using System.Dynamic;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int crewCounts = int.Parse(Console.ReadLine());
            double clothingForOne = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double costs = 0.0;
            string OutPut = string.Empty;

            if (crewCounts > 150)
            {
                clothingForOne += -(0.1 * clothingForOne); //отстъпка
            }

            costs = decor + clothingForOne * crewCounts;

            if (costs > budget)
            {
                double money = costs - budget;
                OutPut = $"Not enough money!\nWingard needs {money:f2} leva more.";
            }
            else
            {
                double money = budget - costs;
                OutPut = $"Action!\nWingard starts filming with {money:f2} leva left.";
            }

            Console.WriteLine(OutPut);
        }
    }
}
