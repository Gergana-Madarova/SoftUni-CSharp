using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string outPut = string.Empty;

            switch (gender)
            {
                case "f":
                    if (age >= 16)
                    {
                        outPut = "Ms.";
                    }
                    else
                        outPut = "Miss";
                    break;

                case "m":
                    if (age >= 16)
                    {
                        outPut = "Mr.";
                    }
                    else
                        outPut = "Master";
                    break;
            }

            Console.WriteLine(outPut);
        }
    }
}
