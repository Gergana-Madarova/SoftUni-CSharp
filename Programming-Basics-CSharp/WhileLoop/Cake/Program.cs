using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            string pieces = string.Empty;

            int cake = length * width;
            bool stop = false;

            while (cake > 0)
            {
                pieces = Console.ReadLine();

                if (pieces != "STOP")
                {
                    cake -= int.Parse(pieces);
                }
                else
                {
                    stop = true;
                    break;
                }
            }

            if (stop)
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }
}
