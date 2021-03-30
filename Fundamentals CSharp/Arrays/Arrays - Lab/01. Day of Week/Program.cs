using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDay = int.Parse(Console.ReadLine());

            string[] daysOfWeek =
                { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (numOfDay > 0 && numOfDay < 8)
            {
                Console.WriteLine(daysOfWeek[numOfDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
