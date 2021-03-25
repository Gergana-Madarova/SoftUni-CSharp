using System;

namespace _1._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float km = meters * 0.001f;

            Console.WriteLine($"{km:f2}");
        }
    }
}
