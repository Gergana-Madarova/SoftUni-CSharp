using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (num != "stop")
            {
                int currentNum = int.Parse(num);
                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (currentNum % 2 == 0)
                {
                    if (currentNum == 2)
                    {
                        sumPrime += currentNum;
                    }
                    else
                    {
                        sumNonPrime += currentNum;
                    }
                }
                else if (currentNum == 3 || currentNum == 5)
                {
                    sumPrime += currentNum;
                }
                else if (currentNum % 2 != 0 && currentNum % 3 != 0 && currentNum % 5 != 0)
                {
                    sumPrime += currentNum;
                }
                else
                {
                    sumNonPrime += currentNum;
                }
                num = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
