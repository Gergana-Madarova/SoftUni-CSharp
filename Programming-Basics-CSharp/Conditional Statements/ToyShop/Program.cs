using System;

namespace ToyShop
{
    class Program
    {
        static void Main()
        {
            double vacantionPrice = double.Parse(Console.ReadLine());
            int countPuzzles = int.Parse(Console.ReadLine());
            int countDolls = int.Parse(Console.ReadLine());
            int countBears = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            double puzzlesPrice = countPuzzles * 2.60;
            double dollsPrice = countDolls * 3;
            double bearsPrice = countBears * 4.10;
            double minionsPrice = countMinions * 8.20;
            double trucksPrice = countTrucks * 2;

            double priceToys = puzzlesPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;
            int toys = countPuzzles + countDolls + countBears + countMinions + countTrucks;

            double forRent = 0.0;
            double fin = 0.0;

            if (toys >= 50)
            {
                double priceToysFin = priceToys - (0.25 * priceToys);   //отстъпка 25%
                forRent = 0.1 * priceToysFin;
                fin = priceToysFin - forRent;
            }
            else
            {
                forRent = 0.1 * priceToys;
                fin = priceToys - forRent;
            }

            if (vacantionPrice <= fin)
            {
                double lackOfMoney = fin - vacantionPrice;
                Console.WriteLine("Yes! {0:f2} lv left.", lackOfMoney);
            }
            else
            {
                double lackOfMoney = vacantionPrice - fin;
                Console.WriteLine("Not enough money! {0:F2} lv needed.", lackOfMoney);
            }
        }
    }
}
