using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;


            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
                sum += number;
            }

            if ((sum-max) == max)
            {
                Console.WriteLine("Yes\nSum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - (sum - max));
                Console.WriteLine("No\nDiff = " + diff);
            }
        }
    }
}
