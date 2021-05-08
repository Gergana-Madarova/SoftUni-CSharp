using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string[] comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (comand[0].ToLower() != "end")
            {
                if (comand[0].ToLower() == "add")
                {
                    numbers.Add(int.Parse(comand[1]));
                }
                else if (comand[0].ToLower() == "insert")
                {
                    if (int.Parse(comand[2]) >= numbers.Count || int.Parse(comand[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                    }    
                }
                else if (comand[0].ToLower() == "remove")
                {
                    int index = int.Parse(comand[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }     
                }
                else if (comand[0].ToLower() == "shift")
                {
                    int count = int.Parse(comand[2]);

                    if (comand[1].ToLower() == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int first = numbers[0];
                            numbers.Add(first);
                            numbers.RemoveAt(0);
                        }
                    }
                    if (comand[1].ToLower() == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int last = numbers[numbers.Count - 1];
                            numbers.Insert(0, last);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }

                comand = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
