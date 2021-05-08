using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string[] comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (comand[0].ToLower() != "end")
            {
                if (comand[0].ToLower() == "add")
                {
                    wagons.Add(int.Parse(comand[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + int.Parse(comand[0])) <= maxCapacity)
                        {
                            wagons[i] = int.Parse(comand[0])+wagons[i];
                            break;
                        }
                    }

                }

                comand = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
