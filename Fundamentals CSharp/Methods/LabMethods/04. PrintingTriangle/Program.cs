using System;
using System.Threading;

namespace _04._PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int end = i;
                PrintingTriangle(end);
            }

            for (int i = num - 1; i >= 1; i--)
            {
                int end = i;
                PrintingTriangle(end);
            }
        }

        private static void PrintingTriangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
