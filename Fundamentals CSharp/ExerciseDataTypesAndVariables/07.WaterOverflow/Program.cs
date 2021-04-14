using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte litersInTank = 255;

            for (byte i = 1; i <= n; i++)
            {
                ushort quantities = ushort.Parse(Console.ReadLine());

                if ( litersInTank - quantities < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litersInTank -= (byte)quantities;
                }
            }
            Console.WriteLine((byte)255 - litersInTank);
        }
    }
}
