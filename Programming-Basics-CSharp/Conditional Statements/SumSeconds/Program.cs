using System;

namespace SumSeconds
{
    class Program
    {
        static void Main()
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int total = firstTime + secondTime + thirdTime;

            int minutes = total / 60;
            int seconds = total % 60;

            string output;
            if (seconds < 10)
            {
                //използваме шаблон
               output = $"{minutes}:0{seconds}";
            }
            else
            {
               output = $"{minutes}:{seconds}";
            }

            Console.WriteLine(output);
        }
    }
}
