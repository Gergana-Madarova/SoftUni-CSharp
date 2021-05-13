using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //"room for one person" – 18.00 лв за нощувка
            //"apartment" – 25.00 лв за нощувка
            //"president apartment" – 35.00 лв за нощувка

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0.0;

            switch (room)
            {
                case "room for one person":
                    {
                        price = (days - 1) * 18;
                    }
                    break;
                case "apartment":
                    {
                        price = (days - 1) * 25;
                        if (days < 10 && days >= 0)
                        {
                            price = price - 0.30 * price;
                        }
                        else if (days >= 10 && days <= 15)
                        {
                            price = price - 0.35 * price;
                        }
                        else if (days > 15 && days <= 365)
                        {
                            price = price - 0.50 * price;
                        }
                    }
                    break;
                case "president apartment":
                    {
                        price = (days - 1) * 35;
                        if (days < 10 && days >= 0)
                        {
                            price = price - 0.10 * price;
                        }
                        else if (days >= 10 && days <= 15)
                        {
                            price = price - 0.15 * price;
                        }
                        else if (days > 15 && days <= 365)
                        {
                            price = price - 0.20 * price;
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Choose room");
                    break;
            }

            if (rating == "positive")
            {
                price = price + 0.25 * price;
            }
            else if (rating == "negative")
            {
                price = price - 0.10 * price;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
