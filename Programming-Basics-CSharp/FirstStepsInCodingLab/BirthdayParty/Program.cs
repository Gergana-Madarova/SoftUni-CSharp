using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Наем за залата
            double rent = double.Parse(Console.ReadLine());

            //Торта  – цената ѝ е 20% от наема на залата
            double cake = 0.2 * rent;
            //Напитки – цената им е 45% по-малко от тази на тортата
            double drinks = cake - 0.45*cake;
            //Аниматор – цената му е 1/3 от цената за наема на залата
            double anime = rent / 3;

            double sum = cake + drinks + anime + rent;

            Console.WriteLine(cake);
            Console.WriteLine(drinks);
            Console.WriteLine(anime);

            //необходим бюджет
            Console.WriteLine(sum);
        }
    }
}
