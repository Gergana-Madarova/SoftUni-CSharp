using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupOfpeople = int.Parse(Console.ReadLine());
            string typeOfpeople = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.0;

            if (typeOfpeople == "Students")
            {
                if (day == "Friday")
                {
                    price = groupOfpeople * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = groupOfpeople * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = groupOfpeople * 10.46;
                }

                if (groupOfpeople >= 30)
                {
                    price = price - (0.15 * price);
                }
            }
            else if (typeOfpeople == "Business")
            {
                if (groupOfpeople >= 100)
                {
                    groupOfpeople -= 10;
                }

                if (day == "Friday")
                {
                    price = groupOfpeople * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = groupOfpeople * 15.60;
                }
                else if (day == "Sunday")
                {
                    price = groupOfpeople * 16;
                }
            }
            else if (typeOfpeople == "Regular")
            {
                if (day == "Friday")
                {
                    price = groupOfpeople * 15;
                }
                else if (day == "Saturday")
                {
                    price = groupOfpeople * 20;
                }
                else if (day == "Sunday")
                {
                    price = groupOfpeople * 22.50;
                }

                if (groupOfpeople >= 10 && groupOfpeople <= 20)
                {
                    price = price - (0.05 * price); ;
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
