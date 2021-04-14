using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte charStart = byte.Parse(Console.ReadLine());
            byte charEnd = byte.Parse(Console.ReadLine());

            for (int i = charStart; i <= charEnd; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
