using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            double insertedCoins = 0.0;

            while (coin != "Start")
            {
                double currCoin = double.Parse(coin);

                if (currCoin == 0.1 || currCoin == 0.2 || currCoin == 0.5 || currCoin == 1 || currCoin == 2)
                {
                    insertedCoins += currCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                coin = Console.ReadLine();
            }

            string product = Console.ReadLine();
            double price = 0.0;
            double money = 0.0;

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        {
                            price += 2.0;
                            break;
                        }
                    case "Water":
                        {
                            price += 0.7;
                            break;
                        }
                    case "Crisps":
                        {
                            price += 1.5;
                            break;
                        }
                    case "Soda":
                        {
                            price += 0.8;
                            break;
                        }
                    case "Coke":
                        {
                            price += 1.0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid product");
                            break;
                        }
                }

                if (insertedCoins < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                    price = 0;
                }
                else if (price != 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money = price;
                }

                product = Console.ReadLine();
            }

            double moneyLeft = Math.Abs(insertedCoins - money);
            Console.WriteLine($"Change: {moneyLeft:f2}");
        }
    }
}
