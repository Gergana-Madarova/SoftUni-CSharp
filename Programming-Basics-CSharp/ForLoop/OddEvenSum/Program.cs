using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int diff = 0;
            int number = 0;

            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sum1 +=number;
                }
                else if (i % 2 == 0)
                {
                    sum2 += number;
                }
            }

            if (sum1==sum2)
            {
                Console.WriteLine($"Yes\nSum = {sum1}");
            }
            else
            {
                diff = Math.Abs(sum1 - sum2);
                Console.WriteLine($"No\nDiff = {diff}");
            }
        }
    }
}
