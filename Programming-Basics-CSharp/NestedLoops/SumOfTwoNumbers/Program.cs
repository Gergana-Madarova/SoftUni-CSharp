using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            string outPut = string.Empty;
            bool find = false;

            for (int i = start; i <= end; i++)
            {
                if (!find)
                {
                    for (int j = start; j <= end; j++)
                    {
                        int sum = i + j;
                        counter++;
                        if (sum == magicNumber)
                        {
                            outPut = $"Combination N:{counter} ({i} + {j} = {magicNumber})";
                            find = true;
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (find)
            {
                Console.WriteLine(outPut);
            }
            else
            {
                outPut = $"{counter} combinations - neither equals {magicNumber}";
                Console.WriteLine(outPut);
            }
        }
    }
}
