using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            decimal biggestKeg = 0;
            string biggestKegModel = string.Empty;

            for (byte i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());

                decimal volume = (decimal)(Math.PI * Math.Pow(radius,2) * height);

               // biggestKeg = Math.Max(biggestKeg, volume);
                if (volume >= biggestKeg)
                {
                    biggestKeg = volume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
