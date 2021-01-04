using System;

namespace SpeedInfo
{
    class Program
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            string outPut = string.Empty;

            if (speed <= 10 && speed > 0)
            {
                outPut = "slow";
            }
            else if (speed <= 50 && speed > 0)
            {
                outPut = "average";
            }
            else if (speed <= 150 && speed > 0)
            {
                outPut = "fast";
            }
            else if (speed <= 1000 && speed > 0)
            {
                outPut = "ultra fast";
            }
            else if (speed > 1000 && speed > 0)
            {
                outPut = "extremely fast";
            }

            Console.WriteLine(outPut);
        }
    }
}
