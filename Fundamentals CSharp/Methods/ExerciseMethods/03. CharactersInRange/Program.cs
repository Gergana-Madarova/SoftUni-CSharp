using System;
using System.ComponentModel.DataAnnotations;

namespace _03._CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());

            GetCharactersInRange(character1, character2);
        }

        private static void GetCharactersInRange(char character1, char character2)
        {
            if (character1 < character2)
            {
                for (char i = character1; i < character2; i++)
                {
                    if (i == character1)
                    {
                        continue;
                    }
                    Console.Write($"{i} ");
                }
            }
            else if (character1 > character2)
            {
                for (char i = character2; i < character1; i++)
                {
                    if (i == character2)
                    {
                        continue;
                    }
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}
