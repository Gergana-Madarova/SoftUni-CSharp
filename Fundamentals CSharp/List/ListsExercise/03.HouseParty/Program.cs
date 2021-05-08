using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>(numberOfComands);

            for (int i = 1; i <= numberOfComands; i++)
            {
                string[] comands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (comands[2] == "going!")
                {
                    if (guests.Contains(comands[0]))
                    {
                        Console.WriteLine($"{comands[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(comands[0]);
                    }
                }
                else if (comands[2] == "not")
                {
                    if (guests.Contains(comands[0]))
                    {
                        guests.Remove(comands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{comands[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, guests));
        }
    }
}
