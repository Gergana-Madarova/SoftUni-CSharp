using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            string output = "Error!";

            if (typeOfDay == "Weekday")
            {
                if ((0 <= age && age <= 18) || (64 < age && age <= 122))
                {
                    output = "12$";
                }
                else if (age > 18 && age <= 64)
                {
                    output = "18$";
                }
            }

            if (typeOfDay == "Weekend")
            {
                if ((0 <= age && age <= 18) || (64 < age && age <= 122))
                {
                    output = "15$";
                }
                else if (age > 18 && age <= 64)
                {
                    output = "20$";
                }
            }

            if (typeOfDay == "Holiday")
            {
                if (0 <= age && age <= 18)
                {
                    output = "5$";
                }
                else if (age > 18 && age <= 64)
                {
                    output = "12$";
                }
                else if (64 < age && age <= 122)
                {
                    output = "10$";
                }
            }
            Console.WriteLine(output);
        }
    }
}
