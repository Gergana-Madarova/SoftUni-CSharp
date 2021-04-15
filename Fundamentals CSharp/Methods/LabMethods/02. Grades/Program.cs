using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Grades(grade);
        }

        private static void Grades(double grade)
        {
            string output = string.Empty;
            if (grade >= 2 && grade <= 2.99)
            {
                output = "Fail";
            }
            else if (grade >= 3 && grade <= 3.49)
            {
                output = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                output = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                output = "Very Good";
            }
            else if (grade >= 5.50 && grade <= 6)
            {
                output = "Excellent";
            }

            Console.WriteLine(output);
        }
    }
}
