using System;

namespace BonusScore
{
    class Program
    {
        static void Main()
        {
            int CountScore = int.Parse(Console.ReadLine());

            double bonus = 0;
            double TotalScore = 0.0;

            if (CountScore <= 100)
            {
                bonus += 5;
            }
            else if (CountScore > 1000)
            {
                bonus += (0.1 * CountScore);
            }
            else
            {
                bonus += +(0.2 * CountScore);
            }

            if (CountScore % 2 == 0)
            {
                bonus += 1;
            }
            else if (CountScore % 10 == 5)
            {
                bonus += 2;
            }

            TotalScore = CountScore + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(TotalScore);

        }
    }
}
