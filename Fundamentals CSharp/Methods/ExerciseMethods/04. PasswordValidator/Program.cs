using System;

namespace _04._PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValidPass = true;

            bool isValid = ValidCharacters(password);

            if (!isValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValidPass = false;
            }

            isValid = LettersAndDigits(password);
            if (!isValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValidPass = false;
            }

            isValid = LeastTwoDigits(password);
            if (!isValid)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValidPass = false;
            }

            if (isValidPass)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool LeastTwoDigits(string password)
        {
            bool isValid = false;
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    counter++;

                    if (counter >= 2)
                    {
                        isValid = true;
                        break;
                    }
                }
            }

            if (!isValid)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool LettersAndDigits(string password)
        {
            bool isValid = false;

            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57) ||
                   (password[i] >= 65 && password[i] <= 90) ||
                   (password[i] >= 97 && password[i] <= 122))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (!isValid)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool ValidCharacters(string password)
        {
            if (password.Length <= 10 && password.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
