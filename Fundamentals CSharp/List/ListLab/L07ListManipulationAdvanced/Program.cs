using System;
using System.Collections.Generic;
using System.Linq;

namespace L07ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool change = false;
            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        change = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        change = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        change = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        change = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(tokens[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum()); 
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);

                        if (condition == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n < number)));
                        }
                        else if (condition == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n > number)));
                        }
                        else if (condition == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= number)));
                        }
                        else if (condition == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= number)));
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            if (change)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
