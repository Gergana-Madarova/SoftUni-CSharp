using System;
using System.Numerics;

namespace L04CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centurie = int.Parse(Console.ReadLine());
            int years = 100 * centurie;
            int days = (int)(years * 365.2422);
            long hours = 24 * (long)days;
            long minutes = 60 * hours;

            Console.WriteLine($"{centurie} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
