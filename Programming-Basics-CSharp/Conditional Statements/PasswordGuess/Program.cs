using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main()
        {
            string pass = Console.ReadLine();
            string a = "s3cr3t!P@ssw0rd";

            if (pass==a)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
