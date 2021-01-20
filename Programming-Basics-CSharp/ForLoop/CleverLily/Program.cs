using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());
            double money = 0.0;
            double sum = 0.0;
            int countToys = 0;
            int countM = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    countToys++;
                }
                else
                {
                    money += 10;
                    sum = (sum + money);
                    countM++;
                }
            }

            sum = (sum - countM) + (countToys * priceToys);

            //if (sum >= priceLaundry)
            //{
            //    double diff = sum - priceLaundry;
            //    Console.WriteLine($"Yes! {diff:f2}");
            //}
            //else
            //{
            //    double diff = priceLaundry - sum;
            //    Console.WriteLine($"No! {diff:f2}");
            //}

            Console.WriteLine(sum>=priceLaundry ? $"Yes! {sum - priceLaundry:0.00}" : $"No! {priceLaundry - sum:f2}");

        }
    }
}
