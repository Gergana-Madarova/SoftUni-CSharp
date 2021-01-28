using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int max = int.MinValue;
            int curentNumber = 0;

            while (number != "Stop")
            {
                curentNumber = int.Parse(number);
                if (curentNumber > max)
                {
                    max = curentNumber;
                }

                number = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
