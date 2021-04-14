using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            for (byte i = 97; i <= 96+ n; i++)
            {
                for (byte j = 97; j <= 96+n; j++)
                {
                    for (byte k = 97; k <= 96+n; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }      
        }
    }
}
