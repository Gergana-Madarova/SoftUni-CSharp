using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceS = 0.0;
            double priceA = 0.0;

            if (month == "May" || month == "October")
            {
                priceA = 65 * nights;
                priceS = 50 * nights;
                if (nights > 14)
                {
                    priceS = priceS - 0.30 * priceS;
                    priceA = priceA - 0.10 * priceA;
                }
                else if (nights > 7)
                {
                    priceS = priceS - 0.05 * priceS;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceS = 75.20 * nights;
                priceA = 68.70 * nights;
                if (nights > 14)
                {
                    priceS = priceS - 0.20 * priceS;
                    priceA = priceA - 0.10 * priceA;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceA = 77 * nights;
                priceS = 76 * nights;
                if (nights > 14)
                {
                    priceA = priceA - 0.10 * priceA;
                }
            }

            Console.WriteLine($"Apartment: {priceA:f2} lv.");
            Console.WriteLine($"Studio: {priceS:f2} lv.");
        }
    }
}
