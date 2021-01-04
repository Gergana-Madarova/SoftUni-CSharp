using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananes = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberry = double.Parse(Console.ReadLine());
 
            double orangesPrice = oranges * ((strawberryPrice / 2) - 0.4 *(strawberryPrice / 2));
            double bananesPrice = bananes* ((strawberryPrice / 2) - 0.8 * (strawberryPrice / 2));
            Console.WriteLine(orangesPrice);
            Console.WriteLine(bananesPrice);

            double money = strawberry*strawberryPrice + raspberries*(strawberryPrice/2) + orangesPrice + bananesPrice ;

            Console.WriteLine(money);
        }
    }
}
