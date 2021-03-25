using System;

namespace L09CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char tirth = char.Parse(Console.ReadLine());

            string all = Convert.ToString(first) + Convert.ToString(second)+Convert.ToString(tirth);

            Console.WriteLine(all);
        }
    }
}
