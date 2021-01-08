using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;
            double remainingMoney = 0.0;
            double needMoney = 0.0;

            switch (kindOfFlowers)
            {
                case "Roses":
                    {
                        price = countOfFlowers * 5;
                        if (countOfFlowers > 80 && countOfFlowers <= 1000)
                        {
                            price = price - 0.1 * price;
                        }
                    }
                    break;
                case "Dahlias":
                    {
                        price = countOfFlowers * 3.80;
                        if (countOfFlowers > 90 && countOfFlowers <= 1000)
                        {
                            price = price - 0.15 * price;
                        }
                    }
                    break;
                case "Tulips":
                    {
                        price = countOfFlowers * 2.80;
                        if (countOfFlowers > 80 && countOfFlowers <= 1000)
                        {
                            price = price - 0.15 * price;
                        }
                    }
                    break;
                case "Narcissus":
                    {
                        price = countOfFlowers * 3;
                        if (countOfFlowers < 120 && countOfFlowers >= 10)
                        {
                            price = price + (0.15 * price);
                        }
                    }
                    break;
                case "Gladiolus":
                    {
                        price = countOfFlowers * 2.5;
                        if (countOfFlowers < 80 && countOfFlowers >= 10)
                        {
                            price = price + 0.2 * price;
                        }
                    }
                    break;
            }

            if (budget >= 50 && budget <= 1000)
            {
                if (budget >= price)
                {
                    remainingMoney = budget - price;
                    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {kindOfFlowers} and {remainingMoney:f2} leva left.");
                }
                else if (price > budget)
                {
                    needMoney = price - budget;
                    Console.WriteLine($"Not enough money, you need {needMoney:f2} leva more.");
                }
            }      
        }
    }
}
