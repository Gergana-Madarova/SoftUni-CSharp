using System;

namespace BonusScore
{
    class Program
    {
        static void Main()
        {
            int countScore = int.Parse(Console.ReadLine());

            double bonus = 0;
            double totalScore = 0.0;

            if (countScore <= 100)
            {
                bonus += 5;
            }
            else if (countScore > 1000)
            {
                bonus += (0.1 * countScore);
            }
            else
            {
                bonus += +(0.2 * countScore);
            }

            if (countScore % 2 == 0)
            {
                bonus += 1;
            }
            else if (countScore % 10 == 5)
            {
                bonus += 2;
            }

            totalScore = countScore + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(totalScore);
        }
    }
}
