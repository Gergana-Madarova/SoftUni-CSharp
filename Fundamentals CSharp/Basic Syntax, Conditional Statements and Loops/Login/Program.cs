using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string pass = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                pass += userName[i];
            }

            string curPass = Console.ReadLine();
            int counter = 0;

            while (pass != curPass)
            {
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
                curPass = Console.ReadLine();
            }

            if (pass == curPass)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
