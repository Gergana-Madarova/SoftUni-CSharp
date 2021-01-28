using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();

            string pass = Console.ReadLine();

            while(pass != password)
            {
                pass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
