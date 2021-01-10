using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            //"leap" (високосна година) или "normal" (невисокосна)
            string year = Console.ReadLine();
            //брой празници в годината (които не са събота и неделя)
            double p = int.Parse(Console.ReadLine());
            //брой уикенди, в които пътува до родния град
            double h = int.Parse(Console.ReadLine());
            //колко пъти Влади е играл волейбол през годината. 
            double count = 0.0;

            count = h + ((48 - h) * 3 / 4) + (2 * p / 3);
            if (year == "leap")
            {
                count = count + 0.15 * count;
            }

            //Закръглете резултата надолу до най-близкото цяло число
            Console.WriteLine($"{Math.Floor(count)}");
        }
    }
}
