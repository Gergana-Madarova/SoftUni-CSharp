using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                int currNum = (int)char.GetNumericValue(num[i]);
                int curFactorial = 1;

                for (int j = 1; j <= currNum; j++)
                {
                    curFactorial *= j;
                }
                sum += curFactorial;
            }

            if (sum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
