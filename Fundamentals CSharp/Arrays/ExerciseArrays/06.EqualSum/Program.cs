using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string output = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                if (i == 0 && numbers.Length == 1)
                {
                    output = "0";
                }
                else
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        sumRight += numbers[j];
                    }

                    for (int k = 0; k <= i - 1; k++)
                    {
                        sumLeft += numbers[k];
                    }

                    if (sumLeft == sumRight)
                    {
                        output = $"{i}";
                        break;
                    }
                    else
                    {
                        output = "no";
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}
