using System;
using System.Collections.Generic;
using System.Linq;

namespace L06ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
