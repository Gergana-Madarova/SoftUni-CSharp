using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main()
        {
            double recordSec = double.Parse(Console.ReadLine());
            double distanceМ = double.Parse(Console.ReadLine());
            double timeInSecForM = double.Parse(Console.ReadLine());

            string outPut = string.Empty;
            double timeIvan = 0.0;

            //съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди
            if (distanceМ < 15)
            {
                timeIvan = distanceМ * timeInSecForM;
            }
            else
            {
                //резултатът се закръглява надолу до най-близкото цяло число.
                double delayCounts = Math.Floor(distanceМ / 15);
                timeIvan = (distanceМ * timeInSecForM) + (delayCounts * 12.5);
            }

            if (timeIvan < recordSec)
            {
                outPut = $"Yes, he succeeded! The new world record is {timeIvan:f2} seconds.";
            }
            else
            {
                double missingSeconds = timeIvan - recordSec;
                outPut = $"No, he failed! He was {missingSeconds:f2} seconds slower.";
            }
            Console.WriteLine(outPut);
        }
    }
}
