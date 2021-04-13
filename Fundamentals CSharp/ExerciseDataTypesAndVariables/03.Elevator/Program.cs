using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberOfPeople = uint.Parse(Console.ReadLine());
            uint capacity = uint.Parse(Console.ReadLine());
            uint courses = (uint)Math.Ceiling((double)numberOfPeople/capacity);

            Console.WriteLine(courses);
        }
    }
}
