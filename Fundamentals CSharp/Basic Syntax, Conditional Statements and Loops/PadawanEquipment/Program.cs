using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            //PricesOfEachItem:
            decimal priceOfLightsabers = decimal.Parse(Console.ReadLine());
            decimal priceOfRobes = decimal.Parse(Console.ReadLine());
            decimal priceOfBelts = decimal.Parse(Console.ReadLine());

            //every sixth belt is free
            int freeBelts = countOfStudents / 6;
            decimal needMoney = priceOfLightsabers * Math.Ceiling(countOfStudents + countOfStudents * 0.1M) + priceOfRobes * (countOfStudents) + priceOfBelts * (countOfStudents - freeBelts);

            if (needMoney <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {needMoney:f2}lv.");
            }
            else if (needMoney > amountOfMoney)
            {
                Console.WriteLine($"John will need {needMoney - amountOfMoney:f2}lv more.");
            }
        }
    }
}
