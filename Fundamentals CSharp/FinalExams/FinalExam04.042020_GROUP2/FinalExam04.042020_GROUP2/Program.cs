using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P01PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string output = string.Empty;

            List<string> comand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (comand[0].ToLower() != "done")
            {
                if (comand[0].ToLower() == "takeodd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        sb.Append(password[i]);
                    }

                    password = sb.ToString();

                    output = password;
                }
                else if (comand[0].ToLower() == "cut")
                {
                    int index = int.Parse(comand[1]);
                    int lenght = int.Parse(comand[2]);

                    password = password.Remove(index, lenght);
                    output = password;
                }
                else if (comand[0].ToLower() == "substitute")
                {
                    string substring = comand[1];

                    if (password.Contains(substring))
                    {
                        string namePattern = comand[1];
                        password = Regex.Replace(password, namePattern, comand[2]);
                        output = password;
                    }
                    else
                    {
                        output = "Nothing to replace!";
                    }
                }

                Console.WriteLine(output);
                comand = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
