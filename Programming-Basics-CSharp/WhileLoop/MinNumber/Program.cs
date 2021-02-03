using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int min = int.MaxValue;
            int curentNumber = 0;

            while (number != "Stop")
            {
                curentNumber = int.Parse(number);
                if (curentNumber < min)
                {
                    min = curentNumber;
                }

                number = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
