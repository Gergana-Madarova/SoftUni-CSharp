using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string desiredBook = Console.ReadLine();
            string book = Console.ReadLine();
            int i = 0;

            while (book != desiredBook)
            {
                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {i} books.");
                    break;
                }
                else
                {
                    book = Console.ReadLine();
                    i++;
                }
            }

            if (book == desiredBook)
            {
                Console.WriteLine($"You checked {i} books and found it.");
            }
        }
    }
}
