using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            uint quantityOfProduct = uint.Parse(Console.ReadLine().ToLower());

            TotalPrice(product, quantityOfProduct);
        }

        private static void TotalPrice(string product, uint quantityOfProduct)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    {
                        price = 1.50 * quantityOfProduct;
                    }
                    break;
                case "water":
                    {
                        price = 1.00 * quantityOfProduct;
                    }
                    break;
                case "coke":
                    {
                        price = 1.40 * quantityOfProduct;
                    }
                    break;
                case "snacks":
                    {
                        price = 2.00 * quantityOfProduct;
                    }
                    break;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
