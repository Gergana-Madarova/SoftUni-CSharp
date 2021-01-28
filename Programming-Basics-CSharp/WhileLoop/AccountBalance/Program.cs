using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();

            double total = 0.0;

            while (money != "NoMoreMoney")
            {
                if (double.Parse(money) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    total += double.Parse(money);
                    Console.WriteLine($"Increase: {double.Parse(money):f2}");
                }
                money = Console.ReadLine();
            }
                Console.WriteLine($"Total: {total:f2}");
        }
    }
}
