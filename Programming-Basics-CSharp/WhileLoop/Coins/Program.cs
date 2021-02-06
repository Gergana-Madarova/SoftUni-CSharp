using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            double changeLv = 0;
            double changeCoins = 0;

            double down = Math.Floor(sum);
            //Console.WriteLine(down);

            while (down > 0)
            {
                down -= 2;
                changeLv++;
                if (down == 1)
                {
                    down = 0;
                    changeLv++;
                }
            }

            double result = (sum * 100) % 100;

            if (result >= 50)
            {
                changeCoins++;
                result -= 50;
            }
            while (result >= 20)
            {
                result -= 20;
                changeCoins++;
            }
            if (result >= 10)
            {
                changeCoins++;
                result -= 10;
            }
            if (result >= 5)
            {
                changeCoins++;
                result -= 5;
            }
            while (result >= 2)
            {
                result -= 2;
                changeCoins++;
            }
            if (result >= 1)
            {
                changeCoins++;
                result -= 1;
            }

            Console.WriteLine(changeLv + changeCoins);
        }
    }
}
