using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
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

            //List<int> result = new List<int>(numbers.Count);

            while (comand[0].ToLower() != "end")
            {
                if (comand[0].ToLower() == "delete")
                {
                    numbers = numbers
                        .Where(n => n != int.Parse(comand[1])).ToList();
                        
                }
                else if (comand[0].ToLower() == "insert")
                {
                    numbers.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                }

                comand = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(' ', numbers));
           // Console.WriteLine(string.Join(' ', result));
        }
    }
}
