using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string output = string.Empty;

            if (age >= 66)
            {
                output = "elder";
            }
            else if (age >= 20)
            {
                output = "adult";
            }
            else if (age >= 14)
            {
                output = "teenager";
            }
            else if (age >= 3)
            {
                output = "child";
            }
            else if (age >= 0)
            {
                output = "baby";
            }

            Console.WriteLine(output);
        }
    }
}
