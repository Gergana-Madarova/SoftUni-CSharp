using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNum = number;
            int sum = 0;

            while (currentNum > 0)
            {
                sum += (currentNum % 10);
                currentNum = currentNum / 10;
            }    
            
            Console.WriteLine(sum);
        }
    }
}
