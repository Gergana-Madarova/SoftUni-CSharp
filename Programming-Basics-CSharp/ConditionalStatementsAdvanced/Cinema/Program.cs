using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double outPut = 0.0;

            switch (type)
            {
                case "Premiere":
                    outPut = 12 * rows * columns;
                    break;
                case "Normal":
                    outPut = 7.50 * rows * columns;
                    break;
                case "Discount":
                    outPut = 5.00 * rows * columns;
                    break;
            }

            Console.WriteLine($"{outPut:f2} leva");
        }
    }
}
