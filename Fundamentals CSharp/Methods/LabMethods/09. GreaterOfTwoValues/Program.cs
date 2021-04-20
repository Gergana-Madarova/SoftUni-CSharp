using System;

namespace _09._GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            string result = string.Empty;

            switch (type)
            {
                case "int":
                    {
                        result = GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())).ToString();
                        break;
                    }
                case "char":
                    {
                        result = GetMax(char.Parse(Console.ReadLine()),
                               char.Parse(Console.ReadLine())).ToString();
                        break;
                    }
                case "string":
                    {
                        result = GetMax(Console.ReadLine(), Console.ReadLine());
                        break;
                    }
            }

            Console.WriteLine(result);
        }

        private static string GetMax(string v1, string v2)
        {
            return v1.CompareTo(v2) > 0 ? v1 : v2;
        }

        private static char GetMax(char v1, char v2)
        {
            return v1.CompareTo(v2) > 0 ? v1 : v2;
        }

        private static int GetMax(int v1, int v2)
        {
            return v1.CompareTo(v2) > 0 ? v1 : v2;
        }
    }
}
