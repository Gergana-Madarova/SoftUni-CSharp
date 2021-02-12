using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterFloor = int.Parse(Console.ReadLine());
            int counterRoom = int.Parse(Console.ReadLine());

            for (int i = counterFloor; i >= 1; i--)
            {
                if (counterFloor == i)
                {
                    for (int j = 0; j < counterRoom; j++)
                    {
                        Console.Write(($"L{i}{j} "));
                    }
                    Console.WriteLine();
                }
                else if (i % 2 == 1)
                {
                    for (int j = 0; j < counterRoom; j++)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < counterRoom; j++)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
