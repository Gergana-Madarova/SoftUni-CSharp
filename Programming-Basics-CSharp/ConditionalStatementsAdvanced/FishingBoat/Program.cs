using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0.0;
            double money = 0.0;

            switch (season)
            {
                case "Spring":
                    {
                        price = 3000;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    {
                        price = 4200;

                    }
                    break;
                case "Winter":
                    {
                        price = 2600;
                    }
                    break;
            }

            if (fishermen <= 6)
            {
                price = price - 0.1 * price;
            }
            else if (fishermen > 6 && fishermen <= 11)
            {
                price = price - 0.15 * price;
            }
            else if (fishermen > 11)
            {
                price = price - 0.25 * price;
            }

            if ((fishermen % 2 == 0) && season != "Autumn")
            {
                price = price - 0.05 * price;
            }

            if (budget >= price)
            {
                money = budget - price;
                Console.WriteLine($"Yes! You have {money:f2} leva left.");
            }
            else
            {
                money = price - budget;
                Console.WriteLine($"Not enough money! You need {money:f2} leva.");
            }

        }
    }
}
