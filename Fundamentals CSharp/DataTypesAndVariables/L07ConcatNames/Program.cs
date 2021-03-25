using System;

namespace L07ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine(first + delimiter + second);
        }
    }
}
